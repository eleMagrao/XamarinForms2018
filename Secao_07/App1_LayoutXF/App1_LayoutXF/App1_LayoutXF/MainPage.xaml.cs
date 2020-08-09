using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1_LayoutXF
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoPaginaStack(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layout.Stack.StackPage());
        }

        private void GoPaginaGrid(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layout.Grid.GridPage());
        }

        private void GoPaginaAbsolute(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layout.Absolute.AbsolutePage());
        }

        private void GoPaginaRelative(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layout.Relative.RelativePage());
        }

        private void GoPaginaScroll(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layout.Scroll.ScrollPage());
        }
    }
}
