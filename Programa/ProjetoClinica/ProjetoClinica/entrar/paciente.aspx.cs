﻿using ProjetoClinica.DB;
using ProjetoClinica.DB.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoClinica.entrar
{
    public partial class paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;

            BDActions bd = new BDActions();

            Paciente p = bd.LoginPaciente(email, pwd);
        }
    }
}