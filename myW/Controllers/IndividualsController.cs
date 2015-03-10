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
using MyW.Models;

namespace MyW.Controllers
{
    public class IndividualsController : ApiController
    {
        private MeasurementContext db = new MeasurementContext();

        // GET: api/Individuals
        public IQueryable<Individual> GetIndividuals()
        {
            return db.Individuals;
        }

        // GET: api/Individuals/5
        [ResponseType(typeof(Individual))]
        public IHttpActionResult GetIndividual(long id)
        {
            Individual individual = db.Individuals.Find(id);
            if (individual == null)
            {
                return NotFound();
            }

            return Ok(individual);
        }

        // PUT: api/Individuals/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIndividual(long id, Individual individual)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != individual.Id)
            {
                return BadRequest();
            }

            db.Entry(individual).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndividualExists(id))
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

        // POST: api/Individuals
        [ResponseType(typeof(Individual))]
        public IHttpActionResult PostIndividual(Individual individual)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Individuals.Add(individual);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = individual.Id }, individual);
        }

        // DELETE: api/Individuals/5
        [ResponseType(typeof(Individual))]
        public IHttpActionResult DeleteIndividual(long id)
        {
            Individual individual = db.Individuals.Find(id);
            if (individual == null)
            {
                return NotFound();
            }

            db.Individuals.Remove(individual);
            db.SaveChanges();

            return Ok(individual);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IndividualExists(long id)
        {
            return db.Individuals.Count(e => e.Id == id) > 0;
        }
    }
}