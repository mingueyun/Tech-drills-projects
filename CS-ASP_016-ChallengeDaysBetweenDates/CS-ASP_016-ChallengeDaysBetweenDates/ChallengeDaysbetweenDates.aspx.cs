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
            
            foreach (DateTime day in Calendar1.SelectedDates)
            {
                Label1.Text = day.Date.ToShortDateString();
            }

            foreach (DateTime day in Calendar2.SelectedDates)
            {
                Label1.Text = day.Date.ToShortDateString();
            }


        } 

        protected void Button1_Click(object sender, EventArgs e)

        {
             Label1.Text = "";

            

            if (Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                Label1.Text = Label1.Text = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate).TotalDays.ToString();
            }
            else if (Calendar1.SelectedDate < Calendar2.SelectedDate)
            {
                Label1.Text = Label1.Text = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays.ToString();
            }
            else
            {

            }
                

        }
    }   
}