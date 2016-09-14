using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Collections;
using System.IO;

namespace ND.MCJ.Framework
{
    /// <summary>
    /// 用于读取和设置AppSetting配置文件
    /// </summary>
    public class Configuration
    {
        public Configuration() { }

        #region Add
        /// <summary>
        /// 往AppSetting添加键值对，如果Key已存在，value则会用逗号分割并累加，仅修改缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Add(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
        }

        /// <summary>
        /// 往AppSetting添加键值对,，如果Key已存在，value则会用逗号分割并累加,修改物理文件
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="filePath">外部配置文件路径</param>
        public static void Add(string key, string value, string filePath)
        {
            var config = Config(filePath);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
        }
        #endregion

        #region Remove
        /// <summary>
        /// 根据Key来删除appSettings
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(string key)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(key);
            config.Save(ConfigurationSaveMode.Modified);
        }

        /// <summary>
        /// 根据Key来删除appSettings
        /// </summary>
        /// <param name="key"></param>
        /// <param name="filePath"></param>
        public static void Remove(string key, string filePath)
        {
            var config = Config(filePath);
            config.AppSettings.Settings.Remove(key);
            config.Save(ConfigurationSaveMode.Modified);
        }
        #endregion

        #region Get
        /// <summary>
        /// 取得appSettings里的值
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>值</returns>
        public static string Get(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// 获取对应路径的appSettings的键值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string Get(string key, string filePath)
        {
            return GetCollection(filePath)[key].Value;
        }

        /// <summary>
        /// 取得appSettings里的值列表
        /// </summary>
        /// <param name="filePath">配置文件路径</param>
        /// <returns>值列表</returns>
        public static KeyValueConfigurationCollection GetCollection(string filePath)
        {
            return Config(filePath).AppSettings.Settings;
        }
        #endregion

        #region Set
        /// <summary>
        /// 设置appSetting的值，会修改物理文件
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="filePath">App.config文件路径</param>
        public static void Set(string key, string value, string filePath)
        {
            var configuration = Config(filePath);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
        }

        /// <summary>
        /// 设置appSetting的值，仅修改缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public static void Set(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        #endregion

        /// <summary>
        /// 获取对应路径的FileMap，仅修改缓存
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static System.Configuration.Configuration Config(string filePath)
        {
            var runpath = AppDomain.CurrentDomain.BaseDirectory;
            runpath = runpath.EndsWith(@"\") ? runpath : runpath + @"\";
            runpath = runpath.Contains(@"\bin\") ? runpath + "/../../" : runpath;
            var path = Path.GetFullPath(runpath + filePath);
            return ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap { ExeConfigFilename = path }, ConfigurationUserLevel.None);
        }
    }
}