using ImageStorageSystem.Lib.Models;
using Newtonsoft.Json;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageStorageSystem.ImageViewer.CLient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnGetData.Click += async (s, e) => {

                var dataSourceUrls = new List<string>
                {
                    "https://localhost:44384", //Local
                    "https://localhost:44313" //Online
                }.GetEnumerator();

                var fallbackPolicy = Policy<IList<ImageInfo>>
                .Handle<HttpRequestException>()
                .FallbackAsync(fallbackAction: async (ct) => {
                    if (dataSourceUrls.MoveNext())
                        return await GetDataAsync(dataSourceUrls.Current);

                    return null;
                });

                //Start
                dataSourceUrls.MoveNext();
                var images = await fallbackPolicy.ExecuteAsync(async () => await GetDataAsync(dataSourceUrls.Current));
                lbImages.ItemsSource = images;
            };
        }

        private async Task<IList<ImageInfo>> GetDataAsync(string url)
        {
            var _httpClient = new HttpClient();
            var response = await _httpClient.GetAsync($"{url}/api/image");
            if (response.IsSuccessStatusCode)
            {
                var images = JsonConvert.DeserializeObject<List<ImageInfo>>(await response.Content.ReadAsStringAsync());
                return images;
            }

            return null;
        }
    }
}
