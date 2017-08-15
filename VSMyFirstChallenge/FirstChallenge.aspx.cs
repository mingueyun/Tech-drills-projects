using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallange
{
    public partial class FirstChallange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string age = ageTextBox.Text;
            string money = moneyTextBox.Text;

            string result = "At " + age + " " + "years old, you only have" +
                money + " in your in your pocket.";

            outPutLabel.Text = result;
        }
    }
}