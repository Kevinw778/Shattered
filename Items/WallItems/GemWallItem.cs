using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Shattered.Items.WallItems
{
    public class GemWallItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gem Wall");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;

            item.createWall = mod.WallType("GemWall");
        }
    }
}
