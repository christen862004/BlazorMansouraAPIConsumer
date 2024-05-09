using BlazorMansouraAPIConsumer.Models;
using BlazorMansouraAPIConsumer.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorMansouraAPIConsumer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient<IService<Employee>, EmployeeService>
                (httpclient=>
                    httpclient.BaseAddress=
                        new Uri(builder.Configuration.GetValue<string>("Api1")));

            builder.Services.AddHttpClient<IService<Department>, DepartmentService>(
                httpclient=>
                    httpclient.BaseAddress=
                        new Uri(builder.Configuration.GetValue<string>("Api2"))
                );

            //builder.Services.AddScoped<IService<Employee>, EmployeeService>();
            //builder.Services.AddScoped<IService<Department>, DepartmentService>();
            //day3
            //builder.Services.AddScoped(sp =>
            //    new HttpClient {
            //        BaseAddress = new Uri(builder.Configuration.GetValue<string>("Api"))
            //        });

            await builder.Build().RunAsync();
        }
    }
}
