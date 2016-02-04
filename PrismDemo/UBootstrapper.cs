using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;

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
            ModuleCatalog catalog = new ModuleCatalog();
            catalog.AddModule(typeof (ModuleAModule.ModuleAModule), InitializationMode.WhenAvailable);
            return catalog;
        }
    }
}
