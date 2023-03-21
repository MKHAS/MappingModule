using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;
using Telerik.WinControls.UI.Map.Bing;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        private List<Site> _sites;
        private List<Site> _sitesMapped;
        private List<Site> _sitesUnMapped;
        private Geolocation2 _initialZoomLocation;
        private IMapCacheProvider _cacheProvider;
        MapLayer pointLayer = new MapLayer("PointG");
        BingRestMapProvider bingProvider;

        string bingkey = "tmUi6YgGTfsr5R4cj2Ru~ZpfA96ifmO0tKaTHvsnEWQ~Ap8rnRFA9C269eCWa-ZZSoZJ38gFhIJxeMw1KcGI54iko2l22-ATc47tBy2V6DoV";
        public Form1(List<Site> sites, Geolocation2 initialZoomLocation)
        {
            InitializeComponent();

            _sites = sites;
            _initialZoomLocation = initialZoomLocation;
            //_cacheProvider = new MyCacheProvider(); // Implement your own cache provider
            //BingRestMapProvider.CacheProvider = _cacheProvider;
            LoadMap();
            LoadData();
            InitializeEventHandlers();
            //RunRouteRequest();
            BingTruckRoute();
            btnGiveDirections_Click();

            string key = bingkey;
            string query = "1 Microsoft Way, Redmond, WA";

            Uri geocodeRequest = new Uri(string.Format("http://dev.virtualearth.net/REST/v1/Locations?q={0}&key={1}", query, key));

            //GetResponse(geocodeRequest, (x) =>
            //{
            //    Console.WriteLine(x.ResourceSets[0].Resources.Length + " result(s) found.");
            //    Console.ReadLine();
            //});
        }

        private void LoadMap()
        {
            try
            {
                string cacheFolder = @"..\..\cache1";
                 bingProvider = new Telerik.WinControls.UI.BingRestMapProvider();
                bingProvider.UseSession = true;
                bingProvider.BingKey = "tmUi6YgGTfsr5R4cj2Ru~ZpfA96ifmO0tKaTHvsnEWQ~Ap8rnRFA9C269eCWa-ZZSoZJ38gFhIJxeMw1KcGI54iko2l22-ATc47tBy2V6DoV";
                LocalFileCacheProvider cache = new LocalFileCacheProvider(cacheFolder);
                bingProvider.CacheProvider = cache;
              // bingProvider.ImagerySet = Telerik.WinControls.UI.Map.Bing.ImagerySet.AerialWithLabels;
                radMap1.MapElement.Providers.Add(bingProvider);
              //  radMap1.MapElement.Center = new Telerik.WinControls.UI.Map.PointG(33.862453, 35.549992 );
               // radMap1.MapElement.ZoomLevel = 12;
                
               
                this.radMap1.MapElement.Layers.Add(pointLayer);
                
              //  this.radMap1.MapElement.Zoom(12, true);
                this.radMap1.MapElement.BringIntoView(new Telerik.WinControls.UI.Map.PointG(33.862453, 35.549992));

                // this.radMap1.MapElement.Zoom(12);
                //this.radMap1.MapElement.Pan(new SizeL(200, 200));
            }
            catch (Exception ex)
            { }
        }

        public void LoadData()
        {
            MapPin pin;
            _sitesMapped = new List<Site>();
            _sitesUnMapped = new List<Site>();
            foreach (Site s in _sites)
                if (s.IsMapped)
                {
                    ddLstSiteMapped.Items.Add(s.Name);
                    _sitesMapped.Add(s);
                     pin = new(new Telerik.WinControls.UI.Map.PointG(s.Geolocation.Latitude, s.Geolocation.Longitude));
                    pin.Text = s.Name;
                    pin.ToolTipText = s.Name;
                   
                    this.radMap1.MapElement.Layers["PointG"].Add(pin);

                }
                else
                {
                    ddLstSiteUnMapped.Items.Add(s.Name);
                    _sitesUnMapped.Add(s);
                }

            Array itemValues = System.Enum.GetValues(typeof(SiteType));
            Array itemNames = System.Enum.GetNames(typeof(SiteType));

            for (int i = 0; i <= itemValues.Length - 1; i++)
            {
               // ListItem item = new ListItem(itemNames[i], itemValues[i]);
                ddLstSitesTypes.Items.Add(itemValues.GetValue(i).ToString());
            }
        }

        

        private void LoadSites()
        {
        
        }

        private void InitializeEventHandlers()
        {
            // ...
        }

        private void AddSiteToMap(Site site)
        {
            // ...
        }

        private void RemoveSiteFromMap(Site site)
        {
            // ...
        }

        private void UpdateSiteVisibility(Site site)
        {
            // ...
        }

        private void mapLocations_MouseMove(object sender, MouseEventArgs e)
        {
            // ...
        }

        private void mapLocations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ...
        }

        private void mapLocations_MouseDown(object sender, MouseEventArgs e)
        {
            // ...
        }

        private void lstSites_Mapped_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ...
        }

        //private void lstSites_Types_ItemCheckedChanged(object sender, ItemCheckedChangedEventArgs e)
        //{
        //    // ...
        //}

        private void btnOk_Click(object sender, EventArgs e)
        {
            // ...
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // ...
        }

        private void ddLstSitesTypes_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            MapPin pin;
            if (ddLstSitesTypes.SelectedIndex>-1)
            {
                this.radMap1.MapElement.Layers["PointG"].Clear();

                foreach (Site s in _sitesMapped)
                    if (s.IsMapped && s.Type.ToString()==ddLstSitesTypes.SelectedText)
                    {
                        
                        pin = new(new Telerik.WinControls.UI.Map.PointG(s.Geolocation.Latitude, s.Geolocation.Longitude));
                        pin.Text = "sleman";
                        this.radMap1.MapElement.Layers["PointG"].Add(pin);

                    }
            }
        }

        private void ddLstSiteMapped_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddLstSiteMapped.SelectedIndex > -1)
            {
                Site s = _sitesMapped[ddLstSiteMapped.SelectedIndex];
                this.radMap1.MapElement.BringIntoView(new Telerik.WinControls.UI.Map.PointG(s.Geolocation.Latitude, s.Geolocation.Longitude),15);
                MapPin pin;
                pin = new(new Telerik.WinControls.UI.Map.PointG(s.Geolocation.Latitude, s.Geolocation.Longitude));
                pin.Text = "sleman";
                

            }
        }

       

        private void radMap1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RadMap map = (RadMap)sender;
            PointL point = new PointL(e.X - map.MapElement.PanOffset.Width, e.Y - map.MapElement.PanOffset.Height);
            PointG location = MapTileSystemHelper.PixelXYToLatLong(point.X, point.Y, map.MapElement.ZoomLevel);

            while (location.Longitude > 180)
            {
                location.Longitude -= 360;
            }

            MapVisualElement  p = this.radMap1.MapElement.Layers["PointG"].HitTest(location) ;

            //if (pin != null)
            //{
            //    this.Text = "Pin Clicked";
            //}

          
            Form2 f= new Form2();
            
            f.ShowDialog();
            Site s = f.s;
            if (s != null)
            {
                s.IsMapped = true;
               s.Geolocation = new Geolocation2() { Latitude = location.Latitude, Longitude = location.Longitude };
               _sitesMapped.Add(s);
               ddLstSiteMapped.Items.Add(s.Name);
               MapPin pin = new(new Telerik.WinControls.UI.Map.PointG(s.Geolocation.Latitude, s.Geolocation.Longitude));
                pin.Text = s.Name;
                pin.ToolTipText = s.Name;
                this.radMap1.MapElement.Layers["PointG"].Add(pin);

            }

        }

        public delegate void delPassDataToFrom(Site s);

        public void RunRouteRequest()
        {
            //add a layer to display the route
            this.radMap1.MapElement.Layers.Add(new MapLayer());
            RouteRequest request = new RouteRequest();
            request.DistanceUnit = DistanceUnit.Kilometer;
            request.Options.Mode = TravelMode.Walking;
            request.Options.Optimization = RouteOptimization.Time;
            request.Options.RouteAttributes = RouteAttributes.RoutePath;
            request.Options.RouteAvoidance = RouteAvoidance.None;
            request.RoutePoints.Add(new Waypoint("Paris, France"));
            request.RoutePoints.Add(new Waypoint("Madrid, Spain"));
            BingRestMapProvider bingProvider = this.radMap1.Providers[0] as BingRestMapProvider;
            bingProvider.CalculateRouteCompleted += BingProvider_RoutingCompleted;
            bingProvider.CalculateRouteAsync(request);
        }
        private void BingProvider_RoutingCompleted(object sender, RoutingCompletedEventArgs e)
        {
            List<Telerik.WinControls.UI.Map.PointG> points = new List<Telerik.WinControls.UI.Map.PointG>();
            foreach (double[] coordinatePair in e.Route.RoutePath.Line.Coordinates)
            {
                Telerik.WinControls.UI.Map.PointG point = new Telerik.WinControls.UI.Map.PointG(coordinatePair[0], coordinatePair[1]);
                points.Add(point);
            }
            Telerik.WinControls.UI.Map.RectangleG boundingRectangle = new Telerik.WinControls.UI.Map.RectangleG(e.Route.BBox[2],
                e.Route.BBox[1], e.Route.BBox[0], e.Route.BBox[3]);
            MapRoute routeElement = new MapRoute(points, boundingRectangle);
            routeElement.BorderColor = Color.Blue;
            routeElement.BorderWidth = 5;
            MapPin start = new MapPin(new Telerik.WinControls.UI.Map.PointG(e.Route.RouteLegs[0].ActualStart.Coordinates[0],
                e.Route.RouteLegs[0].ActualStart.Coordinates[1]));
            start.BackColor = Color.White;
            start.BorderColor = Color.Green;
            start.BorderWidth = 2f;
            MapPin end = new MapPin(new Telerik.WinControls.UI.Map.PointG(e.Route.RouteLegs[e.Route.RouteLegs.Length - 1].ActualEnd.Coordinates[0],
                e.Route.RouteLegs[e.Route.RouteLegs.Length - 1].ActualEnd.Coordinates[1]));
            end.BackColor = Color.White;
            end.BorderColor = Color.Red;
            end.BorderWidth = 2f;
            this.radMap1.MapElement.Layers[0].Add(routeElement);
            this.radMap1.MapElement.Layers[0].Add(start);
            this.radMap1.MapElement.Layers[0].Add(end);
            
        }

        public void BingTruckRoute()
        {
            
           
            this.radMap1.MapElement.Providers.Add(bingProvider);
            this.radMap1.MapElement.Layers.Add(new MapLayer());
            TruckRouteOptions options = new TruckRouteOptions();
            options.Avoid = TruckRouteAvoidance.BorderCrossing;
            options.DateTime = DateTime.Now;
            options.OptimizeWaypoints = true;
            options.RouteAttributes = TruckRouteAttributes.RoutePath;
            options.VehicleSpec = new VehicleSpec()
            {
                DimensionUnit = DimensionUnit.Meter,
                VehicleLength = 32,
                VehicleHeight = 4,
                VehicleSemi = true,
                VehicleHazardousMaterials = HazardousMaterial.Flammable
            };
            List<TruckWaypoint> wp = new List<TruckWaypoint>()
    {
        new TruckWaypoint("590 Crane Ave, Pittsburgh, PA"),
        new TruckWaypoint("600 Forbes Ave, Pittsburgh, PA")
    };
            Telerik.WinControls.UI.Map.Bing.TruckRouteRequest request = new TruckRouteRequest();
            request.RoutePoints = wp;
            request.Options = options;
            bingProvider.CalculateTruckRouteCompleted += BingProvider_TruckRoutingCompleted;
            bingProvider.CalculateTruckRouteError += BingProvider_CalculateRouteError;
            bingProvider.CalculateTruckRouteAsync(request);
        }
        private void BingProvider_CalculateRouteError(object sender, CalculateRouteErrorEventArgs e)
        {
            RadMessageBox.Show(e.Error.Message);
        }
        private void BingProvider_TruckRoutingCompleted(object sender, RoutingCompletedEventArgs e)
        {
            List<Telerik.WinControls.UI.Map.PointG> points = new List<PointG>();
            foreach (double[] coordinatePair in e.Route.RoutePath.Line.Coordinates)
            {
                PointG point = new PointG(coordinatePair[0], coordinatePair[1]);
                points.Add(point);
            }
            RectangleG boundingRectangle = new RectangleG(e.Route.BBox[2], e.Route.BBox[1],
                e.Route.BBox[0], e.Route.BBox[3]);
            MapRoute routeElement = new MapRoute(points, boundingRectangle);
            routeElement.BorderColor = Color.Blue;
            routeElement.BorderWidth = 5;
            MapPin start = new MapPin(new PointG(e.Route.RouteLegs[0].ActualStart.Coordinates[0],
                e.Route.RouteLegs[0].ActualStart.Coordinates[1]));
            start.BackColor = Color.White;
            start.BorderColor = Color.Green;
            start.BorderWidth = 2f;
            MapPin end = new MapPin(new PointG(e.Route.RouteLegs[e.Route.RouteLegs.Length - 1].ActualEnd.Coordinates[0],
                e.Route.RouteLegs[e.Route.RouteLegs.Length - 1].ActualEnd.Coordinates[1]));
            end.BackColor = Color.White;
            end.BorderColor = Color.Red;
            end.BorderWidth = 2f;
            this.radMap1.MapElement.Layers[0].Add(routeElement);
            this.radMap1.MapElement.Layers[0].Add(start);
            this.radMap1.MapElement.Layers[0].Add(end);

           
        }
        private async Task<BingMapsRESTService.Response> GetResponse(Uri uri)
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            var response = await client.GetAsync(uri);
            BingMapsRESTService.Response r;
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(BingMapsRESTService.Response));
                return  ser.ReadObject(stream) as BingMapsRESTService.Response;
            }

            
        }

        private async void btnGiveDirections_Click()
        {
            try
            {
               
                 string   URL = "https://dev.virtualearth.net/REST/v1/Routes/DistanceMatrix?origins=47.6044,-122.3345;47.6731,-122.1185;47.6149,-122.1936&destinations=45.5347,-122.6231;47.4747,-122.2057&travelMode=driving&key=" + bingkey;
                Uri geocodeRequest = new Uri(URL);
                BingMapsRESTService.Response r = await GetResponse(geocodeRequest);

                Geolocation2 geolocator = new Geolocation2();
          

             double   FromLatitude = ((BingMapsRESTService.Route)(r.ResourceSets[0].Resources[0])).RoutePath.Line.Coordinates[0][0];
             double FromLongitude = ((BingMapsRESTService.Route)(r.ResourceSets[0].Resources[0])).RoutePath.Line.Coordinates[0][1];

                
            }
            catch (Exception ex)
            {
            
            }
        }


        private void GetResponse(Uri uri, Action<BingMapsRESTService.Response> callback)
        {
            WebClient wc = new WebClient();
            wc.OpenReadCompleted += (o, a) =>
            {
                if (callback != null)
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Response));
                    callback(ser.ReadObject(a.Result) as Response);
                }
            };
            wc.OpenReadAsync(uri);
        }


    }
}
