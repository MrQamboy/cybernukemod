using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameInput;
 
namespace cybernukemod
{
    public class OPlayer : ModPlayer
    {
 
        public bool zenith = false;
 
        public override void ResetEffects()
        {
            zenith = false;
        }
 
        public override void UpdateBadLifeRegen()
        {
            if (zenith)  // make sure you add the right bool
            {
                player.lifeRegen -= 30; //this make so the player take damage, the highter is the value the more life losing.
            }
        }
 
    }
}