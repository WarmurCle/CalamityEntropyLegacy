using CalamityEntropyLegacy.Content.Projectiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.UI.Poops
{
    public class PoopStinky : Poop
    {
        public override int ProjectileType()
        {
            return ModContent.ProjectileType<PoopStinkyProjectile>();
        }
    }
}
