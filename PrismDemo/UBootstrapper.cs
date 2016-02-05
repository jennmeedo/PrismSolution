using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using PrismDemo.Infrastructure;

namespace PrismDemo
{
    public class UBootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()

        {
            return Container.Resolve<Shell>();
        }


        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window) Shell;
            Application.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var catalog = new DirectoryModuleCatalog();
            catalog.ModulePath = @".\modules";
            return catalog;
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            RegionAdapterMappings mapping = base.ConfigureRegionAdapterMappings();
            mapping.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
            return mapping;
        }

        
    }
}
