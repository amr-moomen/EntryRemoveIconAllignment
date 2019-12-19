using EntryRemoveIconAllignment.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntryRemoveIconAllignment
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPageArabic : ContentPage
    {
        public MainPageArabic()
        {
            InitializeComponent();
           // this.FlowDirection = FlowDirection.RightToLeft;
        }

        private  void ChangeLangugeClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    
    }
}
