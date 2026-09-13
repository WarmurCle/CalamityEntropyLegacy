using CalamityMod.Cooldowns;
using Terraria.Audio;
using Terraria.Localization;

namespace CalamityEntropyLegacy.Content.Cooldowns
{
    public class FetalDreamCooldown : CooldownHandler
    {
        public static new string ID => "FetalDreamCooldown";
        public override bool ShouldDisplay => true;
        public override LocalizedText DisplayName => Language.GetOrRegister("Mods.CalamityEntropyLegacy.FetalDreamCooldown");
        public override string Texture => "CalamityEntropyLegacy/Content/Cooldowns/FetalDreamCooldown";
        public override Color OutlineColor => new Color(210, 130, 160);
        public override Color CooldownStartColor => new Color(200, 111, 145);
        public override Color CooldownEndColor => new Color(200, 111, 145);

        public override SoundStyle? EndSound => new("CalamityEntropyLegacy/Assets/Sounds/soulshine");
    }
}
