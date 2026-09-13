using CalamityMod.Cooldowns;
using Terraria.Audio;
using Terraria.Localization;

namespace CalamityEntropyLegacy.Content.Cooldowns
{
    public class ProtectiveCannonCooldown : CooldownHandler
    {
        public static new string ID => "ProtectiveCannonCooldown";
        public override bool ShouldDisplay => true;
        public override LocalizedText DisplayName => Language.GetOrRegister("Mods.CalamityEntropyLegacy.ProtectiveCannonCooldown");
        public override string Texture => "CalamityEntropyLegacy/Content/Cooldowns/ProtectiveCannonCooldown";
        public override Color OutlineColor => Color.Red;
        public override Color CooldownStartColor => Color.Orange;
        public override Color CooldownEndColor => Color.Firebrick;

        public override SoundStyle? EndSound => new("CalamityEntropyLegacy/Assets/Sounds/alert2");
    }
}
