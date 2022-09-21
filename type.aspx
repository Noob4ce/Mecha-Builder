<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="type.aspx.cs" Inherits="final_project.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="App_themes/css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="container main-container">
        <div class="row">
            <div class="col-7 left-side">
                <div class="row">
                    <div class="col-7">
                        <img src="App_themes/images/hunter.png" id="mechaImage" class="img-fluid  ps-4" style="width: auto; height: 500px; margin-left: auto; margin-right: auto;" />
                    </div>



                    <div class="col-5 mt-5">

                        <div class="row text-warning">
                            <h4 id="abilityName">Core Exposure</h4>
                        </div>

                        <div class="row">
                            <p id="abilityDescription">Hunter boosts its combat mobility by exposing the core from armour and shields</p>
                        </div>

                        <div class="row mt-5">
                            <p id="abilityData">Attack Bonus: 35%/25%/20%</p>
                        </div>

                    </div>
                </div>



            </div>


            <div class="col-5 container">
                <div class="row">
                </div>


                <div class="my-2 ms-3 row justify-content-center">
                    <asp:Label ID="lblName" CssClass="p-0 h2 text-warning" runat="server" Text="Name: "></asp:Label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control ms-3 h4"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ForeColor="Red" ControlToValidate="txtName" Display="Dynamic">Please Enter the Name of Your Mecha</asp:RequiredFieldValidator>
                </div>


                <div class="row my-5 ms-3 justify-content-around">
                    <asp:Label class="p-0 h2 text-warning" ID="Label1" runat="server" Text="Type: "></asp:Label>

                    <asp:RadioButtonList ID="rblShipType" runat="server" CssClass="col-6 table text-light table-borderless ms-3 mt-2 h4 m-0 form-check-inpu" align="center" ColumnSpan="2" RepeatColumns="2">
                        <asp:ListItem Value="1" class="" runat="server" Text="Hunter" Selected="True" OnClick="return loadMecha(this.value)" />
                        <asp:ListItem Value="2" class="" runat="server" Text="Coordinator" OnClick="return loadMecha(this.value)" />
                    </asp:RadioButtonList>
                </div>

                <div class="row my-5 ms-3 justify-content-center">
                    <div class="text-center">
                        <asp:Button runat="server" ID="SomeLinkButton" CssClass="btn btn-warning btn-lg text-white mt-5" Text="Continue" OnClick="createShip"></asp:Button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        function loadMecha(v) {

            let xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {

                    var retreived = JSON.parse(this.responseText);

                    let selected;

                    if (v == "1") {
                        selected = "Hunter";
                    } else {
                        selected = "Coordinator";
                    }

                    document.querySelector("#mechaImage").src = retreived[selected].imgURL;
                    document.querySelector("#abilityName").textContent = retreived[selected].abilityName;
                    document.querySelector("#abilityDescription").textContent = retreived[selected].abilityDescription;
                    document.querySelector("#abilityData").textContent = retreived[selected].abilityData;


                }
            }

            xhttp.open("GET", "mechas.json", true);
            xhttp.send();
        }
    </script>
</asp:Content>
