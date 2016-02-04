using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using PrismDemo.Infrastructure;

namespace ModuleAModule
{
    public class ModuleAModule : IModule
    {
        private IUnityContainer container;
        private IRegionManager regionManager;

        public ModuleAModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            container.Resolve<ToolbarView>();
            container.Resolve<ContentView>();
            regionManager.AddToRegion(RegionNames.ToolbarRegion, container.Resolve<ToolbarView>());
            regionManager.AddToRegion(RegionNames.ToolbarRegion, container.Resolve<ToolbarView>());
            regionManager.AddToRegion(RegionNames.ToolbarRegion, container.Resolve<ToolbarView>());
            regionManager.AddToRegion(RegionNames.ToolbarRegion, container.Resolve<ToolbarView>());
            regionManager.AddToRegion(RegionNames.ToolbarRegion, container.Resolve<ToolbarView>());
            regionManager.AddToRegion(RegionNames.ToolbarRegion, container.Resolve<ToolbarView>());

            regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ContentView));
        }
    }
}
