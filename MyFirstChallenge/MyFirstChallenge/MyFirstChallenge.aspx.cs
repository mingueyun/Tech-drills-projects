using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class MyFirstChallenge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void moneyButton_Click(object sender, EventArgs e)
        {
            string age = ageTextBox.Text;
            string pocket = pocketTextBox.Text;

            string result = "You are " + age + " " + "years old and have " + pocket +
                " " + "dollars in your possesion! get a job!";

            resultLabel.Text = result;
        }
    }
}