using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace carSharingApp
{
    public partial class Registration : System.Web.UI.Page
    {

        string cs = ConfigurationManager.ConnectionStrings["cs1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                Response.Redirect("User.aspx");
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Users where uName=@uname";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uname", UserNameTextBox.Text);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('You have already Registred') </script>");
            }
            else
            {
                SqlConnection con1 = new SqlConnection(cs);
                string query1 = "insert into Users values(@fname,@lname,@gender,@uname,@password)";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                cmd1.Parameters.AddWithValue("@uname", UserNameTextBox.Text);
                cmd1.Parameters.AddWithValue("@fname", FirstNameTextBox.Text);
                cmd1.Parameters.AddWithValue("@lname", LastNameTextBox.Text);
                cmd1.Parameters.AddWithValue("@gender", DropDownList1.SelectedItem.Value);
                cmd1.Parameters.AddWithValue("@password", PassWordTextBox.Text);
                con1.Open();
                int a = cmd1.ExecuteNonQuery();
                con1.Close();
                if (a > 0)
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('SignUp Successfully ') </script>");


                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('SignUp Failed ') </script>");
                }

                con.Close();

            }



        }
    }
}