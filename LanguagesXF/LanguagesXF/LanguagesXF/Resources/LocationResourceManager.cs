namespace LanguagesXF.Resources
{
    using System.ComponentModel;
    using System.Globalization;
    using System.Threading;
    using Xamarin.Essentials;

    public class LocationResourceManager : INotifyPropertyChanged
    {
        private const string LanguageKey = nameof(LanguageKey);
        public static LocationResourceManager Instance { get; } = new LocationResourceManager();
        public string this[string text] => AppResources.ResourceManager.GetString(text, AppResources.Culture);

        public LocationResourceManager()
        {
            SetCulture(new CultureInfo(Preferences.Get(LanguageKey, Thread.CurrentThread.CurrentCulture.Name)));
        }

        public void SetCulture(CultureInfo language)
        {
            Thread.CurrentThread.CurrentUICulture = language;
            AppResources.Culture = language;

            Preferences.Set(LanguageKey, language.TwoLetterISOLanguageName);

            Invalidate();
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void Invalidate()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
