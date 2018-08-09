using Terraria.ID;
using Terraria.ModLoader;

namespace cybernukemod.Items
{
	public class cybernukeammo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cybernuke Bullet");
			Tooltip.SetDefault("This is a modded bullet ammo.");
		}

		public override void SetDefaults()
		{
			item.damage = 1337;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1337;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 11;
			item.shoot = mod.ProjectileType("ExampleBullet");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 12f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 70);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 70);
			recipe.AddRecipe();
		}
	}
}
