using AutoMapper;
using ECF.Data;
using ECF.Data.Dtos;
using ECF.Data.Models;
using ECF.Data.Profiles;
using ECF.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Controllers
{
    class GroupesController : ControllerBase
    {

        private readonly GroupeServices _service;
        private readonly IMapper _mapper;

        /* Modif */
        public GroupesController(EcfContext _context)
        {
            _service = new GroupeServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<GroupeProfiles>();
            });
            _mapper = config.CreateMapper();
        }

        //GET api/Groupe
        [HttpGet]
        public IEnumerable<GroupesDTOOut> GetAllGroupes() /* Modif */
        {
            IEnumerable<Groupe> listeGroupe = _service.GetAllGroupes();
            return _mapper.Map<IEnumerable<GroupesDTOOut>>(listeGroupe);
        }

        //GET api/Groupe/{i}
        [HttpGet("{id}", Name = "GetGroupeById")]
        public ActionResult<GroupesDTOOut> GetGroupeById(int id)
        {
            Groupe commandItem = _service.GetGroupeById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<GroupesDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Groupe
        [HttpPost]
        public ActionResult<GroupesDTOOut> CreateGroupe(GroupesDTOIn objIn)
        {
            Groupe obj = _mapper.Map<Groupe>(objIn);
            _service.AddGroupe(obj);
            return CreatedAtRoute(nameof(GetGroupeById), new { Id = obj.IdGroupe }, obj);
        }

        //POST api/Groupe/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateGroupe(int id, GroupesDTOIn obj)
        {
            Groupe objFromRepo = _service.GetGroupeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateGroupe(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Groupe/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialGroupeUpdate(int id, JsonPatchDocument<Groupe> patchDoc)
        {
            Groupe objFromRepo = _service.GetGroupeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Groupe objToPatch = _mapper.Map<Groupe>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateGroupe(objFromRepo);
            return NoContent();
        }

        //DELETE api/Groupe/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteGroupe(int id)
        {
            Groupe obj = _service.GetGroupeById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteGroupe(obj);
            return NoContent();
        }


    }
}
