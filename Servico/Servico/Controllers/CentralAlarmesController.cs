using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Servico;

namespace Servico.Controllers
{
    public class CentralAlarmesController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/CentralAlarmes
        public IQueryable<CentralAlarme> GetCentralAlarme()
        {
            return db.CentralAlarme;
        }

        // GET: api/CentralAlarmes/5
        [ResponseType(typeof(CentralAlarme))]
        public IHttpActionResult GetCentralAlarme(int id)
        {
            CentralAlarme centralAlarme = db.CentralAlarme.Find(id);
            if (centralAlarme == null)
            {
                return NotFound();
            }

            return Ok(centralAlarme);
        }

        // PUT: api/CentralAlarmes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCentralAlarme(int id, CentralAlarme centralAlarme)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != centralAlarme.id)
            {
                return BadRequest();
            }

            db.Entry(centralAlarme).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CentralAlarmeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CentralAlarmes
        [ResponseType(typeof(CentralAlarme))]
        public IHttpActionResult PostCentralAlarme(CentralAlarme centralAlarme)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CentralAlarme.Add(centralAlarme);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = centralAlarme.id }, centralAlarme);
        }

        // DELETE: api/CentralAlarmes/5
        [ResponseType(typeof(CentralAlarme))]
        public IHttpActionResult DeleteCentralAlarme(int id)
        {
            CentralAlarme centralAlarme = db.CentralAlarme.Find(id);
            if (centralAlarme == null)
            {
                return NotFound();
            }

            db.CentralAlarme.Remove(centralAlarme);
            db.SaveChanges();

            return Ok(centralAlarme);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CentralAlarmeExists(int id)
        {
            return db.CentralAlarme.Count(e => e.id == id) > 0;
        }
    }
}