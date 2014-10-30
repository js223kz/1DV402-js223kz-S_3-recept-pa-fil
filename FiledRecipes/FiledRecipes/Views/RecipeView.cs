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

            //DISPLAY ALL INSTRUCTIONS
            Console.WriteLine();
            Console.WriteLine("GÖR SÅ HÄR:");
            Console.WriteLine("===============================");

            IList<string> instructions = recipe.Instructions.ToList();
            int index = 0;
            
            for (index = 0; index < instructions.Count; ++index)
            {
                Console.WriteLine(String.Format("{0}{1}{2}{3}", "<", index + 1, ">\n", instructions[index]));
            }
         }
        
        public void Show(IEnumerable<IRecipe> recipes)
        {
            foreach (IRecipe rec in recipes)
            {
                Show(rec);
                ContinueOnKeyPressed();
            }

        }
    }
}
