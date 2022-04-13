using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApiBlazor.Models;
using ToDoApiBlazor.Models.Request;
using ToDoApiBlazor.Models.Response;

namespace ToDoApiBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Main>> oRespuesta = new Respuesta<List<Main>>();

            try
            {
                using (TODOdbContext db = new TODOdbContext())
                {
                    var lst = db.Mains.ToList();
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            

            return Ok(oRespuesta);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            Respuesta<Main> oRespuesta = new Respuesta<Main>();

            try
            {
                using (TODOdbContext db = new TODOdbContext())
                {
                    var lst = db.Mains.Find(Id);
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }


            return Ok(oRespuesta);
        }

        [HttpPost]
        public IActionResult Add(MainRequest model)
        {
            Respuesta<List<Main>> oRespuesta = new Respuesta<List<Main>>();

            try
            {
                using (TODOdbContext db = new TODOdbContext())
                {
                    Main oMain = new Main();
                    oMain.Titulo = model.Titulo;
                    oMain.Descripcion = model.Descripcion;
                    db.Mains.Add(oMain);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }


            return Ok(oRespuesta);
        }

        [HttpPut]
        public IActionResult Edit(MainRequest model)
        {
            Respuesta<List<Main>> oRespuesta = new Respuesta<List<Main>>();

            try
            {
                using (TODOdbContext db = new TODOdbContext())
                {
                    Main oMain = db.Mains.Find(model.Id);
                    oMain.Titulo = model.Titulo;
                    oMain.Descripcion = model.Descripcion;
                    db.Entry(oMain).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }


            return Ok(oRespuesta);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            Respuesta<List<Main>> oRespuesta = new Respuesta<List<Main>>();

            try
            {
                using (TODOdbContext db = new TODOdbContext())
                {
                    Main oMain = db.Mains.Find(Id);
                    db.Remove(oMain);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }


            return Ok(oRespuesta);
        }
    }
}
