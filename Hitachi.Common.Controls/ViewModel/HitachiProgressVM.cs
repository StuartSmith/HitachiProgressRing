using Hitachi.Common.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace Hitachi.Common.Controls.ViewModel
{
    class HitachiProgressVM:Bindable
    {
        private Brush _Foreground;
        //The Foreground for color for the logo item in the progress ring
        public Brush Foreground {
            get { return _Foreground; }
            set {
                if (_Foreground != value)
                {
                    _Foreground = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
