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
using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
public partial class Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            this.m1.Text = null;
            this.m2.Text = null;
            this.m3.Text = null;
            this.m4.Text = null;
            this.m5.Text = null;
            this.m6.Text = null;
            this.m7.Text = null;
            this.m8.Text = null;
        }
       // String str=Request["ID"].ToString();
       // this.username.Text = str;
    }
    protected void next2(object sender, EventArgs e)
    {
        this.l2.Visible=true;
        this.b2.Visible=true;
        this.c2.Visible=true;
        this.FileUpload2.Visible=true;
        this.Button2.Visible=true;
        this.Image2.Visible=true;
        this.n2.Visible=true;
        this.f2.Visible=true;
        this.rp2.Visible=false;
        this.rp1.Visible=false;
    }
    protected void next3(object sender, EventArgs e)
    {
        this.l3.Visible = true;
        this.b3.Visible = true;
        this.c3.Visible = true;
        this.FileUpload3.Visible = true;
        this.Button3.Visible = true;
        this.Image3.Visible = true;
        this.n3.Visible = true;
        this.f3.Visible = true;
        this.rp3.Visible = false;
        this.rp4.Visible = false;
    }
    protected void next4(object sender, EventArgs e)
    {
        this.l4.Visible = true;
        this.b4.Visible = true;
        this.c4.Visible = true;
        this.FileUpload4.Visible = true;
        this.Button4.Visible = true;
        this.Image4.Visible = true;
        this.n4.Visible = true;
        this.f4.Visible = true;
        this.rp5.Visible = false;
        this.rp6.Visible = false;
    }
    protected void next5(object sender, EventArgs e)
    {
        this.l5.Visible = true;
        this.b5.Visible = true;
        this.c5.Visible = true;
        this.FileUpload5.Visible = true;
        this.Button5.Visible = true;
        this.Image5.Visible = true;
        this.n5.Visible = true;
        this.f5.Visible = true;
        this.rp7.Visible = false;
        this.rp8.Visible = false;
    }
    protected void next6(object sender, EventArgs e)
    {
        this.l6.Visible = true;
        this.b6.Visible = true;
        this.c6.Visible = true;
        this.FileUpload6.Visible = true;
        this.Button6.Visible = true;
        this.Image6.Visible = true;
        this.f6.Visible = true;
        this.rp9.Visible = false;
        this.rp10.Visible = false;
    }
    protected void Show(object sender, EventArgs e) {
        string phone = Request["user_id"].ToString();
        this.img.Visible = false;
        String fullname = this.uploadimage.PostedFile.FileName;//获取上传图片的完整路径
        FileInfo fl = new FileInfo(fullname);//创建FileInfo类的实例
        String name = fl.Name;//获取文件名
        String type = fl.Extension;//获取扩展名
        String savepath = Server.MapPath("images");
        this.uploadimage.PostedFile.SaveAs(savepath + "\\" + name);
        this.img.Visible = true;
        this.img.ImageUrl = "images" + "/" + name;
        //将宝贝名称，宝贝图片 用户名称，以及所需材料存入数据库 
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        con.Open();
        string cmdtext = "insert into meteral(pdt_id,m1,m2,m3,m4,m5,m6,m7,m8) values(@ppdt_id,@mm1,@mm2,@mm3,@mm4,@mm5,@mm6,@mm7,@mm8)";
        string amdtext = "insert into product(user_id,pdt_id,pdt_name,pdt_img) values(@user_id,@pdt_id,@pdt_name,@pdt_img)";
        SqlCommand cmd = new SqlCommand(cmdtext,con);
        SqlCommand amd = new SqlCommand(amdtext,con);
        cmd.Parameters.Add("@ppdt_id", SqlDbType.VarChar, 50);
        cmd.Parameters["@ppdt_id"].Value = phone;
        cmd.Parameters.Add("@mm1", SqlDbType.VarChar, 50);
        cmd.Parameters["@mm1"].Value = this.m1.Text.ToString();
        cmd.Parameters.Add("@mm2", SqlDbType.VarChar, 50);
        cmd.Parameters["@mm2"].Value = this.m2.Text.ToString();
        cmd.Parameters.Add("@mm3", SqlDbType.VarChar, 50);
        cmd.Parameters["@mm3"].Value = this.m3.Text.ToString();
        cmd.Parameters.Add("@mm4", SqlDbType.VarChar, 50);
        cmd.Parameters["@mm4"].Value = this.m4.Text.ToString();
        cmd.Parameters.Add("@mm5", SqlDbType.VarChar, 50);
        cmd.Parameters["@mm5"].Value = this.m5.Text.ToString();
        cmd.Parameters.Add("@mm6", SqlDbType.VarChar, 50);
        cmd.Parameters["@mm6"].Value = this.m6.Text.ToString();
        cmd.Parameters.Add("@mm7", SqlDbType.VarChar, 50);
        cmd.Parameters["@mm7"].Value = this.m7.Text.ToString();
        cmd.Parameters.Add("@mm8", SqlDbType.VarChar, 50);
        cmd.Parameters["@mm8"].Value = this.m8.Text.ToString();
        amd.Parameters.Add("@user_id", SqlDbType.VarChar, 50);
        amd.Parameters["@user_id"].Value = phone;
        amd.Parameters.Add("@pdt_id", SqlDbType.VarChar, 50);
        amd.Parameters["@pdt_id"].Value = phone;
        amd.Parameters.Add("@pdt_name", SqlDbType.VarChar, 50);
        amd.Parameters["@pdt_name"].Value = this.thname.Text.ToString();
        amd.Parameters.Add("@pdt_img", SqlDbType.VarChar, 50);
        amd.Parameters["@pdt_img"].Value = "images" + "/" + name;
        cmd.ExecuteNonQuery();
        amd.ExecuteNonQuery();
        con.Close();
    }
    protected void Show1(object sender, EventArgs e)
    {
        string phone = Request["user_id"].ToString();
        this.Image1.Visible = false;
        String fullname = this.FileUpload1.PostedFile.FileName;//获取上传图片的完整路径
        FileInfo fl = new FileInfo(fullname);//创建FileInfo类的实例
        String name = fl.Name;//获取文件名
        String type = fl.Extension;//获取扩展名
        String savepath = Server.MapPath("images");
        this.FileUpload1.PostedFile.SaveAs(savepath + "\\" + name);
        this.Image1.Visible = true;
        this.Image1.ImageUrl = "images" + "/" + name;
        //把第一步的制作方法和图片存入数据库
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        con.Open();
        string cmdtext = "insert into process(pdt_id,pcs_img1) values(@pdt_id,@img1)";
        string amdtext = "insert into wordprocess(pdt_id,pcs_1) values(@pdt_id,@pcs1)";
        SqlCommand cmd = new SqlCommand(cmdtext, con);
        SqlCommand amd = new SqlCommand(amdtext, con);
        amd.Parameters.Add("@pdt_id", SqlDbType.VarChar, 50);
        amd.Parameters["@pdt_id"].Value =phone;
        amd.Parameters.Add("@pcs1", SqlDbType.VarChar, 50);
        amd.Parameters["@pcs1"].Value = this.b1.Text.ToString();
        cmd.Parameters.Add("@pdt_id", SqlDbType.VarChar, 50);
        cmd.Parameters["@pdt_id"].Value = phone;
        cmd.Parameters.Add("@img1", SqlDbType.VarChar, 50);
        cmd.Parameters["@img1"].Value = "images" + "/" + name;
        cmd.ExecuteNonQuery();
        amd.ExecuteNonQuery();
        con.Close();
    }
    protected void Show2(object sender, EventArgs e)
    {
        string phone = Request["user_id"].ToString();
        this.Image2.Visible = false;
        String fullname = this.FileUpload2.PostedFile.FileName;//获取上传图片的完整路径
        FileInfo fl = new FileInfo(fullname);//创建FileInfo类的实例
        String name = fl.Name;//获取文件名
        String type = fl.Extension;//获取扩展名
        String savepath = Server.MapPath("images");
        this.FileUpload2.PostedFile.SaveAs(savepath + "\\" + name);
        this.Image2.Visible = true;
        this.Image2.ImageUrl = "images" + "/" + name;
        //把第二步的制作方法和图片存入数据库
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        con.Open();
        string cmdtext = "Update process set pcs_img2=@img2 where pdt_id=@id";
        string amdtext = "Update wordprocess set pcs_2=@pcs2 where pdt_id=@id";
        SqlCommand cmd = new SqlCommand(cmdtext, con);
        SqlCommand amd = new SqlCommand(amdtext, con);
        cmd.Parameters.Add("@id", SqlDbType.VarChar, 50);
        cmd.Parameters["@id"].Value = phone;
        cmd.Parameters.Add("@img2", SqlDbType.VarChar, 50);
        cmd.Parameters["@img2"].Value = "images" + "/" + name;
        amd.Parameters.Add("@id", SqlDbType.VarChar, 50);
        amd.Parameters["@id"].Value = phone;
        amd.Parameters.Add("@pcs2", SqlDbType.VarChar, 50);
        amd.Parameters["@pcs2"].Value = this.b2.Text.ToString();
        try {
            cmd.ExecuteNonQuery();
            amd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            throw new System.Exception(err.Message);
        }
        finally
        {
            con.Close();
        }
    }
    protected void Show3(object sender, EventArgs e)
    {
        string phone = Request["user_id"].ToString();
        this.Image3.Visible = false;
        String fullname = this.FileUpload3.PostedFile.FileName;//获取上传图片的完整路径
        FileInfo fl = new FileInfo(fullname);//创建FileInfo类的实例
        String name = fl.Name;//获取文件名
        String type = fl.Extension;//获取扩展名
        String savepath = Server.MapPath("images");
        this.FileUpload3.PostedFile.SaveAs(savepath + "\\" + name);
        this.Image3.Visible = true;
        this.Image3.ImageUrl = "images" + "/" + name;
        //把第三步的制作方法和图片存入数据库
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        con.Open();
        string cmdtext = "Update process set pcs_img3=@img3 where pdt_id=@id";
        string amdtext = "Update wordprocess set pcs_3=@pcs3 where pdt_id=@id";
        SqlCommand cmd = new SqlCommand(cmdtext, con);
        SqlCommand amd = new SqlCommand(amdtext, con);
        cmd.Parameters.Add("@id", SqlDbType.VarChar, 50);
        cmd.Parameters["@id"].Value = phone;
        cmd.Parameters.Add("@img3", SqlDbType.VarChar, 50);
        cmd.Parameters["@img3"].Value = "images" + "/" + name;
        amd.Parameters.Add("@id", SqlDbType.VarChar, 50);
        amd.Parameters["@id"].Value = phone;
        amd.Parameters.Add("@pcs3", SqlDbType.VarChar, 50);
        amd.Parameters["@pcs3"].Value = this.b3.Text.ToString();
        try
        {
            cmd.ExecuteNonQuery();
            amd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            throw new System.Exception(err.Message);
        }
        finally
        {
            con.Close();
        }
    }
    protected void Show4(object sender, EventArgs e)
    {
        string phone = Request["user_id"].ToString();
        this.Image4.Visible = false;
        String fullname = this.FileUpload4.PostedFile.FileName;//获取上传图片的完整路径
        FileInfo fl = new FileInfo(fullname);//创建FileInfo类的实例
        String name = fl.Name;//获取文件名
        String type = fl.Extension;//获取扩展名
        String savepath = Server.MapPath("images");
        this.FileUpload4.PostedFile.SaveAs(savepath + "\\" + name);
        this.Image4.Visible = true;
        this.Image4.ImageUrl = "images" + "/" + name;
        //把第四步的制作方法和图片存入数据库
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        con.Open();
        string cmdtext = "Update process set pcs_img4=@img4 where pdt_id=@id";
        string amdtext = "Update wordprocess set pcs_4=@pcs4 where pdt_id=@id";
        SqlCommand cmd = new SqlCommand(cmdtext, con);
        SqlCommand amd = new SqlCommand(amdtext, con);
        cmd.Parameters.Add("@id", SqlDbType.VarChar, 50);
        cmd.Parameters["@id"].Value = phone;
        cmd.Parameters.Add("@img4", SqlDbType.VarChar, 50);
        cmd.Parameters["@img4"].Value = "images" + "/" + name;
        amd.Parameters.Add("@id", SqlDbType.VarChar, 50);
        amd.Parameters["@id"].Value = phone;
        amd.Parameters.Add("@pcs4", SqlDbType.VarChar, 50);
        amd.Parameters["@pcs4"].Value = this.b4.Text.ToString();
        try
        {
            cmd.ExecuteNonQuery();
            amd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            throw new System.Exception(err.Message);
        }
        finally
        {
            con.Close();
        }
    }
    protected void Show5(object sender, EventArgs e)
    {
        string phone = Request["user_id"].ToString();
        this.Image5.Visible = false;
        String fullname = this.FileUpload5.PostedFile.FileName;//获取上传图片的完整路径
        FileInfo fl = new FileInfo(fullname);//创建FileInfo类的实例
        String name = fl.Name;//获取文件名
        String type = fl.Extension;//获取扩展名
        String savepath = Server.MapPath("images");
        this.FileUpload5.PostedFile.SaveAs(savepath + "\\" + name);
        this.Image5.Visible = true;
        this.Image5.ImageUrl = "images" + "/" + name;
        //把第五步的制作方法和图片存入数据库
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        con.Open();
        string cmdtext = "Update process set pcs_img5=@img5 where pdt_id=@id";
        string amdtext = "Update wordprocess set pcs_5=@pcs5 where pdt_id=@id";
        SqlCommand cmd = new SqlCommand(cmdtext, con);
        SqlCommand amd = new SqlCommand(amdtext, con);
        cmd.Parameters.Add("@id", SqlDbType.VarChar, 50);
        cmd.Parameters["@id"].Value = phone;
        cmd.Parameters.Add("@img5", SqlDbType.VarChar, 50);
        cmd.Parameters["@img5"].Value = "images" + "/" + name;
        amd.Parameters.Add("@id", SqlDbType.VarChar, 50);
        amd.Parameters["@id"].Value = phone;
        amd.Parameters.Add("@pcs5", SqlDbType.VarChar, 50);
        amd.Parameters["@pcs5"].Value = this.b5.Text.ToString();
        try
        {
            cmd.ExecuteNonQuery();
            amd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            throw new System.Exception(err.Message);
        }
        finally
        {
            con.Close();
        }
    }
    protected void Show6(object sender, EventArgs e)
    {
        string phone = Request["user_id"].ToString();
        this.Image6.Visible = false;
        String fullname = this.FileUpload6.PostedFile.FileName;//获取上传图片的完整路径
        FileInfo fl = new FileInfo(fullname);//创建FileInfo类的实例
        String name = fl.Name;//获取文件名
        String type = fl.Extension;//获取扩展名
        String savepath = Server.MapPath("images");
        this.FileUpload6.PostedFile.SaveAs(savepath + "\\" + name);
        this.Image6.Visible = true;
        this.Image6.ImageUrl = "images" + "/" + name;
        //把第六步的制作方法和图片存入数据
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        con.Open();
        string cmdtext = "Update process set pcs_img6=@img6 where pdt_id=@id";
        string amdtext = "Update wordprocess set pcs_6=@pcs6 where pdt_id=@id";
        SqlCommand cmd = new SqlCommand(cmdtext, con);
        SqlCommand amd = new SqlCommand(amdtext, con);
        cmd.Parameters.Add("@id", SqlDbType.VarChar, 50);
        cmd.Parameters["@id"].Value = phone;
        cmd.Parameters.Add("@img6", SqlDbType.VarChar, 50);
        cmd.Parameters["@img6"].Value = "images" + "/" + name;
        amd.Parameters.Add("@id", SqlDbType.VarChar, 50);
        amd.Parameters["@id"].Value = phone;
        amd.Parameters.Add("@pcs6", SqlDbType.VarChar, 50);
        amd.Parameters["@pcs6"].Value = this.b6.Text.ToString();
        try
        {
            cmd.ExecuteNonQuery();
            amd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            throw new System.Exception(err.Message);
        }
        finally
        {
            con.Close();
        }
    }
    protected void finish(object sender, EventArgs e) {
        Response.Redirect("Main.aspx");
    }
}