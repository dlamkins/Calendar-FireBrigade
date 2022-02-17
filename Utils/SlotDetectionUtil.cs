using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Outlook;

namespace CalendarFireBrigade {
    public static class SlotDetectionUtil {

        public static string GetOwner(string ownerHint) {
            // Remove non-team-member categories
            foreach (var filteredCategory in CfbConfig.Instance.NonTeamMemberCategories) {
                ownerHint = ownerHint.Replace(filteredCategory, "");
            }

            // Fix name spelling
            foreach (var preferredName in CfbConfig.Instance.PreferredSpellings) {
                string[] namePair = preferredName.Split('=');

                ownerHint = ownerHint.Replace(namePair[0], namePair[1]);
            }

            return ownerHint.Replace(",", "").Trim();
        }

        public static TimeSlotType GetSlotType(string categories, string subject) {
            categories = categories.ToLowerInvariant();
            subject    = subject.ToLowerInvariant();
            
            if (categories.Contains(CfbConfig.Instance.OutOfOfficeCategory.ToLowerInvariant())) {
                return TimeSlotType.OutOfOffice;
            } else if (categories.Contains(CfbConfig.Instance.TrainingCategory.ToLowerInvariant())) {
                return TimeSlotType.Training;
            } else if (subject == "lunch") {
                return TimeSlotType.OutOfOffice;
            } else {
                foreach (string otherPattern in CfbConfig.Instance.AvoidedMeetingPatterns) {
                    if (Regex.IsMatch(subject, otherPattern, RegexOptions.CultureInvariant | RegexOptions.IgnoreCase)) {
                        return TimeSlotType.Other;
                    }
                }
            }

            return TimeSlotType.Case;
        }

        public static TimeSlot GetTimeSlotFromAppointment(AppointmentItem appointmentItem, string forcedOwner = null) {
            string safeCategories = appointmentItem.Categories ?? "";

            string owner    = forcedOwner ?? GetOwner(safeCategories);
            var    slotType = GetSlotType(safeCategories, appointmentItem.Subject);

            return !string.IsNullOrWhiteSpace(owner)
                       ? new TimeSlot(owner, appointmentItem.Subject, appointmentItem.Start, appointmentItem.Duration / 60f) { SlotType = slotType, OriginalItem = appointmentItem }
                       : null;
        }

    }
}
