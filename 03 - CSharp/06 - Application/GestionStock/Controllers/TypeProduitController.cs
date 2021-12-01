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
    class TypeProduitController : ControllerBase
    {

        private readonly TypeProduitServices _service;
        private readonly IMapper _mapper;

        public TypeProduitController(TypeProduitServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/TypeProduit
        [HttpGet]
        public ActionResult<IEnumerable<TypeProduitDTOOut>> GetAllTypeProduit()
        {
            IEnumerable<TypeProduit> listeTypeProduit = _service.GetAllTypeProduit();
            return Ok(_mapper.Map<IEnumerable<TypeProduitDTOOut>>(listeTypeProduit));
        }

        //GET api/TypeProduit/{i}
        [HttpGet("{id}", Name = "GetTypeProduitById")]
        public ActionResult<TypeProduitDTOOut> GetTypeProduitById(int id)
        {
            TypeProduit commandItem = _service.GetTypeProduitById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<TypeProduitDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/TypeProduit
        [HttpPost]
        public ActionResult<TypeProduitDTOOut> CreateTypeProduit(TypeProduitDTOIn objIn)
        {
            TypeProduit obj = _mapper.Map<TypeProduit>(objIn);
            _service.AddTypeProduit(obj);
            return CreatedAtRoute(nameof(GetTypeProduitById), new { Id = obj.IdTypeProduit }, obj);
        }

        //POST api/TypeProduit/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateTypeProduit(int id, TypeProduitDTOIn obj)
        {
            TypeProduit objFromRepo = _service.GetTypeProduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateTypeProduit(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/TypeProduit/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialTypeProduitUpdate(int id, JsonPatchDocument<TypeProduit> patchDoc)
        {
            TypeProduit objFromRepo = _service.GetTypeProduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            TypeProduit objToPatch = _mapper.Map<TypeProduit>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateTypeProduit(objFromRepo);
            return NoContent();
        }

        //DELETE api/TypeProduit/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTypeProduit(int id)
        {
            TypeProduit obj = _service.GetTypeProduitById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteTypeProduit(obj);
            return NoContent();
        }


    }
}
