using System.Globalization;
using System.Linq;
using System.Threading;
using WordForm.Properties;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace WordForm
{
    public partial class ThisDocument
    {
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            // var lcid = Application.LanguageSettings.LanguageID[Office.MsoAppLanguageID.msoLanguageIDUI];
            // var culture = new CultureInfo(lcid);
            //
            // var languages = new[] { "en", "ru" };
            // if (languages.Contains(culture.TwoLetterISOLanguageName))
            // {
            //     Resources.Culture = culture;
            // }
        }

        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += new System.EventHandler(ThisDocument_Startup);
            Shutdown += new System.EventHandler(ThisDocument_Shutdown);
        }

        #endregion

        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            var app = this.GetHostItem<Word.Application>(typeof(Word.Application), "Application");
            var lcid = app.LanguageSettings.LanguageID[Office.MsoAppLanguageID.msoLanguageIDUI];
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lcid);
            return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
                new Microsoft.Office.Tools.Ribbon.IRibbonExtension[] { new FormRibbon() });
        }
    }
}
