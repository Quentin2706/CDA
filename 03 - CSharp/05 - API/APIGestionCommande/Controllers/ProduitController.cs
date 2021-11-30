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
    public class ProduitController : ControllerBase
    {

        private readonly ProduitServices _service;
        private readonly IMapper _mapper;

        public ProduitController(ProduitServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Produit
        [HttpGet]
        public ActionResult<IEnumerable<ProduitDTO>> GetAllProduit()
        {
            IEnumerable<Produit> listeProduit = _service.GetAllProduit();
            return Ok(_mapper.Map<IEnumerable<ProduitPreparationDTO>>(listeProduit));
        }

        //GET api/Produit/{i}
        [HttpGet("{id}", Name = "GetProduitById")]
        public ActionResult<ProduitDTO> GetProduitById(int id)
        {
            Produit commandItem = _service.GetProduitById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ProduitPreparationDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Produit
        [HttpPost]
        public ActionResult<ProduitDTO> CreateProduit(ProduitDTO objIn)
        {
            Produit obj = _mapper.Map<Produit>(objIn);
            _service.AddProduit(obj);
            return CreatedAtRoute(nameof(GetProduitById), new { Id = obj.IdProduit }, obj);
        }

        //POST api/Produit/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateProduit(int id, ProduitDTO obj)
        {
            Produit objFromRepo = _service.GetProduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateProduit(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Produit/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialProduitUpdate(int id, JsonPatchDocument<Produit> patchDoc)
        {
            Produit objFromRepo = _service.GetProduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Produit objToPatch = _mapper.Map<Produit>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateProduit(objFromRepo);
            return NoContent();
        }

        //DELETE api/Produit/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteProduit(int id)
        {
            Produit obj = _service.GetProduitById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteProduit(obj);
            return NoContent();
        }


    }
}
