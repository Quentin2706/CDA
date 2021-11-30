using APIAeroport.Data.Dtos;
using APIAeroport.Data.Models;
using APIAeroport.Data.Services;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiloteController : ControllerBase
    {

        private readonly PiloteServices _service;
        private readonly IMapper _mapper;

        public PiloteController(PiloteServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Pilote
        [HttpGet]
        public ActionResult<IEnumerable<PiloteDTO>> GetAllPilote()
        {
            IEnumerable<Pilote> listePilote = _service.GetAllPilote();
            return Ok(_mapper.Map<IEnumerable<PiloteDTO>>(listePilote));
        }

        //GET api/Pilote/{i}
        [HttpGet("{id}", Name = "GetPiloteById")]
        public ActionResult<PiloteDTO> GetPiloteById(int id)
        {
            Pilote commandItem = _service.GetPiloteById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<PiloteDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Pilote
        [HttpPost]
        public ActionResult<Pilote> CreatePilote(PiloteDTO obj)
        {
            Pilote newObj = _mapper.Map<Pilote>(obj);
            _service.AddPilote(newObj);
            return CreatedAtRoute(nameof(GetPiloteById), new { Id = newObj.IdPilote }, newObj);
        }

        //POST api/Pilote/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePilote(int id, PiloteDTO obj)
        {
            Pilote objFromRepo = _service.GetPiloteById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdatePilote(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Pilote/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialPiloteUpdate(int id, JsonPatchDocument<Pilote> patchDoc)
        {
            Pilote objFromRepo = _service.GetPiloteById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Pilote objToPatch = _mapper.Map<Pilote>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdatePilote(objFromRepo);
            return NoContent();
        }

        //DELETE api/Pilote/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePilote(int id)
        {
            Pilote obj = _service.GetPiloteById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeletePilote(obj);
            return NoContent();
        }


    }
}
