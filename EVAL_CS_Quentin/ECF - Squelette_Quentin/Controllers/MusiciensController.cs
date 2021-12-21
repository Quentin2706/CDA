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
    class MusiciensController : ControllerBase
    {

        private readonly MusicienServices _service;
        private readonly IMapper _mapper;

        public MusiciensController(EcfContext _context)
        {
            _service = new MusicienServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MusicienProfiles>();
            });
            _mapper = config.CreateMapper();
        }

        //GET api/Musicien
        [HttpGet]
        public IEnumerable<MusiciensDTOOut> GetAllMusiciens() /* Modif */
        {
            IEnumerable<Musicien> listeMusicien = _service.GetAllMusiciens();
            return _mapper.Map<IEnumerable<MusiciensDTOOut>>(listeMusicien);
        }

        [HttpGet]
        public IEnumerable<MusiciensDTOOutAvecGroupe> GetAllMusiciensAvecGroupe() /* Modif */
        {
            IEnumerable<Musicien> listeMusicien = _service.GetAllMusiciensAvecGroupe();
            return _mapper.Map<IEnumerable<MusiciensDTOOutAvecGroupe>>(listeMusicien);
        }

        //GET api/Musicien/{i}
        [HttpGet("{id}", Name = "GetMusicienById")]
        public ActionResult<MusiciensDTOOut> GetMusicienById(int id)
        {
            Musicien commandItem = _service.GetMusicienById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<MusiciensDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Musicien
        [HttpPost]
        public ActionResult<MusiciensDTOOut> CreateMusicien(MusiciensDTOIn objIn)
        {
            Musicien obj = _mapper.Map<Musicien>(objIn);
            _service.AddMusicien(obj);
            return CreatedAtRoute(nameof(GetMusicienById), new { Id = obj.IdMusicien }, obj);
        }

        //POST api/Musicien/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateMusicien(int id, MusiciensDTOIn obj)
        {
            Musicien objFromRepo = _service.GetMusicienById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateMusicien(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Musicien/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialMusicienUpdate(int id, JsonPatchDocument<Musicien> patchDoc)
        {
            Musicien objFromRepo = _service.GetMusicienById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Musicien objToPatch = _mapper.Map<Musicien>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateMusicien(objFromRepo);
            return NoContent();
        }

        //DELETE api/Musicien/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMusicien(int id)
        {
            Musicien obj = _service.GetMusicienById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteMusicien(obj);
            return NoContent();
        }


    }
}
