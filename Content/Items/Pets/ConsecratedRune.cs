using CalamityEntropyLegacy.Content.Buffs.Pets;
using CalamityEntropyLegacy.Content.Items.Donator;
using CalamityEntropyLegacy.Content.Projectiles.Pets;
using CalamityMod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.Pets
{
    public class ConsecratedRune : ModItem, IDevItem
    {
        public string DevName => "锯角";
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ZephyrFish);
            Item.UseSound = SoundID.Item1;
            Item.shoot = ModContent.ProjectileType<Pooney>();
            Item.buffType = ModContent.BuffType<ConsecratedRefuge>();
        }

        public override bool? UseItem(Player player)
        {
            if (player.whoAmI == Main.myPlayer)
            {
                player.AddBuff(Item.buffType, 3600);
            }
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.SoulofLight, 2).
                AddIngredient(ItemID.HallowedBar, 4).
                AddIngredient<EssenceofSunlight>().
                AddTile(TileID.WorkBenches).
                Register();
        }
    }
}