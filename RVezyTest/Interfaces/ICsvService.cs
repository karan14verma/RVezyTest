using RVezyTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RVezyTest.Interfaces
{
    public interface ICsvService
    {
        IEnumerable<Listing> GetValues();
        IEnumerable<Listing> GetValuesByPropertyType(string property_type);
    }
}
