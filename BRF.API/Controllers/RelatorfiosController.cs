using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BRF.API.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BRF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatorfiosController : ControllerBase
    {
        private readonly BRF_dbContext _context;

        public RelatorfiosController(BRF_dbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetRelatorio()
        {
            string StoredProc = "exec [GetFornecedoresProdutos]";
            var response = _context.Relatorios.FromSqlRaw(StoredProc).ToList();


            return (IActionResult)response;
        }

    }   
}
