using CalamityEntropyLegacy.Content.Rarities;
using CalamityEntropyLegacy.Content.Tiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.MusicBoxes
{
    public class CruiserMusicBox : MusicBox
    {
        public override string MusicFile => "Assets/Sounds/Music/CruiserBoss";
        public override int MusicBoxTile => ModContent.TileType<CruiserMusicBoxTile>();
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ModContent.RarityType<VoidPurple>();
        }
    }
    public class CruiserMusicBoxTile : MusicBoxTile
    {
    }
}
