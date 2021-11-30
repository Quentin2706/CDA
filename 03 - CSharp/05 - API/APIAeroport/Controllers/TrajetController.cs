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
    public class TrajetController : ControllerBase
    {

        private readonly TrajetServices _service;
        private readonly IMapper _mapper;

        public TrajetController(TrajetServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Trajet
        [HttpGet]
        public ActionResult<IEnumerable<TrajetDTO>> GetAllTrajet()
        {
            IEnumerable<Trajet> listeTrajet = _service.GetAllTrajet();
            return Ok(_mapper.Map<IEnumerable<TrajetDTO>>(listeTrajet));
        }

        //GET api/Trajet/{i}
        [HttpGet("{id}", Name = "GetTrajetById")]
        public ActionResult<TrajetDTO> GetTrajetById(int id)
        {
            Trajet commandItem = _service.GetTrajetById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<TrajetDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Trajet
        [HttpPost]
        public ActionResult<Trajet> CreateTrajet(TrajetDTO obj)
        {
            Trajet newObj = _mapper.Map<Trajet>(obj);
            _service.AddTrajet(newObj);
            return CreatedAtRoute(nameof(GetTrajetById), new { Id = newObj.IdTrajet }, newObj);
        }

        //POST api/Trajet/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateTrajet(int id, TrajetDTO obj)
        {
            Trajet objFromRepo = _service.GetTrajetById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateTrajet(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Trajet/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialTrajetUpdate(int id, JsonPatchDocument<Trajet> patchDoc)
        {
            Trajet objFromRepo = _service.GetTrajetById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Trajet objToPatch = _mapper.Map<Trajet>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateTrajet(objFromRepo);
            return NoContent();
        }

        //DELETE api/Trajet/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTrajet(int id)
        {
            Trajet obj = _service.GetTrajetById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteTrajet(obj);
            return NoContent();
        }


    }
}
