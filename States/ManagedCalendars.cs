using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CalendarFireBrigade.States {
    public class ManagedCalendars {

        private static ManagedCalendars _instance;
        public static  ManagedCalendars Instance => _instance ?? (_instance = Reload());

        public List<string> AvailableTeamCalendars = new List<string>();
        public List<string> EnabledTeamCalendars   = new List<string>();

        public string SelectedSyncCalendar = "";

        public List<string> AvailableTeamMemberCalendars = new List<string>();
        public List<string> EnabledTeamMemberCalendars   = new List<string>();

        public bool AutoSync = false;

        public static ManagedCalendars Reload() {
            try {
                return JsonConvert.DeserializeObject<ManagedCalendars>(File.ReadAllText("calendars.json"));
            } catch (Exception) {
                return new ManagedCalendars();
            }
        }

        public static void Save() {
            File.WriteAllText("calendars.json", JsonConvert.SerializeObject(Instance));
        }

    }
}
