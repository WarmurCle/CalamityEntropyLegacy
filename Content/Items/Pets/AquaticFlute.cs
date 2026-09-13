using CalamityEntropyLegacy.Content.Buffs.Pets;
using CalamityEntropyLegacy.Content.Projectiles.Pets.Aquatic;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.Pets
{
    public class AquaticFlute : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ZephyrFish);
            Item.shoot = ModContent.ProjectileType<AquaticPet>();
            Item.buffType = ModContent.BuffType<AquaticChan>();
            Item.UseSound = null;
        }

        public override bool? UseItem(Player player)
        {
            if (!Main.dedServ)
            {
                SoundEngine.PlaySound(new SoundStyle("CalamityEntropyLegacy/Assets/Sounds/flute" + Main.rand.Next(1, 3).ToString()));
            }
            if (player.whoAmI == Main.myPlayer)
            {
                player.AddBuff(Item.buffType, 3600);
            }
            return true;
        }
    }
}