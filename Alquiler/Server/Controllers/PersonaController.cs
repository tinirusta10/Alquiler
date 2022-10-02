using Context;
using Context.Data.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Alquiler.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        private readonly Bdcontext context;

        public PersonaController(Bdcontext context)
        {
            this.context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Persona>> Get(int id)
        {
            var dato = await context.Personas
                                         .Where(l => l.Id == id)
                                         
                                         .FirstOrDefaultAsync();

            if (dato == null)
            {
                return NotFound($"No existe persona de id: {id}");
            }
            return dato;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Post(Persona persona)
        {
            try
            {
                context.Personas.Add(persona);
                await context.SaveChangesAsync();
                return persona.Id;
            }
            catch (Exception l)
            {
                return BadRequest(l.Message);
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Persona persona)
        {


            if (id != persona.Id)
            {
                return BadRequest("No existe la persona");
            }

            var person = context.Personas.Where(l => l.Id == id).FirstOrDefault();
           

            if (person == null)
            {
                return NotFound("No existe la persona");
            }

            person.Nombre = persona.Nombre;
            person.Apellido = persona.Apellido;
            person.DNI = persona.DNI;
            person.Mail = persona.Mail;
            person.NumeroTelefono = persona.NumeroTelefono;
            person.DNI = persona.DNI;
            person.TipoDocumentoId = persona.TipoDocumentoId;
            person.ProvinciaId = persona.ProvinciaId;
            person.Barrio = persona.Barrio;
            person.Piso = persona.Piso;
            person.DepartamentoId = persona.DepartamentoId;
            person.calle = persona.calle;
            person.Depto = persona.Depto;
            person.LocalidadId = persona.LocalidadId;
            person.Altura = persona.Altura;
            person.CP = persona.CP;

            try
            {
                //throw(new Exception("Cualquier Verdura"));
                context.Personas.Update(person);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception l)
            {
                return BadRequest($"Los datos no han sido actualizados por: {l.Message}");
            }
        }



        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var person = context.Personas.Where(x => x.Id == id).FirstOrDefault();

            if (person == null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }

            try
            {
                context.Personas.Remove(person);
                context.SaveChanges();
                return Ok($"El registro de {person.Nombre} ha sido borrado.");
            }
            catch (Exception l)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {l.Message}");
            }
        }

    }
}