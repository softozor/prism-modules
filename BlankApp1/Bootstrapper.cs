using BlankApp1.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace BlankApp1
{
  public class Bootstrapper : UnityBootstrapper
  {
    protected override IModuleCatalog CreateModuleCatalog()
    {
      return new DirectoryModuleCatalog() { ModulePath = @".\\Modules" };
    }

    protected override DependencyObject CreateShell()
    {
      return Container.Resolve<MainWindow>();
    }

    protected override void InitializeShell()
    {
      Application.Current.MainWindow = Shell as Window;
      Application.Current.MainWindow.Show();
    }
  }
}
