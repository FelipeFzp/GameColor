﻿using Newtonsoft.Json;

namespace GameColor.Core.Models
{
    public class Configuration
    {
        #region Properties
        public ConfigurationStartWithWindows StartWithWindows { get; set; }
        public ConfigurationTurnOnWhenOpen TurnOnWhenOpen { get; set; }
        public ConfigurationShortcuts Shortcuts { get; set; }
        #endregion

        #region Constructors
        public Configuration()
        {
            StartWithWindows = new ConfigurationStartWithWindows();
            TurnOnWhenOpen = new ConfigurationTurnOnWhenOpen();
            Shortcuts = new ConfigurationShortcuts();
        }
        #endregion

        #region Overrides
        public override string ToString() =>
            JsonConvert.SerializeObject(this, Formatting.Indented);
        #endregion
    }
}
