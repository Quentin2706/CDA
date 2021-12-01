using AutoMapper;
using GestionStock.Data;
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
    class ArticleController : ControllerBase
    {

        private readonly ArticleServices _service;
        private readonly IMapper _mapper;

        public ArticleController(ArticleServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ArticleController(GestionStockContext ctx, IMapper mapper)
        {
            _service = new ArticleServices(ctx);
            _mapper = mapper;
        }

        //GET api/Article
        [HttpGet]
        public IEnumerable<ArticleDTOOut> GetAllArticle()
        {
            IEnumerable<Article> listeArticle = _service.GetAllArticle();
            return _mapper.Map<IEnumerable<ArticleDTOOut>>(listeArticle);
        }

        //GET api/Article/{i}
        [HttpGet("{id}", Name = "GetArticleById")]
        public ActionResult<ArticleDTOOut> GetArticleById(int id)
        {
            Article commandItem = _service.GetArticleById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ArticleDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Article
        [HttpPost]
        public ActionResult<ArticleDTOOut> CreateArticle(ArticleDTOIn objIn)
        {
            Article obj = _mapper.Map<Article>(objIn);
            _service.AddArticle(obj);
            return CreatedAtRoute(nameof(GetArticleById), new { Id = obj.IdArticle }, obj);
        }

        //POST api/Article/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateArticle(int id, ArticleDTOIn obj)
        {
            Article objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Article/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialArticleUpdate(int id, JsonPatchDocument<Article> patchDoc)
        {
            Article objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Article objToPatch = _mapper.Map<Article>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }

        //DELETE api/Article/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteArticle(int id)
        {
            Article obj = _service.GetArticleById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteArticle(obj);
            return NoContent();
        }


    }
}
