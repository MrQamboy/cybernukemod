using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using cybernukemod.NPCs;
using cybernukemod;
 
namespace cybernukemod.Buffs
{
    public class zenith : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Zenith"); //the name displayed when hovering over the buff ingame.
            Description.SetDefault("You choked on the square jumps! (Defense set to 0)"); //The description of the buff shown when hovering over ingame.          
            Main.debuff[Type] = true;   //Tells the game if this is a buf or not.
            Main.pvpBuff[Type] = true;  //Tells the game if pvp buff or not.
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }
 
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<npcinfo>(mod).zenith = true;    //this tells the game to use the public bool zenith from NPCsINFO.cs
            int num1 = Dust.NewDust(npc.position, npc.width, npc.height, DustID.PinkFlame);    //this is the dust/flame effect that will apear on npc or player if is hit by this buff  
            Main.dust[num1].scale = 2.9f; //the dust scale , the higher is the value the large is the dust
            Main.dust[num1].velocity *= 3f; //the dust velocity
            Main.dust[num1].noGravity = true;
        }
    /*
        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<OPlayer>(mod).zenith = true;  //this tells the game to use the public bool zenith from MyPlayer.cs
            int num1 = Dust.NewDust(player.position, player.width, player.height, DustID.PinkFlame);    //this is the dust/flame effect that will apear on npc or player if is hit by this buff  
            Main.dust[num1].scale = 2.9f; //the dust scale , the higher is the value the large is the dust
            Main.dust[num1].velocity *= 3f; //the dust velocity
            Main.dust[num1].noGravity = true;
        }
    */
    }
}