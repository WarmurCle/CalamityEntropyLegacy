using CalamityEntropyLegacy.Common;
using CalamityEntropyLegacy.Content.Rarities;
using CalamityMod.Items.LoreItems;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.Lores
{
    public class CruiserLore : LoreItem
    {
        public const int LifeBoost = 20;
        public const int ManaBoost = 50;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.LeftShift))
                return;
            if (LoreEffect.Enabled)
            {
                TooltipLine tooltipLineEF = new TooltipLine(base.Mod, "Entropy:Effect", Language.GetTextValue("Mods.CalamityEntropyLegacy.UseToggle"));
                tooltips.Add(tooltipLineEF);
                TooltipLine tooltipLineA = new TooltipLine(base.Mod, "Entropy:Effect", Language.GetTextValue("Mods.CalamityEntropyLegacy.loreCruiserEffect"));
                tooltips.Add(tooltipLineA);
                TooltipLine tooltipLineE = new TooltipLine(base.Mod, "Entropy:Effect", Language.GetTextValue("Mods.CalamityEntropyLegacy." + (Main.LocalPlayer.Entropy().CruiserLoreBonus ? "Enabled" : "Disabled")));
                tooltipLineE.OverrideColor = Main.LocalPlayer.Entropy().CruiserLoreBonus ? Color.Yellow : Color.Gray;
                tooltips.Add(tooltipLineE);
            }

            /*TooltipLine tooltipLine = new TooltipLine(base.Mod, "CalamityMod:Lore", Language.GetTextValue("Mods.CalamityEntropyLegacy.loreCruiser"));
            if (ExtensionIndicatorColor.HasValue)
            {
                tooltipLine.OverrideColor = ExtensionIndicatorColor.Value;
            }

            CEUtils.HoldShiftTooltip(tooltips, new TooltipLine[1] { tooltipLine }, hideNormalTooltip: true);*/
        }
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.useAnimation = 30;
            Item.useTime = 30;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.rare = ModContent.RarityType<VoidPurple>();
            SoundStyle s = new("CalamityEntropyLegacy/Assets/Sounds/vmspawn");
            s.Volume = 0.6f;
            s.Pitch = 1.4f;
            Item.UseSound = s;
            Item.maxStack = 1;
            Item.useTurn = true;
        }
        public override bool CanUseItem(Player player)
        {
            return LoreEffect.Enabled;
        }
        public override bool? UseItem(Player player)
        {
            EModPlayer modPlayer = player.Entropy();
            player.itemTime = Item.useTime;
            modPlayer.CruiserLoreBonus = !modPlayer.CruiserLoreBonus;
            return true;
        }
    }
}
