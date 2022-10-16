using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oowada.PromptsGenerator.ConfigReader;
using Oowada.PromptsGenerator.Common;
using static Oowada.PromptsGenerator.ConfigReader.BaseConfigReader;

namespace Oowada.PromptsGenerator.Manager
{
    /// <summary>
    /// 本地化管理类
    /// </summary>
    internal class LocaleManager : BaseManager
    {
        /// <summary>
        /// 当前语言
        /// </summary>
        public static string CurrentLanguage { get; private set; }

        /// <summary>
        /// 加载当前选择的语言
        /// </summary>
        private static void LoadLanguage()
        {
            localeConfigReader.Read(languageConfigReader.Get(CurrentLanguage));
        }

        /// <summary>
        /// 选择语言
        /// </summary>
        /// <param name="language">要选择的语言</param>
        public static void SelectLanguage(string language)
        {
            if (CurrentLanguage != language)
            {
                CurrentLanguage = language;
                LoadLanguage();
                savedConfigReader.Set("Language", language);
                savedConfigReader.Save();
            }
        }

        /// <summary>
        /// 初始化语言
        /// </summary>
        public static void InitLanguage()
        {
            CurrentLanguage = savedConfigReader.Get("Language");
            LoadLanguage();
        }

        /// <summary>
        /// 获取本地化字符串
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>本地化字符串</returns>
        public static string Get(string key)
        {
            return localeConfigReader.Get(key);
        }

        /// <summary>
        /// 添加语言配置阅读器语法错误的委托
        /// </summary>
        /// <param name="onSyntaxError">委托</param>
        public static void AddLanguageConfigReaderOnSyntaxError(Action<object, BaseConfigReader.SyntaxErrorArgs> onSyntaxError)
        {
            AddConfigReaderOnSyntaxError(languageConfigReader, onSyntaxError);
        }

        /// <summary>
        /// 移除语言配置阅读器语法错误的委托
        /// </summary>
        /// <param name="onSyntaxError">委托</param>
        public static void RemoveLanguageConfigReaderOnSyntaxError(Action<object, BaseConfigReader.SyntaxErrorArgs> onSyntaxError)
        {
            RemoveConfigReaderOnSyntaxError(languageConfigReader, onSyntaxError);
        }

        /// <summary>
        /// 添加本地化配置阅读器语法错误的委托
        /// </summary>
        /// <param name="onSyntaxError">委托</param>
        public static void AddLocaleConfigReaderOnSyntaxError(Action<object, BaseConfigReader.SyntaxErrorArgs> onSyntaxError)
        {
            AddConfigReaderOnSyntaxError(localeConfigReader, onSyntaxError);
        }

        /// <summary>
        /// 移除本地化配置阅读器语法错误的委托
        /// </summary>
        /// <param name="onSyntaxError">委托</param>
        public static void RemoveLocaleConfigReaderOnSyntaxError(Action<object, BaseConfigReader.SyntaxErrorArgs> onSyntaxError)
        {
            RemoveConfigReaderOnSyntaxError(localeConfigReader, onSyntaxError);
        }

        /// <summary>
        /// 添加语言配置阅读器文件未找到的委托
        /// </summary>
        /// <param name="onFileNotFound">委托</param>
        public static void AddLanguageConfigReaderOnFileNotFound(Action<object, FileNotFoundArgs> onFileNotFound)
        {
            AddConfigReaderOnFileNotFound(languageConfigReader, onFileNotFound);
        }

        /// <summary>
        /// 移除语言配置阅读器文件未找到的委托
        /// </summary>
        /// <param name="onFileNotFound">委托</param>
        public static void RemoveLanguageConfigReaderOnFileNotFound(Action<object, FileNotFoundArgs> onFileNotFound)
        {
            RemoveConfigReaderOnFileNotFound(languageConfigReader, onFileNotFound);
        }

        /// <summary>
        /// 添加本地化配置阅读器文件未找到的委托
        /// </summary>
        /// <param name="onFileNotFound">委托</param>
        public static void AddLocaleConfigReaderOnFileNotFound(Action<object, FileNotFoundArgs> onFileNotFound)
        {
            AddConfigReaderOnFileNotFound(localeConfigReader, onFileNotFound);
        }

        /// <summary>
        /// 移除本地化配置阅读器文件未找到的委托
        /// </summary>
        /// <param name="onFileNotFound">委托</param>
        public static void RemoveLocaleConfigReaderOnFileNotFound(Action<object, FileNotFoundArgs> onFileNotFound)
        {
            RemoveConfigReaderOnFileNotFound(localeConfigReader, onFileNotFound);
        }

        /// <summary>
        /// 获取语言配置
        /// </summary>
        /// <returns>语言配置</returns>
        public static Dictionary<string, string> GetLanguageConfig()
        {
            return languageConfigReader.Config;
        }

        /// <summary>
        /// 获取本地化配置
        /// </summary>
        /// <returns>本地化配置</returns>
        public static Dictionary<string, string> GetLocaleConfig()
        {
            return localeConfigReader.Config;
        }
    }
}
