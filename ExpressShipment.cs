using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP05
{
    internal class ExpressShipment:Shipment,ITrackable
    {
        #region fields
        private decimal extraFee;
        #endregion
        #region properties
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }
        #endregion
        #region constructor
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        #endregion
        #region methods
        public string GetTrackingStatus()
        {
            return $"shipment{TrackingCode} is out of delivery";
        }
        #endregion
    }
}
