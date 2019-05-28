using Module2.Views;
using Prism.Modularity;
using Prism.Regions;

namespace Module2
{
  public class Module2 : IModule
  {
    readonly IRegionManager _regionManager;

    public Module2(IRegionManager regionManager)
    {
      _regionManager = regionManager;
    }

    public void Initialize()
    {
      _regionManager.RegisterViewWithRegion("ContentRegion2", typeof(View));
    }
  }
}