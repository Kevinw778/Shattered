using Terraria.ModLoader;

namespace Shattered
{
    public class Shattered : Mod
    {
        public Shattered()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadBackgrounds = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}
