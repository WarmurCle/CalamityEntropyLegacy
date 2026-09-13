using CalamityMod.Cooldowns;
using Terraria.Audio;
using Terraria.Localization;

namespace CalamityEntropyLegacy.Content.Cooldowns
{
    public class ScytheReviveCooldown : CooldownHandler
    {
        public static new string ID => "ScytheReviveCooldown";
        public override bool ShouldDisplay => true;
        public override LocalizedText DisplayName => Language.GetOrRegister("Mods.CalamityEntropyLegacy.ScytheReviveCooldown");
        public override string Texture => "CalamityEntropyLegacy/Content/Cooldowns/ScytheReviveCooldown";
        public override Color OutlineColor => Color.SkyBlue;
        public override Color CooldownStartColor => Color.DarkRed;
        public override Color CooldownEndColor => Color.Firebrick;

        public override SoundStyle? EndSound => new("CalamityEntropyLegacy/Assets/Sounds/MantleCDEnd");
    }
}
