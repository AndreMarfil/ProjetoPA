﻿//RETIRAR O COMENTÁRIO APÓS FAZER ALTERAÇÕES
namespace VendasAPI.Domínio.Entidades
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Municipio { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string email { get; set; }
        public string UF { get; set; }
    }
}
