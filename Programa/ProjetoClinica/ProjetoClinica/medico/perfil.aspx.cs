﻿using ProjetoClinica.DB.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoClinica.perfil
{
    public partial class medico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MedicoDBO usuario = (MedicoDBO)Session["Usuario"];

            if (usuario.Imagem == null)
                ImgPerfil.ImageUrl = "/images/default_profile_picture.png";
            else
                ImgPerfil.ImageUrl = usuario.Imagem;

            LblApelido.Text = usuario.Nome_Completo.Split(' ')[0];
            LblNome.Text = usuario.Nome_Completo;
            LblEmail.Text = usuario.Email;
            LblDataDeNascimento.Text = usuario.Data_de_Nascimento;
            LblEndereco.Text = usuario.Endereco;
            LblCelular.Text = usuario.Celular;
            LblTelefoneResidencial.Text = usuario.Telefone_Residencial;
            LblEspecialidade.Text = usuario.Especialidade.Nome;
        }
    }
}