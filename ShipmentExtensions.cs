using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP05
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string shipmentType = shipment.GetType().Name.Replace("Shipment", "");

            ITrackable trackable = (ITrackable)shipment;

            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} KG | {trackable.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            ITrackable trackable = (ITrackable)shipment;

            return trackable.GetTrackingStatus() == "Delivered";
        }
    }
}
