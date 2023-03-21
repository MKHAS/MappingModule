using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace SOPTerminalView.Providers.MapProvider
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //   Application.Run(new Form1(DialogMapModel.GetSites(),null));

            TestLocation _t = new TestLocation()
            {
                LinkedLocations = null,
                Location = new GeoLocation() { Latitude = 33.872424, Lontitude = 35.533439 }
            };

            List<LocationInfo> ls = new List<LocationInfo>()

            {
                new LocationInfo(){ IsSelected=true,
                    SType = SiteType.ClientLocation,
                    Name="Loc1",
           // LocationSite=_t
                                  },
            };

            Application.Run(new Form3());

        }
    }
}
