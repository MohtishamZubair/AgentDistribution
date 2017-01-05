using System;
using AgentDistribution.Repository.Models;

namespace AgentDistribution.Repository.Helper
{
    public class ModelHelper
    {
        public static Delivery GetDeliveryDomain(DeliveryManage dm)
        {
            return new Delivery
            {
                DeliveryId = dm.DeliveryId,
                InvoiceId = dm.InvoiceId,
                ApplicationUserId = dm.AgentId,
                Title = dm.Title,
                DeliveryTime = dm.DeliveryTime,
                CreatedOn = dm.CreatedOn,                
                DeliveryDate = dm.DeliveryDate,
                Notes = dm.Notes,
                IsDelivered = dm.IsDelivered
            };
        }

        public static DeliveryManage GetDeliveryManage(Delivery d)
        {
            return new DeliveryManage
                {
                    AgentId = d.ApplicationUserId,
                    DeliveryId = d.DeliveryId,
                    InvoiceId = d.InvoiceId,
                    Title = d.Title,
                    DeliveryTime = d.DeliveryTime,
                    CreatedOn = d.CreatedOn,
                    DeliveryDate = d.DeliveryDate,
                    IsDelivered = d.IsDelivered,
                    Notes = d.Notes
                };
        }
    }
}