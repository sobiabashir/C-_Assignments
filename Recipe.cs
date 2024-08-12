using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Recipe
    {
        public string recpName;
        public FoodCategory Category;
        public string Description;
        public string[] ingredients;
        private int maxNumOfIngredients;
       

        /// <summary> getter setter
        public string GetRecpName()
        { return recpName; }
        public void SetRecpName(string name)
        { this.recpName = name; }
        public FoodCategory GetFoodCategory()
        { return Category; }
        public void SetCategory(FoodCategory category)
        { this.Category = category; }
        public string GetDescription()
            { return Description; }
        public void SetDescription(string description)
            { this.Description = description; }
        public string[] GetIngredients()
        {
            return ingredients;
        }
        public void SetIngredients(string[] ingredients)
        {
            this.ingredients = ingredients;
        }
        public int GetMaxNumOfIngredients()
        {
            return maxNumOfIngredients;
        }

        ///// constructor

        public Recipe(int maxNumOfIngredients)
        {
            this.maxNumOfIngredients = maxNumOfIngredients;
        }


        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="maxNumOfIngredients"></param>



        public bool AddIngredient(string ingredient)
        {
            
            if (ingredients == null || ingredients.Length >= maxNumOfIngredients)
            {
                return false; // Unable to add ingredient, maximum capacity reached
            }

            // Create a new array with increased size to accommodate the new ingredient
            string[] newIngredients = new string[ingredients.Length + 1];

            // Copy existing ingredients to the new array
            Array.Copy(ingredients, newIngredients, ingredients.Length);

            // Add the new ingredient to the end of the new array
            newIngredients[ingredients.Length] = ingredient;

            // Assign the new array back to the ingredients field
            ingredients = newIngredients;

            return true; // Successfully added ingredient
        }

        public bool CheckIndex(int index)
        {
            // Check if the ingredients array is not null and the index is within the valid range
            if (ingredients != null && index >= 0 && index < ingredients.Length)
            {
                return true; // Index is valid
            }
            else
            {
                return false; // Index is out of range or ingredients array is null
            }
        }



        public bool ChangeIngredientsAt(int index, string value)
        {
            // Check if the index is valid
            if (CheckIndex(index))
            {
                // Change the value of the ingredient at the specified index
                ingredients[index] = value;
                return true; // Successfully changed the ingredient
            }
            else
            {
                return false; // Invalid index
            }
        }

        public int CurrentNumOfIngredients()
        {
            if (ingredients != null)
            {
                return ingredients.Length; // Return the length of the ingredients array
            }
            else
            {
                return 0; // Return 0 if ingredients array is null
            }
        }
        
        public void DefaultValues()
        {
            recpName = ""; // Set default value for recpName
            Category = FoodCategory.Default; // Set default value for Category
            Description = ""; // Set default value for Description
            ingredients = new string[0]; // Initialize ingredients array with an empty array
            maxNumOfIngredients = 0; // Set default value for maxNumOfIngredients
        }

        public void DeleteIngredientAt(int index)
        {
            // Check if the index is valid
            if (CheckIndex(index))
            {
                // Create a new array to hold ingredients excluding the one at the specified index
                string[] newIngredients = new string[ingredients.Length - 1];

                // Copy ingredients before the specified index
                Array.Copy(ingredients, 0, newIngredients, 0, index);

                // Copy ingredients after the specified index
                Array.Copy(ingredients, index + 1, newIngredients, index, ingredients.Length - index - 1);

                // Assign the new array back to the ingredients field
                ingredients = newIngredients;
            }
            // else: Invalid index, do nothing
        }
      public int FindVacantPosition()
        {
            // Iterate through the ingredients array
            for (int i = 0; i < ingredients.Length; i++)
            {
                // If the current element is null, return its index
                if (ingredients[i] == null)
                {
                    return i;
                }
            }

            // If no vacant position is found, return -1
            return -1;
        }

        public String GetIngredientsString()
        {
            if (ingredients == null || ingredients.Length == 0)
            {
                return "0"; // Return "No ingredients" if the ingredients array is null or empty
            }
            else
            {
                return ingredients.Length.ToString();  // Return a string representation of ingredients separated by commas
            }
        }

     

        public override string ToString()
        {
            // Create a string builder to construct the string representation
            StringBuilder stringBuilder = new StringBuilder();

            // Append recipe name
            stringBuilder.AppendLine($"{recpName.PadRight(50)}");

            // Append category
            stringBuilder.AppendLine($"{Category.ToString().PadRight(50)}");
           // stringBuilder.AppendLine(CurrentNumOfIngredients().ToString());
                        // Append ingredients
            stringBuilder.AppendLine($"{GetIngredientsString().PadRight(10)}");

            // Return the constructed string
            return stringBuilder.ToString();
        }

    }

       
    
}
