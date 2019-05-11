using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Shattered
{
    public class GemWall : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true; // Can be used for house
            drop = mod.ItemType("GemWall");
            AddMapEntry(new Color(100, 150, 100));
            dustType = mod.DustType("GemTileDust");
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3; // not really sure what this does, tbqh
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 1f; // could also do r = 1f / 255f * 102f to use 0 - 255, instead
            g = 0.0f;
            b = 0.4f;
        }
    }
}
