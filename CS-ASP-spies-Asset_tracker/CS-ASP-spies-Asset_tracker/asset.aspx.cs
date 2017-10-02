using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_spies_Asset_tracker
{
    public partial class asset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                double[] rigged = new double[0];
                ViewState.Add("Rigged", rigged);
                double[] subterfuge = new double[0];
                ViewState.Add("Subterfuge", subterfuge);
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {

            double[] rigged = (double[])ViewState["Rigged"];
            Array.Resize(ref rigged, rigged.Length + 1);
            int newRig = rigged.GetUpperBound(0);
            rigged[newRig] = double.Parse(TextBox2.Text);
            ViewState["Rigged"] = rigged;

            double[] subterfuge = (double[])ViewState["Subterfuge"];
            Array.Resize(ref subterfuge, subterfuge.Length + 1);
            int newSubterfuge = subterfuge.GetUpperBound(0);
            subterfuge[newSubterfuge] = double.Parse(TextBox3.Text);
            ViewState["Subterfuge"] = subterfuge;



            string Value = TextBox1.Text;


            Label.Text = String.Format("Total elections Rigged: {1} <br /> Average Acts of Subterfuge per Assett:{0:N2}<br /> last asset name: {2}",
                subterfuge.Average(),
                rigged.Sum(),
                Value);

        }
    }
}