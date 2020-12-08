using LanguagesXF.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LanguagesXF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BtnSp.Text = AppResources.Btn_languageSp;
            BtnEn.Text = AppResources.Btn_languageEn;
        }

        private void Tapped_TranslateToSpanish(object sender, EventArgs e)
        {
            LoadLanguage("es");
        }

        private void Tapped_TranslateToEnglish(object sender, EventArgs e)
        {
            LoadLanguage("en");
        }

        private void LoadLanguage(string language)
        {
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            //AppResources.Culture = new System.Globalization.CultureInfo(language);

            //App.Current.MainPage = new MainPage();

            LocationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo(language));

            BtnSp.Text = AppResources.Btn_languageSp;
            BtnEn.Text = AppResources.Btn_languageEn;
        }
    }
}