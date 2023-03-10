using Geor.Debugging;

namespace Geor
{
    public class GeorConsts
    {
        public const string LocalizationSourceName = "Geor";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8be9197f50f346c09bf9bea0a8cad4b3";
    }
}
