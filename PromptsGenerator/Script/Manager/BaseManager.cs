using Oowada.PromptsGenerator.Common;
using Oowada.PromptsGenerator.ConfigReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Oowada.PromptsGenerator.ConfigReader.BaseConfigReader;

namespace Oowada.PromptsGenerator.Manager
{
    /// <summary>
    /// 管理类的基类
    /// </summary>
    internal class BaseManager
    {
        /// <summary>
        /// 保存配置阅读器
        /// </summary>
        protected static SavedConfigReader savedConfigReader = new SavedConfigReader();
        /// <summary>
        /// 语言配置阅读器
        /// </summary>
        protected static LanguageConfigReader languageConfigReader = new LanguageConfigReader();
        /// <summary>
        /// 本地化配置阅读器
        /// </summary>
        protected static LocaleConfigReader localeConfigReader = new LocaleConfigReader();
        /// <summary>
        /// Prompt配置阅读器
        /// </summary>
        protected static PromptConfigReader promptConfigReader = new PromptConfigReader();

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Init()
        {
            savedConfigReader.Read(Const.SavedConfigFilePath);
            languageConfigReader.Read(Const.LanguageConfigFilePath);
        }

        /// <summary>
        /// 添加配置阅读器语法错误委托
        /// </summary>
        /// <param name="configReader">配置阅读器</param>
        /// <param name="onSyntaxError">委托</param>
        protected static void AddConfigReaderOnSyntaxError(BaseConfigReader configReader, Action<object, SyntaxErrorArgs> onSyntaxError)
        {
            configReader.AddOnSyntaxError(onSyntaxError);
        }

        /// <summary>
        /// 移除配置阅读器语法错误委托
        /// </summary>
        /// <param name="configReader">配置阅读器</param>
        /// <param name="onSyntaxError">委托</param>
        protected static void RemoveConfigReaderOnSyntaxError(BaseConfigReader configReader, Action<object, SyntaxErrorArgs> onSyntaxError)
        {
            configReader.RemoveOnSynctaxError(onSyntaxError);
        }

        /// <summary>
        /// 添加配置阅读器文件未发现委托
        /// </summary>
        /// <param name="configReader">配置阅读器</param>
        /// <param name="onFileNotFound">委托</param>
        protected static void AddConfigReaderOnFileNotFound(BaseConfigReader configReader, Action<object, FileNotFoundArgs> onFileNotFound)
        {
            configReader.AddOnFileNotFound(onFileNotFound);
        }

        /// <summary>
        /// 移除配置阅读器文件未发现委托
        /// </summary>
        /// <param name="configReader">配置阅读器</param>
        /// <param name="onFileNotFound">委托</param>
        protected static void RemoveConfigReaderOnFileNotFound(BaseConfigReader configReader, Action<object, FileNotFoundArgs> onFileNotFound)
        {
            configReader.RemoveFileNotFound(onFileNotFound);
        }

        /// <summary>
        /// 添加保存配置阅读器语法错误的委托
        /// </summary>
        /// <param name="onSyntaxError">委托</param>
        public static void AddSavedConfigReaderOnSyntaxError(Action<object, SyntaxErrorArgs> onSyntaxError)
        {
            AddConfigReaderOnSyntaxError(savedConfigReader, onSyntaxError);
        }

        /// <summary>
        /// 移除保存配置阅读器语法错误的委托
        /// </summary>
        /// <param name="onSyntaxError">委托</param>
        public static void RemoveSavedConfigReaderOnSyntaxError(Action<object, SyntaxErrorArgs> onSyntaxError)
        {
            RemoveConfigReaderOnSyntaxError(savedConfigReader, onSyntaxError);
        }

        public static void AddSavedConfigReaderOnFileNotFound(Action<object, FileNotFoundArgs> onFileNotFound)
        {
            AddConfigReaderOnFileNotFound(savedConfigReader, onFileNotFound);
        }

        public static void RemoveSavedConfigReaderOnFileNotFound(Action<object, FileNotFoundArgs> onFileNotFound)
        {
            RemoveConfigReaderOnFileNotFound(savedConfigReader, onFileNotFound);
        }
    }
}
