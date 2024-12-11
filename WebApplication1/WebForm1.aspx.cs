using System;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.DropDownList DropDownList1;


        // This method is triggered every time the page is loaded in the browser
        protected void Page_Load(object sender, EventArgs e)
        {
            // Checks if the page is being loaded for the first time
            if (!IsPostBack)
            {
                Response.Write("<h1>WELCOME TO PIZZERIA BELLISSIMA! 🍕 🍕 🍕</h1>");
                Response.Write("<h2>Which delicious pizza are you going to eat today?</h2>");
            }
            // Checks if the page is being reloaded due to a user action
            else if (IsPostBack)
            {

                Response.Write("<br><br><h1>If you want some extra really fresh toppings added, don't hold back!</h1>");
            }
        }


        // Executes whenever the selection in the dropdown changes
        // Calls the UpdateTotalPrice method
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }


        // Responds to changes in the toppings selection (checkbox list)
        // Calls the UpdateTotalPrice method
        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }


        // Combines the base price of the selected pizza with the prices of selected toppings
        private void UpdateTotalPrice()
        {
            double pizzaPrice = 0;
            double toppingsPrice = 0;

            // Making sure a valid pizza is selected
            if (DropDownList1.SelectedValue != "0") 
            {
                // If a valid pizza is selected, its price 
                // is converted to a double and assigned to pizzaPrice
                pizzaPrice = Convert.ToDouble(DropDownList1.SelectedValue);
            }


            // Calculate toppings price
            // Loops through all the items in the toppings checkbox list 
            foreach (ListItem item in CheckBoxList1.Items)
            {
                // if a topping is selected (item.Selected is true), 
                // its price is converted to a double and added to toppingsPrice
                if (item.Selected)
                {
                    toppingsPrice += Convert.ToDouble(item.Value);
                }
            }


            // Calculate total price
            double totalPrice = pizzaPrice + toppingsPrice;


            // Display total price
            lblTotalPrice.Text = $"Total Price: ${totalPrice:F2}";
        }


        // Validates the coupon code entered by the user. If valid, calculates and applies a discount.
        // Updates the result label with either the discounted price or an error message.
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve the entered coupon code
            string enteredCoupon = txtCoupon.Text.Trim();

            // Valid coupon code
            string validCoupon = "SAVE20";

            // Making sure a valid pizza is selected
            if (DropDownList1.SelectedValue != "0")
            {
                // Get the price of the selected pizza
                double originalPrice = Convert.ToDouble(DropDownList1.SelectedValue);

                // Check if the entered coupon is valid
                if (string.Equals(enteredCoupon, validCoupon, StringComparison.OrdinalIgnoreCase))
                {
                    // Calculate the discount and final price
                    double discount = originalPrice * 0.20; // 20% discount
                    double finalPrice = originalPrice - discount;

                    // Display success message with the discounted price
                    lblResult.Text = $"\nCoupon applied! You received a 20% discount. Your final price is: ${finalPrice:F2}.";
                    lblResult.ForeColor = System.Drawing.Color.Green; // Set text color to green
                }
                else
                {
                    // Display invalid coupon message
                    lblResult.Text = "\nInvalid coupon code. Please try again.";
                    lblResult.ForeColor = System.Drawing.Color.Red; // Set text color to red
                }
            }
            else
            {
                // No pizza selected, ask the user to choose a pizza
                lblResult.Text = "Please select a pizza before applying a coupon.";
                lblResult.ForeColor = System.Drawing.Color.Orange; // Set text color to orange for warning
            }
        }

    }
}