using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagData;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunFlacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllFlags : ContentPage
    {
        public AllFlags()
        {
            InitializeComponent();

            BindingContext = DependencyService.Get<FunFlactsViewModel>();
        }
    }
}