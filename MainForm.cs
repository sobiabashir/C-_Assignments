using System.Text;

namespace RecipeManager
{
    public partial class MainForm : Form
    {

        private const int MaxIngredients = 50;
        private const int MaxRecipes = 200;
        private RecipeManager1 rcpeMngr;
        private Recipe currRecipe;
        private Recipe selectedRecipe;

        public MainForm()
        {
            InitializeComponent();
            InitializeComboBox();
            rcpeMngr = new RecipeManager1(MaxRecipes);
            currRecipe = new Recipe(MaxIngredients);
            CenterToScreen();
            InitializeGUI();
            //lstRecipes.DoubleClick += lstRecipes_DoubleClick;

        }

        private void InitializeComboBox()
        {
            cmbCategeory.Items.AddRange(Enum.GetNames(typeof(FoodCategory)));
        }

        private void InitializeGUI()
        {
            // Initialize GUI components
            Text = "Apu RecipeBook by Sobia Bashir";
            // Other GUI initialization as required
           
        }



        private void btnAddIngerdients_Click(object sender, EventArgs e)
        {
            string recipeName = txtNameOfRecipe.Text;
            if (!string.IsNullOrWhiteSpace(txtNameOfRecipe.Text) && cmbCategeory.SelectedItem != null)
            {
                // Create a new Recipe object with the entered name and category
                currRecipe = new Recipe(MaxIngredients);
                currRecipe.SetRecpName(recipeName);
                currRecipe.SetCategory((FoodCategory)Enum.Parse(typeof(FoodCategory), cmbCategeory.SelectedItem.ToString()));

                fillIngredients(currRecipe);
                
            }
            else
            {
                MessageBox.Show("Please enter recipe name and select a category for the recipe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            FoodCategory selectedCategory;

            bool ok = Enum.TryParse(cmbCategeory.SelectedItem.ToString(), out selectedCategory);
            if (!string.IsNullOrWhiteSpace(txtNameOfRecipe.Text) && cmbCategeory.SelectedItem != null && ok)
            {
                SaveCurrRecipe();
              //  MessageBox.Show($"Recipe Name: {currRecipe.GetRecpName()}\nCategory: {currRecipe.GetFoodCategory()}" +
               //     $"\nDescription: {currRecipe.GetDescription()}\nTotal Ingredients: {currRecipe.CurrentNumOfIngredients()}", "Recipe Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a category for the recipe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveCurrRecipe()
        {


            string description = txtDescriptionRecipe.Text;

            if (currRecipe.CurrentNumOfIngredients() <= 0)
            {
                MessageBox.Show("No ingredients specified for the current recipe.", "Error");
            }
            else
            {
                // Set the description for the current recipe
                currRecipe.SetDescription(description);

                // Add the current recipe to mngrRecipe
                rcpeMngr.Add(currRecipe);
                lstRecipes.Items.Add(currRecipe.ToString());

                // Optionally, you can clear currRecipe here if needed
                // currRecipe.DefaultValues();
                ResetFormFields();
            }
            
        }
        private void ResetFormFields()
        {
            txtNameOfRecipe.Text = ""; // Clear recipe name field
            cmbCategeory.SelectedIndex = -1;// Clear category selection
            txtDescriptionRecipe.Text = "";
            btnAddRecipe.Enabled = true;
            
        }
        private void lstRecipes_DoubleClick(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem != null)
            {
                // Get the selected recipe string from the list box
                string selectedRecipeString = lstRecipes.SelectedItem.ToString();
                string recpName = selectedRecipeString.Substring(0, 10);

                // Find the corresponding Recipe object in the rcpeMngr
                Recipe selectedRecipe = FindRecipeByName(recpName.Trim());

                // Check if the Recipe object is found
                if (selectedRecipe != null)
                {
                    // Construct the message to display
                    StringBuilder messageBuilder = new StringBuilder();
                    messageBuilder.AppendLine($"Recipe: {selectedRecipe.GetRecpName()}");
                   
                    messageBuilder.AppendLine($"Ingredients: {selectedRecipe.CurrentNumOfIngredients()}");
                    foreach (string ingredient in selectedRecipe.GetIngredients())
                    {
                        messageBuilder.AppendLine($"- {ingredient}");
                    }
                    messageBuilder.AppendLine($"Category: {selectedRecipe.GetFoodCategory()}");
                    messageBuilder.AppendLine($"Description> {selectedRecipe.GetDescription()}");
                   

                    // Append each ingredient to the message
                    

                    // Append description if available
                    

                    // Display the message box with recipe information
                    MessageBox.Show(messageBuilder.ToString(), $"Cooking instruction for : {selectedRecipe.GetRecpName()}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private Recipe FindRecipeByName(string recipeName)
        {

            string newS;
           // Iterate through the recipeList in rcpeMngr to find the Recipe object with the given name
            foreach (Recipe recipe in rcpeMngr.recipeList)
            {
               newS= recipe.GetRecpName();
                if ((recipe != null) && (newS == recipeName))
                {
                    return recipe; // Return the found Recipe object
                }
            }
            return null; // Recipe not found   
        }

        private void btnEditbegin_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem != null)
            {
                // Find the selected recipe in the RecipeManager1 instance
                string selectedRecipeName = lstRecipes.SelectedItem.ToString().Substring(0, 10).Trim();
                selectedRecipe = rcpeMngr.FindRecipeByName(selectedRecipeName);

                if (selectedRecipe != null)
                {
                    // Enable editing controls and populate them with the selected recipe's information
                    txtNameOfRecipe.Text = selectedRecipe.GetRecpName();
                    cmbCategeory.SelectedItem = selectedRecipe.GetFoodCategory().ToString();
                    txtDescriptionRecipe.Text = selectedRecipe.GetDescription();

                    // Clear the ingredients listbox
                  
                    // Enable editing controls
                    txtNameOfRecipe.Enabled = true;
                    cmbCategeory.Enabled = true;
                    txtDescriptionRecipe.Text = "";
                    fillIngredients(selectedRecipe);

                    txtDescriptionRecipe.Enabled = true;
                   // lstOfIngridients.Enabled = true;

                    // Disable "Add Ingredients" button as we are editing existing ingredients
                    btnAddIngerdients.Enabled = false;
                    btnAddRecipe.Enabled = false;
                    
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            if (selectedRecipe != null)
            {
                selectedRecipe.SetRecpName(txtNameOfRecipe.Text);
                selectedRecipe.SetCategory((FoodCategory)Enum.Parse(typeof(FoodCategory), cmbCategeory.SelectedItem.ToString()));
                selectedRecipe.SetDescription(txtDescriptionRecipe.Text);
                rcpeMngr.ChangeElement(lstRecipes.SelectedIndex, selectedRecipe);

                // Update the listbox item with the edited recipe
                lstRecipes.Items[lstRecipes.SelectedIndex] = selectedRecipe.ToString();

                // Reset the selectedRecipe field and clear the form controls
                selectedRecipe = null;
                ResetFormFields();
                btnAddIngerdients.Enabled = true;

            }
            else
            {
                MessageBox.Show("No recipe is selected for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void fillIngredients(Recipe currRecipe)
        {

            FormIngredients dlg = new FormIngredients(currRecipe);
            DialogResult dialogResult = dlg.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (currRecipe.CurrentNumOfIngredients() <= 0)
                {
                    MessageBox.Show("No ingredients specified.", "Error");
                }

                int numberOfIngredients = dlg.UpdateIngredientsCount();

            }

        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem != null)
            {
                // Get the selected recipe string from the list box
                string selectedRecipeString = lstRecipes.SelectedItem.ToString();
                string recpName = selectedRecipeString.Substring(0, 50).Trim();

                // Find the corresponding Recipe object in the rcpeMngr
                Recipe selectedRecipe = FindRecipeByName(recpName);

                // Check if the Recipe object is found
                if (selectedRecipe != null)
                {
                    // Clear the ingredients of the selected recipe
                    selectedRecipe.SetIngredients(new string[0]);

                    // Remove the selected recipe from the list
                    lstRecipes.Items.RemoveAt(lstRecipes.SelectedIndex);
                }
            }
            btnAddRecipe.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem != null)
            {
                // Get the selected recipe string from the list box
                string selectedRecipeString = lstRecipes.SelectedItem.ToString();
                string recpName = selectedRecipeString.Substring(0, 50).Trim();

                // Find the corresponding Recipe object in the rcpeMngr
                Recipe selectedRecipe = FindRecipeByName(recpName);

                // Check if the Recipe object is found
                if (selectedRecipe != null)
                {
                    // Find the index of the selected recipe in the recipeList
                    int index = Array.IndexOf(rcpeMngr.recipeList, selectedRecipe);

                    // Delete the selected recipe from the rcpeMngr
                    rcpeMngr.DeleteElement(index);

                    // Remove the selected recipe from the list
                    lstRecipes.Items.RemoveAt(lstRecipes.SelectedIndex);
                }
            }

        }
    }

}