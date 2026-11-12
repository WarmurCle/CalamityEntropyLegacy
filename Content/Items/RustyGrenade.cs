using CalamityEntropyLegacy.Content.Projectiles;
using CalamityEntropyLegacy.Core;
using CalamityMod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items
{
    public class RustyGrenade : ModItem
    {
        public override void SetStaticDefaults()
        {
            AmmoID.Sets.IsSpecialist[Type] = true;
            AmmoID.Sets.SpecificLauncherAmmoProjectileMatches[ItemID.RocketLauncher].Add(Type, ModContent.ProjectileType<RustyGrenadeProjectile>());
            AmmoID.Sets.SpecificLauncherAmmoProjectileMatches[ItemID.GrenadeLauncher].Add(Type, ModContent.ProjectileType<RustyGrenadeProjectile>());
            AmmoID.Sets.SpecificLauncherAmmoProjectileMatches[ItemID.ProximityMineLauncher].Add(Type, ModContent.ProjectileType<RustyGrenadeProjectile>());
            AmmoID.Sets.SpecificLauncherAmmoProjectileMatches[ItemID.SnowmanCannon].Add(Type, ModContent.ProjectileType<RustyGrenadeProjectile>());
            AmmoID.Sets.SpecificLauncherAmmoProjectileMatches[ItemID.Celeb2].Add(Type, ProjectileID.Celeb2Rocket);
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.maxStack = 9999;
            Item.value = Item.sellPrice(silver: 1);
            Item.rare = ItemRarityID.White;
            Item.ammo = AmmoID.Rocket;
            Item.DamageType = DamageClass.Ranged;
            Item.damage = CrossModSystem.IEoRBalancing ? 10 : 20;
        }

        public override void AddRecipes()
        {
            CreateRecipe(250).AddIngredient(ModContent.ItemType<DubiousPlating>(), 2).AddIngredient(ItemID.IronBar, 10).AddTile(TileID.Anvils).Register();
        }
    }
}
