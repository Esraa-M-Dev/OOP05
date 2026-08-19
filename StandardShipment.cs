using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP05
{
    internal class StandardShipment:Shipment,ITrackable
    {
        #region constructor
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        #endregion
        #region method
        public string GetTrackingStatus()
        {
            return $"shipment{TrackingCode} is ready";
        }
        #endregion

    }
}
