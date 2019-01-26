using System;
using System.Collections.Generic;
using System.Diagnostics;
using Windows.Storage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFUWPFileSystem
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           
            MainPage = new MainPage();
        }
        public async void GetDirectories(string sDir)
        {
            
            var folder = await StorageFolder.GetFolderFromPathAsync(sDir);   
            foreach (var file in await folder.GetFilesAsync())
            {
                Debug.WriteLine(file.Name);
                
            }
        
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
