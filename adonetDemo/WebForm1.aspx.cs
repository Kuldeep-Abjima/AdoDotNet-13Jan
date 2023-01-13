using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace adonetDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {

            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            //SqlConnection con = new SqlConnection(CS);
            //try
            //{
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from SuperHeros";
            //cmd.CommandText = "select Count(id) from SuperHeros";
            //cmd.CommandText = "insert into SuperHeros values ('Hulk', 'Anger', 'Hulk-smash', 2, 'Human')";
            //cmd.CommandText = "update SuperHeros set origin = 'Humans' where SuperHeroId = 6";


            //cmd.Connection = con;
            //con.Open();
            //var UpdatedRows = cmd.ExecuteNonQuery();
            //Response.Write("Total Updated Rows -: " + UpdatedRows);

            //var AffectedRows = cmd.ExecuteNonQuery();
            //Response.Write("total affected rows = " + AffectedRows);

            //var result = cmd.ExecuteScalar();
            //Response.Write("Totol superheros ids are =" + result.ToString());
            //GridView1.DataSource = cmd.ExecuteReader();
            //GridView1.DataBind();





            //}
            //catch 
            //{

            //}
            //finally
            //{
            //    con.Close();
            //}

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            try
            {
                string Command = "select * from SuperHeros where SName like '" + TextBox1.Text + "%'";
                SqlCommand cmd = new SqlCommand(Command, con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}