using Oowada.PromptsGenerator.ConfigReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Oowada.PromptsGenerator.ConfigReader.BaseConfigReader;

namespace Oowada.PromptsGenerator.Manager
{
    /// <summary>
    /// Prompt管理类
    /// </summary>
    internal class PromptManager : BaseManager
    {
        /// <summary>
        /// 当前Prompt配置文件路径
        /// </summary>
        public static string CurrentConfigFilePath { get; private set; }

        /// <summary>
        /// 初始化Prompt配置
        /// </summary>
        public static void InitPromptConfig()
        {
            CurrentConfigFilePath = savedConfigReader.Get("Prompt");
            LoadPromptConfig();
        }

        /// <summary>
        /// 选择Prompt配置文件
        /// </summary>
        /// <param name="promptConfigPath">配置文件路径</param>
        public static void SelectPromptConfig(string promptConfigPath)
        {
            if (CurrentConfigFilePath != promptConfigPath)
            {
                CurrentConfigFilePath = promptConfigPath;
                LoadPromptConfig();
                savedConfigReader.Set("Prompt", promptConfigPath);
                savedConfigReader.Save();
            }
        }

        /// <summary>
        /// 加载Prompt配置文件
        /// </summary>
        private static void LoadPromptConfig()
        {
            promptConfigReader.Read(CurrentConfigFilePath);
        }

        /// <summary>
        /// 获取配置
        /// </summary>
        /// <returns>配置</returns>
        public static Dictionary<string, Dictionary<string, string>> GetConfig()
        {
            return promptConfigReader.Config;
        }

        /// <summary>
        /// 根据类型获取所有的关键字和Prompt
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns>所有的关键字和Prompt</returns>
        public static Dictionary<string, string> GetTokenPrompts(string type)
        {
            return promptConfigReader.GetPrompts(type);
        }

        /// <summary>
        /// 获取Prompt
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="token">关键字</param>
        /// <returns>Prompt</returns>
        public static string GetPrompt(string type, string token)
        {
            return promptConfigReader.GetPrompts(type)[token];
        }

        /// <summary>
        /// 获取通用Prompt
        /// </summary>
        /// <returns>通用Prompt</returns>
        public static string GetCommonPrompt()
        {
            return savedConfigReader.Get("CommonPrompt");
        }

        /// <summary>
        /// 设置通用Prompt
        /// </summary>
        /// <param name="prompt">通用Prompt</param>
        public static void SetCommonPrompt(string prompt)
        {
            savedConfigReader.Set("CommonPrompt", prompt);
            savedConfigReader.Save();
        }

        /// <summary>
        /// 获取通用Negative Prompt
        /// </summary>
        /// <returns>通用Negative Prompt</returns>
        public static string GetCommonNegativePrompt()
        {
            return savedConfigReader.Get("CommonNegativePrompt");
        }

        /// <summary>
        /// 设置通用Negative Prompt
        /// </summary>
        /// <param name="prompt">通用Negative Prompt</param>
        public static void SetNegativeCommonPrompt(string prompt)
        {
            savedConfigReader.Set("CommonNegativePrompt", prompt);
            savedConfigReader.Save();
        }

        /// <summary>
        /// 添加Prompt配置阅读器语法错误的委托
        /// </summary>
        /// <param name="onSyntaxError">委托</param>
        public static void AddPromptConfigReaderOnSyntaxError(Action<object, BaseConfigReader.SyntaxErrorArgs> onSyntaxError)
        {
            AddConfigReaderOnSyntaxError(promptConfigReader, onSyntaxError);
        }

        /// <summary>
        /// 移除Prompt配置阅读器语法错误的委托
        /// </summary>
        /// <param name="onSyntaxError">委托</param>
        public static void RemovePromptConfigReaderOnSyntaxError(Action<object, BaseConfigReader.SyntaxErrorArgs> onSyntaxError)
        {
            RemoveConfigReaderOnSyntaxError(promptConfigReader, onSyntaxError);
        }

        /// <summary>
        /// 添加Prompt配置阅读器文件未发现的委托
        /// </summary>
        /// <param name="onFileNotFound">委托</param>
        public static void AddPromptConfigReaderOnFileNotFound(Action<object, FileNotFoundArgs> onFileNotFound)
        {
            AddConfigReaderOnFileNotFound(promptConfigReader, onFileNotFound);
        }

        /// <summary>
        /// 移除Prompt配置阅读器文件未发现的委托
        /// </summary>
        /// <param name="onFileNotFound">委托</param>
        public static void RemovePromptConfigReaderOnFileNotFound(Action<object, FileNotFoundArgs> onFileNotFound)
        {
            RemoveConfigReaderOnFileNotFound(promptConfigReader, onFileNotFound);
        }
    }
}
