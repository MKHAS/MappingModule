using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;
using Telerik.WinControls.UI.Map.Bing;
using WindowsFormsApp1;

namespace SOPTerminalView.Providers.MapProvider
{

    public class MapProvider
    {
        string bingkey = "tmUi6YgGTfsr5R4cj2Ru~ZpfA96ifmO0tKaTHvsnEWQ~Ap8rnRFA9C269eCWa-ZZSoZJ38gFhIJxeMw1KcGI54iko2l22-ATc47tBy2V6DoV";
        RadMap map;
        BingRestMapProvider bingProvider;
        MapLayer pointLayer;
        public delegate void UpdateGeoInfo(GeoLocation _location);
        public UpdateGeoInfo UpdategeoInfoOnForm;
       public GeoLocation newSelectedLocation { get; set; }
        public MapProvider(RadMap _map) 
        { 
            map = _map;
            newSelectedLocation = null;
            LoadMapProvider();
            LoadLayers();

            _map.MouseDoubleClick += radMap_MouseDoubleClickAsync;
        }


        public void LoadMapProvider()
        {
            string cacheFolder = @"..\..\cache1";
            bingProvider = new Telerik.WinControls.UI.BingRestMapProvider();
            bingProvider.UseSession = true;
            bingProvider.BingKey = bingkey;
            LocalFileCacheProvider cache = new LocalFileCacheProvider(cacheFolder);
            bingProvider.CacheProvider = cache;
            // bingProvider.ImagerySet = Telerik.WinControls.UI.Map.Bing.ImagerySet.AerialWithLabels;
            map.MapElement.Providers.Add(bingProvider);
        }

        public void LoadLayers()
        {
            pointLayer = new MapLayer("PointG");
            map.MapElement.Layers.Add(pointLayer);

        }

        public async void LocationCountryOnMap(string _country)
        {
           await getAsync(_country);
         
        }

        public async Task getAsync(string _country)
        {
            BingMapsRESTService.Response r = await GetGeoInfoByCountry(_country);

            map.MapElement.BringIntoView(new Telerik.WinControls.UI.Map.RectangleG(((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).BoundingBox[0],
                ((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).BoundingBox[1],
                ((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).BoundingBox[2],
                ((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).BoundingBox[3]));

        }
        public void LocationOnMap(GeoLocation selectedLocation,bool _zoomIn)
        {
           MapPin pin = new(new Telerik.WinControls.UI.Map.PointG(selectedLocation.Latitude, selectedLocation.Lontitude));
            pin.Text = "ssss";
            pin.ToolTipText = "jkjlj";

            pointLayer.Add(pin);

            if (_zoomIn)
            {
                map.MapElement.EnableZooming = true;
               //
                map.MapElement.Pan(new SizeL(20, 20));
                map.MapElement.BringIntoView(new Telerik.WinControls.UI.Map.PointG(selectedLocation.Latitude, selectedLocation.Lontitude), 12);
                //  map.MapElement.Center = new Telerik.WinControls.UI.Map.PointG(selectedLocation.Latitude, selectedLocation.Lontitude);
                map.MapElement.Center = new Telerik.WinControls.UI.Map.PointG(selectedLocation.Latitude, selectedLocation.Lontitude);
               // map.MapElement.Zoom(12, true);
               

            }
        }


        private  void radMap_MouseDoubleClickAsync(object sender, MouseEventArgs e)
        {


            SetNewLocation(sender, e);
        }

        private async Task<BingMapsRESTService.Response> GetGeoInfoByCountry(string  _country)
        {
            try
            {

                string URL = "http://dev.virtualearth.net/REST/v1/Locations?countryRegion="+_country+"&key=" + bingkey;
                Uri geocodeRequest = new Uri(URL);
                return await GetResponse(geocodeRequest);

                //while (r == null)
                //    Thread.Sleep(10);

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private async Task<BingMapsRESTService.Response> GetGeoInfoByLocation(PointG _location)
        {
            try
            {

                string URL = "http://dev.virtualearth.net/REST/v1/Locations/"+_location.Latitude+","+_location.Longitude+ "?include=ciso2&key=" + bingkey;
                Uri geocodeRequest = new Uri(URL);
                return await GetResponse(geocodeRequest);

                //while (r == null)
                //    Thread.Sleep(10);

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public async void SetNewLocation(object sender, MouseEventArgs e)
        {
            RadMap map = (RadMap)sender;
            PointL point = new PointL(e.X - map.MapElement.PanOffset.Width, e.Y - map.MapElement.PanOffset.Height);
            PointG location = MapTileSystemHelper.PixelXYToLatLong(point.X, point.Y, map.MapElement.ZoomLevel);

            while (location.Longitude > 180)
            {
                location.Longitude -= 360;
            }

            MapVisualElement p = pointLayer.HitTest(location);
            BingMapsRESTService.Response r = await GetGeoInfoByLocation(location);

            newSelectedLocation = new GeoLocation()
            {
                Latitude = location.Latitude,
                Lontitude = location.Longitude,
                City = ((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).Address.Locality,
                Region = ((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).Address.AdminDistrict,
                Country = ((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).Address.CountryRegion,
                CountryCode2Digits = ((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).Address.CountryRegionIso2,
                SubRegion= ((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).Address.AdminDistrict2,
                PostalCode= ((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).Address.PostalCode,
                AddressLine= ((BingMapsRESTService.Location)r.ResourceSets[0].Resources[0]).Address.AddressLine
            };

            UpdategeoInfoOnForm(newSelectedLocation);

            MapPin pin = new(new Telerik.WinControls.UI.Map.PointG(newSelectedLocation.Latitude, newSelectedLocation.Lontitude));

            pointLayer.Clear();
            pointLayer.Add(pin);

        }
        private async Task<BingMapsRESTService.Response> GetResponse(Uri uri)
        {
            try { 

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            var response = await client.GetAsync(uri);
           
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(BingMapsRESTService.Response));
                return ser.ReadObject(stream) as BingMapsRESTService.Response;
            }

        }
            catch (Exception ex)
            {
                return null;
            }

}


    }
}
