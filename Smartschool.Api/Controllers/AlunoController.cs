using Microsoft.AspNetCore.Mvc;
using Smartschool.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Smartschool.Api.Controllers
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
                Nome = "Andre",
                Sobrenome = "Pereira",
                Telefone = "3840401010"

            },
            new Aluno()
            {
            Id = 2,
            Nome = "Arthur",
            Sobrenome = "Santos",
            Telefone = "38988098788"

            },
            new Aluno()
            {
                Id = 3,
                Nome = "Mírian",
                Sobrenome = "Raquel",
                Telefone = "38991483239"

            },
         };

        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById( int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
                return NotFound("Aluno não encontrado!");
            
            return Ok(aluno);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome,string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome) );
            if (aluno == null)
                return NotFound("Aluno não encontrado!");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id )
        {
            return Ok();
        }
    }
}