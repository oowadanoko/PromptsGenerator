using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oowada.PromptsGenerator.Common
{
    /// <summary>
    /// 常量类
    /// </summary>
    internal class Const
    {
        /// <summary>
        /// 配置文件的文件后缀
        /// </summary>
        public const string ConfigSubffix = ".config";
        /// <summary>
        /// 注释符号
        /// </summary>
        public const char CommentToken = '#';
        /// <summary>
        /// 配置文件目录
        /// </summary>
        public const string ConfigDirectoryPath = "./Config";
        /// <summary>
        /// 本地化配置文件目录
        /// </summary>
        public const string LocaleConfigDirectoryPath = ConfigDirectoryPath + "/Locale";
        /// <summary>
        /// 语言配置文件路径
        /// </summary>
        public const string LanguageConfigFilePath = LocaleConfigDirectoryPath + "/Language.config";
        /// <summary>
        /// Prompt配置文件目录
        /// </summary>
        public const string PromptConfigDirectoryPath = ConfigDirectoryPath + "/Prompt";
        /// <summary>
        /// 保存配置文件路径
        /// </summary>
        public const string SavedConfigFilePath = ConfigDirectoryPath + "/SavedConfig.config";
        /// <summary>
        /// 键值对类型配置分隔符
        /// </summary>
        public const char KeyValuePairConfigSeparator = '=';
        /// <summary>
        /// Prompt配置分隔符
        /// </summary>
        public const char PromptConfigSeparator = ',';

        public const string DecreaseWeightFormat = "[{0}]";

        public const string IncreaseWeight105Format = "{{{0}}}";

        public const string IncreaseWeight110Format = "({0})";

        public const string CustomWeightFormat = "({0}:{1})";
    }
}
