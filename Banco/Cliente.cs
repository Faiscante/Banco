namespace Banco
{
    public class Cliente
    {
        private string p;
        public Cliente(string p)
        {
            this.Nome = p;
        }
        public string Nome { get; set; }
    }

    /*public bool PodeAbrirContaSozinho
    {
        get
        {
            var maiorDeIdade = this.idade >= 18;
            var emancipado = this.documentos.contains("emancipacao");
            var possuiCPF = !string.IsNullOrEmpty(this.cpf);
            return (maiorDeIdade || emancipado) && possuiCPF;
        }}
    */
}