using System;

namespace SenjuPay.API.Model
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string RazaoSocial { get; set; }
        public long CNPJ { get; set; }
        public string LogoOficial { get; set; }
        public string Segmento { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}