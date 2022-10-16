using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oowada.PromptsGenerator.Manager;
using Oowada.PromptsGenerator.ConfigReader;
using Oowada.PromptsGenerator.Common;
using System.IO;
using static Oowada.PromptsGenerator.ConfigReader.BaseConfigReader;

namespace Oowada.PromptsGenerator.Forms
{
    public partial class MainForm : Form
    {
        private string currentType;
        private string currentToken;
        private string currentPrompt;
        private List<string> promptConfigFiles;

        private bool findLanguageConfigFile = true;
        private bool findLocaleConfigFile = true;
        private bool findPromptConfigFile = true;
        private bool findSavedConfigFile = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BaseManager.AddSavedConfigReaderOnSyntaxError(OnSyntaxError);
            LocaleManager.AddLanguageConfigReaderOnSyntaxError(OnSyntaxError);
            LocaleManager.AddLocaleConfigReaderOnSyntaxError(OnSyntaxError);
            PromptManager.AddPromptConfigReaderOnSyntaxError(OnSyntaxError);

            BaseManager.AddSavedConfigReaderOnFileNotFound(OnFileNotFound);
            LocaleManager.AddLanguageConfigReaderOnFileNotFound(OnFileNotFound);
            LocaleManager.AddLocaleConfigReaderOnFileNotFound(OnFileNotFound);
            PromptManager.AddPromptConfigReaderOnFileNotFound(OnFileNotFound);

            BaseManager.Init();
            if (findSavedConfigFile)
            {
                LocaleManager.InitLanguage();
                PromptManager.InitPromptConfig();

                SetCustomWeightInputEnable(false);
                SetText();
                SetData();
            }
        }

        private void SetText()
        {
            Text = LocaleManager.Get("MainFormTitle");

            tpgPromptGenerate.Text = LocaleManager.Get("tpgPromptGenerate");
            tpgSettings.Text = LocaleManager.Get("tpgSettings");

            gpbPromptGenerate.Text = LocaleManager.Get("gpbPromptGenerate");
            gpbSetWeight.Text = LocaleManager.Get("gpbSetWeight");
            gpbPrompt.Text = LocaleManager.Get("gpbPrompt");
            gpbNegativePrompt.Text = LocaleManager.Get("gpbNegativePrompt");

            lblSelectType.Text = LocaleManager.Get("lblSelectType");
            lblSelectToken.Text = LocaleManager.Get("lblSelectToken");
            lblPreview.Text = LocaleManager.Get("lblPreview");
            lblPreviewPrompt.Text = string.Empty;
            lblLanguage.Text = LocaleManager.Get("lblLanguage");
            lblPromptConfigFile.Text = LocaleManager.Get("lblPromptConfigFile");
            lblSettingLanguage.Text = LocaleManager.Get("lblSettingLanguage");
            lblSettingPromptConfigFile.Text = LocaleManager.Get("lblSettingPromptConfigFile");

            btnAddPrompt.Text = LocaleManager.Get("btnAddPrompt");
            btnAddNegativePrompt.Text = LocaleManager.Get("btnAddNegativePrompt");
            btnBatchAdd.Text = LocaleManager.Get("btnBatchAdd");
            btnOkWeight.Text = LocaleManager.Get("btnOkWeight");
            btnClearWeight.Text = LocaleManager.Get("btnClearWeight");
            btnCopyPrompt.Text = LocaleManager.Get("btnCopyPrompt");
            btnClearPrompt.Text = LocaleManager.Get("btnClearPrompt");
            btnImportCommonConfigPrompt.Text = LocaleManager.Get("btnImportCommonConfigPrompt");
            btnSetCommonConfigPrompt.Text = LocaleManager.Get("btnSetCommonConfigPrompt");
            btnCopyNegativePrompt.Text = LocaleManager.Get("btnCopyNegativePrompt");
            btnClearNegativePrompt.Text = LocaleManager.Get("btnClearNegativePrompt");
            btnImportCommonConfigNegativePrompt.Text = LocaleManager.Get("btnImportCommonConfigNegativePrompt");
            btnSetCommonConfigNegativePrompt.Text = LocaleManager.Get("btnSetCommonConfigNegativePrompt");

            rdbDecreaseWeight.Text = LocaleManager.Get("rdbDecreaseWeight");
            rdbIncreaseWeight105.Text = LocaleManager.Get("rdbIncreaseWeight105");
            rdbIncreaseWeight110.Text = LocaleManager.Get("rdbIncreaseWeight110");
            rdbCustomWeight.Text = LocaleManager.Get("rdbCustomWeight");
        }

        private void SetData()
        {
            CheckAndSetLanguageData();
            CheckAndSetPromptConfigFileData();
        }

        private void CheckAndSetLanguageData()
        {
            if (findSavedConfigFile && findLanguageConfigFile && findLocaleConfigFile)
            {
                SetLanguageData();
            }
        }

        private void CheckAndSetPromptConfigFileData()
        {
            if (findPromptConfigFile && findSavedConfigFile)
            {
                SetTypeData();
                SetPromptConfigFileData();
            }
        }

        private void SetTypeData()
        {
            BindingSource bsType = new BindingSource();
            bsType.DataSource = PromptManager.GetConfig();
            cbbChooseType.DataSource = bsType;
            cbbChooseType.ValueMember = "Key";
            cbbChooseType.DisplayMember = "Key";
            cbbChooseType_SelectionChangeCommitted(this, null);
        }

        private void SetLanguageData()
        {
            BindingSource bsLanguage = new BindingSource();
            bsLanguage.DataSource = LocaleManager.GetLanguageConfig();

            cbbLanguage.DataSource = bsLanguage;
            cbbLanguage.ValueMember = "Key";
            cbbLanguage.DisplayMember = "Key";
            cbbLanguage.SelectedValue = LocaleManager.CurrentLanguage;

            cbbSettingsLanguage.DataSource = bsLanguage;
            cbbSettingsLanguage.ValueMember = "Key";
            cbbSettingsLanguage.DisplayMember = "Key";
            cbbSettingsLanguage.SelectedValue = LocaleManager.CurrentLanguage;
        }

        private void SetPromptConfigFileData()
        {
            promptConfigFiles = Directory.EnumerateFiles(Const.PromptConfigDirectoryPath).Where(filePath => filePath.EndsWith(Const.ConfigSubffix)).Select(filePath => BaseConfigReader.GetFileName(filePath)).ToList();

            cbbPromptConfigFile.DataSource = promptConfigFiles;
            cbbPromptConfigFile.Text = BaseConfigReader.GetFileName(PromptManager.CurrentConfigFilePath);

            cbbSettingsPromptConfigFile.DataSource = promptConfigFiles;
            cbbSettingsPromptConfigFile.Text = BaseConfigReader.GetFileName(PromptManager.CurrentConfigFilePath);
        }

        private void OnSyntaxError(object sender, BaseConfigReader.SyntaxErrorArgs args)
        {
            MessageBox.Show(BaseConfigReader.GetFileName(args.ConfigFileName) + "的第" + args.LineNumber + "行有语法错误！");
        }

        private void OnFileNotFound(object sender, FileNotFoundArgs args)
        {
            switch(args.FileType)
            {
                case FileNotFoundArgs.ConfigFileType.Unknown:
                    break;
                case FileNotFoundArgs.ConfigFileType.LanguageConfigFile:
                    findLanguageConfigFile = false;
                    findLocaleConfigFile = false;
                    break;
                case FileNotFoundArgs.ConfigFileType.SavedConfigFile:
                    findSavedConfigFile = false;
                    findLanguageConfigFile = false;
                    findLocaleConfigFile = false;
                    break;
                case FileNotFoundArgs.ConfigFileType.LocaleConfigFile:
                    findLocaleConfigFile=false;
                    break;
                case FileNotFoundArgs.ConfigFileType.PromptConfigFile:
                    findPromptConfigFile = false;
                    break;
            }
            MessageBox.Show(BaseConfigReader.GetFileName(args.FileName) + "未找到！");
        }

        private void cbbChooseType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentType = cbbChooseType.SelectedValue.ToString();
            BindingSource bsToken = new BindingSource();
            bsToken.DataSource = PromptManager.GetTokenPrompts(currentType);
            cbbChooseToken.DataSource = bsToken;
            cbbChooseToken.ValueMember = "Key";
            cbbChooseToken.DisplayMember = "key";
            cbbChooseToken_SelectionChangeCommitted(this, null);
        }

        private void cbbChooseToken_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentToken = cbbChooseToken.SelectedValue.ToString();
            currentPrompt = PromptManager.GetPrompt(currentType, currentToken);
            lblPreviewPrompt.Text = currentPrompt;
        }

        private void rdbDecreaseWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDecreaseWeight.Checked)
            {
                lblPreviewPrompt.Text = string.Format(Const.DecreaseWeightFormat, currentPrompt);
            }
        }

        private void rdbIncreaseWeight105_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIncreaseWeight105.Checked)
            {
                lblPreviewPrompt.Text = string.Format(Const.IncreaseWeight105Format, currentPrompt);
            }
        }

        private void rdbIncreaseWeight110_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIncreaseWeight110.Checked)
            {
                lblPreviewPrompt.Text = string.Format(Const.IncreaseWeight110Format, currentPrompt);
            }
        }

        private void SetCustomWeightInputEnable(bool enable)
        {
            txtWeight.Enabled = enable;
            btnOkWeight.Enabled = enable;
        }

        private void rdbCustomWeight_CheckedChanged(object sender, EventArgs e)
        {
            lblPreviewPrompt.Text = currentPrompt;
            SetCustomWeightInputEnable(rdbCustomWeight.Checked);
            if (!rdbCustomWeight.Checked)
            {
                txtWeight.Text = string.Empty;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 46)    
            {
                if (txtWeight.Text.Length <= 0)
                {
                    e.Handled = true;
                } 
                else
                {
                    float oldf;
                    float f;
                    bool before = float.TryParse(txtWeight.Text, out oldf); ;
                    bool after = float.TryParse(txtWeight.Text + e.KeyChar.ToString(), out f);
                    if (after)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = before;
                    }
                }
            }
        }

        private void btnOkWeight_Click(object sender, EventArgs e)
        {
            float weight = float.Parse(txtWeight.Text);
            lblPreviewPrompt.Text = string.Format(Const.CustomWeightFormat, currentPrompt, weight);
            txtWeight.Text = string.Empty;
        }

        private void btnClearWeight_Click(object sender, EventArgs e)
        {
            lblPreviewPrompt.Text = currentPrompt;
            rdbDecreaseWeight.Checked = false;
            rdbIncreaseWeight105.Checked = false;
            rdbIncreaseWeight110.Checked = false;
            rdbCustomWeight.Checked = false;
        }

        private void OnSelectLanguage(ComboBox cbb)
        {
            findSavedConfigFile = true;
            findLanguageConfigFile = true;
            findLocaleConfigFile = true;
            LocaleManager.SelectLanguage(cbb.SelectedValue.ToString());
            SetText();
            cbbChooseToken_SelectionChangeCommitted(this, null);
        }

        private void cbbLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OnSelectLanguage(cbbLanguage);
        }

        private void OnSelectPromptConfigFile(ComboBox cbb)
        {
            findSavedConfigFile = true;
            findPromptConfigFile = true;
            PromptManager.SelectPromptConfig(Const.PromptConfigDirectoryPath + "/" + cbb.SelectedValue.ToString());
            CheckAndSetPromptConfigFileData();
        }

        private void cbbPromptConfigFile_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OnSelectPromptConfigFile(cbbPromptConfigFile);
        }

        private void AddPromptTo(TextBox txt, string prompt)
        {
            if (txt.Text.Length <= 0)
            {
                txt.Text = prompt;
            }
            else
            {
                txt.Text += ", " + prompt;
            }
        }

        public void AddToPrompt(string prompt)
        {
            AddPromptTo(txtPrompt, prompt);
        }

        public void AddToNegativePrompt(string prompt)
        {
            AddPromptTo(txtNegativePrompt, prompt);
        }

        private void btnAddPrompt_Click(object sender, EventArgs e)
        {
            AddPromptTo(txtPrompt, lblPreviewPrompt.Text);
            btnClearWeight_Click(this, null);
            lblPreviewPrompt.Text = currentPrompt;
        }

        private void btnAddNegativePrompt_Click(object sender, EventArgs e)
        {
            AddPromptTo(txtNegativePrompt, lblPreviewPrompt.Text);
            btnClearWeight_Click(this, null);
            lblPreviewPrompt.Text = currentPrompt;
        }

        private void CopyPrompt(TextBox txt)
        {
            Clipboard.SetText(txt.Text);
        }

        private void btnCopyPrompt_Click(object sender, EventArgs e)
        {
            CopyPrompt(txtPrompt);
        }

        private void btnCopyNegativePrompt_Click(object sender, EventArgs e)
        {
            CopyPrompt(txtNegativePrompt);
        }

        private void ClearPrompt(TextBox txt)
        {
            txt.Text = string.Empty;
        }

        private void btnClearPrompt_Click(object sender, EventArgs e)
        {
            ClearPrompt(txtPrompt);
        }

        private void btnClearNegativePrompt_Click(object sender, EventArgs e)
        {
            ClearPrompt(txtNegativePrompt);
        }

        private void btnImportCommonConfigPrompt_Click(object sender, EventArgs e)
        {
            if (txtPrompt.Text.Length > 0)
            {
                txtPrompt.Text += ", ";
            }
            txtPrompt.Text += PromptManager.GetCommonPrompt();
        }

        private void btnImportCommonConfigNegativePrompt_Click(object sender, EventArgs e)
        {
            if (txtNegativePrompt.Text.Length > 0)
            {
                txtNegativePrompt.Text += ", ";
            }
            txtNegativePrompt.Text += PromptManager.GetCommonNegativePrompt();
        }

        private void btnSetCommonConfigPrompt_Click(object sender, EventArgs e)
        {
            PromptManager.SetCommonPrompt(txtPrompt.Text); 
        }

        private void btnSetCommonConfigNegativePrompt_Click(object sender, EventArgs e)
        {
            PromptManager.SetNegativeCommonPrompt(txtNegativePrompt.Text);
        }

        private void btnBatchAdd_Click(object sender, EventArgs e)
        {
            BatchAddForm batchAddForm = new BatchAddForm();
            batchAddForm.ShowDialog(this);
        }

        private void cbbSettingsLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OnSelectLanguage(cbbSettingsLanguage);
        }

        private void cbbSettingsPromptConfigFile_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OnSelectPromptConfigFile(cbbSettingsPromptConfigFile);
        }
    }
}
