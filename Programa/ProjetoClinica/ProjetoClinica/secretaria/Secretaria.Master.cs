﻿using ProjetoClinica.DB.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoClinica
{
    public partial class Secretaria : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            object usuario = Session["Usuario"];
            Type secretaria = Type.GetType("SecretariaDBO");

            if (Session.IsNewSession || usuario == null || !usuario.GetType().Equals(secretaria))
            {
                Response.Redirect("/index.aspx");
            }
        }
    }
}