using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using cybernukemod.NPCs;
 
namespace cybernukemod.NPCs
{
    public class npcglobal : GlobalNPC
    {
 
        public override void ResetEffects(NPC npc)
        {
            npc.GetGlobalNPC<npcinfo>(mod).zenith = false;
        }
 
        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (npc.GetGlobalNPC<npcinfo>(mod).zenith)  //this tells the game to use the public bool customdebuff from NPCsINFO.cs
            {
                npc.defense = 0;      //this make so the npc have 0 defense;
            }
        }
    }
}