using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WbA2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
       
        /*
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LF3C6PJ;Initial Catalog=WebApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert";
            cmd.Parameters.Add("@id_carte", SqlDbType.Char).Value = txtIdCarte.Text;
            cmd.Parameters.Add("@titlu", SqlDbType.VarChar).Value = txtTitlu.Text;
            cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = txtAutor.Text;
            cmd.Parameters.Add("@pret", SqlDbType.Double).Value = txtPret.Text;
            cmd.ExecuteNonQuery();
            Response.Write("Inserted");

            con.Close();

        }
        */
        /*
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LF3C6PJ;Initial Catalog=WebApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Delete";
            cmd.Parameters.Add("@id_carte", SqlDbType.Int).Value = txtIdCarte.Text;
            cmd.ExecuteNonQuery();
            Response.Write("Deleted");
            con.Close();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-63BDLF8;Initial Catalog=WebApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Update";
            cmd.Parameters.Add("@id_carte", SqlDbType.Int).Value = txtIdCarte.Text;
            cmd.Parameters.Add("@titlu", SqlDbType.VarChar).Value = txtTitlu.Text;
            cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = txtAutor.Text;
            cmd.Parameters.Add("@pret", SqlDbType.VarChar).Value = txtPret.Text;
            cmd.ExecuteNonQuery();
            Response.Write("Updated");
            con.Close();

        }
        */
    }
}
            
    


