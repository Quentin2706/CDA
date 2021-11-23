using ApiVoitures;
using APIVoitures.Data.Dtos;
using APIVoitures.Data.Models;
using APIVoitures.Data.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVoitures.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoituresController : ControllerBase
    {
        private readonly VoituresService _service;
        private readonly IMapper _mapper;

        public VoituresController(VoituresService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VoituresDTO>> GetAllVoitures()
        {
            IEnumerable<Voiture> listeVoitures = _service.GetAllVoitures();
            listeVoitures.Dump();
            return Ok(_mapper.Map<IEnumerable<VoituresDTO>>(listeVoitures));
        }


    }
}
