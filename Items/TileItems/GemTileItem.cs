using Terraria;
using Terraria.ModLoader;

namespace Shattered.Items.TileItems
{
    public class GemTileItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gem Tile Block");
            Tooltip.SetDefault("This item will allow you to place a tile of its kind");
        }

        public override void SetDefaults()
        {
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.createTile = mod.TileType("GemTile");
        }
    }
}
