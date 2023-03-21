using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class DialogMapModel
    {
       public static List<Site> GetSites()
        {
            return new List<Site>() {
                new Site()
                {  Type=SiteType.ClientLocation,
                    Name="site1",
                    IsMapped=true,
                    Geolocation= new Geolocation2()
                    { Latitude= 33.811023,
                      Longitude =  35.536137},

                } ,
                new Site()
                {  Type=SiteType.ClientLocation,
                    Name="site2",
                    IsMapped=false,
                    Geolocation= new Geolocation2()
                    { Latitude=  33.858708,
                      Longitude =  35.543314},

                } ,
                new Site()
                {  Type=SiteType.FinalProductWarehouse,
                    Name="site3",
                    IsMapped=true,
                    Geolocation= new Geolocation2()
                    { Latitude= 33.792805, 
                      Longitude = 35.652296},

                } ,
                new Site()
                {  Type=SiteType.FinalProductWarehouse,
                    Name="site4",
                    IsMapped=false,
                    Geolocation= new Geolocation2()
                    { Latitude= 34.049832, 
                      Longitude = 35.670856},

                } ,
                new Site()
                {  Type=SiteType.Manufacturing,
                    Name="site5",
                    IsMapped=true,
                    Geolocation= new Geolocation2()
                    { Latitude= 33.821195, 
                      Longitude = 35.727721 },

                } ,
                 new Site()
                {  Type=SiteType.Manufacturing,
                    Name="site6",
                    IsMapped=false,
                    Geolocation= new Geolocation2()
                    { Latitude= 33.869427,
                      Longitude = 35.540578 },

                } ,
                  new Site()
                {  Type=SiteType.Port,
                    Name="site7",
                    IsMapped=true,
                    Geolocation= new Geolocation2()
                    { Latitude=  33.615688, 
                      Longitude = 35.514856},

                } ,
                   new Site()
                {  Type=SiteType.Port,
                    Name="site8",
                    IsMapped=false,
                    Geolocation= new Geolocation2()
                    { Latitude= 33.635635,
                      Longitude =  35.885568},

                } ,
                    new Site()
                {  Type=SiteType.RawMaterialWarehouse,
                    Name="site9",
                    IsMapped=true,
                    Geolocation= new Geolocation2()
                    { Latitude=  33.363826, 
                      Longitude = 35.465617},

                } ,
                     new Site()
                {  Type=SiteType.RawMaterialWarehouse,
                    Name="site10",
                    IsMapped=false,
                    Geolocation= new Geolocation2()
                    { Latitude=  33.367658, 
                      Longitude = 35.897199 },

                } ,
            };
        }
    }

}
