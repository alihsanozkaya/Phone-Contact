using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Phone_Contact.Business.Abstract;
using Phone_Contact.Business.Concrete;
using Phone_Contact.Core.Utilities.Interceptors;
using Phone_Contact.DataAccess.Abstract;
using Phone_Contact.DataAccess.Concrete;


namespace Phone_Contact.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<PersonService>().As<IPersonService>();
            builder.RegisterType<PersonRepository>().As<IPersonRepository>();

          

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
