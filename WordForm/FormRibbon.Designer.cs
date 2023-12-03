using Microsoft.Office.Tools.Ribbon;
using Office = Microsoft.Office.Core;

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
            formRibbonCustomizationTab = Factory.CreateRibbonTab();
            customizeFormGroup = Factory.CreateRibbonGroup();
            customizeFormButton = Factory.CreateRibbonButton();
            fillDocumentGroup = Factory.CreateRibbonGroup();
            fiilInFormButton = Factory.CreateRibbonButton();
            formRibbonCustomizationTab.SuspendLayout();
            customizeFormGroup.SuspendLayout();
            fillDocumentGroup.SuspendLayout();
            SuspendLayout();
            // 
            // formRibbonCustomizationTab
            // 
            formRibbonCustomizationTab.Groups.Add(customizeFormGroup);
            formRibbonCustomizationTab.Groups.Add(fillDocumentGroup);
            formRibbonCustomizationTab.Label = global::WordForm.Properties.Resources.Label_Form;
            formRibbonCustomizationTab.Name = "formRibbonCustomizationTab";
            // 
            // customizeFormGroup
            // 
            customizeFormGroup.Items.Add(customizeFormButton);
            customizeFormGroup.Label = global::WordForm.Properties.Resources.Label_CustomizeForm;
            customizeFormGroup.Name = "customizeFormGroup";
            // 
            // customizeFormButton
            // 
            customizeFormButton.ControlSize = Office.RibbonControlSize.RibbonControlSizeLarge;
            customizeFormButton.Image = ((System.Drawing.Image)(resources.GetObject("customizeFormButton.Image")));
            customizeFormButton.Label = global::WordForm.Properties.Resources.Label_CustomizeForm;
            customizeFormButton.Name = "customizeFormButton";
            customizeFormButton.ShowImage = true;
            // 
            // fillDocumentGroup
            // 
            fillDocumentGroup.Items.Add(fiilInFormButton);
            fillDocumentGroup.Label = global::WordForm.Properties.Resources.Label_FillDocument;
            fillDocumentGroup.Name = "fillDocumentGroup";
            // 
            // fiilInFormButton
            // 
            fiilInFormButton.ControlSize = Office.RibbonControlSize.RibbonControlSizeLarge;
            fiilInFormButton.Image = ((System.Drawing.Image)(resources.GetObject("fiilInFormButton.Image")));
            fiilInFormButton.Label = global::WordForm.Properties.Resources.Label_FillDocument;
            fiilInFormButton.Name = "fiilInFormButton";
            fiilInFormButton.ShowImage = true;
            // 
            // FormRibbon
            // 
            Name = "FormRibbon";
            RibbonType = "Microsoft.Word.Document";
            Tabs.Add(formRibbonCustomizationTab);
            Load += new RibbonUIEventHandler(FormRibbon_Load);
            formRibbonCustomizationTab.ResumeLayout(false);
            formRibbonCustomizationTab.PerformLayout();
            customizeFormGroup.ResumeLayout(false);
            customizeFormGroup.PerformLayout();
            fillDocumentGroup.ResumeLayout(false);
            fillDocumentGroup.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        internal RibbonTab formRibbonCustomizationTab;
        internal RibbonGroup customizeFormGroup;
        internal RibbonButton customizeFormButton;
        internal RibbonGroup fillDocumentGroup;
        internal RibbonButton fiilInFormButton;
    }

    partial class ThisRibbonCollection
    {
        internal FormRibbon FormRibbon
        {
            get { return this.GetRibbon<FormRibbon>(); }
        }
    }
}
