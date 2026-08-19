using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP05
{
    internal class InternationalShipment:Shipment,ITrackable
    {
        #region fields
        private string destinationCountry = null!;
        private decimal customsFee;
        #endregion
        #region properties
        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }
        #endregion
        #region constructor
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        #endregion
        #region methods
        public string GetTrackingStatus()
        {
            return "Delivered";
        } 
        #endregion
    }
}
