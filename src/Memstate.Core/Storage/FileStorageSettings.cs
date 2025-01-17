﻿using Memstate.Configuration;

namespace Memstate
{
    public class FileStorageSettings : Settings
    {
        public override string Key { get;  } = "Memstate:StorageProviders:FileStorage";

        private readonly EngineSettings _memstateSettings;

        public FileStorageSettings(Config config)
        {
            _memstateSettings = config.GetSettings<EngineSettings>();
        }

        public string FileNameSuffix { get; set; } = ".journal";

        public string FileName => _memstateSettings.StreamName + FileNameSuffix;
    }
}