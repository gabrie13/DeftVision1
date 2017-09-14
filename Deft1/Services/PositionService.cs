using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Deft1.Models;
using System.Data.Entity;

namespace Deft1.Services
{
    public class PositionService : IPositionService
    {
        private DeftDB db = new DeftDB();

        public List<PositionViewModel> GetAll()
        {

            var positionList = db.Positions.ToList();
            return positionList.Select(pos => PosDto(pos)).ToList();
        }

        private static PositionViewModel PosDto(Position pos)
        {
            return new PositionViewModel
            {
                PositionId    = pos.PositionId,
                PositionTitle = pos.PositionTitle
            };
        }
    }
}