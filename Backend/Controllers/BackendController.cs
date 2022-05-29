using Backend.Data;
using Backend.Modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("[controller]/[action]")]
    public class BackendController : ControllerBase
    {
        private readonly BackendContext _context;
        public BackendController(BackendContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultaEstudiante()
        {
            return Ok(await _context.Estudiante.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AgregarEstudiante(Estudiante estudiante)
        {
            _context.Estudiante.Add(estudiante);
            await _context.SaveChangesAsync();
            return Ok(estudiante);
        }
        [HttpPut]
        public async Task<IActionResult> ActualizarEstudiante(Estudiante estudiante)
        {
            _context.Update(estudiante);
            await _context.SaveChangesAsync();
            return Ok(estudiante);
        }
        [HttpDelete]
        public async Task<IActionResult> BorrarEstudiante(Estudiante estudiante)
        {
            _context.Remove(estudiante);
            await _context.SaveChangesAsync();
            return Ok(estudiante);
        }



        [HttpGet]
        public async Task<IActionResult> ConsultaMascota()
        {
            return Ok(await _context.Mascota.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AgregarMascota(Mascota mascota)
        {
            _context.Mascota.Add(mascota);
            await _context.SaveChangesAsync();
            return Ok(mascota);
        }
        [HttpPut]
        public async Task<IActionResult> ActualizarMascota(Mascota mascota)
        {
            _context.Update(mascota);
            await _context.SaveChangesAsync();
            return Ok(mascota);
        }
        [HttpDelete]
        public async Task<IActionResult> BorrarMascota(Mascota mascota)
        {
            _context.Remove(mascota);
            await _context.SaveChangesAsync();
            return Ok(mascota);
        }
    }
}
