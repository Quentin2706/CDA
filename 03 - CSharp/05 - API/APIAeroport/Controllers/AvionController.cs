﻿using APIAeroport.Data.Dtos;
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
    public class AvionController : ControllerBase
    {

        private readonly AvionServices _service;
        private readonly IMapper _mapper;

        public AvionController(AvionServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Avion
        [HttpGet]
        public ActionResult<IEnumerable<AvionDTO>> GetAllAvion()
        {
            IEnumerable<Avion> listeAvion = _service.GetAllAvion();
            return Ok(_mapper.Map<IEnumerable<AvionDTO>>(listeAvion));
        }

        //GET api/Avion/{i}
        [HttpGet("{id}", Name = "GetAvionById")]
        public ActionResult<AvionDTO> GetAvionById(int id)
        {
            Avion commandItem = _service.GetAvionById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<AvionDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Avion
        [HttpPost]
        public ActionResult<Avion> CreateAvion(AvionDTO obj)
        {
            Avion newObj = _mapper.Map<Avion>(obj);
            _service.AddAvion(newObj);
            return CreatedAtRoute(nameof(GetAvionById), new { Id = newObj.IdAvion }, newObj);
        }

        //POST api/Avion/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAvion(int id, AvionDTO obj)
        {
            Avion objFromRepo = _service.GetAvionById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAvion(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Avion/{id}
        //[HttpPatch("{id}")]
        //public ActionResult PartialAvionUpdate(int id, JsonPatchDocument<Avion> patchDoc)
        //{
        //    Avion objFromRepo = _service.GetAvionById(id);
        //    if (objFromRepo == null)
        //    {
        //        return NotFound();
        //    }
        //    Avion objToPatch = _mapper.Map<Avion>(objFromRepo);
        //    patchDoc.ApplyTo(objToPatch, ModelState);
        //    if (!TryValidateModel(objToPatch))
        //    {
        //        return ValidationProblem(ModelState);
        //    }
        //    _mapper.Map(objToPatch, objFromRepo);
        //    _service.UpdateAvion(objFromRepo);
        //    return NoContent();
        //}

        //DELETE api/Avion/{id}
        //[HttpDelete("{id}")]
        //public ActionResult DeleteAvion(int id)
        //{
        //    Avion obj = _service.GetAvionById(id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    _service.DeleteAvion(obj);
        //    return NoContent();
        //}


    }
}
