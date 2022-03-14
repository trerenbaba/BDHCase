using BDHCase.Persistence.Context;
using BDHCase.Persistence.Repo.Abstract;
using BDHCase.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDHCase.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalisanlarController : ControllerBase
    {
        private readonly ICalisanRepository _calisanRepository;
        private readonly AppDbContext _appDbContext;
        public CalisanlarController(ICalisanRepository calisanRepository, AppDbContext appDbContext)
        {
            _calisanRepository = calisanRepository;
            _appDbContext = appDbContext;
        }

        [HttpPost("bordro")]
        public IActionResult GetBordro([FromBody] BordroInputModel model)
        {
            var response = _appDbContext.Calisan.FromSqlRaw($"exec GetBordro {model.Tc}").ToList();

            if (response.Count == 0)
            {
                return NotFound();
            }
            return Ok(response);

        }
    }
}
