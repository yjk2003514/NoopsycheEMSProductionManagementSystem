using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace NoopsycheEMSProductionManagementSystem.Localization
{
    public static class NoopsycheEMSProductionManagementSystemLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(NoopsycheEMSProductionManagementSystemConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NoopsycheEMSProductionManagementSystemLocalizationConfigurer).GetAssembly(),
                        "NoopsycheEMSProductionManagementSystem.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
