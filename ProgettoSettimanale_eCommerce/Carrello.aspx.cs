﻿using System;

namespace ProgettoSettimanale_eCommerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        int totaleOrdini = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                nullaDaMostrare.Visible = false;
                btn_tornaIndietro.Visible = true;

                if (Request.Cookies["CookieSedia"] != null || Request.Cookies["CookieBicchiere"] != null ||
                    Request.Cookies["CookieScarpa"] != null || Request.Cookies["CookieSlittino"] != null)
                {

                    if (Request.Cookies["CookieSedia"] != null)
                    {
                        // come suddivido i valori del cookie 
                        string Nomesedia = Request.Cookies["CookieSedia"].Value.Split(',')[0];
                        string prezzoSedia = Request.Cookies["CookieSedia"].Value.Split(',')[1];
                        string DescrizioneSedia = Request.Cookies["CookieSedia"].Value.Split(',')[2];

                        if (int.TryParse(prezzoSedia, out int prezzoSediaInt))
                        {
                            /*
                             * 
                            Button btnELimina = new Button();
                            btnELimina.Text = "Elimina Ordine";
                            btnELimina.Click += new EventHandler(BtnELimina_Click);

                            */


                            contenitore_Carrello.InnerHtml += $" <div class='d-flex gap-3'> <p>{Nomesedia}  </p> <p> {prezzoSediaInt}  </p> <p> {DescrizioneSedia}  </p>  </div> ";
                            // contenitore_Carrello.Controls.Add(btnELimina);
                            totaleOrdini += prezzoSediaInt;
                        }


                    }

                    if (Request.Cookies["CookieBicchiere"] != null)
                    {
                        // come suddivido i valori del cookie 
                        string NomeBicchiere = Request.Cookies["CookieBicchiere"].Value.Split(',')[0];
                        string PrezzoBicchiere = Request.Cookies["CookieBicchiere"].Value.Split(',')[1];
                        string DescrizioneBicchiere = Request.Cookies["CookieBicchiere"].Value.Split(',')[2];

                        if (int.TryParse(PrezzoBicchiere, out int PrezzoBicchiereInt))
                        {
                            contenitore_Carrello.InnerHtml += $" <div class='d-flex gap-3'> <p>{NomeBicchiere}  </p> <p> {PrezzoBicchiereInt}  </p> <p> {DescrizioneBicchiere}  </p>  </div> ";
                            totaleOrdini += PrezzoBicchiereInt;
                        }

                    }

                    if (Request.Cookies["CookieScarpa"] != null)
                    {
                        // come suddivido i valori del cookie 
                        string NomeScarpa = Request.Cookies["CookieScarpa"].Value.Split(',')[0];
                        string prezzoScarpa = Request.Cookies["CookieScarpa"].Value.Split(',')[1];
                        string DescrizioneScarpa = Request.Cookies["CookieScarpa"].Value.Split(',')[2];

                        if (int.TryParse(prezzoScarpa, out int prezzoScarpaInt))
                        {
                            contenitore_Carrello.InnerHtml += $" <div class='d-flex gap-3'> <p>{NomeScarpa}  </p> <p> {prezzoScarpaInt}  </p> <p> {DescrizioneScarpa}  </p>  </div> ";
                            totaleOrdini += prezzoScarpaInt;
                        }

                    }

                    if (Request.Cookies["CookieSlittino"] != null)
                    {
                        // come suddivido i valori del cookie 
                        string NomeSlittino = Request.Cookies["CookieSlittino"].Value.Split(',')[0];
                        string PrezzoSlittino = Request.Cookies["CookieSlittino"].Value.Split(',')[1];
                        string DescrizioneSlittino = Request.Cookies["CookieSlittino"].Value.Split(',')[2];

                        if (int.TryParse(PrezzoSlittino, out int PrezzoSlittinoInt))
                        {
                            contenitore_Carrello.InnerHtml += $" <div class='d-flex gap-3 border border-1 m-2'> <p>{NomeSlittino}  </p> <p> {PrezzoSlittinoInt}  </p> <p> {DescrizioneSlittino}  </p>  </div> ";
                            totaleOrdini += PrezzoSlittinoInt;
                        }

                    }

                }
                else
                {
                    nullaDaMostrare.Visible = true;
                    nullaDaMostrare.InnerText = "Nessun prodotto nel carrello da mostrare!";

                }

                contenitoreTotale.InnerHtml = $"<h3> Totale: {totaleOrdini} </h3>";
            }

        }

        protected void btn_tornaIndietro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


    }
}