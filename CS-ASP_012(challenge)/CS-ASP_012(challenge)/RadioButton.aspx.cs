using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_012_challenge_
{
    public partial class RadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            label.Text = "";

            if (Pencil.Checked)
            {
                ImageButton.ImageUrl = "Resources/pencil.png";
                label.Text = "You Selected Pencil";
            }
            else if(Pen.Checked)
            {
                ImageButton.ImageUrl = "Resources/pen.png";
                label.Text = "You Selected Pen";
            }
            else if(Phone.Checked)
            {
                ImageButton.ImageUrl = "Resources/phone.png";
                label.Text = "You Selected Phone";
            }
           else if (Tablet.Checked)
            {
                ImageButton.ImageUrl = "Resources/tablet.png";
                label.Text = "You Selected Tablet";
            }
            else
            {
                label.Text = "Please Select an option";
            }
        }
    }
}