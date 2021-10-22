﻿using MetroOffice.AdministrationService.Application.Contracts;
using MetroOffice.AdministrationService.Domain;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;

namespace MetroOffice.AdministrationService.Application
{
    [DependsOn(
        typeof(AdministrationServiceDomainModule),
        typeof(AdministrationServiceApplicationContractsModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule),
        typeof(AbpSettingManagementApplicationModule)
        )]
    public class AdministrationServiceApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<AdministrationServiceApplicationModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AdministrationServiceApplicationModule>(validate: true);
            });
        }
    }
}
