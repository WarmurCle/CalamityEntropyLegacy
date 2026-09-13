using CalamityEntropyLegacy.Content.Items.Donator;
using CalamityMod.Cooldowns;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;

namespace CalamityEntropyLegacy.Content.Cooldowns
{
    public class TlipocasScytheSlashCooldown : CooldownHandler
    {
        public static new string ID => "TlipocasScytheSlashCooldown";
        public override bool ShouldDisplay => true;
        public override LocalizedText DisplayName => Language.GetOrRegister("Mods.CalamityEntropyLegacy.TlipocasScytheSlashCooldown");
        public override string Texture => "CalamityEntropyLegacy/Content/Cooldowns/TlipocasScytheSlashCooldown";
        public override Color OutlineColor => Color.SkyBlue;
        public override Color CooldownStartColor => Color.DarkRed;
        public override Color CooldownEndColor => Color.Firebrick;
        public override bool CanTickDown => Main.LocalPlayer.HeldItem.ModItem is TlipocasScythe;
        public override SoundStyle? EndSound => new("CalamityEntropyLegacy/Assets/Sounds/MantleCDEnd");
    }
}
