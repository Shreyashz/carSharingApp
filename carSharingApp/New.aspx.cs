using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace carSharingApp
{
    public partial class New : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cs1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["userName"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Carpool values(@vehilc,@from,@to,@by,@cap, @with, @jorDate)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Vehilc", VehicleNameTextBox.Text);
            cmd.Parameters.AddWithValue("@from", FromTextBox.Text);
            cmd.Parameters.AddWithValue("@to", ToTextBox.Text);
            cmd.Parameters.AddWithValue("@by", Session["userName"]);
            cmd.Parameters.AddWithValue("@with", "None");
            cmd.Parameters.AddWithValue("@cap", MaxTextBox.Text);
            cmd.Parameters.AddWithValue("@jorDate", JourDate.SelectedDate);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('Vehicle added Successfully ') </script>");


            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('Vehicle Adding Failed ') </script>");
            }

            con.Close();


        }
        protected void Home_Leave(object sender, EventArgs e)
        {
            if(Session["userName"] != null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void User_Leave(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                Response.Redirect("User.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void DateCustVal_Validate(object source, ServerValidateEventArgs args)
        {
            if (JourDate.SelectedDate == null
                || JourDate.SelectedDate == new DateTime(0001, 1, 1, 0, 0, 0))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}