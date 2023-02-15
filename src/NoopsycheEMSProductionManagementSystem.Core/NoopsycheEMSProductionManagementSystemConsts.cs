using NoopsycheEMSProductionManagementSystem.Debugging;

namespace NoopsycheEMSProductionManagementSystem
{
    public class NoopsycheEMSProductionManagementSystemConsts
    {
        public const string LocalizationSourceName = "NoopsycheEMSProductionManagementSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "eeb22a07ffb34a18a1190c8d33f219d5";
    }
}
