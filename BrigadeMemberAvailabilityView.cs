using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalendarFireBrigade {
    public partial class BrigadeMemberAvailabilityView : UserControl {

        private const float SPACER_HEIGHT = 13f;

        private TimeSlot[] _conflictingMeetings;

        private readonly List<(Rectangle, TimeSlot)> _tooltipRectangles;
        private          bool                        _shouldPopulateTooltips = true;

        public TimeSlot[] ConflictingMeetings {
            get => _conflictingMeetings;
            set {
                _conflictingMeetings = value;
                lblCallNumber.Text   = value.Count(slot => slot.SlotType == TimeSlotType.Case && slot.Duration > 0.51).ToString();
            }
        }

        public TimeSlot RequestedBlock { get; set; }

        public string Owner {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public BrigadeMemberAvailabilityView() {
            InitializeComponent();

            _tooltipRectangles = new List<(Rectangle, TimeSlot)>();
        }

        private void DrawSlot(Graphics g, TimeSlot timeSlot, Color color, bool solid, HatchStyle style, int sideOffset = 0) {
            float top    = (float)(lblName.Bottom + SPACER_HEIGHT + (timeSlot.StartTime.TimeOfDay.TotalHours - 8f) * SPACER_HEIGHT);
            float bottom = (float)(lblName.Bottom + SPACER_HEIGHT + (timeSlot.StartTime.TimeOfDay.TotalHours - 8f) * SPACER_HEIGHT + (timeSlot.Duration * SPACER_HEIGHT));

            g.FillRectangle(new HatchBrush(style, color, solid ? color : Color.Transparent), 30f + sideOffset, top, this.Width - 42f - sideOffset * 2, bottom - top);
            g.DrawRectangle(new Pen(solid ? Color.Black : color, 2), 30f                         + sideOffset, top, this.Width - 42f - sideOffset * 2, bottom - top);

            if (_shouldPopulateTooltips) {
                _tooltipRectangles.Add((new Rectangle(30 + sideOffset, (int) top, this.Width - 42 - sideOffset * 2, (int) (bottom - top)), timeSlot));
            }
        }

        private Color GetColorFromTimeBetween(double timeBetween) {
            if (timeBetween < 0) return Color.PaleVioletRed;

            if (timeBetween < 0.25) return Color.Orange;

            if (timeBetween < 0.5) return Color.Yellow;

            return Color.LightGreen;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            var g = e.Graphics;

            for (int i = 8; i < 20; i++) {
                float top    = lblName.Bottom + SPACER_HEIGHT + (i - 8f) * SPACER_HEIGHT;
                float bottom = lblName.Bottom + SPACER_HEIGHT + (i - 8f) * SPACER_HEIGHT + (2 * SPACER_HEIGHT);

                if (i % 2 == 0) {
                    g.DrawString((i > 12 ? i - 12 : i).ToString().PadLeft(2), this.Font, new SolidBrush(Color.Black), 10f, top);
                }

                g.DrawLine(new Pen(new HatchBrush(HatchStyle.DashedHorizontal, i % 2 == 0 ? Color.LightSlateGray : Color.LightGray, Color.Transparent), 4), i % 2 == 0 ? 15f : 30, bottom, this.Width - 20f, bottom);
            }

            DrawSlot(g,
                this.RequestedBlock,
                (clrStatus.BackColor = GetColorFromTimeBetween(this.ConflictingMeetings.Where(m => m.SlotType != TimeSlotType.Other).MinOrDefault(s => TimeSlot.TimeBetween(s, this.RequestedBlock), double.MaxValue))),
                true,
                HatchStyle.DarkDownwardDiagonal, 5);

            var caseTypeColors = new Dictionary<TimeSlotType, Color>() {
                { TimeSlotType.Case, Color.LightBlue },
                { TimeSlotType.Training, Color.MediumPurple },
                { TimeSlotType.OutOfOffice, Color.LightCoral },
                { TimeSlotType.Other, Color.LightGray },
            };

            foreach (var slot in this.ConflictingMeetings) {
                DrawSlot(g, slot, caseTypeColors[slot.SlotType], false, HatchStyle.LightUpwardDiagonal);
            }

            if (this.RequestedBlock.StartTime.Date == DateTime.Today) {
                DrawSlot(g, new TimeSlot(string.Empty, "NOW", DateTime.Now, 1 / 60f), Color.Black, false, HatchStyle.BackwardDiagonal, -5);
            }
            
            _tooltipRectangles.Reverse();
            _shouldPopulateTooltips = false;
        }

        private TimeSlot _activeSlot;

        private void BrigadeMemberAvailabilityView_MouseMove(object sender, MouseEventArgs e) {
            if (cmsSlotActions.Visible) return; // Avoid changing active slot while using the menu

            foreach (var recPair in _tooltipRectangles) {
                if (recPair.Item1.Contains(e.Location)) {
                    _activeSlot = recPair.Item2;
                    ttEventInfo.Show($"{_activeSlot.Subject}\r\n\r\n{_activeSlot.StartTime:t} - {_activeSlot.EndTime:t}", this, new Point(e.Location.X + 10, e.Location.Y));
                    return;
                }
            }

            _activeSlot = null;
            ttEventInfo.Hide(this);
        }

        private void BrigadeMemberAvailabilityView_MouseLeave(object sender, System.EventArgs e) {
            ttEventInfo.Hide(this);
        }

        private double _lastClickTime = 0;

        private void BrigadeMemberAvailabilityView_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                if (DateTime.Now.TimeOfDay.TotalMilliseconds - _lastClickTime < SystemInformation.DoubleClickTime) {
                    // Handle as a double click
                    tsmiCopySubjectLine_Click(null, null);
                } else {
                    _lastClickTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
                }

                return;
            }

            // Right-click
            if (_activeSlot != null) {
                tsmiSlotName.Text = _activeSlot.Subject;
                cmsSlotActions.Show(this, e.Location, ToolStripDropDownDirection.BelowRight);
            }
        }

        private void tsmiCopySubjectLine_Click(object sender, EventArgs e) {
            Clipboard.SetText(_activeSlot.Subject);
        }

        private void tsmiOpenInOutlook_Click(object sender, EventArgs e) {
            _activeSlot.OriginalItem.Display(true);
        }

        private void tsmiCopySchedule_Click(object sender, EventArgs e) {
            var writtenSchedule = new StringBuilder();

            writtenSchedule.AppendLine($"{this.Owner}:");

            foreach (var slot in _conflictingMeetings.OrderBy(slot => slot.StartTime)) {
                writtenSchedule.AppendLine($"   {slot.StartTime:t} :: {slot.Subject}");
            }

            Clipboard.SetText(writtenSchedule.ToString());
        }
    }
}
