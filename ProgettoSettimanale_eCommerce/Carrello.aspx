<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="ProgettoSettimanale_eCommerce.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> carrello</title>
      <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="row">
            <div class=" col-12">
                <div class=" text-center">
                    <h1 class=" display-1">Carrello</h1>
                </div>

            </div>
        </div>

        <div class="row">
            <div class="d-flex justify-content-center">
                <h2 class="display-3 " id="nullaDaMostrare" runat="server"></h2>

            </div>
            <div class="d-flex  justify-content-center">
                <asp:Button ID="btn_tornaIndietro" runat="server" Text="torna indietro" OnClick="btn_tornaIndietro_Click" />
            </div>


            <div class="d-flex flex-column" runat="server" id="contenitore_Carrello">
            </div>

        </div>

        <div class="row">
            <h2 runat="server" id="contenitoreTotale"></h2>
        </div>
        <div class=" text-center">
            <asp:Button runat="server" ID="svuotaTuttoCarrello" OnClick="svuotaTuttoCarrello_Click" CssClass=" btn btn-outline-danger my-2" Text="svuota carrello" />
        </div>
    </form>
    <script>
        const cancellaCookie = (nomeCookie) => {
            document.cookie = nomeCookie + "=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
            location.reload(); // Ricarica la pagina per aggiornare il contenuto del carrello
        }
</script>

</body>
</html>
