﻿using MetroOffice.AdministrationService.Application.Contracts;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;

namespace MetroOffice.AdministrationService.HttpApi
{
    [DependsOn(
        typeof(AdministrationServiceApplicationContractsModule),
        typeof(AbpPermissionManagementHttpApiModule),
        typeof(AbpFeatureManagementHttpApiModule),
        typeof(AbpSettingManagementHttpApiModule)
        )]
    public class AdministrationServiceHttpApiModule : AbpModule
    {

    }
}
