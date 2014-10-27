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
         
        void IRecipeView.Show(IRecipe recipe)
        {
            
            RecipeView test = new RecipeView();
            test.Header = recipe.Name;
            Console.Clear();
            test.ShowHeaderPanel();
           
           
            

           
            
        }
        void IRecipeView.Show(IEnumerable<IRecipe> recipes)
        {
            
         
        }


    }
}
