using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WbA2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-63BDLF8;Initial Catalog=Denis;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertCarte";
            cmd.Parameters.Add("@id_carte", SqlDbType.Int).Value = TextIdCarte.Text;
            cmd.Parameters.Add("@titlu", SqlDbType.VarChar).Value = TextTitlu.Text;
            cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = TextAutor.Text;
            cmd.Parameters.Add("@pret", SqlDbType.Int).Value = TextPret.Text;

            cmd.ExecuteNonQuery();
            Response.Write("Inserted :)");

            con.Close();
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-63BDLF8;Initial Catalog=Denis;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateCarte";
            cmd.Parameters.Add("@id_carte", SqlDbType.Int).Value = TextIdCarte.Text;
            cmd.Parameters.Add("@titlu", SqlDbType.VarChar).Value = TextTitlu.Text;
            cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = TextAutor.Text;
            cmd.Parameters.Add("@pret", SqlDbType.Int).Value = TextPret.Text;

            cmd.ExecuteNonQuery();
            Response.Write("Updated :)");

            con.Close();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-63BDLF8;Initial Catalog=Denis;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "StergeCarte";
            cmd.Parameters.Add("@id_carte", SqlDbType.Int).Value = TextIdCarte.Text;
            cmd.Parameters.Add("@titlu", SqlDbType.VarChar).Value = TextTitlu.Text;
            cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = TextAutor.Text;
            cmd.Parameters.Add("@pret", SqlDbType.Int).Value = TextPret.Text;

            cmd.ExecuteNonQuery();
            Response.Write("Deleted :)");

            con.Close();
        }
    }
}