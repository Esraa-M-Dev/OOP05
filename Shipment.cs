using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP05
{
    internal class Shipment
    {
        #region fields
        private static int TotalShipmentsCreated = 0;
        private string trackingcode = null!;
        private string description = null!;
        private decimal weight;
        private decimal deliveryfee;
        #endregion
        #region properties
        public DeliveryAddress Destination
        {
            get;
            set;
        }

        public string TrackingCode
        {
            get { return trackingcode; }
            private set
            {

                if (!string.IsNullOrWhiteSpace(value))
                    trackingcode = value;



            }

        }
        public string Description
        {
            get { return description; }
            set
            {

                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }
        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryfee; }
            private set
            {
                if (value > 0)
                    deliveryfee = value;
            }
        }
        //abstract property
        //public abstract decimal EstimatedCost { get; }
        #endregion
        #region constructors
        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress("Unknown", "Unknown", 0))
        {

        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            TotalShipmentsCreated++;
        }
        //static constructor
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment system initialized");
        }
        //static method
       public static int GetTotalShipments()
        {
            return TotalShipmentsCreated;
        }
        #endregion
        #region methods
        //abstract method
       // public abstract void PrintShipment();

        //coping object
        //manual coping(Q1)
        public Shipment CopyShipment()
        {

            return new Shipment(this.TrackingCode, this.Description, this.Weight, this.DeliveryFee, this.Destination);
            
        } 
        //shallow coping(Q2)
        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }
        //Deep copy
        public Shipment DeepCopy()
        {
            return new Shipment(this.TrackingCode, this.Description, this.Weight, this.DeliveryFee, new DeliveryAddress(this.Destination.City,this.Destination.Street,this.Destination.BuildingNumber));

        }

        #endregion
    }
}
