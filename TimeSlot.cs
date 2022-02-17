using System;
using Microsoft.Office.Interop.Outlook;

namespace CalendarFireBrigade {

    public enum TimeSlotType {
        Case,
        Training,
        OutOfOffice,
        Other,
    }

    public class TimeSlot {

        public AppointmentItem OriginalItem { get; set; }

        public string Owner { get; set; }

        public string Subject { get; set; }

        public DateTime StartTime { get; set; }
        public double    Duration  { get; set; }

        public TimeSlotType SlotType { get; set; }

        public DateTime EndTime => StartTime.AddHours(this.Duration);

        public TimeSlot(string owner, string subject, DateTime startTime, float duration) {
            this.Owner     = owner;
            this.Subject   = subject;
            this.StartTime = startTime;
            this.Duration  = duration;
        }

        public static double TimeBetween(TimeSlot t1, TimeSlot t2) {
            if (t1.StartTime >= t2.EndTime) {
                return Math.Abs((t1.StartTime - t2.EndTime).TotalHours);
            } else if (t2.StartTime >= t1.EndTime) {
                return Math.Abs((t2.StartTime - t1.EndTime).TotalHours);
            } else {
                return -1;
            }
        }

    }
}
