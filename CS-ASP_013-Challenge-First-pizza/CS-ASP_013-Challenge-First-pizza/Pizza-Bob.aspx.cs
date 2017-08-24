using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_013_Challenge_First_pizza
{
    public partial class Pizza_Bob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            totalLabel.Text = "Total: $0.00";
        }

        protected void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            totalLabel.Text = "";

            Double total;


            if (BabySize.Checked)
                total = 10.0;

            else if (MamaSize.Checked)
                total = 13.0;

            else if (PapaSize.Checked)
                total = 16.0;
            else
                total = 00.00;


            if (DeepDish.Checked) total += 2.0;

            if (Anchovies.Checked) total += 2.0;
            
            if (Pepperoni.Checked) total += 1.50;

            if (Onions.Checked) total += .75;
            
            if (GreenPeppers.Checked) total += .50;
            
            if (RedPeppers.Checked) total += .75;
            
            


/*            Ternary operators

                       total = (Pepperoni.Checked) ? total + 1.50 : total;
                       total = (Onions.Checked) ? total + .75 : total;
                       total = (GreenPeppers.Checked) ? total + .50 : total;
                       total = (RedPeppers.Checked) ? total + .75 : total;
                       total = (Anchovies.Checked) ? total + 2.0 : total;
*/
          


            if (Pepperoni.Checked && GreenPeppers.Checked && Anchovies.Checked || Pepperoni.Checked && Onions.Checked && RedPeppers.Checked)
            {
                total -= 2.0;
            }
          

            totalLabel.Text = "Total: $ " + total.ToString();            

        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void specialText_TextChanged(object sender, EventArgs e)
        {


        }
    }
}