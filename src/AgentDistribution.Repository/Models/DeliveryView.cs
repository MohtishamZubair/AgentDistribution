using System;

namespace AgentDistribution.Repository.Models
{
    public class DeliveryView
    {
        public string AgentId    { get; set; }
        public int DeliveryId    { get; set; }
        public int InvoiceId    { get; set; }
        public bool IsDelivered { get; set; }
        public string Notes     { get; set; }
    }
}

namespace AgentDistribution.Repository.Models
{
    public class DeliveryManage
    {
        public int DeliveryId { get; set; }
        public int? InvoiceId { get; set; }        
        public string AgentId { get; set; }
        public string Title { get; set; }
        public int? DeliveryTime { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Notes { get; set; }
        public bool IsDelivered { get; set; }

    }
}