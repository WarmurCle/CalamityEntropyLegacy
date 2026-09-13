using CalamityEntropyLegacy.Content.Tiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.MusicBoxes
{
    public class ApsychosMusicBox : MusicBox
    {
        public override string MusicFile => "Assets/Sounds/Music/Apsychos";
        public override int MusicBoxTile => ModContent.TileType<ApsychosMusicBoxTile>();
    }
    public class ApsychosMusicBoxTile : MusicBoxTile
    {
    }
}
