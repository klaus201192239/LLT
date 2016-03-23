using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EveryPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.m1.Visible = true;
        this.name1.Visible = true;
        this.p1.Visible = true;
        this.p1.ImageUrl = "images/4F105544479.jpg";
        this.name1.Text = "用两双袜子DIY可爱圣诞小雪人";
        this.m1.Text = "所需材料：白色和红色的袜子各一双，棉花，针线。以下就是如何把两对旧袜子通过DIY做成可爱的圣诞节小雪人的做法和制作步骤";
        this.m2.Visible = true;
        this.name2.Visible = true;
        this.p2.Visible = true;
        this.p2.ImageUrl = "images/01744419.jpg";
        this.name2.Text = "用两双袜子DIY可爱圣诞小雪人";
        this.m2.Text = "所需材料：白色和红色的袜子各一双，棉花，针线。以下就是如何把两对旧袜子通过DIY做成可爱的圣诞节小雪人的做法和制作步骤";
    }
}