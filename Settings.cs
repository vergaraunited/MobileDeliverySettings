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
    public class Settings : Notification, IMDMMessage
    {
        static ISettings AppSettings
        {
            get
            {
                if (CrossSettings.IsSupported)
                    return CrossSettings.Current;
                return null; // or your custom implementation
            }
        }

        static Settings settings;
        public static Settings Current
        {
            get { return settings ?? (settings = new Settings()); }
        }

        public void ClearAll()
        {
            AppSettings.Clear();
        }

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
        private static readonly string UMDUrlDefault = GlobalSetting.Config.srvSet.umdurl;

        private const string idUMDPort = "UMDPort";
        private static readonly int UMDPortDefault = GlobalSetting.Config.srvSet.umdport;
       // private static readonly object GlobalSetting;

        #endregion
        public string LogPath
        {
            get
            {
                return AppSettings.GetValueOrDefault(idLogLevel, LogPathDefault);
            }
            set
            {
                if (AppSettings.AddOrUpdateValue(idLogPath, value))
                    OnPropertyChanged();
            }
        }
        public string LogLevel
        {
            get
            {
                return AppSettings.GetValueOrDefault(idLogLevel, LogLevelDefault);
            }
            set
            {
                if (AppSettings.AddOrUpdateValue(idLogLevel, value))
                    OnPropertyChanged();
            }
        }

        public string Url
        {
            get
            {
                return AppSettings.GetValueOrDefault(idUrl, UrlDefault);
            }
            set
            {
                if(AppSettings.AddOrUpdateValue(idUrl, value))
                    OnPropertyChanged();
            }
        }
        public int Port
        {
            get
            {
                return AppSettings.GetValueOrDefault(idPort, PortDefault);
            }
            set
            {
                if(AppSettings.AddOrUpdateValue(idPort, value))
                    OnPropertyChanged();
            }
        }


        public string WinsysUrl
        {
            get
            {
                return AppSettings.GetValueOrDefault(idWinsysUrl, WinsysUrlDefault);
            }
            set
            {
                if(AppSettings.AddOrUpdateValue(idWinsysUrl, value))
                    OnPropertyChanged();
            }
        }

        public int WinsysPort
        {
            get
            {
                return AppSettings.GetValueOrDefault(idWinsysPort, WinsysPortDefault);
            }
            set
            {
                if(AppSettings.AddOrUpdateValue(idWinsysPort, value))
                    OnPropertyChanged();
            }
        }

        public string UMDUrl
        {
            get
            {
                return AppSettings.GetValueOrDefault(idUMDUrl, UMDUrlDefault);
            }
            set
            {
                if(AppSettings.AddOrUpdateValue(idUMDUrl, value))
                    OnPropertyChanged();
            }
        }

        public int UMDPort
        {
            get
            {
                return AppSettings.GetValueOrDefault(idUMDPort, UMDPortDefault);
            }
            set
            {
                if(AppSettings.AddOrUpdateValue(idUMDPort, value))
                    OnPropertyChanged();
            }
        }

        public UMDAppConfig LoadConfig()
        {
            return new UMDAppConfig()
            {
                AppName = "",
                LogLevel = (LogLevel)Enum.Parse(typeof(LogLevel), Settings.Current.LogLevel),
                LogPath = Settings.Current.LogPath
            };
        }
        public MsgTypes.eCommand Command { get; set; }
        public Guid RequestId { get; set; }
    }
}
