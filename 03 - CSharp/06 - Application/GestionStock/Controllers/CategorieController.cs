using AutoMapper;
using GestionStock.Data.Dtos;
using GestionStock.Data.Models;
using GestionStock.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Controllers
{
    class CategorieController : ControllerBase
    {

        private readonly CategorieServices _service;
        private readonly IMapper _mapper;

        public CategorieController(CategorieServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Categorie
        [HttpGet]
        public ActionResult<IEnumerable<CategorieDTOOut>> GetAllCategorie()
        {
            IEnumerable<Categorie> listeCategorie = _service.GetAllCategorie();
            return Ok(_mapper.Map<IEnumerable<CategorieDTOOut>>(listeCategorie));
        }

        //GET api/Categorie/{i}
        [HttpGet("{id}", Name = "GetCategorieById")]
        public ActionResult<CategorieDTOOut> GetCategorieById(int id)
        {
            Categorie commandItem = _service.GetCategorieById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CategorieDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Categorie
        [HttpPost]
        public ActionResult<CategorieDTOOut> CreateCategorie(CategorieDTOIn objIn)
        {
            Categorie obj = _mapper.Map<Categorie>(objIn);
            _service.AddCategorie(obj);
            return CreatedAtRoute(nameof(GetCategorieById), new { Id = obj.IdCategorie }, obj);
        }

        //POST api/Categorie/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCategorie(int id, CategorieDTOIn obj)
        {
            Categorie objFromRepo = _service.GetCategorieById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCategorie(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Categorie/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCategorieUpdate(int id, JsonPatchDocument<Categorie> patchDoc)
        {
            Categorie objFromRepo = _service.GetCategorieById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Categorie objToPatch = _mapper.Map<Categorie>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCategorie(objFromRepo);
            return NoContent();
        }

        //DELETE api/Categorie/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCategorie(int id)
        {
            Categorie obj = _service.GetCategorieById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCategorie(obj);
            return NoContent();
        }


    }
}
