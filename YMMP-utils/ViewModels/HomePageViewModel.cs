using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPFLocalizeExtension.Engine;

namespace YMMP_utils.ViewModels
{
    public partial class HomePageViewModel:ObservableObject
    {
        [ObservableProperty]
        private ComboBoxItem selectedLanguage;


        partial void OnSelectedLanguageChanged(ComboBoxItem value)
        {
            string cultureCode = value.Tag.ToString();

            LocalizeDictionary.Instance.Culture = new CultureInfo(cultureCode);

        }
    }
}
