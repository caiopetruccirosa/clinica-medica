﻿using ProjetoClinica.DB;
using ProjetoClinica.email;
using ProjetoClinica.extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoClinica.secretaria
{
	public partial class enviaremail : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                try
                {
                    CarregarLbPacientes();
                    TxtAreaEmailBody.Text = "Querido paciente, \n\n" +
                                            "Nosso sistema diz que você tem uma consulta em nossa clínica daqui a dois dias! \n" +
                                            "Esperamos você aqui! Caso não puder comparecer, entre em contato conosco. \n \n" +
                                            "Atenciosamente, \n" +
                                            "Clínica Médica.";
                }
                catch (Exception)
                {
                    Response.Redirect(Page.Request.Path);
                }
            }
        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            string subject = "Lembrete: você tem uma consulta marcada!";
            string body = TxtAreaEmailBody.Text.Trim();
            List<ListItem> selecteditems = LbPacientes.GetSelectedItems();

            try
            {
                EmailSender mailer = new EmailSender("clinicamedicapr3@gmail.com", "ClinicaMedicaPR3");
                BDActions bd = new BDActions();
                for (int i = 0; i < selecteditems.Count; i++)
                {
                    string valor = selecteditems[i].Value;

                    if (valor == "")
                        throw new Exception("Escolha algum paciente!");
                    else
                    {
                        string emailPaciente = valor.Split('-')[0];
                        int idConsulta = int.Parse(valor.Split('-')[1]);

                        mailer.sendEmail(emailPaciente, subject, body);
                        bd.MarcarConsultaComoAvisada(idConsulta);
                    }
                }

                LblAviso.ForeColor = System.Drawing.ColorTranslator.FromHtml("#4BB543");
                if (selecteditems.Count > 1)
                    LblAviso.Text = "E-mails enviados com sucesso!";
                else
                    LblAviso.Text = "E-mail enviado com sucesso!";

                TxtAreaEmailBody.Text = "Querido paciente, \n\n" +
                                        "Nosso sistema diz que você tem uma consulta em nossa clínica daqui a dois dias! \n" +
                                        "Esperamos você aqui! Caso não puder comparecer, entre em contato conosco. \n \n" +
                                        "Atenciosamente, \n" +
                                        "Clínica Médica.";
                RecarregarLbPacientes();
            }
            catch (Exception ex)
            {
                LblAviso.ForeColor = System.Drawing.ColorTranslator.FromHtml("#CC0000");
                LblAviso.Text = ex.Message;

                RecarregarLbPacientes();
            }
        }

        protected void CarregarLbPacientes()
        {
            BDActions bd = new BDActions();
            string[][] dados = bd.PacientesComConsultaProxima();

            LbPacientes.Items.Clear();
            if (dados != null)
            {
                for (int i = 0; i < dados.Length; i++)
                {
                    string texto = dados[i][0] + " - Consulta: " + dados[i][3];
                    string valor = dados[i][1] + "-" + dados[i][2];

                    ListItem item = new ListItem(texto, valor);
                    LbPacientes.Items.Add(item);
                }
            }
            else
            {
                LbPacientes.Items.Add(new ListItem("Nenhum paciente não avisado possui uma consulta próxima.", ""));
                LbPacientes.Items[0].Attributes.Add("disabled", "true");
            }
            LbPacientes.SelectedIndex = 0;
        }

        protected void RecarregarLbPacientes()
        {
            try
            {
                CarregarLbPacientes();
            }
            catch (Exception)
            {
                LbPacientes.Items.Add(new ListItem("Não foi possível carregar os pacientes!", ""));
                LbPacientes.Items[0].Attributes.Add("disabled", "true");
            }
            LbPacientes.SelectedIndex = 0;
        }
    }
}