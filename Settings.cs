using MobileDeliveryLogger;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using UMDGeneral.Definitions;
using UMDGeneral.Events;
using UMDGeneral.Interfaces.DataInterfaces;
using UMDGeneral.Settings;

namespace MobileDeliverySettings
{
    public static class Settings //: Notification, IMDMMessage
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

        private const string idSQLConn = "SQLConn";
        private static readonly string SQLConnDefault = @"Data Source=WIN-50GP30FGO75,1433;Initial Catalog=Demodb;User ID=wtssa;Password=demol23";

        private const string idAppName = "AppName";
        private static readonly string AppNameDefault = "defaultAppName";

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

        public static UMDAppConfig LoadConfig()
        {
            ISettings set = Settings.AppSettings;

            return new UMDAppConfig()
            {
                AppName = "",
                LogLevel = (LogLevel)Enum.Parse(typeof(LogLevel), Settings.LogLevel),
                LogPath = set.GetValueOrDefault("LogPath",Settings.LogPath),
                SQLConn  = SQLConn,
               //  Version = 
            };
        }
        public static MsgTypes.eCommand Command { get; set; }
        public static Guid RequestId { get; set; }
    }
}
