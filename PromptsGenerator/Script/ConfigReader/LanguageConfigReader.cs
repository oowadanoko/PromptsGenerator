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
    /// 语言配置文件读取类
    /// </summary>
    internal class LanguageConfigReader : KeyValuePairConfigReader
    {
        /// <summary>
        /// 获取语言所对应的配置文件的路径
        /// </summary>
        /// <param name="language">语言</param>
        /// <returns>语言所对应的配置文件的路径</returns>
        public override string Get(string language)
        {
            return AddSubffix(Const.LocaleConfigDirectoryPath +"/" + base.Get(language));      
        }
    }
}
