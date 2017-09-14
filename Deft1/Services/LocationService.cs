using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Deft1.Models;

namespace Deft1.Services
{
    public class LocationService : ILocationService
    {
        private DeftDB db = new DeftDB();

        public List<LocationViewModel> GetAll()
        {
            var locationList = db.Locations.ToList();
            return locationList.Select(loc => LocDto(loc)).ToList();
        }

        private static LocationViewModel LocDto(Location loc)
        {
            return new LocationViewModel
            {
                LocationId     = loc.LocationId,
                LocationName   = loc.LocationName,
                Phone          = loc.Phone,
                Email          = loc.Email,
                Address        = loc.Address,
                City           = loc.City,
                State          = loc.State,
                ZipCode        = loc.ZipCode,
                OperationDay   = loc.OperationDay,
                OperationHours = loc.OperationHours
            };
        }

        public LocationViewModel FindById(int id)
        {
            var location = db.Locations.Find(id);
            return location != null ? LocDto(location) : null;
        }

    }
}