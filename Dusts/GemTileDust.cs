using Terraria;
using Terraria.ModLoader;

namespace Shattered.Dusts
{
    public class GemTileDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.noLight = true;
            dust.scale = 2f;
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X;
            dust.scale -= 0.1f;

            // This disables dust when it gets small enough,
            // but I could make it depend on whatever
            if (dust.scale < 0.5f)
            {
                dust.active = false;
            }

            return false;
        }
    }
}
