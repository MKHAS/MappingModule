using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Telerik.WinControls.UI.RadForm
    {
      public  Site s;
        public Form2()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Array itemValues = System.Enum.GetValues(typeof(SiteType));
            Array itemNames = System.Enum.GetNames(typeof(SiteType));

            for (int i = 0; i <= itemValues.Length - 1; i++)
            {
                // ListItem item = new ListItem(itemNames[i], itemValues[i]);
                ddLstSitesTypes.Items.Add(itemValues.GetValue(i).ToString());
            }
        }

        private void btnSaveNewSite_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewSite.Text) && ddLstSitesTypes.SelectedIndex >= 0)
            {
                s = new Site();
                s.Name = txtNewSite.Text;
                s.IsMapped = true;
                s.Type = GetSiteTypeByName(ddLstSitesTypes.SelectedText);
            }
        }

        SiteType GetSiteTypeByName(string siteName)
        {
            Array itemValues = System.Enum.GetValues(typeof(SiteType));

            return SiteType.ClientLocation;
        }

        public void retrieveData(Site _s)
        {
            //use the objPassedFromParent object as needed
        }
    }
}
