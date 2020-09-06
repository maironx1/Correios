namespace CorreiosData.Classes
{
    public class Trecho
    {
        public Node Origem { get; set; }
        public Node Destino { get; set; }

        public Trecho (Node origem, Node destino)
        {
            Origem = origem;
            Destino = destino;
        }
    }
}
