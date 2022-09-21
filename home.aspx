<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="final_project.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="App_themes/css/style.css" rel="stylesheet" />

</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">

    <div class="container text-center main-container mt-5" style="height: 550px;">
        <h1 id="test">Build Your Own Mecha</h1>
        <p>Select modules that suit your Mecha’s unique ability. </p>
        <asp:LinkButton runat="server" ID="SomeLinkButton" href="type.aspx" CssClass="btn btn-warning btn-lg text-white mt-5">Start</asp:LinkButton>

    </div>

</asp:Content>
