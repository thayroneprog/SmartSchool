using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {    
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Tijolim",
                Sobrenome = "Silva",
                Telefone = "123456"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "teste2",
                Sobrenome = "Silva",
                Telefone = "123456"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "teste3",
                Sobrenome = "Silva",
                Telefone = "123456"
            },
        };
        public AlunoController() {}
        
        #region GET

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if(aluno == null)
            {
                return BadRequest("Aluno não encontrado por id.");
            }
            return Ok(aluno);
        }

        [HttpGet("byNome/{nome}")]
        public IActionResult GetByFirstName(string nome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
            if(aluno == null)
            {
                return BadRequest("Aluno não encontrado por nome.");
            }
            return Ok(aluno);
        }

        [HttpGet("byNomeSobrenome/{nome}")]
        public IActionResult GetByFirstNameAndLastName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
            if(aluno == null)
            {
                return BadRequest("Aluno não encontrado por nome e sobrenome.");
            }
            return Ok(aluno);
        }
        #endregion
        #region POST

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        #endregion       
        #region PUT

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        #endregion
        #region PATCH

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        #endregion
        #region DELETE

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        #endregion
    }
}