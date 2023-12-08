using Microsoft.Office.Tools.Ribbon;

namespace WordForm.Ribbon
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
            this.formRibbonCustomizationTab.Label = global::WordForm.Properties.Resources.Label_Form;
            this.formRibbonCustomizationTab.Name = "formRibbonCustomizationTab";
            // 
            // customizeFormGroup
            // 
            this.customizeFormGroup.Items.Add(this.customizeFormButton);
            this.customizeFormGroup.Label = global::WordForm.Properties.Resources.Label_CustomizeForm;
            this.customizeFormGroup.Name = "customizeFormGroup";
            // 
            // customizeFormButton
            // 
            this.customizeFormButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.customizeFormButton.Image = ((System.Drawing.Image)(resources.GetObject("customizeFormButton.Image")));
            this.customizeFormButton.Label = global::WordForm.Properties.Resources.Label_CustomizeForm;
            this.customizeFormButton.Name = "customizeFormButton";
            this.customizeFormButton.ShowImage = true;
            this.customizeFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.customizeFormButton_Click);
            // 
            // fillDocumentGroup
            // 
            this.fillDocumentGroup.Items.Add(this.fiilInFormButton);
            this.fillDocumentGroup.Label = global::WordForm.Properties.Resources.Label_FillDocument;
            this.fillDocumentGroup.Name = "fillDocumentGroup";
            // 
            // fiilInFormButton
            // 
            this.fiilInFormButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.fiilInFormButton.Image = ((System.Drawing.Image)(resources.GetObject("fiilInFormButton.Image")));
            this.fiilInFormButton.Label = global::WordForm.Properties.Resources.Label_FillDocument;
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

        internal RibbonTab formRibbonCustomizationTab;
        internal RibbonGroup customizeFormGroup;
        internal RibbonButton customizeFormButton;
        internal RibbonGroup fillDocumentGroup;
        internal RibbonButton fiilInFormButton;
    }
}
