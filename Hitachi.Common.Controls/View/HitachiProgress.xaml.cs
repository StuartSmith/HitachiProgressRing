using Hitachi.Common.Controls.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Hitachi.Common.Controls.View
{
    public sealed partial class HitachiProgress : UserControl
    {
        private HitachiProgressVM _hitachiProgressVM;
        public HitachiProgress()
        {
            this.InitializeComponent();

            _hitachiProgressVM = new HitachiProgressVM();

            this.DataContext = _hitachiProgressVM;

            

    }



        public static DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(HitachiProgress), null);
        public bool IsActive
        {
            get
            {
                return (bool)GetValue(IsActiveProperty);
            }
            set
            {
                SetValue(IsActiveProperty, value);
                if (value == true)
                    ProgressStoryBoard.Begin();
                else
                    ProgressStoryBoard.Stop();
            }
        }



        public static new DependencyProperty ForegroundProperty = DependencyProperty.Register("Foreground", typeof(Brush), typeof(HitachiProgress), null);
        public new Brush Foreground
        {
            get { return _hitachiProgressVM.Foreground; }
            set { _hitachiProgressVM.Foreground =  value; }
        }
       
    }
}
