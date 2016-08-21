using EcsRx.Events;
using EcsRx.Pools;
using EcsRx.Pools.Identifiers;
using EcsRx.Systems.Executor;
using EcsRx.Systems.Executor.Handlers;
using UniRx;
using Zenject;
using EcsRx.Groups;

namespace EcsRx.Unity.Installers
{
    public class DefaultEcsRxInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IMessageBroker>().To<MessageBroker>().AsSingle();
            Container.Bind<IEventSystem>().To<EventSystem>().AsSingle();
            Container.Bind<IIdentityGenerator>().To<SequentialIdentityGenerator>().AsSingle();
            Container.Bind<IPoolManager>().To<PoolManager>().AsSingle();

			Container.Bind<IReactiveGroup> ().To<ReactiveGroup> ();

            Container.Bind<IReactToDataSystemHandler>().To<ReactToDataSystemHandler>();
            Container.Bind<IReactToEntitySystemHandler>().To<ReactToEntitySystemHandler>();
            Container.Bind<IReactToGroupSystemHandler>().To<ReactToGroupSystemHandler>();
            Container.Bind<ISetupSystemHandler>().To<SetupSystemHandler>();
            Container.Bind<IManualSystemHandler>().To<ManualSystemHandler>();

            Container.Bind<ISystemExecutor>().To<SystemExecutor>().AsSingle();
        }
    }
}