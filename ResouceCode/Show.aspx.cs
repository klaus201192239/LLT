using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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

public partial class Show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String id = Request["pdt_name"].ToString();
        String pdt_name, pdt_img,
               m1, m2, m3, m4, m5, m6, m7, m8,
               pcs_1, pcs_2, pcs_3, pcs_4, pcs_5, pcs_6,
               pcs_img1, pcs_img2, pcs_img3, pcs_img4, pcs_img5, pcs_img6;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        con.Open();
        string selectstring = "select * from process,product,wordprocess,meteral where product.pdt_id=process.pdt_id and product.pdt_id=wordprocess.pdt_id and product.pdt_id=meteral.pdt_id and (product.pdt_id='" + id + "' or product.pdt_name='" + id + "')";
        SqlCommand cmd = new SqlCommand(selectstring, con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            pdt_name = dr["pdt_name"].ToString();
            pdt_img = dr["pdt_img"].ToString();
            m1 = dr["m1"].ToString(); m2 = dr["m2"].ToString(); m3 = dr["m3"].ToString(); m4 = dr["m4"].ToString();
            m5 = dr["m5"].ToString(); m6 = dr["m6"].ToString(); m7 = dr["m7"].ToString(); m8 = dr["m8"].ToString();
            pcs_1 = dr["pcs_1"].ToString(); pcs_2 = dr["pcs_2"].ToString(); pcs_3 = dr["pcs_3"].ToString();
            pcs_4 = dr["pcs_4"].ToString(); pcs_5 = dr["pcs_5"].ToString(); pcs_6 = dr["pcs_6"].ToString();
            pcs_img1 = dr["pcs_img1"].ToString(); pcs_img2 = dr["pcs_img2"].ToString(); pcs_img3 = dr["pcs_img3"].ToString();
            pcs_img4 = dr["pcs_img4"].ToString(); pcs_img5 = dr["pcs_img5"].ToString(); pcs_img6 = dr["pcs_img6"].ToString();
            this.la1.Text = "原料为" + m1 + "," + m2 + "," + m3 + "," + m4 + "," + m5 + "," + m6 + "," + m7 + "," + m8;
            this.li1.ImageUrl = pdt_img;
            this.Label1.Text = pdt_name;
            this.li2.ImageUrl = pcs_img1;
            this.la2.Text = pcs_1;
            if (!pcs_2.Equals(null))
            {
                this.Label3.Text = "第二步"; 
                this.li3.ImageUrl = pcs_img2;
                this.la3.Text = pcs_2;
            }
            else
            {
                this.li3.Visible = false; this.la3.Visible = false; this.Label3.Visible = false;
                this.li4.Visible = false; this.la4.Visible = false; this.Label4.Visible = false;
                this.li5.Visible = false; this.la5.Visible = false; this.Label5.Visible = false;
                this.li6.Visible = false; this.la6.Visible = false; this.Label6.Visible = false;
                this.li7.Visible = false; this.la7.Visible = false; this.Label7.Visible = false;
                this.Label3.Text = "已完成！"; this.Label3.Visible = true;
            }
            if (!pcs_3.Equals(null))
            {
                this.Label4.Text = "第三步"; 
                this.li4.ImageUrl = pcs_img3;
                this.la4.Text = pcs_3;
            }
            else
            {
                this.li4.Visible = false; this.la4.Visible = false; this.Label4.Visible = false;
                this.li5.Visible = false; this.la5.Visible = false; this.Label5.Visible = false;
                this.li6.Visible = false; this.la6.Visible = false; this.Label6.Visible = false;
                this.li7.Visible = false; this.la7.Visible = false; this.Label7.Visible = false;
                this.Label4.Text = "已完成！"; this.Label4.Visible = true;
            }
            if (!pcs_4.Equals(null))
            {
                this.Label5.Text = "第四步"; 
                this.li5.ImageUrl = pcs_img4;
                this.la5.Text = pcs_4;
            }
            else
            {
                this.li5.Visible = false; this.la5.Visible = false; this.Label5.Visible = false;
                this.li6.Visible = false; this.la6.Visible = false; this.Label6.Visible = false;
                this.li7.Visible = false; this.la7.Visible = false; this.Label7.Visible = false;
                this.Label5.Text = "已完成！"; this.Label5.Visible = true;
            }
            if (!pcs_5.Equals(null))
            {
                this.Label6.Text = "第五步"; 
                this.li6.ImageUrl = pcs_img5;
                this.la6.Text = pcs_5;
            }
            else
            {
                this.li6.Visible = false; this.la6.Visible = false; this.Label6.Visible = false;
                this.li7.Visible = false; this.la7.Visible = false; this.Label7.Visible = false;
                this.Label6.Text = "已完成！"; this.Label6.Visible = true;
            }
            if (!pcs_6.Equals(null))
            {
                this.Label7.Text = "第六步"; 
                this.li7.ImageUrl = pcs_img6;
                this.la7.Text = pcs_6;
            }
            else
            {
                this.li7.Visible = false; this.la7.Visible = false; this.Label7.Visible = false;
                this.Label7.Text = "已完成！"; this.Label7.Visible = true;
            }
        }
    }
}