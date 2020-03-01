﻿using System.ComponentModel;
using PKHeX.Core;

namespace SysBot.Pokemon
{
    public class LegalitySettings
    {
        private const string Generate = nameof(Generate);
        private const string Misc = nameof(Misc);
        public override string ToString() => "Legality Generating Settings";

        // Generate

        [Category(Generate), Description("Regenerated PKM files will attempt to be sourced from games using trainer data info from these PKM Files.")]
        public string GeneratePathTrainerInfo { get; set; } = string.Empty;

        [Category(Generate), Description("Default Trainer Name for PKM files that can't originate from any of the provided SaveFiles.")]
        public string GenerateOT { get; set; } = "SysBot";

        [Category(Generate), Description("Default 16 Bit Trainer ID (TID) for PKM files that can't originate from any of the provided SaveFiles.")]
        public int GenerateTID16 { get; set; } = 12345;

        [Category(Generate), Description("Default 16 Bit Secret ID (SID) for PKM files that can't originate from any of the provided SaveFiles.")]
        public int GenerateSID16 { get; set; } = 54321;

        [Category(Generate), Description("Default Language for PKM files that can't originate from any of the provided SaveFiles.")]
        public LanguageID GenerateLanguage { get; set; } = LanguageID.English;

        [Category(Generate), Description("Set all possible ribbons for any generated Pokémon.")]
        public bool SetAllLegalRibbons { get; set; }

        [Category(Generate), Description("Set a matching ball (based on color) for any generated Pokémon.")]
        public bool SetMatchingBalls { get; set; }

        // Misc

        [Category(Misc), Description("Zero out HOME tracker regardless of current tracker value. Applies to user requested PKM files as well.")]
        public bool ResetHOMETracker { get; set; } = true;
    }
}