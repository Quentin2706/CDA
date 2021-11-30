using APIGestionCommande.Data.Dtos;
using APIGestionCommande.Data.Models;
using APIGestionCommande.Data.Services;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGestionCommande.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreparationController : ControllerBase
    {

        private readonly PreparationServices _service;
        private readonly IMapper _mapper;

        public PreparationController(PreparationServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Preparation
        [HttpGet]
        public ActionResult<IEnumerable<PreparationDTOListe>> GetAllPreparation()
        {
            IEnumerable<Preparation> listePreparation = _service.GetAllPreparation();
            return Ok(_mapper.Map<IEnumerable<PreparationDTOListe>>(listePreparation));
        }

        //GET api/Preparation/{i}
        [HttpGet("{id}", Name = "GetPreparationById")]
        public ActionResult<PreparationDTOListe> GetPreparationById(int id)
        {
            Preparation commandItem = _service.GetPreparationById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<PreparationDTOListe>(commandItem));
            }
            return NotFound();
        }

        //POST api/Preparation
        [HttpPost]
        public ActionResult<PreparationDTOListe> CreatePreparation(PreparationDTO objIn)
        {
            Preparation obj = _mapper.Map<Preparation>(objIn);
            _service.AddPreparation(obj);
            return CreatedAtRoute(nameof(GetPreparationById), new { Id = obj.IdPreparation }, obj);
        }

        //POST api/Preparation/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePreparation(int id, PreparationDTO obj)
        {
            Preparation objFromRepo = _service.GetPreparationById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdatePreparation(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Preparation/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialPreparationUpdate(int id, JsonPatchDocument<Preparation> patchDoc)
        {
            Preparation objFromRepo = _service.GetPreparationById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Preparation objToPatch = _mapper.Map<Preparation>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdatePreparation(objFromRepo);
            return NoContent();
        }

        //DELETE api/Preparation/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePreparation(int id)
        {
            Preparation obj = _service.GetPreparationById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeletePreparation(obj);
            return NoContent();
        }


    }
}
