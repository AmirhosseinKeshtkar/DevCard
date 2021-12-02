using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DevCard_MVC {
    public class Program {
        public static void Main(string[] args) {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
        //public static IHostBuilder CreateHostBuilder(string[] args) {
        //    var assembly = typeof(Startup).GetTypeInfo().Assembly.FullName;
        //    return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(
        //        webBuilder => {
        //            //webBuilder.UseStartup<Startup>();
        //            webBuilder.UseStartup(assembly);
        //        });
        //}
    }
}
