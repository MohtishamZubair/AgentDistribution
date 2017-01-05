using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgentDistribution.Repository.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public int? InvoiceId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public string Title { get; set; }
        public int? DeliveryTime { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? DeliveryDate { get; set; }    
        public string Notes { get; set; }
        public bool IsDelivered { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}