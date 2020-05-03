using MainScene;
using UI.Core;
using UI.Core.Interface;
using Zenject;

namespace Core.Installer
{
    public class AppInstaller : MonoInstaller<AppInstaller>
    {
        public override void InstallBindings()
        {
            // GameStorageInstaller
            // SettingsInstaller
            // UIInstaller
            
            Container.Bind<IUIStorage>().To<UIStorage>().AsSingle();
            Container.Bind<MainSceneController>().AsSingle().NonLazy();
        }
    }
}