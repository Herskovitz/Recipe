using RecipeSystem;
using System.Data;

namespace RecipeMaui;

public partial class RecipeList : ContentPage
{
	public RecipeList()
	{
		InitializeComponent();
	}

	private void SearchRecipes()
	{
		DataTable dt = Recipe.SearchRecipes(RecipeNametxt.Text);
		Recipelst.ItemsSource = dt.Rows;
	}
    private void RecipeSearchbtn_Clicked(object sender, EventArgs e)
    {
		SearchRecipes();
    }
}