using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.Paint;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;

namespace WindowsFormsApp1
{
    class DialogMapController
    {
    }

    public class Site
    {
        public string Name { get; set; }
        public SiteType Type { get; set; }
        public bool IsMapped { get; set; }
        public Geolocation2 Geolocation { get; set; }
    }

    public enum SiteType
    {
        Manufacturing,
        RawMaterialWarehouse,
        FinalProductWarehouse,
        ClientLocation,
        Port
    }

    public class Geolocation2
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
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

    public enum SiteType2
    {
        Manufacturing = 0,
        RawMaterialWarehouse = 1,
        FinalProductWarehouse = 2,
        ClientLocation = 3,
        SupplierLocation = 4
    }

    [Serializable]
    public class GeoLocation2
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
    }


    public class SOPDataItemSimple
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
