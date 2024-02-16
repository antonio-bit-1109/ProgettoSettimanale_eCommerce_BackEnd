namespace ProgettoSettimanale_eCommerce
{
    public class Prodotto
    {
        public string Immagine { get; set; }
        public string NomeProdotto { get; set; }
        public int Prezzo { get; set; }
        public string Descrizione { get; set; }

        public Prodotto(string immagine, string nomeProdotto, int prezzo, string descrizione)
        {
            this.Immagine = immagine;
            this.NomeProdotto = nomeProdotto;
            this.Prezzo = prezzo;
            this.Descrizione = descrizione;
        }
    }
}