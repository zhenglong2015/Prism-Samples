﻿using Microsoft.Practices.Unity;
using ModuleA.Views;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        IRegionManager _regionManager;
        IUnityContainer _container;

        public ModuleAModule(RegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<PersonList>();
            _container.RegisterTypeForNavigation<PersonDetail>();

            _regionManager.RequestNavigate("ContentRegion", "PersonList");
        }
    }
}