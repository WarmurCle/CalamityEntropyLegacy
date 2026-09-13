using CalamityMod.Cooldowns;
using Terraria.Audio;
using Terraria.Localization;

namespace CalamityEntropyLegacy.Content.Cooldowns
{
    public class AcropolisCooldown : CooldownHandler
    {
        public static new string ID => "AcropolisCooldown";
        public override bool ShouldDisplay => true;
        public override LocalizedText DisplayName => Language.GetOrRegister("Mods.CalamityEntropyLegacy.CdAcr");
        public override string Texture => "CalamityEntropyLegacy/Content/Cooldowns/AcropolisCooldown";
        public override Color OutlineColor => new Color(255, 126, 126);
        public override Color CooldownStartColor => new Color(255, 11, 11);
        public override Color CooldownEndColor => new Color(255, 11, 11);

        public override SoundStyle? EndSound => new("CalamityEntropyLegacy/Assets/Sounds/WulfrumPingReady");
    }
}
