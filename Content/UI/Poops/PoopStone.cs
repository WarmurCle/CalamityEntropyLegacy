using CalamityEntropyLegacy.Content.Projectiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.UI.Poops
{
    public class PoopStone : Poop
    {
        public override int ProjectileType()
        {
            return ModContent.ProjectileType<PoopStoneProjectile>();
        }
    }
}
