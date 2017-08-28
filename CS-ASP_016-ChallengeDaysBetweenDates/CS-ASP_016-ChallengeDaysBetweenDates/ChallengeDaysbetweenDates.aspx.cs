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
            Label1.Text = "";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
     

        }

        protected void Button1_Click(object sender, EventArgs e)

        {

            {
                TimeSpan did;
                if (Calendar1.SelectedDate.Date != DateTime.MinValue.Date)
                    if (Calendar2.SelectedDate.Date != DateTime.MinValue.Date)
                    {
                        DateTime Date1 = Calendar1.SelectedDate;
                        DateTime Date2 = Calendar2.SelectedDate;
                        if (Date2 < Date1)
                        {
                            did = Date1.Subtract(Date2);
                        }
                        else
                        {
                            did = Date2.Subtract(Date1);
                        }
                        Label1.Text = did.Days.ToString();
                    }
                    else
                    {
                        Label1.Text = Calendar1.SelectedDate.ToShortDateString();
                       
                    }
                else
                {
                    Label1.Text = Calendar2.SelectedDate.ToShortDateString();
                   
                }
            }

        }
    }
       
}