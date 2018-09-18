﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="secretaria.aspx.cs" Inherits="ProjetoClinica.entrar.secretaria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <center><h1>Secretária</h1></center>

    <form class="col s6 center">
        <div class="row">
            <div class="input-field">
                <i class="material-icons prefix">account_circle</i>
                <input id="icon_prefix" type="text" class="validate">
                <label for="icon_prefix">Código:</label>
            </div>
        </div>

        <div class="row">
            <div class="input-field">
                <i class="material-icons prefix">lock</i>
                <input id="password" type="password" class="validate">
                <label for="password">Senha:</label>
            </div>
        </div>

        <div class="row">
            <button class="waves-effect waves-light btn-large btn-entrar">Entrar</button>
        </div>
    </form>
</asp:Content>
