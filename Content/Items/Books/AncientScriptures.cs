using CalamityMod.Items.LoreItems;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.Books
{
    public class AncientScriptures : EntropyBook
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.damage = 20;
            Item.crit = 4;
            Item.mana = 5;
        }
        public override int HeldProjectileType => ModContent.ProjectileType<AncientScripturesHeld>();
        public override int SlotCount => 2;

        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ModContent.ItemType<LoreAwakening>())
                .AddIngredient(ItemID.Leather, 6)
                .AddIngredient(ItemID.ManaCrystal, 1)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class AncientScripturesHeld : EntropyBookHeldProjectile
    {
        public override string OpenAnimationPath => "CalamityEntropyLegacy/Content/Items/Books/Textures/AncientScriptures/AncientScripturesOpen";
        public override string PageAnimationPath => "CalamityEntropyLegacy/Content/Items/Books/Textures/AncientScriptures/AncientScripturesPage";
        public override string UIOpenAnimationPath => "CalamityEntropyLegacy/Content/Items/Books/Textures/AncientScriptures/AncientScripturesUI";
    }

}
