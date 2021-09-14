using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProcessoSeletivo.Presentation.Model;
using ProcessoSeletivoRhEstrategia.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessoSeletivo.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(PessoaCadastroModel model, 
            [FromServices] IPessoaRepository pessoaRepository)
        {
            try
            {
                var pessoa = new Pessoa();

                pessoa.Nome = model.Nome;
                pessoa.SobreNome = model.SobreNome;
                pessoa.Cidade = model.Cidade;
                pessoa.Cpf = model.Cpf;
                pessoa.Nacionalidade = model.Nacionalidade;
                pessoa.Cep = model.Cep;
                pessoa.Estado = model.Estado;
                pessoa.Logradouro = model.Logradouro;
                pessoa.Email = model.Email;
                pessoa.Telefone = model.Telefone;

                pessoaRepository.Create(pessoa);

                return Ok("Pessoa cadastrada com sucesso.");

            }
            catch (Exception e)
            {

                return StatusCode(500, "Ocorreu um erro" + e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(PessoaEdicaoModel model,
            [FromServices] IPessoaRepository pessoaRepository)
        {
            try
            {
                var pessoa = pessoaRepository.GetById(model.Id);
                if (pessoa != null)
                {
                    pessoa.Nome = model.Nome;
                    pessoa.SobreNome = model.SobreNome;
                    pessoa.Cidade = model.Cidade;
                    pessoa.Cpf = model.Cpf;
                    pessoa.Nacionalidade = model.Nacionalidade;
                    pessoa.Cep = model.Cep;
                    pessoa.Estado = model.Estado;
                    pessoa.Logradouro = model.Logradouro;
                    pessoa.Email = model.Email;
                    pessoa.Telefone = model.Telefone;

                    pessoaRepository.UpDate(pessoa);

                    return Ok("Dados Atualidado com sucesso ");
                }
                else
                {
                    return StatusCode(400, "Pessoa nao cadastrada no sistema");
                }                
            }
            catch (Exception e)
            {

                return StatusCode(500, "Ocorreu um erro" + e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id,
            [FromServices] IPessoaRepository pessoaRepository)
        {

            try
            {
                var pessoa = pessoaRepository.GetById(id);

                if (pessoa != null)
                {
                    pessoaRepository.Delete(pessoa);
                    return Ok("Pessoa Excluida com sucesso ");
                }
                else
                {
                    return StatusCode(400, "Pessoa nao cadastrada no sistema");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro" + e.Message);
            }
        }

        [ProducesResponseType(typeof(List<PessoaCadastroModel>), 200)]
        [HttpGet]
        public IActionResult GetAll([FromServices] IPessoaRepository pessoaRepository)
        {
            try
            {
                var consulta = pessoaRepository.GetAll();
                var result = new List<PessoaConsultaModel>();

                foreach (var item in consulta)
                {
                    var model = new PessoaConsultaModel();
                    model.Id = item.Id;
                    model.Nome = item.Nome;
                    model.SobreNome = item.SobreNome;
                    model.Cpf = item.Cpf;
                    model.Nacionalidade = item.Nacionalidade;
                    model.Cep = item.Cep;
                    model.Estado = item.Estado;
                    model.Cidade = item.Cidade;
                    model.Logradouro = item.Logradouro;
                    model.Email = item.Email;
                    model.Telefone = item.Telefone;

                    result.Add(model);

                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro" + e.Message);
            }
        }

        [ProducesResponseType(typeof(List<PessoaCadastroModel>), 200)]
        [HttpGet("{id}")]
        public IActionResult GetById(int id,
            [FromServices] IPessoaRepository pessoaRepository)
        {
            try
            {
                var pessoa = pessoaRepository.GetById(id);
                if (pessoa != null)
                {
                    var model = new PessoaConsultaModel();
                    model.Id = pessoa.Id;
                    model.Nome = pessoa.Nome;
                    model.SobreNome = pessoa.SobreNome;
                    model.Cpf = pessoa.Cpf;
                    model.Nacionalidade = pessoa.Nacionalidade;
                    model.Cep = pessoa.Cep;
                    model.Estado = pessoa.Estado;
                    model.Cidade = pessoa.Cidade;
                    model.Logradouro = pessoa.Logradouro;
                    model.Email = pessoa.Email;
                    model.Telefone = pessoa.Telefone;
                    return Ok(model);
                }
                else
                {
                    return StatusCode(400, "Pessoa nao cadastrada no sistema");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro" + e.Message);
            }
            
        }

    }
}
