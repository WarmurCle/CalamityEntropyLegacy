using CalamityEntropyLegacy.Content.Buffs.Pets;
using CalamityEntropyLegacy.Content.Projectiles.Pets;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.Pets
{
    public class LostSoul : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ZephyrFish);
            Item.UseSound = null;
            Item.shoot = ModContent.ProjectileType<LostSoulProj>();
            Item.buffType = ModContent.BuffType<LostSoulBuff>();
        }

        public override bool? UseItem(Player player)
        {
            if (player.whoAmI == Main.myPlayer)
            {
                player.AddBuff(Item.buffType, 3600);
            }
            return true;
        }

    }
}