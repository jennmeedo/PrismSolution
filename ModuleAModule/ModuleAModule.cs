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
    [Module(ModuleName = "ModuleA", OnDemand = true)]
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
            container.RegisterType<ToolbarView>();
            container.RegisterType<IContentAView,ContentView>();
            container.RegisterType<IContentAViewViewModel, ContentAViewViewModel>();
            regionManager.AddToRegion(RegionNames.ContentRegion, container.Resolve<ContentView>());
            regionManager.AddToRegion(RegionNames.ToolbarRegion, container.Resolve<ToolbarView>());
        }
    }
}
