using CalamityEntropyLegacy.Content.Projectiles.Pets.Aquatic;
using CalamityEntropyLegacy.Content.Projectiles.Pets.Desert;
using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Buffs.Pets
{
    public class AquaticAmuletBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            bool unused = false;
            player.BuffHandle_SpawnPetIfNeededAndSetTime(buffIndex, ref unused, ModContent.ProjectileType<AquaticPet>());
            player.BuffHandle_SpawnPetIfNeededAndSetTime(buffIndex, ref unused, ModContent.ProjectileType<DSPet>());

        }
    }
}
