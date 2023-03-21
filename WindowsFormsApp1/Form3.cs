
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOPTerminalView.Providers.MapProvider
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           

            List<temp> lis = new List<temp>()
            {
                new temp(){
                    IsSelected =true,
                    SType=SiteType.ClientLocation,
                    Name="Site1",
                    Latitude= 33.872424,
                    Lontitude= 35.533439 ,
                    City="c1",
                    Country="cou1",
                },
               new temp(){
                    IsSelected =true,
                    SType=SiteType.ClientLocation,
                    Name="Site2",
                    Country="United States",

                }
            };

            int i = 0;
            foreach (temp t in lis)
            {
                radGridView1.Rows.AddNew();
                radGridView1.Rows[i].Cells["IsSelected"].Value = t.IsSelected;
                radGridView1.Rows[i].Cells["City"].Value = t.City;
                radGridView1.Rows[i].Cells["Country"].Value = t.Country;
                radGridView1.Rows[i].Cells["CountryCode2Digits"].Value = t.CountryCode2Digits;
                radGridView1.Rows[i].Cells["Region"].Value = t.Region;
                radGridView1.Rows[i].Cells["Latitude"].Value = t.Latitude;
                radGridView1.Rows[i].Cells["Lontitude"].Value = t.Lontitude;
                i++;
            }
        }

     public   class temp
        {
            public  bool IsSelected;
            public SiteType SType;
            public string Name;
            public double Latitude;
            public double Lontitude;
            public string Country;
              public string CountryCode2Digits;
            public string Region;

            public string City;



        }

        private void radGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(radGridView1.SelectedRows.Count>0)
            {
                temp t = new temp();
                t.IsSelected=Convert.ToBoolean(radGridView1.SelectedRows[0].Cells["IsSelected"].Value );
                // radGridView1.SelectedRows[0].Cells["City"].Value = t.City;
                //  radGridView1.SelectedRows[0].Cells["Country"].Value = t.Country;
                //  radGridView1.SelectedRows[0].Cells["CountryCode2Digits"].Value = t.CountryCode2Digits;
                //  radGridView1.SelectedRows[0].Cells["Region"].Value = t.Region;
                t.Latitude = Convert.ToDouble(radGridView1.SelectedRows[0].Cells["Latitude"] != null ? radGridView1.SelectedRows[0].Cells["Latitude"].Value : "0");
                t.Lontitude=Convert.ToDouble(  radGridView1.SelectedRows[0].Cells["Lontitude"]!=null ? radGridView1.SelectedRows[0].Cells["Lontitude"].Value : "0");


                TestLocation _t = new TestLocation()
                {
                    LinkedLocations = null,
                    Location = new GeoLocation() { Latitude = t.Latitude, Lontitude = t.Lontitude }
                };

                List<LocationInfo> ls = new List<LocationInfo>()

            {
                new LocationInfo(){ IsSelected=t.IsSelected,
                    SType = SiteType.ClientLocation,
                    Name="Loc1",
                    LocationSite=_t
                                  },
            };

                frmAssignLocation frm = new frmAssignLocation(ls, false);
                frm.ShowDialog();

                if(frm.selectedLocation!=null)
                {

                    radGridView1.SelectedRows[0].Cells["City"].Value = frm.selectedLocation.City;
                    radGridView1.SelectedRows[0].Cells["Country"].Value = frm.selectedLocation.Country;
                    radGridView1.SelectedRows[0].Cells["CountryCode2Digits"].Value = frm.selectedLocation.CountryCode2Digits;
                    radGridView1.SelectedRows[0].Cells["Region"].Value = frm.selectedLocation.Region;
                    radGridView1.SelectedRows[0].Cells["Latitude"].Value = frm.selectedLocation.Latitude;
                    radGridView1.SelectedRows[0].Cells["Lontitude"].Value = frm.selectedLocation.Lontitude;

                }

            }
        }
    }
}
