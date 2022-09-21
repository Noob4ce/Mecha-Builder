<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="summary.aspx.cs" Inherits="final_project.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="App_themes/css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">


    <div class="container mt-5">
        <div class="row mt-4">
            <h2 class="text-warning text-center">Select your Mecha</h2>
        </div>

        <div class="row mt-4">
            <div class="text-center">
                <asp:DropDownList ID="drplstMechas" runat="server" AutoPostBack="true" OnSelectedIndexChanged="handleSeletedChange">
                    <asp:ListItem Text="Select" />
                </asp:DropDownList>
            </div>
        </div>

        <div class="row mt-5">

            <div class="col-6">
                <div class="row">
                    <asp:Image ID="mechaImage" runat="server" ImageUrl=""
                        class="img-fluid" Style="width: auto; height: 500px; margin-left: auto; margin-right: auto;" />
                </div>

            </div>

            <div class="col-6">
                <div class="row">
                    <div class="col-6">
                        <asp:Table ID="tblWeapon" class="col-6" runat="server" CssClass="table text-light">
                            <asp:TableHeaderRow>
                                <asp:TableHeaderCell>Weapon</asp:TableHeaderCell>
                            </asp:TableHeaderRow>
                        </asp:Table>
                    </div>

                    <div class="col-6">
                        <asp:Table ID="tblShield" runat="server" CssClass="table text-light  ">
                            <asp:TableHeaderRow>
                                <asp:TableHeaderCell>Shield</asp:TableHeaderCell>

                            </asp:TableHeaderRow>
                        </asp:Table>
                    </div>
                </div>

                <div class="row">
                    <div class="col-6">
                        <asp:Table ID="tblAttack" class="col-6" runat="server" CssClass="table text-light">
                            <asp:TableHeaderRow>
                                <asp:TableHeaderCell></asp:TableHeaderCell>
                            </asp:TableHeaderRow>
                        </asp:Table>
                    </div>

                    <div class="col-6">
                        <asp:Table ID="tblDefence" runat="server" CssClass="table text-light  ">
                            <asp:TableHeaderRow>
                                <asp:TableHeaderCell></asp:TableHeaderCell>

                            </asp:TableHeaderRow>
                        </asp:Table>
                    </div>
                </div>





            </div>






        </div>

    </div>

    <div class="row">
    </div>




    <script>

    </script>
</asp:Content>


