﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoClinica.entrar
{
    public partial class medico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Redirect("/medico/index.aspx");
        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;

            Response.Redirect("/medico/index.aspx");
        }
    }
}