﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeiXin_Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            File.WriteAllText(Server.MapPath("/ErrorTXT/" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt"), "访问Index页");
        }

        protected void button1_OnClick(object sender, EventArgs e)
        {

          lab1.Text=  new WX_Tools.get_access_token().Get_access_token();
        }

        protected void button2_OnClick(object sender, EventArgs e)
        {
            Label1.Text =new WX_Tools.getcallbackip().getServerIPString();
        }
    }
}