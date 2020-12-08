namespace LanguagesXF.Resources
{
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension<BindingBase>
    {
        //private const string ResourceId = "LanguagesXF.Resources.AppResources";
        //public string Text { get; set; }

        //public object ProvideValue(IServiceProvider serviceProvider)
        //{
        //    if (Text == null) return null;

        //    ResourceManager resourceManager = new ResourceManager(ResourceId,
        //        typeof(TranslateExtension).GetTypeInfo().Assembly);

        //    return resourceManager.GetString(Text, CultureInfo.CurrentCulture);
        //}

        public string Text { get; set; }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }

        public BindingBase ProvideValue(IServiceProvider serviceProvider)
        {
            var binding = new Binding()
            {
                Mode = BindingMode.OneWay,
                Path = $"[{Text}]",
                Source = LocationResourceManager.Instance
            };

            return binding;
        }
    }
}
