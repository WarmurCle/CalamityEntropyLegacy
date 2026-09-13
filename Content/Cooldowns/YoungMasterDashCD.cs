using CalamityEntropyLegacy.Content.Items.Donator;
using CalamityMod.Cooldowns;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;

namespace CalamityEntropyLegacy.Content.Cooldowns
{
    public class YoungMasterDashCD : CooldownHandler
    {
        public static new string ID => "YoungMasterDashCD";
        public override bool ShouldDisplay => true;
        public override LocalizedText DisplayName => Language.GetOrRegister("Mods.CalamityEntropyLegacy.YoungMasterDashCD");
        public override string Texture => "CalamityEntropyLegacy/Content/Cooldowns/YoungMasterDashCD";
        public override Color OutlineColor => Color.SkyBlue;
        public override Color CooldownStartColor => Color.DarkRed;
        public override Color CooldownEndColor => Color.Firebrick;
        public override SoundStyle? EndSound => new("CalamityEntropyLegacy/Assets/Sounds/SwordHit0");
    }
}
