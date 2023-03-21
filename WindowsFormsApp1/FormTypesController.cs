using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOPTerminalView.Providers.MapProvider
{
  public  class FormTypesController
    {
    }

    public class LocationInfo
    {
        public ILocationSite LocationSite { get; set; }
        public SiteType SType { get; set; }
        public bool IsSelected { get; set; }
        public string Name { get; set; }
    }

    public interface ILocationSite
    {
        List<LinkedLocation> LinkedLocations { get; set; }
        GeoLocation Location { get; set; }
    }

    public enum SiteType
    {
        Manufacturing = 0,
        RawMaterialWarehouse = 1,
        FinalProductWarehouse = 2,
        ClientLocation = 3,
        SupplierLocation = 4
    }

    [Serializable]
    public class GeoLocation
    {
        [ReadOnly(true)]
        public double Latitude { get; set; }

        [ReadOnly(true)]
        public double Lontitude { get; set; }

        [ReadOnly(true)]
        public string Country { get; set; }

        [ReadOnly(true)]
        public string CountryCode2Digits { get; set; }

        [ReadOnly(true)]
        public string Region { get; set; }

        [ReadOnly(true)]
        public string City { get; set; }

        [ReadOnly(true)]
        public string SubRegion { get; set; }

        [ReadOnly(true)]
        public string AddressLine { get; set; }

        [ReadOnly(true)]
        public string PostalCode { get; set; }
    }

    [Serializable]
    public class LinkedLocation : SOPDataItemSimple, ICloneable
    {
        [DisplayName("Location")]
        public new string Name { get; set; }

        [Browsable(false)]
        public string IdLocation { get; set; }

        [ReadOnly(true)]
        public double BySea { get; set; }

        [ReadOnly(true)]
        public double ByAir { get; set; }

        [ReadOnly(true)]
        public double ByTruck { get; set; }

        public object Clone()
        {
            return new LinkedLocation()
            {
                Id = Id,
                Name = Name,
                IdLocation = IdLocation,
                BySea = BySea,
                ByAir = ByAir,
                ByTruck = ByTruck
            };
        }
    }

  


    public class SOPDataItemSimple
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class TestLocation : ILocationSite
    {
        public List<LinkedLocation> LinkedLocations { get ; set ; }
        public GeoLocation Location { get ; set ; }
    }

}
