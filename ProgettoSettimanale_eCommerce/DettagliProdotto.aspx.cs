using System;

namespace ProgettoSettimanale_eCommerce
{
    public partial class DettagliProdotto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Cookies["Prodotto"] != null)
            {
                // richiamo il cookie creato in Default.aspx.cs per visualizzare le informazioni del prodotto cliccato
                string nomeprodotto = Request.Cookies["Prodotto"].Value.Split(',')[0];
                string prezzoProdotto = Request.Cookies["Prodotto"].Value.Split(',')[1];
                string descrizioneAggiuntiva = Request.Cookies["Prodotto"].Value.Split(',')[2];


                titoloDettagli.InnerText = $"Descrizione del prodotto {nomeprodotto}";
                contenitore1.InnerText = $"Prezzo: {prezzoProdotto} Euro";
                contenitore2.InnerText = $"Descrizione: {descrizioneAggiuntiva}";
            }

            if (Request.Cookies["ImmagineProdotto"] != null)
            {
                string URL_immagine = Request.Cookies["ImmagineProdotto"].Value;
                imageContainer.Src = URL_immagine;
            }
        }

        protected void torna_indietro(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}