using CalamityEntropyLegacy.Content.Rarities;
using CalamityEntropyLegacy.Content.Tiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.MusicBoxes
{
    public class NihilityTwinsMusicBox : MusicBox
    {
        public override string MusicFile => "Assets/Sounds/Music/vtfight";
        public override int MusicBoxTile => ModContent.TileType<NihilityTwinsMusicBoxTile>();
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ModContent.RarityType<NihilityBlue>();
        }
    }
    public class NihilityTwinsMusicBoxTile : MusicBoxTile
    {
    }
}
