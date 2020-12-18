namespace ListaDeObjetos.Classes
{
    public class Cartao
    {
        public string Titular { get; set; }
        public int Numero { get; set; }
        public string Bandeira { get; set; }
        public int Cvv { get; set; }

        public Cartao(){}

        public Cartao(string _titular, int _numero, string _bandeira, int _cvv)
        {
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Cvv = _cvv;
        }
    }
}