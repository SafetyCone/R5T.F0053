using System;

using R5T.T0132;


namespace R5T.F0053
{
	[FunctionalityMarker]
	public partial interface ICodeFileGenerator : IFunctionalityMarker
	{
		public void CreateDocumentationFile(
			 string filePath,
			 string namespaceName,
			 string description)
		{
			var text =
$@"
using System;


namespace {namespaceName}
{{
	/// <summary>
	/// {description}
	/// </summary>
	public static class Documentation
	{{
	}}
}}
";

			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}

		public void CreateInstancesFile(
			string filePath,
			string namespaceName)
		{
			var text =
$@"
using System;


namespace {namespaceName}
{{
    public static class Instances
    {{
		
    }}
}}
";

			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}

		public void CreateProgramFile(
			string filePath,
			string namespaceName)
		{
			var text =
$@"
using System;


namespace {namespaceName}
{{
    class Program
    {{
        static void Main()
        {{
            Console.WriteLine(""Hello World!"");
        }}
    }}
}}
";
			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}

		public void CreateProgramFile_WebApplication(
	string filePath,
	string namespaceName)
		{
			var text =
$@"
using System;

using Microsoft.AspNetCore.Builder;


namespace {namespaceName}
{{
    public class Program
    {{
        public static void Main(string[] args)
        {{
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet(""/"", () => ""Hello World!"");

            app.Run();
        }}
    }}
}}
";
			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}

		public void CreateProgramFile_WebApplication_WithConfigurers(
			string filePath,
			string namespaceName)
		{
			var text =
$@"
using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;


namespace {namespaceName}
{{
    public class Program
    {{
        public static async Task Main()
        {{
            await R5T.F0065.Instances.WebApplication
                .ConfigureServices(async services =>
                {{
                    await services.UseServicesConfigurer<ServicesConfigurer>();
                }})
                .ConfigureServices(services =>
                {{

                }})
                .ConfigureWebApplicationBuilder(async webApplicationBuilder =>
                {{
                    await webApplicationBuilder.UseWebApplicationBuilderConfigurer<WebApplicationBuilderConfigurer>();
                }})
                .Build()
                .ConfigureWebApplication(webApplication =>
                {{
                    webApplication.MapGet(""/"", () => ""Hello World!"");
                }})
                .ConfigureWebApplication(async webApplication =>
                {{
                    await webApplication.UseWebApplicationConfigurer<WebApplicationConfigurer>();
                }})
                .Run();
        }}
    }}
}}
";
			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}

		public void CreateProgramFile_ProgramAsService(
			string filePath,
			string namespaceName)
		{
			var text =
$@"
using System;
using System.Threading.Tasks;


namespace {namespaceName}
{{
    partial class Program
    {{
        public Task Run()
        {{
            Console.WriteLine(""Hello world!"");

            return Task.CompletedTask;
        }}
    }}
}}
";
			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}

		public void CreateProgramFile_ProgramEntryPoint(
			string filePath,
			string namespaceName)
		{
			var text =
$@"
using System;
using System.Threading.Tasks;

using R5T.F0037;


namespace {namespaceName}
{{
    partial class Program : IAsynchronousProgram
    {{
        static async Task Main()
        {{
            await R5T.F0037.Instances.Program
                .ConfigureServices(servicesBuilder =>
                {{
                    return servicesBuilder.UseServicesConfigurer<ServicesConfigurer>();
                }})
                .Run<Program>();
        }}
    }}
}}
";
			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}

		public void CreateServiceDefinition(
			string filePath,
			string namespaceName,
			string serviceDefinitionInterfaceTypeName)
		{
			var text =
$@"
using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace {namespaceName}
{{
	[ServiceDefinitionMarker]
    public interface {serviceDefinitionInterfaceTypeName} : IServiceDefinition
    {{
        
    }}
}}
";
			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}

		public void CreateServicesConfigurer(
			string filePath,
			string namespaceName)
		{
			var text =
$@"
using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using R5T.F0036.F001;


namespace {namespaceName}
{{
    public class ServicesConfigurer : IServicesConfigurer
    {{
        public Task ConfigureServices(IServiceCollection services)
        {{
            R5T.F0035.ServicesOperator.Instance.AddLogging(services);

            return Task.CompletedTask;
        }}
    }}
}}
";
			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}

		public void CreateWebApplicationBuilderConfigurer(
			string filePath,
			string namespaceName)
		{
			var text =
$@"
using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;

using R5T.F0066;


namespace {namespaceName}
{{
    public class WebApplicationBuilderConfigurer : IWebApplicationBuilderConfigurer
    {{
        public async Task ConfigureWebApplicationBuilder(WebApplicationBuilder webApplicationBuilder)
        {{
            
        }}
    }}
}}
";
			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}

		public void CreateWebApplicationConfigurer(
			string filePath,
			string namespaceName)
		{
			var text =
$@"
using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;

using R5T.F0066;


namespace {namespaceName}
{{
    public class WebApplicationConfigurer : IWebApplicationConfigurer
    {{
        public async Task ConfigureWebApplication(WebApplication webApplication)
        {{
            
        }}
    }}
}}
";
			Instances.TextFileGenerator.WriteText(
				filePath,
				text);
		}
	}
}