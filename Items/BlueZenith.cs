using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace cybernukemod.Items.Weapons
{
	public class BlueZenith : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Zenith");
			Tooltip.SetDefault("727 blue zenith lol");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 727;
			item.magic = true;
			item.mana = 2;
			item.width = 40;
			item.height = 40;
			item.useTime = 3;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 72727;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("ZenithProj");
			item.shootSpeed = 16f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}