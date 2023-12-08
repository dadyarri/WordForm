using Microsoft.Office.Tools.Ribbon;
using WordForm.Ui;

namespace WordForm.Ribbon
{
    public partial class FormRibbon
    {
        private void FormRibbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void customizeFormButton_Click(object sender, RibbonControlEventArgs e)
        {
            var form = new CustomizeFormWindow(Globals.ThisDocument.CustomXMLParts);
            form.ShowDialog();
        }
    }
}
