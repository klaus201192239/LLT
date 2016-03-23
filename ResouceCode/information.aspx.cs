using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.IO;
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

public partial class information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btncal(object sender, EventArgs e)
    {
        //String userName = this.tname.Text.ToString();
        //String Sex = this.tsex.Text.ToString();
        //String Age = this.tage.Text.ToString();
        //String Emai = this.tmail.Text.ToString();
        //String Phone = this.tphone.Text.ToString();
        String fullname = this.FileUpload.PostedFile.FileName;//获取上传图片的完整路径
        FileInfo fl = new FileInfo(fullname);//创建FileInfo类的实例
        String name = fl.Name;//获取文件名
        String type = fl.Extension;//获取扩展名
        String savepath = Server.MapPath("images");
        this.FileUpload.PostedFile.SaveAs(savepath + "\\" + name);
        this.Image.Visible = true;
        this.Image.ImageUrl = "images" + "/" + name;
        //然后操作数据库，将username,Sex,Age,Emai,Ph,和ImageUrl 存入数据库
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        con.Open();
        string select = "select user_name from users where user_name=@user_name";
        SqlCommand selcmd = new SqlCommand(select, con);
        selcmd.Parameters.Add("@user_name", SqlDbType.VarChar);
        selcmd.Parameters["@user_name"].Value = this.tname.Text.ToString();
        SqlDataReader dr = selcmd.ExecuteReader();
        if (dr.Read())
        {
            Response.Write("<script>alert('用户存在！')</script>");
            return;
        }
        dr.Close();
        string cmdtext = "insert into users(user_id,user_name, user_key, user_sex, user_age, user_mail, user_img) values(@phone,@name,@phone,@sex,@age,@mail,@img)";
        SqlCommand cmd = new SqlCommand(cmdtext, con);
        //cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50);
        //cmd.Parameters["@phone"].Value = this.tphone.Text.ToString();
        cmd.Parameters.Add("@name", SqlDbType.VarChar,50);
        cmd.Parameters["@name"].Value = this.tname.Text.ToString();
        cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50);
        cmd.Parameters["@phone"].Value = this.tphone.Text.ToString();
        cmd.Parameters.Add("@sex", SqlDbType.VarChar, 50);
        cmd.Parameters["@sex"].Value = this.tsex.Text.ToString();
        cmd.Parameters.Add("@age", SqlDbType.VarChar,50);
        cmd.Parameters["@age"].Value = this.tage.Text.ToString();
        cmd.Parameters.Add("@mail", SqlDbType.VarChar, 50);
        cmd.Parameters["@mail"].Value = this.tmail.Text.ToString();
        cmd.Parameters.Add("@img", SqlDbType.VarChar,50);
        cmd.Parameters["@img"].Value = "images" + "/" + name;
        cmd.ExecuteNonQuery();
        con.Close();
    }
    protected void finish(object sender, EventArgs e)
    {
        Response.Redirect("Add.aspx?user_id="+this.tphone.Text.ToString());
    }
}