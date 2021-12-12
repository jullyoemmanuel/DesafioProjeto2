namespace DIO.Series
{
    public abstract class EntidadeBase
    {
        public int Id {get; protected set; }
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao {get; set; }
        private int Ano {get; set; }
    }
}