using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class RecipeManager1
    {
        public Recipe[] recipeList;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxNumOfRecipes"></param>
        private int numOfRecipes;
        public RecipeManager1(int maxNumOfRecipes)
        {
            
            recipeList = new Recipe[maxNumOfRecipes];
            numOfRecipes = 0;

        }

       



        public bool Add(Recipe recipe)
        {

            if (recipe != null)
            {
                // Find an empty slot in the recipeList
                for (int i = 0; i < recipeList.Length; i++)
                {
                    if (recipeList[i] == null)
                    {
                        // Add the recipe to the empty slot
                        recipeList[i] = recipe;
                        numOfRecipes++; // Increment numOfRecipes
                        return true; // Successfully added the recipe
                    }
                }
                // No empty slot found
                MessageBox.Show("Cannot add more recipes. Maximum limit reached.");
                return false;
            }
            else
            {
                MessageBox.Show("Cannot empty.");
                return false; // Recipe is null, cannot be added
            }
        }


        public bool Add(string name, FoodCategory category, string[] ingredients)
        {
            // Check if there is space available in the recipeList
            if (numOfRecipes < recipeList.Length)
            {
                // Create a new Recipe object using the provided parameters
                Recipe newRecipe = new Recipe(recipeList.Length); // Assuming maxNumOfIngredients is the only parameter

                // Set the properties of the new Recipe object
                newRecipe.SetRecpName(name);
                newRecipe.SetCategory(category);
                newRecipe.SetIngredients(ingredients);

                // Add the new Recipe object to the recipeList using the existing Add method
                if (Add(newRecipe))
                {
                    numOfRecipes++; // Increment the count of elements with values
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // No space available in the recipeList
                // You can handle this scenario as per your requirement
                return false;
            }
        }
        public void ChangeElement(int index, Recipe recipe)
        {
            // Check if the index is valid
            if (index >= 0 && index < recipeList.Length)
            {
                recipeList[index] = recipe;
            }
            // else: Invalid index, do nothing
        }
        public bool CheckIndex(int index)
        {
            // Check if the index is within the valid range for the recipeList
            return index >= 0 && index < recipeList.Length;
        }

        public void DeleteElement(int index)
        {
            // Check if the index is within the valid range
            // Check if the index is within the valid range
            if (index >= 0 && index < recipeList.Length)
            {
                // Shift elements to the left starting from the index to be deleted
                for (int i = index; i < recipeList.Length - 1; i++)
                {
                    recipeList[i] = recipeList[i + 1];
                }

                // Set the last element to null
                recipeList[recipeList.Length - 1] = null;

                numOfRecipes--; // Decrement the count of elements with values
            }
            else
            {
                // Index is out of range
                // You can handle this scenario as per your requirement
            }
        }
        public int FindVacantPosition()
        {
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                {
                    return i;
                }
            }
            return -1; // No vacant position found
        }
        public int GetCurrentNumberOfRecipes()
        {
            return numOfRecipes;
        }

        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
            {
                return recipeList[index];
            }
            else
            {
                Console.WriteLine("Invalid index.");
                return null;
            }
        }

        
       
        public Recipe FindRecipeByName(string recipeName)
        {
            foreach (Recipe recipe in recipeList)
            {
                if (recipe != null && recipe.GetRecpName() == recipeName)
                {
                    return recipe;
                }
            }
            return null; // Recipe not found
        }

    }
}