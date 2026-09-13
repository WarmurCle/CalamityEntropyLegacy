using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Rarities
{
    public class Golden : ModRarity
    {
        public override Color RarityColor => new Color(246, 200, 0);

        public override int GetPrefixedRarity(int offset, float valueMult)
        {
            return Type;
        }
    }
}
