using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Gift : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){}
    protected void function1(object sender, EventArgs e)
    {
        this.Image1.Visible = false;
        this.Label1.Visible = true;
        Random rd = new Random();
        int x = rd.Next(0, 10);
        this.Label1.Text = "你获得了 " + x+"等奖哦！";
        this.Image2.Visible = false;
        this.Ima2.Visible = true;
        this.Image3.Visible = false;
        this.Ima3.Visible = true;
        this.Image5.Visible = false;
        this.Ima5.Visible = true;
        this.Image6.Visible = false;
        this.Ima6.Visible = true;
        this.Image7.Visible = false;
        this.Ima7.Visible = true;
        this.Image8.Visible = false;
        this.Ima8.Visible = true;
    }
    protected void function2(object sender, EventArgs e)
    {
        this.Image2.Visible = false;
        this.Label2.Visible = true;
        Random rd = new Random();
        int x = rd.Next(0, 10);
        this.Label2.Text = "你获得了 " + x + "等奖哦！";
        this.Image1.Visible = false;
        this.Ima1.Visible = true;
        this.Image3.Visible = false;
        this.Ima3.Visible = true;
        this.Image5.Visible = false;
        this.Ima5.Visible = true;
        this.Image6.Visible = false;
        this.Ima6.Visible = true;
        this.Image7.Visible = false;
        this.Ima7.Visible = true;
        this.Image8.Visible = false;
        this.Ima8.Visible = true;
    }
    protected void function3(object sender, EventArgs e)
    {
        this.Image3.Visible = false;
        this.Label3.Visible = true;
        Random rd = new Random();
        int x = rd.Next(0, 10);
        this.Label3.Text = "你获得了 " + x + "等奖哦！";
        this.Image2.Visible = false;
        this.Ima2.Visible = true;
        this.Image1.Visible = false;
        this.Ima1.Visible = true;
        this.Image5.Visible = false;
        this.Ima5.Visible = true;
        this.Image6.Visible = false;
        this.Ima6.Visible = true;
        this.Image7.Visible = false;
        this.Ima7.Visible = true;
        this.Image8.Visible = false;
        this.Ima8.Visible = true;
    }
    protected void function5(object sender, EventArgs e)
    {
        this.Image5.Visible = false;
        this.Label5.Visible = true;
        Random rd = new Random();
        int x = rd.Next(0, 10);
        this.Label5.Text = "你获得了 " + x + "等奖哦！";
        this.Image2.Visible = false;
        this.Ima2.Visible = true;
        this.Image3.Visible = false;
        this.Ima3.Visible = true;
        this.Image1.Visible = false;
        this.Ima1.Visible = true;
        this.Image6.Visible = false;
        this.Ima6.Visible = true;
        this.Image7.Visible = false;
        this.Ima7.Visible = true;
        this.Image8.Visible = false;
        this.Ima8.Visible = true;
    }
    protected void function6(object sender, EventArgs e)
    {
        this.Image6.Visible = false;
        this.Label6.Visible = true;
        Random rd = new Random();
        int x = rd.Next(0, 10);
        this.Label6.Text = "你获得了 " + x + "等奖哦！";
        this.Image2.Visible = false;
        this.Ima2.Visible = true;
        this.Image3.Visible = false;
        this.Ima3.Visible = true;
        this.Image5.Visible = false;
        this.Ima5.Visible = true;
        this.Image1.Visible = false;
        this.Ima1.Visible = true;
        this.Image7.Visible = false;
        this.Ima7.Visible = true;
        this.Image8.Visible = false;
        this.Ima8.Visible = true;
    }
    protected void function7(object sender, EventArgs e)
    {
        this.Image7.Visible = false;
        this.Label7.Visible = true;
        Random rd = new Random();
        int x = rd.Next(0, 10);
        this.Label7.Text = "你获得了 " + x + "等奖哦！";
        this.Image2.Visible = false;
        this.Ima2.Visible = true;
        this.Image3.Visible = false;
        this.Ima3.Visible = true;
        this.Image5.Visible = false;
        this.Ima5.Visible = true;
        this.Image6.Visible = false;
        this.Ima6.Visible = true;
        this.Image1.Visible = false;
        this.Ima1.Visible = true;
        this.Image8.Visible = false;
        this.Ima8.Visible = true;
    }
    protected void function8(object sender, EventArgs e)
    {
        this.Image8.Visible = false;
        this.Label8.Visible = true;
        Random rd = new Random();
        int x = rd.Next(0, 10);
        this.Label8.Text = "你获得了 " + x + "等奖哦！";
        this.Image2.Visible = false;
        this.Ima2.Visible = true;
        this.Image3.Visible = false;
        this.Ima3.Visible = true;
        this.Image5.Visible = false;
        this.Ima5.Visible = true;
        this.Image6.Visible = false;
        this.Ima6.Visible = true;
        this.Image7.Visible = false;
        this.Ima7.Visible = true;
        this.Image1.Visible = false;
        this.Ima1.Visible = true;
    }
}