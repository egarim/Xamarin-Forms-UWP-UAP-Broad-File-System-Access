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
        public async void DirSearch(string sDir)
        {
            var ext = new List<string> { ".txt", ".zip" };
            var folder = await StorageFolder.GetFolderFromPathAsync(sDir);
            //var ExactLocalFolder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("ExactLocalFolder");
            foreach (var file in await folder.GetFilesAsync())
            {
                Debug.WriteLine(file.Name);
                
            }
            //copy the files to the folder that you want to save the extract file into
            //foreach (var file in await ExactLocalFolder.GetFilesAsync())
            //{
            //    await file.CopyAsync(folder);
            //}
            ////delete the folder in the local folder
            //await ExactLocalFolder.DeleteAsync();
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
