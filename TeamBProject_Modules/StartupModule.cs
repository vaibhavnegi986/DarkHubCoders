using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBProject_Modules.ViewModels;
using TeamBProject_Modules.Views;

namespace TeamBProject_Modules
{
    public class StartupModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //View Register Only
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("LoginRegion", typeof(LoginView));
            regionManager.RegisterViewWithRegion("DashboardRegion", typeof(DashboardView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //View Register Only
            containerRegistry.RegisterForNavigation<LoginView, LoginViewViewModel>();
            containerRegistry.RegisterForNavigation<DashboardView, DashboardViewViewModel>();
        }
    }
}
