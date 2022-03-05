using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SenjuPay.API.Data;
using SenjuPay.API.Model;

namespace SenjuPay.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly DataContext _context;
        public EmpresaController(DataContext context)
        {
            _context = context;

        }
        public IEnumerable<Empresa> _empresa = new Empresa[]{
            new Empresa(){
            EmpresaId = 1,
            RazaoSocial = "Rafaela e Benedito Telecom Ltda",
            CNPJ = 20875261000162,
            LogoOficial = "Batata",
            Segmento = "ERP",
            DataCadastro = DateTime.Now
            },
            new Empresa(){
            EmpresaId = 2,
            RazaoSocial = "Juliana e Marcos Vinicius Pães e Doces ME",
            CNPJ = 34544287000132,
            LogoOficial = "Batata",
            Segmento = "Pagamentos",
            DataCadastro = DateTime.Now
            }
         };

        [HttpGet]
        public IEnumerable<Empresa> Get()
        {
            return _context.Empresas;
        }       

        [HttpGet("{id}")]
        public Empresa GetById(int id)
        {
            return _context.Empresas.FirstOrDefault(empresa => empresa.EmpresaId == id);
        }
    }
}
