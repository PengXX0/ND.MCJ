using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using ND.MCJ.DataProvider;
using ND.MCJ.Model;
using System;
using System.Web.Http;
using System.Web.Mvc;

namespace ND.MCJ.IOC
{
    public class AutofacResolver
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            var baseType = typeof(IDependency);
            var assemblys = AppDomain.CurrentDomain.GetAssemblies();
            builder.RegisterControllers(assemblys).InstancePerLifetimeScope();
            builder.RegisterApiControllers(assemblys).InstancePerLifetimeScope();
            builder.Register(s => new ResponseModel()).InstancePerLifetimeScope();

            #region 三种注册方法
            //方法一、手动注入，每个类对应的接口都要注入一遍
            //builder.RegisterType<UsersRepository>().As<IUsersRepository>().SingleInstance();
            //builder.RegisterType<UsersService>().As<IUsersService>().SingleInstance();

            //方法二、自动注入，只需把底层被继承的IDependency注入一遍即可实现全局注入
            //builder.RegisterTypes(assemblys.SelectMany(s => s.GetTypes())
            //       .Where(p => baseType.IsAssignableFrom(p) && p != baseType).ToArray())
            //       .AsImplementedInterfaces().InstancePerLifetimeScope();

            //方法三、自动注入，跟方法二类似，只是更简洁
            builder.RegisterAssemblyTypes(assemblys).Where(t => baseType.IsAssignableFrom(t) && t != baseType)
                   .AsImplementedInterfaces().InstancePerLifetimeScope();
            #endregion

            var container = builder.Build();
            //解析到 MVC
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //解析到 WebAPI
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
