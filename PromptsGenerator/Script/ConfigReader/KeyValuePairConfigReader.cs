using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oowada.PromptsGenerator.Common;

namespace Oowada.PromptsGenerator.ConfigReader
{
    /// <summary>
    /// 键值对类型配置文件读取类的基类
    /// </summary>
    internal abstract class KeyValuePairConfigReader : BaseConfigReader
    {
        /// <summary>
        /// 配置文件中的键值对
        /// </summary>
        public Dictionary<string, string> Config { get; private set; } = new Dictionary<string, string>();

        /// <summary>
        /// 获取配置文件键值对的值
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>值</returns>
        public virtual string Get(string key)
        {
            return this.Config.ContainsKey(key) ? this.Config[key] : null;
        }

        /// <summary>
        /// 处理配置文件的具体函数
        /// </summary>
        /// <param name="configFilePath">配置文件路径</param>
        protected override void HandleFile(string configFilePath)
        {
            int lineNumber = 0;
            Config.Clear();
            foreach (string line in File.ReadLines(configFilePath))
            {
                ++lineNumber;
                if (IsCommentOrBlankLine(line))
                {
                    continue;
                }
                string[] splits = line.Split(Const.KeyValuePairConfigSeparator);
                if (splits.Length != 2)
                {
                    OnSyntaxError?.Invoke(this, new SyntaxErrorArgs(configFilePath, lineNumber));
                }
                else
                {
                    Config[splits[0].Trim()] = splits[1].Trim();
                }
            }
        }
    }
}
