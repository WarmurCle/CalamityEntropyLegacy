using CalamityMod.Cooldowns;
using Terraria.Audio;
using Terraria.Localization;

namespace CalamityEntropyLegacy.Content.Cooldowns
{
    public class DamageReduceCD : CooldownHandler
    {
        public static new string ID => "DamageReduceCooldown";
        public override bool ShouldDisplay => true;
        public override LocalizedText DisplayName => Language.GetOrRegister("Mods.CalamityEntropyLegacy.DamageReduceCD");
        public override string Texture => "CalamityEntropyLegacy/Content/Cooldowns/DamageReduceCD";
        public override Color OutlineColor => new Color(235, 235, 160);
        public override Color CooldownStartColor => new Color(235, 235, 160);
        public override Color CooldownEndColor => new Color(235, 235, 160);

        public override SoundStyle? EndSound => null;
    }
}
