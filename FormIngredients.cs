using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManager
{
    public partial class FormIngredients : Form
    {
        private MainForm form1;
        private Recipe recipe;

        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();
            InitializeGUI();
            this.recipe = recipe; // Set the recipe field with the provided Recipe object
            this.Text = $"{recipe.GetRecpName()} -- Add Ingredients"; // Set the title of the form


        }
        private void InitializeGUI()
        {
            // Initialize GUI components
           

            // Other GUI initialization as required

        }

        private void btnAddIngridient_Click(object sender, EventArgs e)
        {
            string ingredient = txtIngridient.Text.Trim();

            // Check if the textbox is not empty
            if (!string.IsNullOrEmpty(ingredient))
            {
                // Add the ingredient to the lstOfIngredients listbox
                lstOfIngridients.Items.Add(ingredient);

                // Clear the textbox for the next input
                txtIngridient.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an ingredient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           if(lstOfIngridients.SelectedIndex!=-1)
            {
                lstOfIngridients.Items.RemoveAt(lstOfIngridients.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an ingredient to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditIngridient_Click(object sender, EventArgs e)
        {
            int selectedItem = lstOfIngridients.SelectedIndex;
            if (selectedItem >= 0)
            {
                if (!string.IsNullOrEmpty(txtIngridient.Text))
                {
                    lstOfIngridients.Items.RemoveAt(lstOfIngridients.SelectedIndex);
                    lstOfIngridients.Items.Insert(selectedItem, txtIngridient.Text);
                }
                else
                {
                    MessageBox.Show("Please enter a new Ingredient.");
                }
            }
            else
            {
                MessageBox.Show("Please select an ingredient to change.");
            }
            txtIngridient.Text = "";
        }

        private void btnOKIngridient_Click(object sender, EventArgs e)
        {
            // Get the number of ingredients entered by the user
            int numOfIngredients = lstOfIngridients.Items.Count;

            // Check if there are any ingredients entered
            if (numOfIngredients == 0)
            {
                MessageBox.Show("Please enter at least one ingredient.", "Error");
                return;
            }

            // Check if the number of ingredients entered exceeds the maximum allowed
            if (numOfIngredients > recipe.GetMaxNumOfIngredients())
            {
                MessageBox.Show($"You can only add up to {recipe.GetMaxNumOfIngredients()} ingredients.", "Error");
                return;
            }

            // Create an array to store the entered ingredients
            string[] enteredIngredients = new string[numOfIngredients];

            // Populate the array with the ingredients from the ListBox
            for (int i = 0; i < numOfIngredients; i++)
            {
                enteredIngredients[i] = lstOfIngridients.Items[i].ToString();
            }

            // Update the ingredients array of the recipe object with the entered ingredients
            recipe.SetIngredients(enteredIngredients);

            // Close the form and return DialogResult.OK to indicate that the operation was successful
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelIngridients_Click(object sender, EventArgs e)
        {
            // Clear the items in the ListBox
            lstOfIngridients.Items.Clear();

            // Update the label to display the number of ingredients
            lblDisplayNumberOfingredients.Text ="";
        }
        public void ClearIngredientsList()
        {
            lstOfIngridients.Items.Clear();
        }
        public int UpdateIngredientsCount()
        {
            // Return the number of items in lstOfIngridients
            return lstOfIngridients.Items.Count;
        }

    }
}
