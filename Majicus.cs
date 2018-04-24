using Terraria.ModLoader;

namespace Majicus
{
	class Majicus : Mod
	{
		public Majicus()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
