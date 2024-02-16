<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DettagliProdotto.aspx.cs" Inherits="ProgettoSettimanale_eCommerce.DettagliProdotto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Dettaglio</title>
      <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="row justify-content-center vh-100">
            <div class="d-flex align-items-center justify-content-center">
                <div class="col-5">
                    <div class="d-flex flex-column p-3 border border-1">
                        <h1 runat="server" id="titoloDettagli"></h1>
                        <img id="imageContainer" class="w-50 m-auto" runat="server" />
                        <h3 id="contenitore1" runat="server"></h3>
                        <h5 id="contenitore2" runat="server"></h5>
                        <asp:Button CssClass="btn btn-outline-primary" ID="Button1" runat="server" Text="Torna indietro " OnClick="torna_indietro" />
                    </div>

                </div>
            </div>


        </div>

    </form>
</body>
</html>
