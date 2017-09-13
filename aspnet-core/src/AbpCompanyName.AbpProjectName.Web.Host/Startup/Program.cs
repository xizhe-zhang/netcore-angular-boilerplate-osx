﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AbpCompanyName.AbpProjectName.Web.Host.Startup
{
    public class Program
    {
		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.UseUrls("http://localhost:5200/")
				.Build();
    }
}
