using System;

namespace CRUDCliente.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Documento { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
