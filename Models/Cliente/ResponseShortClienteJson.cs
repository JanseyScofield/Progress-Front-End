﻿namespace ProgressFrontEnd.Models.Cliente
{
public class ResponseShortClienteJson
    {
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public DateTime ProximaVisita { get; set; }
    }
}
