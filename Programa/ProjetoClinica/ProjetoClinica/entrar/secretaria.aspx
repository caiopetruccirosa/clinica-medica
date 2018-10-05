﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="secretaria.aspx.cs" Inherits="ProjetoClinica.entrar.secretaria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <center><h1>Secretária</h1></center>

    <form>
        <div class="container">
            <div class="col m9 s12">
                <div class="row">
                    <div class="input-field">
                        <i class="material-icons prefix">account_circle</i>
                        <asp:TextBox ID="txtCodigo" runat="server" CssClass="validate"></asp:TextBox>
                        <label for="MainContent_txtCodigo">Código:</label>
                    </div>
                </div>

                <div class="row">
                    <div class="input-field">
                        <i class="material-icons prefix">lock</i>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="validate" TextMode="Password"></asp:TextBox>
                        <label for="MainContent_txtPassword">Senha:</label>
                    </div>
                </div>

                <div class="row">
                    <asp:Button ID="BtnEntrar" runat="server" Text="Entrar" CssClass="waves-effect waves-light btn-large btn-entrar" ForeColor="White" OnClick="BtnEntrar_Click"/>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
