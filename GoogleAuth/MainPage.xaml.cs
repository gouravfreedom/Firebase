using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Forms;

namespace GoogleAuth
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Auth = new OAuth2Authenticator(
            Configuration.ClientId,
            string.Empty,
            "email",
            new Uri("https://accounts.google.com/o/oauth2/v2/auth"),
            new Uri(Configuration.RedirectUrl),
            new Uri("https://www.googleapis.com/oauth2/v4/token"),
            isUsingNativeUI: true);


            Auth.Completed += OnAuthenticationCompleted;
            Auth.Error += OnAuthenticationFailed;

        }
    }
}
