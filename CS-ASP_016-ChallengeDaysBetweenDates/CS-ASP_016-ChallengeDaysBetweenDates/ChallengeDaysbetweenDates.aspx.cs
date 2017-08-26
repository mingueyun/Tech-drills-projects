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
            if (Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                Label1.Text = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate).TotalDays.ToString();
            }

            else
            {
                Label1.Text = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays.ToString();
            }

            /*

                                    DateTime firstDate = Calendar1.SelectedDate;
                                    DateTime secondDate = Calendar2.SelectedDate;

                                    TimeSpan differenceInDays;

                                    if (firstDate > secondDate)
                                        differenceInDays = (firstDate - secondDate);
                                    else
                                        differenceInDays = (secondDate - firstDate);

                                    int did = differenceInDays.Days;
                                    Label1.Text = did.ToString();
            */



        }
    }
}