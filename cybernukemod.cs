using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace cybernukemod
{
	class cybernukemod : Mod
	{
		public cybernukemod()
		{
		}
		public override void Load()
		{
			if (!Main.dedServ){
				Main.music[MusicID.Dungeon] = GetMusic("Sounds/Music/blackrover");
			}
		}
	}

}
