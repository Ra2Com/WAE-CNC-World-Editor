﻿using Rampastring.Tools;

namespace TSMapEditor.Models.ArtConfig
{
    public class OverlayArtConfig : IArtConfig
    {
        public bool Theater { get; set; }
        public bool Remapable => false;

        public void ReadFromIniSection(IniSection iniSection)
        {
            Theater = iniSection.GetBooleanValue(nameof(Theater), Theater);
        }
    }
}
