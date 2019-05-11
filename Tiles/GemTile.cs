using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shattered.Tiles
{
    public class GemTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Makes this a solid tile
            Main.tileMergeDirt[Type] = true; // Merges gracefully w/ dirt
            Main.tileLighted[Type] = true; // Allow to emit light
            Main.tileLavaDeath[Type] = true; // Lava will kill this tile

            drop = mod.ItemType("ExampleTileItem"); // Drops this item upon destruction
            dustType = DustID.Platinum; // Use platinum particles

            // Map entry
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Example Tile Name");
            // Will add color & name to map
            AddMapEntry(new Microsoft.Xna.Framework.Color(100, 150, 200), name); // (or) AddMapEntry(Color.Red);

            minPick = 20; // Requires pick power of value to break
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.5f;
            g = 0.75f;
            b = 1f;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}
