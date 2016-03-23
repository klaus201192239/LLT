using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){}
    protected void Imb1(object sender, EventArgs e){
        String str = this.ImageButton1.ID.ToString();//str中存储的是此张图片所对应的在数据库抓那个存储的成品ID号或成品名称
        Response.Redirect("Show.aspx?pdt_name="+str);
    }
    protected void Imb2(object sender, EventArgs e)
    {
        String str = this.ImageButton2.ID.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void Imb3(object sender, EventArgs e)
    {
        String str = this.ImageButton3.ID.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void Imb4(object sender, EventArgs e)
    {
        String str = this.ImageButton4.ID.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void Imb5(object sender, EventArgs e)
    {
        String str = this.ImageButton5.ID.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void Imb6(object sender, EventArgs e)
    {
        String str = this.ImageButton6.ID.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void Imb7(object sender, EventArgs e)
    {
        String str = this.ImageButton7.ID.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void Imb8(object sender, EventArgs e)
    {
        String str = this.ImageButton8.ID.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void Imb9(object sender, EventArgs e)
    {
        String str = this.ImageButton9.ID.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void Imb10(object sender, EventArgs e)
    {
        String str = this.ImageButton10.ID.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb1(object sender, EventArgs e) {
        String str = this.LinkButton1.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb2(object sender, EventArgs e) {
        String str = this.LinkButton2.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb3(object sender, EventArgs e) {
        String str = this.LinkButton3.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb4(object sender, EventArgs e) {
        String str = this.LinkButton4.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb5(object sender, EventArgs e) {
        String str = this.LinkButton5.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb6(object sender, EventArgs e) {
        String str = this.LinkButton6.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb7(object sender, EventArgs e) {
        String str = this.LinkButton7.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb8(object sender, EventArgs e) {
        String str = this.LinkButton8.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb9(object sender, EventArgs e) {
        String str = this.LinkButton9.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb10(object sender, EventArgs e) {
        String str = this.LinkButton10.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb11(object sender, EventArgs e) {
        String str = this.LinkButton11.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb13(object sender, EventArgs e) {
        String str = this.LinkButton13.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb14(object sender, EventArgs e) {
        String str = this.LinkButton14.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb15(object sender, EventArgs e) {
        String str = this.LinkButton15.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb16(object sender, EventArgs e) {
        String str = this.LinkButton16.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void lkb17(object sender, EventArgs e) {
        String str = this.LinkButton17.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    } 
    protected void lkb18(object sender, EventArgs e) {
        String str = this.LinkButton18.Text.ToString();
        Response.Redirect("Show.aspx?pdt_name=" + str);
    }
    protected void search(object sender, EventArgs e) { 
        String str = this.input.Text.ToString();
        Response.Redirect("Sum.aspx?st="+str);
    }
    protected void gift(object sender, EventArgs e) {
        Response.Redirect("Login.aspx");
    }
    protected void add(object sender, EventArgs e) {
        Response.Redirect("LoginWithAdmin.aspx");
    } 
}