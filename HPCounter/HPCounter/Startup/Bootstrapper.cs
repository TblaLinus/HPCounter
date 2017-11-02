using Autofac;
using HPCounter.Model;

namespace HPCounter.Startup
{
    class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Condition>().As<ICondition>();
            builder.RegisterType<Monster>().As<IMonster>();

            return builder.Build();
        }
    }
}
