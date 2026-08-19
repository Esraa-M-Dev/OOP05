using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP05
{
    internal class DeliveryAddress
    {
        #region Properties
        public string City;
        public string Street;
        public int BuildingNumber;
        #endregion
        #region constructor
        public DeliveryAddress(string city, string street, int number)
        {
            City = city;
            Street = street;
            BuildingNumber = number;
        }
        #endregion
        #region Methods
        public string GetFullAddress()
        {
            string CompleteAddress = $"{BuildingNumber} {Street} , {City}";
            return CompleteAddress;
        }
        #endregion
    }
}
