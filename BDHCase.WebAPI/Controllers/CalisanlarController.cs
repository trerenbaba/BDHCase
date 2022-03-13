using BDHCase.Persistence.Repo.Abstract;
using BDHCase.WebAPI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public CalisanlarController(ICalisanRepository calisanRepository)
        {
            _calisanRepository = calisanRepository;
        }

        [HttpPost("bordro")]
        public IActionResult GetBordro([FromBody] BordroRequestDto model)
        {
            var data = _calisanRepository.GetQuery();
            var response = _calisanRepository.GetSqlRawQuery($"exec GetBordro {model.Tc}");
            BordroResponseDto bordro = new BordroResponseDto
            {
                Ad = response.Ad,
                Soyad = response.Soyad,
                Tc = response.TC,
                Maas = response.Maas
            };

            return Ok(bordro);
        }
    }
}
