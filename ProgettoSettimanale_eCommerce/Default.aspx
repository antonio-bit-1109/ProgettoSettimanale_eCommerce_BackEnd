<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProgettoSettimanale_eCommerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main style="background-image : url('./Content/immagini/sfondo.jpg'); object-position :center">
        <div class="row">
            <div class=" col-12">
                <div class=" text-center">
                    <h1 class=" display-1 text-light">E-commerce Bello</h1>
                    <asp:Button CssClass="m-1 btn btn-outline-primary" ID="Button3" runat="server" Text="Vai Al carrello"  OnClick="VaiAlcarrello" />
                        <p  runat="server" class="text-light" id="messAddToCart" >Item Aggiunto al carrello! </p>
                </div>
                
            </div>
        </div>

        <div class="row justify-content-center">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <div class="col-4 my-3 mx-2 border border-1 rounded-3 d-flex m-auto flex-column align-items-center bg-light">
                        <img class="w-50" src='<%# Eval("Immagine") %>' />
                        <h2 class="display-4">'<%# Eval("nomeProdotto") %>'</h2>
                        <h3 class="fs-4">'<%# Eval("prezzo") %>' Euro</h3>
                        <p class=" fs-italic">'<%# Eval("descrizione") %>'</p>
                        <asp:Button CssClass="m-1 btn btn-outline-info" ID="Button1" runat="server" Text="visualizza dettagli" CommandArgument='<%# Eval("NomeProdotto") %>' OnClick="Click_visualizzaDettagli" />
                        <asp:Button CssClass="m-1 btn btn-outline-success"  ID="Button2" runat="server" Text="Aggiungi al carrello" CommandArgument='<%# Eval("nomeProdotto") + "," + Eval("prezzo") + "," + Eval("descrizione") %>' OnClick="AggiungiAlCarrello" OnClientClick="apparitesto();" />
                    </div>

                </ItemTemplate>
            </asp:Repeater>
        </div>

    </main>

    <script>
        setTimeout(function () {
            $("#<%= messAddToCart.ClientID %>").hide();
        }, 3000);       
    </script>

</asp:Content>
