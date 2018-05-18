using Api.Implantacao.Data.Repositorio;
using Api.Implantacao.Data.UnityOfWork;
using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Azure.Documents;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Api.Implantacao
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnityOfWork>().As<IUnityOfWork<IDocumentClient>>();
            builder.RegisterType<RepositorioModeloNegocio>().As<IRepositorio<Data.Entidades.ModeloNegocio.ModeloNegocio, string>>();
            builder.RegisterType<RepositorioProfissao>().As<IRepositorio<Data.Entidades.ModeloNegocio.Profissao, int>>();
            builder.RegisterType<RepositorioSimulacao>().As<IRepositorio<Data.Entidades.Simulacao.Simulacao, string>>();
            builder.RegisterInstance<Serilog.ILogger>(new LoggerConfiguration()
                .WriteTo
                .RollingFile(@"c:\temp\log-{Date}.txt", retainedFileCountLimit: 1)
                .CreateLogger());

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
