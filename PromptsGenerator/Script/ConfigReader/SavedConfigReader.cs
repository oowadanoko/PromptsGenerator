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
    /// 保存配置文件读取类
    /// </summary>
    internal class SavedConfigReader : KeyValuePairConfigReader
    {
        /// <summary>
        /// 设置已存在的键的值，如果键不存在则不会设置
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="val">值</param>
        public void Set(string key, string val)
        {
            if(Config.ContainsKey(key))
            {
                Config[key] = val;
            }
        }

        /// <summary>
        /// 保存配置文件
        /// </summary>
        public void Save()
        {
            using (FileStream fp = File.Open(Const.SavedConfigFilePath, FileMode.Truncate))
            {
                using (StreamWriter streamWriter = new StreamWriter(fp))
                {
                    foreach (string key in Config.Keys)
                    {
                        streamWriter.WriteLine(key + Const.KeyValuePairConfigSeparator + Config[key]);
                    }
                }  
            }
        }
    }
}
