using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_Spies_Challenge
{
    public partial class spies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now.Date;
                Calendar2.SelectedDate = DateTime.Today.Date.AddDays(+14);
                Calendar3.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Label.Text = "";
            
            double timeOff = (Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).Days);
            DateTime work = Calendar1.SelectedDate.AddDays(14);

            if (timeOff < 14)
            {
                Label.Text = "Error: Must allow at least two weeks between previous asignments and new assignment and the earliest date is " + work;
                Calendar2.SelectedDate = Calendar1.SelectedDate.AddDays(14);
                Calendar3.SelectedDate = Calendar1.SelectedDate.AddDays(21);
            }

            else
            {
                TimeSpan returnHome = Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate);
                double jobDuration = (returnHome.TotalDays);
                double Budget = jobDuration * 500;
                if (jobDuration > 21)
                {

                    Label.Text = "Assignment of " + TextBox1.Text + " " + "to assignment Project: " + TextBox2.Text + " " + "is authorized. Budget total: $" + (Budget + 1000);
                }
                else if (jobDuration < 1)
                {
                    Label.Text = "Error. Please review the job duration! " + "Chosen duration is" +  " " + returnHome.TotalDays + " days at the moment!";
                }
                
                else
                {
                    Label.Text = "Assignment of " + TextBox1.Text + " " + "to assignment Project: " + TextBox2.Text + " " + "is authorized. Budget total: $" + Budget;
                }
                
                
                    
                
            }

        }
    }
}