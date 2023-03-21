
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radSplitContainer2 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ddLstSitesTypes = new Telerik.WinControls.UI.RadDropDownList();
            this.ddLstSiteUnMapped = new Telerik.WinControls.UI.RadDropDownList();
            this.lblTypes = new Telerik.WinControls.UI.RadLabel();
            this.ddLstSiteMapped = new Telerik.WinControls.UI.RadDropDownList();
            this.lblUnMapped = new Telerik.WinControls.UI.RadLabel();
            this.lblDistance = new Telerik.WinControls.UI.RadLabel();
            this.lblMapped = new Telerik.WinControls.UI.RadLabel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.radMap1 = new Telerik.WinControls.UI.RadMap();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).BeginInit();
            this.radSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddLstSitesTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLstSiteUnMapped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLstSiteMapped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUnMapped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMapped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer2
            // 
            this.radSplitContainer2.Controls.Add(this.splitPanel1);
            this.radSplitContainer2.Controls.Add(this.splitPanel2);
            this.radSplitContainer2.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.radSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer2.Name = "radSplitContainer2";
            this.radSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer2.Size = new System.Drawing.Size(2100, 1128);
            this.radSplitContainer2.TabIndex = 1;
            this.radSplitContainer2.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radPanel1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(2100, 200);
            this.splitPanel1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute;
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ddLstSitesTypes);
            this.radPanel1.Controls.Add(this.ddLstSiteUnMapped);
            this.radPanel1.Controls.Add(this.lblTypes);
            this.radPanel1.Controls.Add(this.ddLstSiteMapped);
            this.radPanel1.Controls.Add(this.lblUnMapped);
            this.radPanel1.Controls.Add(this.lblDistance);
            this.radPanel1.Controls.Add(this.lblMapped);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(2100, 200);
            this.radPanel1.TabIndex = 0;
            // 
            // ddLstSitesTypes
            // 
            this.ddLstSitesTypes.Location = new System.Drawing.Point(464, 94);
            this.ddLstSitesTypes.Name = "ddLstSitesTypes";
            this.ddLstSitesTypes.Size = new System.Drawing.Size(236, 27);
            this.ddLstSitesTypes.TabIndex = 1;
            this.ddLstSitesTypes.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddLstSitesTypes_SelectedIndexChanged);
            // 
            // ddLstSiteUnMapped
            // 
            this.ddLstSiteUnMapped.Location = new System.Drawing.Point(472, 29);
            this.ddLstSiteUnMapped.Name = "ddLstSiteUnMapped";
            this.ddLstSiteUnMapped.Size = new System.Drawing.Size(236, 27);
            this.ddLstSiteUnMapped.TabIndex = 1;
            // 
            // lblTypes
            // 
            this.lblTypes.Location = new System.Drawing.Point(394, 101);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(64, 18);
            this.lblTypes.TabIndex = 0;
            this.lblTypes.Text = "Sites Types:";
            // 
            // ddLstSiteMapped
            // 
            this.ddLstSiteMapped.Location = new System.Drawing.Point(123, 29);
            this.ddLstSiteMapped.Name = "ddLstSiteMapped";
            this.ddLstSiteMapped.Size = new System.Drawing.Size(236, 27);
            this.ddLstSiteMapped.TabIndex = 1;
            this.ddLstSiteMapped.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddLstSiteMapped_SelectedIndexChanged);
            // 
            // lblUnMapped
            // 
            this.lblUnMapped.Location = new System.Drawing.Point(375, 36);
            this.lblUnMapped.Name = "lblUnMapped";
            this.lblUnMapped.Size = new System.Drawing.Size(91, 18);
            this.lblUnMapped.TabIndex = 0;
            this.lblUnMapped.Text = "Sites UnMapped:";
            // 
            // lblDistance
            // 
            this.lblDistance.Location = new System.Drawing.Point(63, 94);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(77, 18);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Sites Mapped:";
            // 
            // lblMapped
            // 
            this.lblMapped.Location = new System.Drawing.Point(40, 34);
            this.lblMapped.Name = "lblMapped";
            this.lblMapped.Size = new System.Drawing.Size(77, 18);
            this.lblMapped.TabIndex = 0;
            this.lblMapped.Text = "Sites Mapped:";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.radMap1);
            this.splitPanel2.Location = new System.Drawing.Point(0, 204);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(2100, 924);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // radMap1
            // 
            this.radMap1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radMap1.Location = new System.Drawing.Point(0, 0);
            this.radMap1.Name = "radMap1";
            this.radMap1.Size = new System.Drawing.Size(2100, 924);
            this.radMap1.TabIndex = 0;
            this.radMap1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.radMap1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(2100, 1128);
            this.Controls.Add(this.radSplitContainer2);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).EndInit();
            this.radSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddLstSitesTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLstSiteUnMapped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLstSiteMapped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUnMapped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMapped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer2;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadMap radMap1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel lblUnMapped;
        private Telerik.WinControls.UI.RadLabel lblMapped;
        private Telerik.WinControls.UI.RadDropDownList ddLstSiteUnMapped;
        private Telerik.WinControls.UI.RadDropDownList ddLstSiteMapped;
        private Telerik.WinControls.UI.RadDropDownList ddLstSitesTypes;
        private Telerik.WinControls.UI.RadLabel lblTypes;
        private Telerik.WinControls.UI.RadLabel lblDistance;
    }
}
