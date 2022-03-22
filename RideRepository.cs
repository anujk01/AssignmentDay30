﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {

        Dictionary<string, List<Ride>> userRides = null;

        public RideRepository()
        {
        }

        public RideRepository(RideType nORMAL)
        {
            this.userRides = new Dictionary<string, List<Ride>>();
        }

        internal double AddRide()
        {
            throw new NotImplementedException();
        }

        public void AddRide(string userId, Ride[] rides)
        {
            bool rideList = this.userRides.ContainsKey(userId);
            try
            {
                if (!rideList)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.userRides.Add(userId, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Rides are null");
            }
        }


        public Ride[] GetRides(string userId)
        {
            try
            {
                return this.userRides[userId].ToArray();
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid user id");
            }
        }
    }
}