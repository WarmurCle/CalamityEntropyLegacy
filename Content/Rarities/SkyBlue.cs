using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Rarities
{
    public class SkyBlue : ModRarity
    {
        public override Color RarityColor => Color.SkyBlue;

        public override int GetPrefixedRarity(int offset, float valueMult) => Type;
    }
}
