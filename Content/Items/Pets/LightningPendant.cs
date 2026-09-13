using CalamityEntropyLegacy.Content.Buffs.Pets;
using CalamityEntropyLegacy.Content.Projectiles.Pets.StormWeaver;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.Pets
{
    public class LightningPendant : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ZephyrFish);
            SoundStyle s = new("CalamityEntropyLegacy/Assets/Sounds/vmspawn");
            s.Volume = 0.6f;
            Item.UseSound = s;
            Item.shoot = ModContent.ProjectileType<StormWeaverPet>();
            Item.buffType = ModContent.BuffType<Rainstorm>();
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