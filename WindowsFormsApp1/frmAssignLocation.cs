
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace SOPTerminalView.Providers.MapProvider
{
    public partial class frmAssignLocation : Telerik.WinControls.UI.RadForm
    {
        bool mCloseByButton;
        
        public GeoLocation selectedLocation = null;
        string focusesLocationName = string.Empty ;
        SiteType SType;
        MapProvider _mapProvider;
        public frmAssignLocation(List<LocationInfo> locations, bool isAssigned)
        {
            InitializeComponent();

            if (locations != null && locations.Any(x => x.IsSelected)) 
            {
                focusesLocationName = locations.First(x => x.IsSelected).Name;
                SType = locations.First(x => x.IsSelected).SType;
                if (locations.Any(x => x.LocationSite != null))
                {
                    selectedLocation = locations.First(x => x.LocationSite != null).LocationSite.Location;                    
                }

                _mapProvider = new MapProvider(radMap1);
                _mapProvider.UpdategeoInfoOnForm = new MapProvider.UpdateGeoInfo(UpdateGeoInfo);
                if (selectedLocation != null && selectedLocation.Latitude > 0)
                {
                    _mapProvider.LocationOnMap(selectedLocation, true);
                    UpdateGeoInfo(selectedLocation);
                }
                else
                    if (selectedLocation != null && selectedLocation.Country != null)
                    _mapProvider.LocationCountryOnMap(selectedLocation.Country);
            }


           // this.btnOk.Image = Properties.Resources.confirmation_64px;
            //this.Shown += (s, e) =>
            //{
            //    this.TopMost = true;
            //};
            this.FormClosing += FrmDisconnect_FormClosing;
            btnOk.Click += BtnConnect_Click;
        }

        // must display all locations on map, and put the symbol location on the selected location if any, and zoom to it

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (_mapProvider.newSelectedLocation != null)
            {
                selectedLocation = _mapProvider.newSelectedLocation;

                selectedLocation.SubRegion = txtSubRegion.Text;
                selectedLocation.City = txtCity.Text;
                selectedLocation.AddressLine = txtAddressLine.Text;
                selectedLocation.PostalCode = txtPostalCode.Text;
            }
            mCloseByButton = true;
            this.Close();
        }
        private void FrmDisconnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!mCloseByButton)
            {
                e.Cancel = true;
                return;
            }
        }

        void UpdateGeoInfo(GeoLocation _selectedLocation)
        {
            if (_selectedLocation != null)
            {
                txtCountry.Text = string.IsNullOrEmpty(_selectedLocation.Country) ? "" : _selectedLocation.Country;
                txtRegion.Text = string.IsNullOrEmpty(_selectedLocation.Region) ? "" : _selectedLocation.Region;
                txtSubRegion.Text = string.IsNullOrEmpty(_selectedLocation.SubRegion) ? "" : _selectedLocation.SubRegion;
                txtCity.Text = string.IsNullOrEmpty(_selectedLocation.City) ? "" : _selectedLocation.City;
                txtAddressLine.Text = string.IsNullOrEmpty(_selectedLocation.AddressLine) ? "" : _selectedLocation.AddressLine;
                txtPostalCode.Text = string.IsNullOrEmpty(_selectedLocation.PostalCode) ? "" : _selectedLocation.PostalCode;
            }
        }


    }
}
