
namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNewSite = new Telerik.WinControls.UI.RadTextBox();
            this.btnSaveNewSite = new Telerik.WinControls.UI.RadButton();
            this.ddLstSitesTypes = new Telerik.WinControls.UI.RadDropDownList();
            this.lblTypes = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveNewSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLstSitesTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewSite
            // 
            this.txtNewSite.Location = new System.Drawing.Point(93, 56);
            this.txtNewSite.Name = "txtNewSite";
            this.txtNewSite.Size = new System.Drawing.Size(225, 27);
            this.txtNewSite.TabIndex = 0;
            // 
            // btnSaveNewSite
            // 
            this.btnSaveNewSite.Location = new System.Drawing.Point(208, 146);
            this.btnSaveNewSite.Name = "btnSaveNewSite";
            this.btnSaveNewSite.Size = new System.Drawing.Size(248, 54);
            this.btnSaveNewSite.TabIndex = 1;
            this.btnSaveNewSite.Text = "Save";
            this.btnSaveNewSite.Click += new System.EventHandler(this.btnSaveNewSite_Click);
            // 
            // ddLstSitesTypes
            // 
            this.ddLstSitesTypes.Location = new System.Drawing.Point(169, 89);
            this.ddLstSitesTypes.Name = "ddLstSitesTypes";
            this.ddLstSitesTypes.Size = new System.Drawing.Size(236, 27);
            this.ddLstSitesTypes.TabIndex = 3;
            // 
            // lblTypes
            // 
            this.lblTypes.Location = new System.Drawing.Point(99, 96);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(64, 18);
            this.lblTypes.TabIndex = 2;
            this.lblTypes.Text = "Sites Types:";
            // 
            // Form2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 25);
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 232);
            this.Controls.Add(this.ddLstSitesTypes);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.btnSaveNewSite);
            this.Controls.Add(this.txtNewSite);
            this.Name = "Form2";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveNewSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLstSitesTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtNewSite;
        private Telerik.WinControls.UI.RadButton btnSaveNewSite;
        private Telerik.WinControls.UI.RadDropDownList ddLstSitesTypes;
        private Telerik.WinControls.UI.RadLabel lblTypes;
    }
}