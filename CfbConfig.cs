using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace CalendarFireBrigade {
    public class CfbConfig {

        private const string CONFIG_PATH = "config.txt";

        public static CfbConfig Instance { get; private set; } = null;

        #region Detection Types

        public List<string> NonTeamMemberCategories = new List<string>() {
            "Announcements",
            "Monitor EMEA",
            "Training",
            "Time Slot",
            "T2 Onboarding",
            "OOO"
        };

        public string OutOfOfficeCategory = "OOO";

        public string TrainingCategory = "Training";

        public List<string> AvoidedMeetingPatterns = new List<string>() {
            ".*1-on-1.*",
            ".*tentative.*"
        };

        #endregion

        #region Calendar Syncing

        public string CaseSyncPattern { get; set; } = @".*(0?[4-9]\d{5}).*";

        public List<string> SubjectCleanup { get; set; } = new List<string>() {
            "Remote Session for Case No."
        };

        public int DaysToSync { get; set; } = 4;

        public int SyncFrequency { get; set; } = 5;

        #endregion

        #region Team Members

        public List<string> PreferredSpellings { get; set; } = new List<string>() {
            "James Brooks=Jimi Brooks"
        };

        #endregion
        
        public static void SaveState(CfbConfig cfbConfig = null) {
            cfbConfig = cfbConfig ?? Instance;

            var yamlSerializer = new SerializerBuilder()
                                .WithNamingConvention(HyphenatedNamingConvention.Instance)
                                .Build();

            File.WriteAllText(CONFIG_PATH, yamlSerializer.Serialize(cfbConfig), Encoding.UTF8);

            yamlSerializer.Serialize(cfbConfig);
        }

        public static void LoadState() {
            if (!File.Exists(CONFIG_PATH)) {
                // Create config file for the first time using defaults.
                SaveState(new CfbConfig());
            }

            var yamlDeserializer = new DeserializerBuilder().WithNamingConvention(HyphenatedNamingConvention.Instance)
                                                            .IgnoreUnmatchedProperties()
                                                            .Build();

            Instance = yamlDeserializer.Deserialize<CfbConfig>(File.ReadAllText(CONFIG_PATH));
        }

    }
}
