using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Assets.Register
{
    public class AssetsRegister : ModSystem
    {
        private const string AssetsPath = "CalamityEntropyLegacy/Assets/";
        private const string ExtraPath = "CalamityEntropyLegacy/Assets/Extra/";
        public static Asset<Texture2D> FireTornado;
        public override void Load()
        {
            FireTornado = ModContent.Request<Texture2D>($"{ExtraPath}Tornade_Fire");
        }
        public override void Unload()
        {
            FireTornado = null;
        }
    }
}