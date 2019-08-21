Developer (Anuja Patel)

Prerequisites
	Visual Studio 2017 version 15.7 or later with these workloads:
	ASP.NET and web development (under Web & Cloud)
	.NET Core cross-platform development (under Other Toolsets)
	.NET Core 2.2 SDK.
	
Create a new project
	Open Visual Studio 2017
	File > New > Project
	From the left menu, select Installed > Visual C# > .NET Core.
	Select ASP.NET Core Web Application.
	Enter MultitenantInNetCore for the name and click OK.
	In the New ASP.NET Core Web Application dialog:
	Make sure that .NET Core and ASP.NET Core 2.1 are selected in the drop-down lists
	Select the Web Application (Model-View-Controller) project template
	Make sure that Authentication is set to No Authentication
	Click OK

Create the models which consists of table definition and classes which implements DbContext interface.

Create the database
	Tools > NuGet Package Manager > Package Manager Console
	Run the following commands:
		Add-Migration InitialCreate --Context {ContextName} 
		Update-Database
		
NOTE: Here we have 2 different models and 2 classes which implements DbContext interface. so, while running above commands we need to provide DbContext name too.

Create DatabaseTenantProvider class which implements ITenantProvider interface.

Add below in Startup.cs
var connection = @"";
services.AddDbContext<TenantsDbContext>(o => o.UseSqlServer(connection));
services.AddDbContext<PersonDbContext>(o => o.UseSqlServer(connection));

services.AddTransient<ITenantProvider, DatabaseTenantProvider>();
services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();