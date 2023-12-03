namespace WordForm
{
    partial class FormRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FormRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRibbon));
            this.formRibbonCustomizationTab = this.Factory.CreateRibbonTab();
            this.customizeFormGroup = this.Factory.CreateRibbonGroup();
            this.customizeFormButton = this.Factory.CreateRibbonButton();
            this.fillDocumentGroup = this.Factory.CreateRibbonGroup();
            this.fiilInFormButton = this.Factory.CreateRibbonButton();
            this.formRibbonCustomizationTab.SuspendLayout();
            this.customizeFormGroup.SuspendLayout();
            this.fillDocumentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // formRibbonCustomizationTab
            // 
            this.formRibbonCustomizationTab.Groups.Add(this.customizeFormGroup);
            this.formRibbonCustomizationTab.Groups.Add(this.fillDocumentGroup);
            this.formRibbonCustomizationTab.Label = "Form";
            this.formRibbonCustomizationTab.Name = "formRibbonCustomizationTab";
            // 
            // customizeFormGroup
            // 
            this.customizeFormGroup.Items.Add(this.customizeFormButton);
            this.customizeFormGroup.Label = "Customize form";
            this.customizeFormGroup.Name = "customizeFormGroup";
            // 
            // customizeFormButton
            // 
            this.customizeFormButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.customizeFormButton.Image = ((System.Drawing.Image)(resources.GetObject("customizeFormButton.Image")));
            this.customizeFormButton.Label = "Customize form";
            this.customizeFormButton.Name = "customizeFormButton";
            this.customizeFormButton.ShowImage = true;
            // 
            // fillDocumentGroup
            // 
            this.fillDocumentGroup.Items.Add(this.fiilInFormButton);
            this.fillDocumentGroup.Label = "Fill document";
            this.fillDocumentGroup.Name = "fillDocumentGroup";
            // 
            // fiilInFormButton
            // 
            this.fiilInFormButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.fiilInFormButton.Image = ((System.Drawing.Image)(resources.GetObject("fiilInFormButton.Image")));
            this.fiilInFormButton.Label = "Fill in the form";
            this.fiilInFormButton.Name = "fiilInFormButton";
            this.fiilInFormButton.ShowImage = true;
            // 
            // FormRibbon
            // 
            this.Name = "FormRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.formRibbonCustomizationTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.FormRibbon_Load);
            this.formRibbonCustomizationTab.ResumeLayout(false);
            this.formRibbonCustomizationTab.PerformLayout();
            this.customizeFormGroup.ResumeLayout(false);
            this.customizeFormGroup.PerformLayout();
            this.fillDocumentGroup.ResumeLayout(false);
            this.fillDocumentGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab formRibbonCustomizationTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup customizeFormGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton customizeFormButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup fillDocumentGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fiilInFormButton;
    }

    partial class ThisRibbonCollection
    {
        internal FormRibbon FormRibbon
        {
            get { return this.GetRibbon<FormRibbon>(); }
        }
    }
}
