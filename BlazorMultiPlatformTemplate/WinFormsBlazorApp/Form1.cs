using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using SharedLibrary;
using SharedLibrary.Data;

namespace WinFormsBlazorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddSingleton<WeatherForecastService>();
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");
        }

        private void blazorWebView1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}