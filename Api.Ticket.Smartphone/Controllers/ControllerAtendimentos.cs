using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes;
using AtendimentosSD;
using ClasseDeTabela;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Atendimentos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerAtendimentos : ControllerBase
    {


        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            return Ok();

        }

        // POST api/<ValuesController>
        [HttpPost]
        //public ActionResult PostAtendimento(int id)
        //{
        //    //var NomeDoUsuario = new Atendimento{ NomeDoUsuario = "Elias.souza" };
        //    //using (var contexto = new Ticketcontext())
        //    //{
        //    //    contexto.Add(NomeDoUsuario);
        //    //    contexto.SaveChanges();
        //    //}
        //    //return Ok();

        //    DateTime DataAtual = DateTime.Now;
        //    Atendimento Salvar = new Atendimento();

        //    Salvar.Analista = "Thiago.Giovanne";
        //    Salvar.NomeDoUsuario = "Marcia.Fonseca";
        //    Salvar.Ticket = 34221332 ;
        //    Salvar.Descricao = "instalação de certificado";
        //    Salvar.Filial = "Sertãozinho";
        //    Salvar.Data = DataAtual.ToString();

        //    using (var contexto = new Ticketcontext())
        //    {
        //        contexto.Add(Salvar);
        //        contexto.SaveChanges();
        //    }

        //    return Ok();
        //}
        public ActionResult PostDeltaLog(int id)
        {

            TblAtendimentoDeltaLog Salvar = new TblAtendimentoDeltaLog();

            Salvar.Motorista = "Joao.Catastrofe";
            Salvar.Monitor = "Caio";
            Salvar.Shift = "SH012345";
            Salvar.Placa = "BAX-9817";
            Salvar.Imei = 847329;
            Salvar.Analista = "Lucas.Coelho";
            Salvar.Origem = "DeltaLog";
            Salvar.Problema = "Tela Branca, Aparelho travado";
            Salvar.Acao = "limpar os dados do Armazenamento";

            using (var contexto = new Ticketcontext())
            {
                contexto.Add(Salvar);
                contexto.SaveChanges();
            }

            return Ok();
        }

        // PUT api/<ControllerAtendimentos>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ControllerAtendimentos>/5
        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            Atendimento Excluir = new Atendimento();
            Excluir.Id = 7;

            using (var contexto = new Ticketcontext())
            {
                contexto.Remove(Excluir);
                contexto.SaveChanges();
            }
        }
    }
}
