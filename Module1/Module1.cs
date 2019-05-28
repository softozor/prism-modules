using Module1.Views;
using Prism.Modularity;
using Prism.Regions;

namespace Module1
{
  public class Module1 : IModule
  {
    readonly IRegionManager _regionManager;

    public Module1(IRegionManager regionManager)
    {
      _regionManager = regionManager;
    }

    public void Initialize()
    {
      _regionManager.RegisterViewWithRegion("ContentRegion", typeof(View));
    }
  }
}