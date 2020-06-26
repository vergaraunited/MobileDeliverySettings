using MobileDeliveryLogger;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using MobileDeliveryGeneral.Definitions;
using MobileDeliverySettings.Settings;

namespace MobileDeliverySettings
{
    public static class SettingsAPI
    {
        //private Settings(){
        //    if (settings == null) settings = new Settings();
        //}
        static ISettings AppSettings
        {
            get
            {
                if (CrossSettings.IsSupported)
                    return CrossSettings.Current;
                return null; // or your custom implementation
            }
        }

        //static Settings settings;
        //public static Settings Current()
        //{
        //    if (AppSettings != null) return AppSettings;
        //    else
        //    {
        //        settings = new Settings();
        //        return settings;
        //    }
        //}

        //public void ClearAll()
        //{
        //    AppSettings.Clear();
        //}

        #region Setting Constants

        private const string idLogPath = "LogPath";
        private static readonly string LogPathDefault = string.Empty;

        private const string idLogLevel = "LogLevel";
        private static readonly string LogLevelDefault = string.Empty;

        private const string idUrl = "Url";
        private static readonly string UrlDefault = string.Empty;

        private const string idPort = "Port";
        private static readonly int PortDefault = 0;

        private const string idWinsysUrl = "WinsysUrl";
        private static readonly string WinsysUrlDefault = string.Empty;

        private const string idWinsysPort = "WinsysPort";
        private static readonly int WinsysPortDefault = 8181;

        private const string idUMDUrl = "UMDUrl";
        private static readonly string UMDUrlDefault = "localhost";

        private const string idUMDPort = "UMDPort";
        private static readonly int UMDPortDefault = 81;

        //SQLLite Cache Paths
        private const string idTruckCachePath = "TruckCachePath";
        private static readonly string TruckCachePathDefault = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\UMDDB_Trucks.db3";

        private const string idOrderCachePath = "OrderCachePath";
        private static readonly string OrderCachePathDefault = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\UMDDB_Orders.db3";

        private const string idStopCachePath = "StopCachePath";
        private static readonly string StopCachePathDefault = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\UMDDB_Stops.db3";

        private const string idOrderDetailCachePath = "OrderDetailCachePath";
        private static readonly string OrderDetailCachePathDefault = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\UMDDB_OrderDetails.db3";

        private const string idOrderOptionCachePath = "OrderOptionCachePath";
        private static readonly string OrderOptionCachePathDefault = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\UMDDB_OrderOptions.db3";

        private const string idSQLConn = "SQLConn";
        private static readonly string SQLConnDefault = @"Data Source=WIN-50GP30FGO75,1433;Initial Catalog=Demodb;User ID=wtssa;Password=demol23";

        private const string idAppName = "AppName";
        private static readonly string AppNameDefault = "defaultAppName";

        private const string idKeepAlive = "KeepAlive";
        private static readonly int KeepAliveDefault = 60000;

        private const string idRetry = "Retry";
        private static readonly int RetryDefault = 60000;

        private const string idReconTimeout = "ReconTimeout";
        private static readonly int ReconTimeoutDefault = 60000;

        private const string idErrReconTimeout = "ErrReconTimeout";
        private static readonly int ErrReconTimeoutDefault = 60000;

        // private static readonly object GlobalSetting;

        #endregion

        public static string AppName
        {
            get
            {
                return AppSettings.GetValueOrDefault(idAppName, AppNameDefault);
            }
            set
            {
                // if (
                AppSettings.AddOrUpdateValue(idAppName, value); //)
                                                                // OnPropertyChanged();
            }
        }
        public static string LogPath
        {
            get
            {
                return AppSettings.GetValueOrDefault(idLogPath, LogPathDefault);
            }
            set
            {
                // if (
                AppSettings.AddOrUpdateValue(idLogPath, value); //)
                   // OnPropertyChanged();
            }
        }
        public static string LogLevel
        {
            get
            {
                return AppSettings.GetValueOrDefault(idLogLevel, LogLevelDefault);
            }
            set
            {

                AppSettings.AddOrUpdateValue(idLogLevel, value);
            }
        }

        public static string Url
        {
            get
            {
                return AppSettings.GetValueOrDefault(idUrl, UrlDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idUrl, value);
            }
        }
        public static int Port
        {
            get
            {
                return AppSettings.GetValueOrDefault(idPort, PortDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idPort, value);
            }
        }


        public static string WinsysUrl
        {
            get
            {
                return AppSettings.GetValueOrDefault(idWinsysUrl, WinsysUrlDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idWinsysUrl, value);
            }
        }

        public static int WinsysPort
        {
            get
            {
                return AppSettings.GetValueOrDefault(idWinsysPort, WinsysPortDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idWinsysPort, value);
            }
        }

        public static string UMDUrl
        {
            get
            {
                return AppSettings.GetValueOrDefault(idUMDUrl, UMDUrlDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idUMDUrl, value);
            }
        }
        public static string SQLConn
        {
            get
            {
                return AppSettings.GetValueOrDefault(idSQLConn, SQLConnDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idSQLConn, value);
            }
        }
        public static int UMDPort
        {
            get
            {
                return AppSettings.GetValueOrDefault(idUMDPort, UMDPortDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idUMDPort, value);
            }
        }


        
            public static string TruckCachePath
        {
            get
            {
                return AppSettings.GetValueOrDefault(idTruckCachePath, TruckCachePathDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idTruckCachePath, value);
            }
        }

        public static string OrderCachePath
        {
            get
            {
                return AppSettings.GetValueOrDefault(idOrderCachePath, OrderCachePathDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idOrderCachePath, value);
            }
        }
        public static string StopCachePath
        {
            get
            {
                return AppSettings.GetValueOrDefault(idStopCachePath, StopCachePathDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idStopCachePath, value);
            }
        }

        public static string OrderDetailCachePath
        {
            get
            {
                return AppSettings.GetValueOrDefault(idOrderDetailCachePath, OrderDetailCachePathDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idOrderDetailCachePath, value);
            }
        }
        public static string OrderOptionCachePath
        {
            get
            {
                return AppSettings.GetValueOrDefault(idOrderOptionCachePath, OrderOptionCachePathDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idOrderOptionCachePath, value);
            }
        }

        public static int KeepAlive {
            get
            {
                return AppSettings.GetValueOrDefault(idKeepAlive, KeepAliveDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idKeepAlive, value);
            }
        }
        public static int Retry
        {
            get
            {
                return AppSettings.GetValueOrDefault(idRetry, RetryDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idRetry, value);
            }
        }

        //get { return SettingsAPI.OrderCachePath; } set { SettingsAPI.OrderCachePath = value; OnPropertyChanged("OrderCachePath"); } }

        public static int ReconTimeout {
            get
            {
                return AppSettings.GetValueOrDefault(idReconTimeout, ReconTimeoutDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idReconTimeout, value);
            }
        }

        public static int ErrReconTimeout
        {
            get
            {
                return AppSettings.GetValueOrDefault(idErrReconTimeout, ErrReconTimeoutDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(idErrReconTimeout, value);
            }
        }

        public static UMDAppConfig LoadConfig()
        {
            ISettings set = SettingsAPI.AppSettings;

            return new UMDAppConfig()
            {
                AppName = "",
                LogLevel = (LogLevel)Enum.Parse(typeof(LogLevel), SettingsAPI.LogLevel),
                LogPath = set.GetValueOrDefault("LogPath", SettingsAPI.LogPath),
                SQLConn  = SQLConn,
               //  Version = 
            };
        }
        public static MsgTypes.eCommand Command { get; set; }
        public static Guid RequestId { get; set; }
    }
}
