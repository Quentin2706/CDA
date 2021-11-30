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
    public class VolController : ControllerBase
    {

        private readonly VolServices _service;
        private readonly IMapper _mapper;

        public VolController(VolServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Vol
        [HttpGet]
        public ActionResult<IEnumerable<VolDTO>> GetAllVol()
        {
            IEnumerable<Vol> listeVol = _service.GetAllVol();
            return Ok(_mapper.Map<IEnumerable<VolDTO>>(listeVol));
        }

        //GET api/Vol/{i}
        [HttpGet("{id}", Name = "GetVolById")]
        public ActionResult<VolDTO> GetVolById(int id)
        {
            Vol commandItem = _service.GetVolById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<VolDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Vol
        [HttpPost]
        public ActionResult<Vol> CreateVol(VolDTO obj)
        {
            Vol newObj = _mapper.Map<Vol>(obj);
            _service.AddVol(newObj);
            return CreatedAtRoute(nameof(GetVolById), new { Id = newObj.IdVol }, newObj);
        }

        //POST api/Vol/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateVol(int id, VolDTO obj)
        {
            Vol objFromRepo = _service.GetVolById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateVol(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Vol/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialVolUpdate(int id, JsonPatchDocument<Vol> patchDoc)
        {
            Vol objFromRepo = _service.GetVolById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Vol objToPatch = _mapper.Map<Vol>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateVol(objFromRepo);
            return NoContent();
        }

        //DELETE api/Vol/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteVol(int id)
        {
            Vol obj = _service.GetVolById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteVol(obj);
            return NoContent();
        }


    }
}
