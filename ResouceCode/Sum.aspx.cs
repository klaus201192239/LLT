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
using System.Data.SqlClient;

public partial class Sum : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            gridpage();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        gridpage();
    }
    private void gridpage()
    {
        String str=Request["st"].ToString();//用户输入的字符串，这个串用于sql中的模糊搜索:like 
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        con.Open();
        string cmdtext = "select product.pdt_name,m1,m2,m3,m4,m5,m6,m7,m8 from product,meteral where meteral.pdt_id=product.pdt_id and (m1 like '" + str + "' or m2 like '" + str + "' or m3 like '" + str + "' or m4 like '" + str + "' or m5 like '" + str + "' or m6 like '" + str + "' or m7 like'"+str+"'or m8 like '" + str + "')";
        //此处需换成我们的数据库查询 切忌：要将数据信息配置到WeBconfig文件中
        SqlDataAdapter sda = new SqlDataAdapter(cmdtext, con);
        DataSet ds = new DataSet();
        sda.Fill(ds, "tablepage");
        GridView1.DataSource = ds.Tables["tablepage"].DefaultView;
        GridView1.DataBind();
        con.Close();
        this.lcurr.Text = "当前页为第" + (this.GridView1.PageIndex + 1).ToString() + "页　共有" + (this.GridView1.PageCount).ToString() + "页";
    }
    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {
        this.lcurr.Text = "当前页为第" + (this.GridView1.PageIndex + 1).ToString() + "页　共有" + (this.GridView1.PageCount).ToString() + "页";
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.GridView1.PageSize = Convert.ToInt32(DropDownList1.SelectedValue);
        gridpage();
    }
}