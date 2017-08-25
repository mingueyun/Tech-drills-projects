using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_016_ChallengeDaysBetweenDates
{
    public partial class ChallengeDaysbetweenDates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
/*          
          I used this code first to get it working and it did, and I figured out the negative days

            DateTime firstDate = Calendar1.SelectedDate;
            DateTime secondDate = Calendar2.SelectedDate;

            TimeSpan did = secondDate - firstDate;
            int differenceIndays = did.Days;
            
            Label1.Text = differenceIndays.ToString();
*/

            DateTime firstDate = Calendar1.SelectedDate;
            DateTime secondDate = Calendar2.SelectedDate;

            TimeSpan differenceInDays;

            int did;

            if (firstDate > secondDate)
                differenceInDays = (firstDate - secondDate);
            else
                differenceInDays = (secondDate - firstDate);

            did = differenceInDays.Days;
            Label1.Text = did.ToString();

        }
    }
}