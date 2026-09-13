using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Particles
{
    public class HealingParticle : EParticle
    {
        public override Texture2D Texture => ModContent.Request<Texture2D>("CalamityEntropyLegacy/Content/Particles/HealingParticle").Value;
        public override void OnSpawn()
        {
            this.Lifetime = 46;
        }
        public override void AI()
        {
            base.AI();
            if (this.Lifetime < 26)
                this.Opacity *= 0.9f;
        }
    }
}