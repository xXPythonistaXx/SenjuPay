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
