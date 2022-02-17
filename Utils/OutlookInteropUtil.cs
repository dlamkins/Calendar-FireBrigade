using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Outlook;

namespace CalendarFireBrigade {
    public static class OutlookInteropUtil {

        public static (NameSpace Mapi, Recipient Calendar, Application Outlook) GetCalendar(string calendarAddress) {
            var outlook = new Application();
            var mapi    = outlook.GetNamespace("MAPI");

            return (mapi, mapi.CreateRecipient(calendarAddress), outlook);
        }

        public static IEnumerable<TimeSlot> GetCalendarEvents(string calendarAddress, DateTime start, DateTime end, bool shared = true) {
            var (mapi, calendar, _) = GetCalendar(calendarAddress);

            var folder = mapi.GetSharedDefaultFolder(calendar, OlDefaultFolders.olFolderCalendar);

            var events = folder.Items;

            foreach (AppointmentItem calendarEvent in events.Restrict($"[Start] >= '{start:MM/dd/yyyy hh:mm tt}' AND [End] <= '{end:MM/dd/yyyy hh:mm tt}'")) {
                TimeSlot slot = null;

                try {
                    var selectedEvent = calendarEvent;

                    if (calendarEvent.IsRecurring) {
                        selectedEvent = calendarEvent.GetRecurrencePattern().GetOccurrence(start.Date + selectedEvent.Start.TimeOfDay);

                        if (selectedEvent == null) {
                            // Skip recurring meetings when for the wrong day
                            continue;
                        }
                    }

                    slot = SlotDetectionUtil.GetTimeSlotFromAppointment(selectedEvent, shared ? null : calendar.Name);
                } catch (System.Exception ex) {
                    Console.WriteLine(ex.Message);
                }

                if (slot != null) {
                    yield return slot;
                }
            }
        }

    }
}
