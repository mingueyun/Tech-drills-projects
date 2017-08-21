using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class SimpleCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string One = firstTextBox.Text;
            string Two = secondTextBox.Text;

            totalLabel.Text = (Convert.ToDouble(firstTextBox.Text) + Convert.ToDouble(secondTextBox.Text)).ToString();

//          this code had issues with not passing runtime which I could not do fractions
//          string One = firstTextBox.Text;
//          string Two = secondTextBox.Text;
//          int valueOne = int.Parse(One);
//          int valueTwo = int.Parse(Two);
//          totalLabel.Text = (Convert.ToDouble(valueOne) + (valueTwo)).ToString();

//          example of an if statement for an operand that returns true  and exception but i am not sure what differnce this made but it still
//          works. 
//          if (!string.IsNullOrEmpty(firstTextBox.Text) && !string.IsNullOrEmpty(secondTextBox.Text))
//          totalLabel.Text = (Convert.ToDouble(firstTextBox.Text) - Convert.ToDouble(secondTextBox.Text)).ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            string One = firstTextBox.Text;
            string Two = secondTextBox.Text;

            totalLabel.Text = (Convert.ToDouble(firstTextBox.Text) - Convert.ToDouble(secondTextBox.Text)).ToString();

        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            string One = firstTextBox.Text;
            string Two = secondTextBox.Text;

            totalLabel.Text = (Convert.ToDouble(firstTextBox.Text) * Convert.ToDouble(secondTextBox.Text)).ToString();

        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            string One = firstTextBox.Text;
            string Two = secondTextBox.Text;

            totalLabel.Text = (Convert.ToDouble(firstTextBox.Text) / Convert.ToDouble(secondTextBox.Text)).ToString();

        }
    }
}