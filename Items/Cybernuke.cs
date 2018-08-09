using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace cybernuke.Items
{
	public class Cybernuke : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cybernuke");
			Tooltip.SetDefault("Is that a 'go' for launch? It'll completely fry his system.");
		}
		public override void SetDefaults()
		{
			item.damage = 1337;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 4;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Bullet;
		}
		public override bool ConsumeAmmo(Player player)
		{
			//this f value is chance to not consume ammo as portion of 1
			return Main.rand.NextFloat() >= .76f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
