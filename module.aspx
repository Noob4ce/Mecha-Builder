<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="module.aspx.cs" Inherits="final_project.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="App_themes/css/style.css" rel="stylesheet" />

</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="container main-container">
        <div class="row">
            <div class="col-4 pe-5 left-side">
                <div class="row">
                    <asp:Label ID="lblTest" runat="server" Text="Label" CssClass="h3 text-center text-warning"></asp:Label>
                    <asp:Label ID="lblEnergy" runat="server" Text="Label" CssClass="h5 text-center "></asp:Label>
                    <asp:Image ID="mechaImage" runat="server" ImageUrl="App_themes/images/hunter.png"
                        class="img-fluid  ps-4" Style="width: auto; height: 500px; margin-left: auto; margin-right: auto;" />
                </div>
            </div>

            <div class="col-8">
                <div class="row">
                    <div class="col-6">
                        <div class="row">
                            <h2 class="text-warning">Weapon</h2>
                        </div>
                        <asp:CheckBoxList ID="chklstWeapons" CssClass="h6" runat="server">
                        </asp:CheckBoxList>

                    </div>

                    <div class="col-6">
                        <div class="row">
                            <h2 class="text-warning">Shield</h2>
                        </div>
                        <asp:CheckBoxList ID="chklstShield" CssClass="h6" runat="server" stlye="">
                        </asp:CheckBoxList>
                    </div>
                </div>

                <div class="row text-center">
                    <asp:CustomValidator ID="cvChklstWeapons" runat="server" ErrorMessage="You must select at least one module" ForeColor="Red" OnServerValidate="validateChklist"></asp:CustomValidator>

                    <asp:CustomValidator ID="cvEnerygy" runat="server" ErrorMessage="Your design has exceeded the energy supply." ForeColor="Red" OnServerValidate="validateEnergyCost"></asp:CustomValidator>
                </div>


                <div class="row text-center me-5">
                    <div>
                        <asp:Button runat="server" ID="SomeLinkButton" CssClass="btn btn-warning btn-lg text-white mt-5" Text="Continue" OnClick="addModule"></asp:Button>
                    </div>
                </div>
            </div>

        </div>


        <div class="row">
            <div class="col-8"></div>
            <div class="col-4">
                <div class="row">
                </div>

                <div class="row">
                </div>


            </div>
        </div>

        <div class="row ">
            <div class="col-8"></div>

        </div>


    </div>










</asp:Content>
