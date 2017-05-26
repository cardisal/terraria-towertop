using Terraria.ModLoader;

namespace towertop
{
	class towertop : Mod
	{
		public towertop()
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
