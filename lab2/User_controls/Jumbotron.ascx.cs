﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2.User_controls
{
    public partial class Jumbotron : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            JumbotronH1.InnerText = "Welcome!";
        }
    }
}