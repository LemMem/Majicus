using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
namespace Majicus.Tiles
{
    public class MagicTableBlock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileNoAttach[Type] = true;
            Main.tileSolid[Type] = true;
            drop = mod.ItemType("MagicTable");
            disableSmartCursor = true;
            AddMapEntry(new Color(00, 00, 00));
        }
    }
}
