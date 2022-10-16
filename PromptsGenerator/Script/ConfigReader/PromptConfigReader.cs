using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Oowada.PromptsGenerator.Common;
using System.Windows.Forms;

namespace Oowada.PromptsGenerator.ConfigReader
{
    /// <summary>
    /// Prompt配置文件阅读器
    /// </summary>
    internal class PromptConfigReader : BaseConfigReader
    {
        /// <summary>
        /// 配置文件
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> Config { get; private set; } = new Dictionary<string, Dictionary<string, string>>();

        /// <summary>
        /// 根据类型获取所有的关键字和prompt
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns>所有的关键字和prompt</returns>
        public Dictionary<string, string> GetPrompts(string type)
        {
            return Config.ContainsKey(type) ? Config[type] : null;
        }

        /// <summary>
        /// 处理配置文件的具体函数
        /// </summary>
        /// <param name="configFilePath">配置文件路径</param>
        protected override void HandleFile(string configFilePath)
        {
            int lineNumber = 0;
            Config.Clear();
            foreach(string line in File.ReadLines(configFilePath))
            {
                ++lineNumber;
                if (IsCommentOrBlankLine(line))
                {
                    continue;
                }
                string[] splits = line.Split(Const.PromptConfigSeparator);
                if (splits.Length != 3)
                {
                    OnSyntaxError?.Invoke(this, new SyntaxErrorArgs(configFilePath, lineNumber));
                }
                else
                {
                    string type = splits[0].Trim();
                    if (!Config.ContainsKey(type))
                    {
                        Config[type] = new Dictionary<string, string>();
                    }
                    Config[type][splits[1].Trim()] = splits[2].Trim();
                }
            }
        }
    }
}
