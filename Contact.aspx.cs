using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApp3
{
    public partial class Contact : System.Web.UI.Page
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(local)\sqlexpress;Initial Catalog=ASPWP;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            lblResponse.ForeColor = System.Drawing.Color.DarkGray;
            lblResponse.Font.Bold = false;
            lblResponse.Text = "Please wait...";
            //txtName.Text = "";
            //txtMobile.Text = "";
            //txtAddress.Text = "";


            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            string sqlcmd1 = "SELECT * FROM Contact WHERE ContactID = " + txtContactID.Text;

            SqlCommand sqlCmd = new SqlCommand(sqlcmd1, sqlCon);

            sqlCmd.ExecuteNonQuery();

            SqlDataReader reader = sqlCmd.ExecuteReader();

            reader.Read();


            if (reader.HasRows)
            {
                txtName.Text = reader["Name"].ToString();
                txtMobile.Text = reader["Mobile"].ToString();
                txtAddress.Text = reader["Address"].ToString();

                lblResponse.ForeColor = System.Drawing.Color.Green;
                lblResponse.Font.Bold = true;
                lblResponse.Text = "Record Exists";
            }
            else
            {
                txtName.Text = "";
                txtMobile.Text = "";
                txtAddress.Text = "";
                lblResponse.ForeColor = System.Drawing.Color.Red;
                lblResponse.Font.Bold = true;
                lblResponse.Text = "Record Not Found: Does Not Exist";
            }


            reader.Close();
            reader.Dispose();


            sqlCon.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblResponse.ForeColor = System.Drawing.Color.DarkGray;
            lblResponse.Font.Bold = false;
            lblResponse.Text = "Please wait...";
           

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            string sqlCmd1 = "SELECT * FROM Contact WHERE ContactID = " + txtContactID.Text;

            SqlCommand sqlCmd = new SqlCommand(sqlCmd1, sqlCon);

            sqlCmd.ExecuteNonQuery();

            SqlDataReader reader = sqlCmd.ExecuteReader();

            reader.Read();

            bool hasData = reader.HasRows;
            reader.Close();
            reader.Dispose();

            if (hasData)
            {

                SqlCommand sqlCmd2 = new SqlCommand("UPDATE Contact SET Name='" + txtName.Text + "', Mobile='" + txtMobile.Text + "', Address='" + txtAddress.Text + "' WHERE ContactID=" + txtContactID.Text, sqlCon);

                sqlCmd2.ExecuteNonQuery();

                lblResponse.ForeColor = System.Drawing.Color.Green;
                lblResponse.Font.Bold = true;
                lblResponse.Text = "Record Updated";
            }
            else
            {

                SqlCommand sqlCmd3 = new SqlCommand("INSERT INTO Contact (ContactID, Name, Mobile, Address) VALUES('" + txtContactID.Text + "'," + "'" + txtName.Text + "','" + txtMobile.Text + "','" + txtAddress.Text + "')", sqlCon);

                sqlCmd3.ExecuteNonQuery();

                lblResponse.ForeColor = System.Drawing.Color.Green;
                lblResponse.Font.Bold = true;
                lblResponse.Text = "New Record Added";
            }


            sqlCon.Close();



        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            lblResponse.ForeColor = System.Drawing.Color.DarkGray;
            lblResponse.Font.Bold = false;
            lblResponse.Text = "Please wait...";
           

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            string sqlCmd1 = "SELECT * FROM Contact WHERE ContactID = " + txtContactID.Text;

            SqlCommand sqlCmd = new SqlCommand(sqlCmd1, sqlCon);

            sqlCmd.ExecuteNonQuery();

            SqlDataReader reader = sqlCmd.ExecuteReader();

            reader.Read();

            bool hasData = reader.HasRows;
            reader.Close();
            reader.Dispose();

            if (hasData)
            {
                SqlCommand sqlCmd2 = new SqlCommand("DELETE FROM Contact WHERE ContactID='" + txtContactID.Text + "'", sqlCon);

                sqlCmd2.ExecuteNonQuery();

                lblResponse.ForeColor = System.Drawing.Color.Green;
                lblResponse.Font.Bold = true;
                lblResponse.Text = "Record Deleted";
            }
            else
            {
                lblResponse.ForeColor = System.Drawing.Color.Red;
                lblResponse.Font.Bold = true;
                lblResponse.Text = "Record Not Found: Does Not Exist";
            }
            sqlCon.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            txtContactID.Text = "";
            txtName.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";
            lblResponse.Text = "";

        }
    }
}

