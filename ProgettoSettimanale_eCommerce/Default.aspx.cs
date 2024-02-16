using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgettoSettimanale_eCommerce
{
    public partial class _Default : Page
    {
        /* return: void 
         * descrizione: al caricamento della pagina vengono mostrati gli item creati a partire dalla classe prodotto, questi una volta creati
         * vengono inseriti in una lista e passati al repeater per venir mappati attraverso Repeater1.DataBind();
         */
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<Prodotto> ProdottiDisponibili = new List<Prodotto>();

                Prodotto sedia = new Prodotto("https://www.arredasi.it/10771-large_default/sedia-legno-cucina-fresia-110-2.jpg", "Sedia", 50, "Sedia in legno");
                Prodotto bicchiere = new Prodotto("https://shop.mondoalberghiero.it/prodotti/116235/XXL/116235foto.jpg", "Bicchiere", 9, "Bicchiere in vetro");
                Prodotto scarpa = new Prodotto("https://images.internetstores.de/products/473667/02/a235c3/scarpa-mojito-skor-iron-gray-1.jpg?forceSize=true&forceAspectRatio=true&useTrim=true&size=613x613", "Scarpa", 25, "Scarpa per lunghe passeggiate montanare");
                Prodotto slittino = new Prodotto("https://cdn.produceshop.it/150418-large_default/slittino-da-neve-in-legno-per-bambini-slitta-2-posti-classica-vixen.jpg", "Slittino", 45, "Slittino da neve");

                ProdottiDisponibili.Add(sedia);
                ProdottiDisponibili.Add(bicchiere);
                ProdottiDisponibili.Add(scarpa);
                ProdottiDisponibili.Add(slittino);

                Repeater1.DataSource = ProdottiDisponibili;
                Repeater1.DataBind();
            }

            // se esiste un cookie prodotto al ritorna dalla pagina dettagli, questo viene eliminato
            if (Request.Cookies["Prodotto"] != null)
            {
                HttpCookie cookie = new HttpCookie("Prodotto");
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }


            // se esiste un cookie immagineProdotto al ritorna dalla pagina dettagli, questo viene eliminato
            if (Request.Cookies["ImmagineProdotto"] != null)
            {
                HttpCookie Cookie_immagine = new HttpCookie("ImmagineProdotto");
                Cookie_immagine.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(Cookie_immagine);
            }

        }

        // return: void 
        // descrizione : al click del bottone visualizzaDettagli, viene preso il nome del prodotto relativo all'item selezionato grazie al command argument
        // e confrontato con una stringa, se quel nome corrisponde ad una delle stringhe presenti entra nell relativo if e genera due cookie uno contenente
        // le informazioni e l'altro contenente url dell 'immagine, inviate al client, infine avviene il redirect alla pagine dettagli.

        protected void Click_visualizzaDettagli(object sender, EventArgs e)
        {
            // crea un cookie dove salvare le informazioni del prodotto cliccato per visualizzarle nella pagina DettagliProdotto.aspx
            Button Button1 = (Button)sender;
            string NomeProdotto = Button1.CommandArgument;

            if (NomeProdotto == "Sedia")
            {
                HttpCookie cookie = new HttpCookie("Prodotto");
                cookie.Value = "Sedia , 50 , Sedia in legno Massello finemente decorata ideale per le tue passeggiate mattutine. magari un po dura all'inizio ma cosi va la vita caro mio.";
                Response.Cookies.Add(cookie);



                HttpCookie Cookie_immagine = new HttpCookie("ImmagineProdotto");
                Cookie_immagine.Value = "https://www.arredasi.it/10771-large_default/sedia-legno-cucina-fresia-110-2.jpg";
                Response.Cookies.Add(Cookie_immagine);


            }

            else if (NomeProdotto == "Bicchiere")
            {
                HttpCookie cookie = new HttpCookie("Prodotto");
                cookie.Value = "Bicchiere , 9 , Bicchiere in vetro liscio e resistente. Se vuoi berti della sana e buona acqua trasparente e vuoi essere sicuro che sia proprio acqua perfetto questo è il tuo oggetto.";
                Response.Cookies.Add(cookie);


                HttpCookie Cookie_immagine = new HttpCookie("ImmagineProdotto");
                Cookie_immagine.Value = "https://shop.mondoalberghiero.it/prodotti/116235/XXL/116235foto.jpg";
                Response.Cookies.Add(Cookie_immagine);
            }


            else if (NomeProdotto == "Scarpa")
            {
                HttpCookie cookie = new HttpCookie("Prodotto");
                cookie.Value = "Scarpa , 25 , scarpa di montagna per lunghe passeggiate. ideali per le tue mani infreddolite.";
                Response.Cookies.Add(cookie);


                HttpCookie Cookie_immagine = new HttpCookie("ImmagineProdotto");
                Cookie_immagine.Value = "https://images.internetstores.de/products/473667/02/a235c3/scarpa-mojito-skor-iron-gray-1.jpg?forceSize=true&forceAspectRatio=true&useTrim=true&size=613x613";
                Response.Cookies.Add(Cookie_immagine);
            }

            else if (NomeProdotto == "Slittino")
            {
                HttpCookie cookie = new HttpCookie("Prodotto");
                cookie.Value = "Slittino , 45 , Slittino per scivolate sulla neve. se proprio hai voglia di qualcosa di caldo ricorda che la scivolizia se la beve strega salamandra.";
                Response.Cookies.Add(cookie);


                HttpCookie Cookie_immagine = new HttpCookie("ImmagineProdotto");
                Cookie_immagine.Value = "https://cdn.produceshop.it/150418-large_default/slittino-da-neve-in-legno-per-bambini-slitta-2-posti-classica-vixen.jpg";
                Response.Cookies.Add(Cookie_immagine);
            }


            Response.Redirect("DettagliProdotto.aspx");
        }


        protected void VaiAlcarrello(object sender, EventArgs e)
        {

            Response.Redirect("Carrello.aspx");
        }




        // return: void
        // al click del bottone aggiungi al carrello viene preso il bottone ed il contenuto del relativo command argument ad esso associato. 
        //se il cookie carrello non esiste viene creato e a seconda nei valori passati dal command argument viene creato il relativo cookie ed inviato al client.
        protected void AggiungiAlCarrello(object sender, EventArgs e)
        {
            Button Button2 = (Button)sender;
            string Dettagliprodotto = Button2.CommandArgument;

            if (Request.Cookies["carrello"] == null)
            {
                if (Dettagliprodotto.Contains("Sedia"))
                {

                    HttpCookie cookie_carrello = new HttpCookie("CookieSedia");
                    cookie_carrello.Value = Dettagliprodotto;
                    Response.Cookies.Add(cookie_carrello);

                }

                else if (Dettagliprodotto.Contains("Bicchiere"))
                {

                    HttpCookie cookie_carrello = new HttpCookie("CookieBicchiere");
                    cookie_carrello.Value = Dettagliprodotto;
                    Response.Cookies.Add(cookie_carrello);

                }

                else if (Dettagliprodotto.Contains("Scarpa"))
                {

                    HttpCookie cookie_carrello = new HttpCookie("CookieScarpa");
                    cookie_carrello.Value = Dettagliprodotto;
                    Response.Cookies.Add(cookie_carrello);

                }

                else if (Dettagliprodotto.Contains("Slittino"))
                {

                    HttpCookie cookie_carrello = new HttpCookie("CookieSlittino");
                    cookie_carrello.Value = Dettagliprodotto;
                    Response.Cookies.Add(cookie_carrello);

                }

            }

        }
    }
}