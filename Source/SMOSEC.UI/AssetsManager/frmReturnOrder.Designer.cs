using System;
using Smobiler.Core;
using SMOSEC.UI.UserControl;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmReturnOrder : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmReturnOrder()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Title1 = new SMOSEC.UI.UserControl.MenuTitle();
            this.btnAdd = new Smobiler.Core.Controls.Button();
            this.ListViewCO = new Smobiler.Core.Controls.ListView();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.Black;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "归还单列表";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FontSize = 15F;
            this.btnAdd.Location = new System.Drawing.Point(0, 40);
            this.btnAdd.Margin = new Smobiler.Core.Controls.Margin(10F, 10F, 10F, 0F);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 34);
            this.btnAdd.Text = "添加";
            this.btnAdd.Press += new System.EventHandler(this.btnAdd_Press);
            // 
            // ListViewCO
            // 
            this.ListViewCO.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.ListViewCO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListViewCO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewCO.Location = new System.Drawing.Point(0, 73);
            this.ListViewCO.Margin = new Smobiler.Core.Controls.Margin(0F, 20F, 0F, 0F);
            this.ListViewCO.Name = "ListViewCO";
            this.ListViewCO.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListViewCO.PageSizeTextSize = 11F;
            this.ListViewCO.Size = new System.Drawing.Size(300, 400);
            this.ListViewCO.TemplateControlName = "ReturnOrderLayout";
            // 
            // frmReturnOrder
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.btnAdd,
            this.ListViewCO});
            this.DrawerName = "LeftMenu";
            this.Name = "frmReturnOrder";
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.FrmReturnOrder_KeyDown);
            this.Load += new System.EventHandler(this.FrmReturnOrder_Load);
            this.Name = "frmReturnOrder";

        }
        #endregion

        private MenuTitle Title1;
        internal Smobiler.Core.Controls.Button btnAdd;
        internal Smobiler.Core.Controls.ListView ListViewCO;
    }
}