using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {

        public void Show(IRecipe recipe)
        {

            //SHOW HEADERPANEL OF CHOOSEN RECIPE
            RecipeView newRecipe = new RecipeView();
            newRecipe.Header = recipe.Name;
            Console.Clear();
            newRecipe.ShowHeaderPanel();

            //DISPLAY ALL INGREDIENTS
            Console.WriteLine();
            Console.WriteLine("INGREDIENSER:");
            Console.WriteLine("===============================");

            IList<IIngredient> ingredients = recipe.Ingredients.ToList();

            foreach (IIngredient item in ingredients)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("GÖR SÅ HÄR:");
            Console.WriteLine("===============================");

            //DISPLAY ALL INSTRUCTIONS
            IList<string> instructions = recipe.Instructions.ToList();
            
            foreach(string item in instructions)
            {
                Console.WriteLine(item);
            }







        }
        public void Show(IEnumerable<IRecipe> recipes)
        {
         
        }


    }
}
