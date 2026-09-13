using CalamityEntropyLegacy.Content.Buffs.Pets;
using CalamityEntropyLegacy.Content.Projectiles.Pets.Eater;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.Pets
{
    public class CannedCarrion : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ZephyrFish);
            Item.shoot = ModContent.ProjectileType<EaterProj>();
            Item.buffType = ModContent.BuffType<EaterBuff>();
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