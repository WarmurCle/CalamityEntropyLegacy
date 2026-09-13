using CalamityEntropyLegacy.Content.Projectiles.Pets.DarkFissure;
using CalamityEntropyLegacy.Content.Projectiles.Pets.DoG;
using CalamityEntropyLegacy.Content.Projectiles.Pets.Signus;
using CalamityEntropyLegacy.Content.Projectiles.Pets.StormWeaver;
using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Buffs.Pets
{
    public class DevourerAndTheApostles : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            bool unused = false;
            player.BuffHandle_SpawnPetIfNeededAndSetTime(buffIndex, ref unused, ModContent.ProjectileType<SigPetProj>());
            player.BuffHandle_SpawnPetIfNeededAndSetTime(buffIndex, ref unused, ModContent.ProjectileType<DarkFissure>());
            player.BuffHandle_SpawnPetIfNeededAndSetTime(buffIndex, ref unused, ModContent.ProjectileType<StormWeaverPet>());
            player.BuffHandle_SpawnPetIfNeededAndSetTime(buffIndex, ref unused, ModContent.ProjectileType<DoG>());
        }
    }
}
