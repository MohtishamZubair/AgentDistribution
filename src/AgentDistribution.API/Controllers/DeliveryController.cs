using AgentDistribution.Repository;
using AgentDistribution.Repository.Helper;
using AgentDistribution.Repository.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;

namespace AgentDistribution.Controllers
{
    [RoutePrefix("api/Delivery")]
    public class DeliveryController : ApiController
    {
        AuthContext db = new AuthContext();

        //public IQueryable<Delivery> GetDeliveries()
        //{
        //    return db.Deliveries;
        //}
        //   http://localhost:63547/api/Delivery/ManageDeliveries

        [Route("ManageDeliveries")]
        [Authorize]
        public IHttpActionResult GetManageDeliveries()
        {
            return Ok(new
            {
                data =
                db.Deliveries.ToList().Select(d => ModelHelper.GetDeliveryManage(d))
            });
        }

        public IHttpActionResult GetDeliveries()
        {
            return Ok(new { data = Enumerable.Range(1, 5).Select(i => new DeliveryView { DeliveryId = i, AgentId = i.ToString(), InvoiceId = i, IsDelivered = false, Notes = string.Format("notes for {0}", i) }).ToList() });
        }

        // GET: api/Delivery/5
        [ResponseType(typeof(Delivery))]
        public IHttpActionResult GetDelivery(int id)
        {
            Delivery deliveryDomain = db.Deliveries.Find(id);
            if (deliveryDomain == null)
            {
                return NotFound();
            }

            return Ok(deliveryDomain);
        }


        // change type to delivery view with Automapper make change to Delivery
        //done
        // PUT: api/Delivery/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDelivery(int id, DeliveryView deliveryDomain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != deliveryDomain.DeliveryId)
            {
                return BadRequest();
            }

            Delivery delivery = db.Deliveries.Find(id);
            delivery.IsDelivered = deliveryDomain.IsDelivered;
            delivery.Notes = deliveryDomain.Notes;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException dup)
            {
                if (!DeliveryExists(id))
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

        // POST: api/Delivery
        [ResponseType(typeof(DeliveryManage))]
        public async Task<IHttpActionResult> PostDelivery(DeliveryManage deliveryManage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Delivery delivery = ModelHelper.GetDeliveryDomain(deliveryManage);
            delivery.CreatedOn = DateTime.Now;

            db.Deliveries.Add(delivery);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = deliveryManage.DeliveryId }, deliveryManage);
        }

        // DELETE: api/Delivery/5
        [ResponseType(typeof(Delivery))]
        public async Task<IHttpActionResult> DeleteDelivery(int id)
        {
            Delivery Delivery = db.Deliveries.Find(id);
            if (Delivery == null)
            {
                return NotFound();
            }

            db.Deliveries.Remove(Delivery);
            await db.SaveChangesAsync();

            return Ok(Delivery);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DeliveryExists(int id)
        {
            return db.Deliveries.Count(e => e.DeliveryId == id) > 0;
        }


    }
}
