namespace Linea.ActorModel
{
    using Akka.Actor;
    using Akka.DI.Ninject;
    using Ninject;

    public static class ActorSystemReference
    {
        public static ActorSystem ActorSystem { get; private set; }

        static ActorSystemReference()
        {
            CreateActorSystem();
        }

        private static void CreateActorSystem()
        {
            ActorSystem = Akka.Actor.ActorSystem.Create("LineaActorSystem");

            var container = new StandardKernel();
            var resolver = new NinjectDependencyResolver(container, ActorSystem);
        }
    }
}