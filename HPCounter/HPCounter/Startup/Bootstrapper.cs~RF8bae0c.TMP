using Autofac;
using HPCounter.Model;
using HPCounter.ViewModel;

namespace HPCounter.Startup
{
    class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();

            builder.RegisterType<Condition>().As<ICondition>();
            builder.RegisterType<Monster>().As<IMonster>();

            return builder.Build();
        }
    }
}
