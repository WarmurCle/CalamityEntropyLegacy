using CalamityMod.Cooldowns;
using Terraria.Audio;
using Terraria.Localization;

namespace CalamityEntropyLegacy.Content.Cooldowns
{
    public class RuneDashCD : CooldownHandler
    {
        public static new string ID => "RuneDashCD";
        public override bool ShouldDisplay => true;
        public override LocalizedText DisplayName => Language.GetOrRegister("Mods.CalamityEntropyLegacy.RuneDashCD");
        public override string Texture => "CalamityEntropyLegacy/Content/Cooldowns/RuneDashCD";
        public override Color OutlineColor => Color.SkyBlue;
        public override Color CooldownStartColor => Color.SkyBlue;
        public override Color CooldownEndColor => Color.SkyBlue;

        public override SoundStyle? EndSound => new("CalamityMod/Sounds/Item/CometShardUse");
    }
}
