using Hitachi.Common.Controls.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hitachi.Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ToggleProgressBar(ToggleSwitch TGL, HitachiProgress PRG)
        {
            if (TGL == null)
                return;

            if (TGL.IsOn == true)
                PRG.IsActive = true;
            else
                PRG.IsActive = false;
        }


        private void TGL1_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleProgressBar(TGL1, PRG1);           
        }

        private void TGL2_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleProgressBar(TGL2, PRG2);
        }
        private void TGL3_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleProgressBar(TGL3, PRG3);
        }
    }
}
