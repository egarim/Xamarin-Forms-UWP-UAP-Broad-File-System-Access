using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

namespace XFUWPFileSystem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DirSearch(@"C:\");
        }
        public async void DirSearch(string sDir)
        {
            List<string> Directories = new List<string>();
            var folder = await StorageFolder.GetFolderFromPathAsync(sDir);
      
            foreach (var Folder in await folder.GetFoldersAsync())
            {
                Debug.WriteLine(Folder.Name);
                Directories.Add(Folder.Name);

            }
            this.Fs.ItemsSource = Directories;
           
        }
    }
}
