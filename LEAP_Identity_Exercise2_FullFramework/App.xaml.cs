using System.Windows;
using Microsoft.Identity.Client;

namespace LEAP_Identity_Exercise2_FullFramework
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Below is the clientId of your app registration. 
        //You have to replace the below with the Application Id for your app registration
        private static string ClientId = "0c1f59bd-2b10-48ab-ae20-beca2330cf1f";

        public static PublicClientApplication PublicClientApp = new PublicClientApplication(ClientId);

    }
}
