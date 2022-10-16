using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oowada.PromptsGenerator.Common;

namespace Oowada.PromptsGenerator.ConfigReader
{
    /// <summary>
    /// 所有配置文件读取类的基类
    /// </summary>
    internal abstract class BaseConfigReader
    {
        /// <summary>
        /// 语法错误参数
        /// </summary>
        internal class SyntaxErrorArgs : EventArgs
        {
            /// <summary>
            /// 配置文件名称
            /// </summary>
            public string ConfigFileName { get; private set; }
            /// <summary>
            /// 出错的行号
            /// </summary>
            public int LineNumber { get; private set; }
            /// <summary>
            /// 初始化参数
            /// </summary>
            /// <param name="configFileName">配置文件名称</param>
            /// <param name="lineNumber">出错的行号</param>
            public SyntaxErrorArgs(string configFileName, int lineNumber)
            {
                ConfigFileName = configFileName;
                LineNumber = lineNumber;
            }

        }

        /// <summary>
        /// 文件未发现参数
        /// </summary>
        internal class FileNotFoundArgs : EventArgs
        {
            /// <summary>
            /// 配置文件类型
            /// </summary>
            internal enum ConfigFileType
            {
                Unknown,
                LanguageConfigFile,
                LocaleConfigFile,
                PromptConfigFile,
                SavedConfigFile
            }

            /// <summary>
            /// 配置文件路径
            /// </summary>
            public string FileName { get; private set; }

            /// <summary>
            /// 配置文件类型
            /// </summary>
            public ConfigFileType FileType { get; private set; }

            /// <summary>
            /// 初始化参数
            /// </summary>
            /// <param name="fileName">文件名</param>
            /// <param name="fileType">文件类型</param>
            public FileNotFoundArgs(string fileName, ConfigFileType fileType)
            {
                FileName = fileName;
                FileType = fileType;
            }
        }

        /// <summary>
        /// 文件未找到时执行的委托
        /// </summary>
        public Action<object, FileNotFoundArgs> OnFileNotFound { get; private set; }

        /// <summary>
        /// 语法错误时执行的委托
        /// </summary>
        public Action<object, SyntaxErrorArgs> OnSyntaxError { get; private set; }

        /// <summary>
        /// 读取指定的配置文件
        /// </summary>
        /// <param name="configFilePath">配置文件路径</param>
        public void Read(string configFilePath)
        {
            configFilePath = AddSubffix(configFilePath);
            if (File.Exists(configFilePath))
            {
                HandleFile(configFilePath);
            }
            else
            {
                OnFileNotFound?.Invoke(this, new FileNotFoundArgs(GetFileName(configFilePath), GetFileType(configFilePath)));
            }
        }

        /// <summary>
        /// 具体处理配置文件的过程
        /// </summary>
        /// <param name="configFilePath">配置文件路径</param>
        protected abstract void HandleFile(string configFilePath);

        /// <summary>
        /// 为无后缀的配置文件路径添加后缀，如果有后缀则不会添加
        /// </summary>
        /// <param name="configFilePath">配置文件</param>
        /// <returns>正确添加了后缀的配置文件路径</returns>
        protected string AddSubffix(string configFilePath)
        {
            if (!configFilePath.ToLower().EndsWith(Const.ConfigSubffix))
            {
                configFilePath += Const.ConfigSubffix;
            }
            return configFilePath;
        }

        /// <summary>
        /// 给定行是否是注释或空行
        /// </summary>
        /// <param name="line">行</param>
        /// <returns>是否是注释或空行</returns>
        protected bool IsCommentOrBlankLine(string line)
        {
            return string.IsNullOrWhiteSpace(line) || line.Trim()[0] == Const.CommentToken;
        }

        /// <summary>
        /// 根据文件路径获取最后的文件名
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns>文件名</returns>
        public static string GetFileName(string path)
        {
            return path.Split(new char[] { '/', '\\'}).Last();
        }

        /// <summary>
        /// 根据文件路径获取配置文件类型
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns>文件类型</returns>
        public static FileNotFoundArgs.ConfigFileType GetFileType(string path)
        {
            string name = GetFileName(path);
            FileNotFoundArgs.ConfigFileType type = FileNotFoundArgs.ConfigFileType.Unknown;
            if (name == GetFileName(Const.LanguageConfigFilePath))
            {
                type = FileNotFoundArgs.ConfigFileType.LanguageConfigFile;
            }
            else if (name == GetFileName(Const.SavedConfigFilePath))
            {
                type = FileNotFoundArgs.ConfigFileType.SavedConfigFile;
            }
            else if (path.Contains(Const.LocaleConfigDirectoryPath))
            {
                type = FileNotFoundArgs.ConfigFileType.LocaleConfigFile;
            }
            else if (path.Contains(Const.PromptConfigDirectoryPath))
            {
                type = FileNotFoundArgs.ConfigFileType.PromptConfigFile;
            }
            return type;
        }

        /// <summary>
        /// 添加语法错误时执行的委托
        /// </summary>
        /// <param name="onSyntaxError">委托</param>
        public void AddOnSyntaxError(Action<object, SyntaxErrorArgs> onSyntaxError)
        {
            OnSyntaxError += onSyntaxError;
        }

        /// <summary>
        /// 移除语法错误时执行的委托
        /// </summary>
        /// <param name="onSyntaxError">委托</param>
        public void RemoveOnSynctaxError(Action<object, SyntaxErrorArgs> onSyntaxError)
        {
            OnSyntaxError -= onSyntaxError; 
        }

        /// <summary>
        /// 添加文件未找到时执行的委托
        /// </summary>
        /// <param name="onFileNotFound">委托</param>
        public void AddOnFileNotFound(Action<object, FileNotFoundArgs> onFileNotFound)
        {
            OnFileNotFound += onFileNotFound;
        }

        /// <summary>
        /// 移除文件未找到时执行的委托
        /// </summary>
        /// <param name="onFileNotFound">委托</param>
        public void RemoveFileNotFound(Action<object, FileNotFoundArgs> onFileNotFound)
        {
            OnFileNotFound -= onFileNotFound;
        }
    }
}
