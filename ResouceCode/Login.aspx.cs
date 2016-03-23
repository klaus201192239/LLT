using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){}
    protected void btnlog_Click(object sender, EventArgs e)
    {
        if (tname.Text == string.Empty||tpass.Text == string.Empty)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            String username = this.tname.Text.ToString();
            String psw = this.tpass.Text.ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            con.Open();
            string selectstring = "select * from users where user_name='" + username + "' and user_key='" + psw + "'";
            SqlCommand cmd = new SqlCommand(selectstring, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("Gift.aspx");
            }
            else {
                Response.Redirect("Login.aspx");
            }
        }
    }
}
