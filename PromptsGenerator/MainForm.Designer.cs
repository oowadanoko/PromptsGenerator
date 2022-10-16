namespace Oowada.PromptsGenerator.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpgPromptGenerate = new System.Windows.Forms.TabPage();
            this.gpbPromptGenerate = new System.Windows.Forms.GroupBox();
            this.cbbPromptConfigFile = new System.Windows.Forms.ComboBox();
            this.lblPromptConfigFile = new System.Windows.Forms.Label();
            this.cbbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblSelectType = new System.Windows.Forms.Label();
            this.btnBatchAdd = new System.Windows.Forms.Button();
            this.cbbChooseType = new System.Windows.Forms.ComboBox();
            this.gpbSetWeight = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnClearWeight = new System.Windows.Forms.Button();
            this.btnOkWeight = new System.Windows.Forms.Button();
            this.rdbCustomWeight = new System.Windows.Forms.RadioButton();
            this.rdbIncreaseWeight110 = new System.Windows.Forms.RadioButton();
            this.rdbIncreaseWeight105 = new System.Windows.Forms.RadioButton();
            this.rdbDecreaseWeight = new System.Windows.Forms.RadioButton();
            this.lblSelectToken = new System.Windows.Forms.Label();
            this.btnAddNegativePrompt = new System.Windows.Forms.Button();
            this.btnAddPrompt = new System.Windows.Forms.Button();
            this.cbbChooseToken = new System.Windows.Forms.ComboBox();
            this.lblPreviewPrompt = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.gpbNegativePrompt = new System.Windows.Forms.GroupBox();
            this.btnSetCommonConfigNegativePrompt = new System.Windows.Forms.Button();
            this.btnImportCommonConfigNegativePrompt = new System.Windows.Forms.Button();
            this.btnClearNegativePrompt = new System.Windows.Forms.Button();
            this.btnCopyNegativePrompt = new System.Windows.Forms.Button();
            this.txtNegativePrompt = new System.Windows.Forms.TextBox();
            this.gpbPrompt = new System.Windows.Forms.GroupBox();
            this.btnSetCommonConfigPrompt = new System.Windows.Forms.Button();
            this.btnImportCommonConfigPrompt = new System.Windows.Forms.Button();
            this.btnClearPrompt = new System.Windows.Forms.Button();
            this.btnCopyPrompt = new System.Windows.Forms.Button();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.tpgSettings = new System.Windows.Forms.TabPage();
            this.cbbSettingsPromptConfigFile = new System.Windows.Forms.ComboBox();
            this.lblSettingPromptConfigFile = new System.Windows.Forms.Label();
            this.cbbSettingsLanguage = new System.Windows.Forms.ComboBox();
            this.lblSettingLanguage = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpgPromptGenerate.SuspendLayout();
            this.gpbPromptGenerate.SuspendLayout();
            this.gpbSetWeight.SuspendLayout();
            this.gpbNegativePrompt.SuspendLayout();
            this.gpbPrompt.SuspendLayout();
            this.tpgSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpgPromptGenerate);
            this.tabControl.Controls.Add(this.tpgSettings);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(741, 430);
            this.tabControl.TabIndex = 0;
            // 
            // tpgPromptGenerate
            // 
            this.tpgPromptGenerate.Controls.Add(this.gpbPromptGenerate);
            this.tpgPromptGenerate.Controls.Add(this.gpbNegativePrompt);
            this.tpgPromptGenerate.Controls.Add(this.gpbPrompt);
            this.tpgPromptGenerate.Location = new System.Drawing.Point(4, 22);
            this.tpgPromptGenerate.Margin = new System.Windows.Forms.Padding(0);
            this.tpgPromptGenerate.Name = "tpgPromptGenerate";
            this.tpgPromptGenerate.Size = new System.Drawing.Size(733, 404);
            this.tpgPromptGenerate.TabIndex = 0;
            this.tpgPromptGenerate.Text = "Prompt生成";
            this.tpgPromptGenerate.UseVisualStyleBackColor = true;
            // 
            // gpbPromptGenerate
            // 
            this.gpbPromptGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbPromptGenerate.Controls.Add(this.cbbPromptConfigFile);
            this.gpbPromptGenerate.Controls.Add(this.lblPromptConfigFile);
            this.gpbPromptGenerate.Controls.Add(this.cbbLanguage);
            this.gpbPromptGenerate.Controls.Add(this.lblLanguage);
            this.gpbPromptGenerate.Controls.Add(this.lblSelectType);
            this.gpbPromptGenerate.Controls.Add(this.btnBatchAdd);
            this.gpbPromptGenerate.Controls.Add(this.cbbChooseType);
            this.gpbPromptGenerate.Controls.Add(this.gpbSetWeight);
            this.gpbPromptGenerate.Controls.Add(this.lblSelectToken);
            this.gpbPromptGenerate.Controls.Add(this.btnAddNegativePrompt);
            this.gpbPromptGenerate.Controls.Add(this.btnAddPrompt);
            this.gpbPromptGenerate.Controls.Add(this.cbbChooseToken);
            this.gpbPromptGenerate.Controls.Add(this.lblPreviewPrompt);
            this.gpbPromptGenerate.Controls.Add(this.lblPreview);
            this.gpbPromptGenerate.Location = new System.Drawing.Point(3, 7);
            this.gpbPromptGenerate.Name = "gpbPromptGenerate";
            this.gpbPromptGenerate.Size = new System.Drawing.Size(355, 395);
            this.gpbPromptGenerate.TabIndex = 13;
            this.gpbPromptGenerate.TabStop = false;
            this.gpbPromptGenerate.Text = "Prompt生成";
            // 
            // cbbPromptConfigFile
            // 
            this.cbbPromptConfigFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbPromptConfigFile.FormattingEnabled = true;
            this.cbbPromptConfigFile.Location = new System.Drawing.Point(156, 328);
            this.cbbPromptConfigFile.Name = "cbbPromptConfigFile";
            this.cbbPromptConfigFile.Size = new System.Drawing.Size(158, 22);
            this.cbbPromptConfigFile.TabIndex = 16;
            this.cbbPromptConfigFile.SelectionChangeCommitted += new System.EventHandler(this.cbbPromptConfigFile_SelectionChangeCommitted);
            // 
            // lblPromptConfigFile
            // 
            this.lblPromptConfigFile.AutoSize = true;
            this.lblPromptConfigFile.Location = new System.Drawing.Point(154, 297);
            this.lblPromptConfigFile.Name = "lblPromptConfigFile";
            this.lblPromptConfigFile.Size = new System.Drawing.Size(89, 12);
            this.lblPromptConfigFile.TabIndex = 15;
            this.lblPromptConfigFile.Text = "Prompt配置文件";
            // 
            // cbbLanguage
            // 
            this.cbbLanguage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbLanguage.FormattingEnabled = true;
            this.cbbLanguage.Location = new System.Drawing.Point(13, 328);
            this.cbbLanguage.Name = "cbbLanguage";
            this.cbbLanguage.Size = new System.Drawing.Size(111, 22);
            this.cbbLanguage.TabIndex = 14;
            this.cbbLanguage.SelectionChangeCommitted += new System.EventHandler(this.cbbLanguage_SelectionChangeCommitted);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(11, 297);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(101, 12);
            this.lblLanguage.TabIndex = 13;
            this.lblLanguage.Text = "语言（Language）";
            // 
            // lblSelectType
            // 
            this.lblSelectType.AutoSize = true;
            this.lblSelectType.Location = new System.Drawing.Point(11, 25);
            this.lblSelectType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectType.Name = "lblSelectType";
            this.lblSelectType.Size = new System.Drawing.Size(53, 12);
            this.lblSelectType.TabIndex = 1;
            this.lblSelectType.Text = "选择类型";
            // 
            // btnBatchAdd
            // 
            this.btnBatchAdd.Location = new System.Drawing.Point(199, 232);
            this.btnBatchAdd.Name = "btnBatchAdd";
            this.btnBatchAdd.Size = new System.Drawing.Size(115, 33);
            this.btnBatchAdd.TabIndex = 12;
            this.btnBatchAdd.Text = "批量添加";
            this.btnBatchAdd.UseVisualStyleBackColor = true;
            this.btnBatchAdd.Click += new System.EventHandler(this.btnBatchAdd_Click);
            // 
            // cbbChooseType
            // 
            this.cbbChooseType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbChooseType.FormattingEnabled = true;
            this.cbbChooseType.Location = new System.Drawing.Point(13, 50);
            this.cbbChooseType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbChooseType.Name = "cbbChooseType";
            this.cbbChooseType.Size = new System.Drawing.Size(126, 22);
            this.cbbChooseType.TabIndex = 2;
            this.cbbChooseType.SelectionChangeCommitted += new System.EventHandler(this.cbbChooseType_SelectionChangeCommitted);
            // 
            // gpbSetWeight
            // 
            this.gpbSetWeight.Controls.Add(this.txtWeight);
            this.gpbSetWeight.Controls.Add(this.btnClearWeight);
            this.gpbSetWeight.Controls.Add(this.btnOkWeight);
            this.gpbSetWeight.Controls.Add(this.rdbCustomWeight);
            this.gpbSetWeight.Controls.Add(this.rdbIncreaseWeight110);
            this.gpbSetWeight.Controls.Add(this.rdbIncreaseWeight105);
            this.gpbSetWeight.Controls.Add(this.rdbDecreaseWeight);
            this.gpbSetWeight.Location = new System.Drawing.Point(13, 82);
            this.gpbSetWeight.Margin = new System.Windows.Forms.Padding(2);
            this.gpbSetWeight.Name = "gpbSetWeight";
            this.gpbSetWeight.Padding = new System.Windows.Forms.Padding(2);
            this.gpbSetWeight.Size = new System.Drawing.Size(169, 183);
            this.gpbSetWeight.TabIndex = 6;
            this.gpbSetWeight.TabStop = false;
            this.gpbSetWeight.Text = "设置权重";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(20, 109);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(74, 21);
            this.txtWeight.TabIndex = 10;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // btnClearWeight
            // 
            this.btnClearWeight.Location = new System.Drawing.Point(4, 138);
            this.btnClearWeight.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearWeight.Name = "btnClearWeight";
            this.btnClearWeight.Size = new System.Drawing.Size(139, 37);
            this.btnClearWeight.TabIndex = 9;
            this.btnClearWeight.Text = "清除权重";
            this.btnClearWeight.UseVisualStyleBackColor = true;
            this.btnClearWeight.Click += new System.EventHandler(this.btnClearWeight_Click);
            // 
            // btnOkWeight
            // 
            this.btnOkWeight.Location = new System.Drawing.Point(99, 102);
            this.btnOkWeight.Margin = new System.Windows.Forms.Padding(2);
            this.btnOkWeight.Name = "btnOkWeight";
            this.btnOkWeight.Size = new System.Drawing.Size(45, 32);
            this.btnOkWeight.TabIndex = 5;
            this.btnOkWeight.Text = "确定";
            this.btnOkWeight.UseVisualStyleBackColor = true;
            this.btnOkWeight.Click += new System.EventHandler(this.btnOkWeight_Click);
            // 
            // rdbCustomWeight
            // 
            this.rdbCustomWeight.AutoSize = true;
            this.rdbCustomWeight.Location = new System.Drawing.Point(5, 82);
            this.rdbCustomWeight.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCustomWeight.Name = "rdbCustomWeight";
            this.rdbCustomWeight.Size = new System.Drawing.Size(137, 16);
            this.rdbCustomWeight.TabIndex = 3;
            this.rdbCustomWeight.TabStop = true;
            this.rdbCustomWeight.Text = "自定义权重（*系数）";
            this.rdbCustomWeight.UseVisualStyleBackColor = true;
            this.rdbCustomWeight.CheckedChanged += new System.EventHandler(this.rdbCustomWeight_CheckedChanged);
            // 
            // rdbIncreaseWeight110
            // 
            this.rdbIncreaseWeight110.AutoSize = true;
            this.rdbIncreaseWeight110.Location = new System.Drawing.Point(5, 62);
            this.rdbIncreaseWeight110.Margin = new System.Windows.Forms.Padding(2);
            this.rdbIncreaseWeight110.Name = "rdbIncreaseWeight110";
            this.rdbIncreaseWeight110.Size = new System.Drawing.Size(137, 16);
            this.rdbIncreaseWeight110.TabIndex = 2;
            this.rdbIncreaseWeight110.TabStop = true;
            this.rdbIncreaseWeight110.Text = "提高权重()（*1.10）";
            this.rdbIncreaseWeight110.UseVisualStyleBackColor = true;
            this.rdbIncreaseWeight110.CheckedChanged += new System.EventHandler(this.rdbIncreaseWeight110_CheckedChanged);
            // 
            // rdbIncreaseWeight105
            // 
            this.rdbIncreaseWeight105.AutoSize = true;
            this.rdbIncreaseWeight105.Location = new System.Drawing.Point(5, 41);
            this.rdbIncreaseWeight105.Margin = new System.Windows.Forms.Padding(2);
            this.rdbIncreaseWeight105.Name = "rdbIncreaseWeight105";
            this.rdbIncreaseWeight105.Size = new System.Drawing.Size(137, 16);
            this.rdbIncreaseWeight105.TabIndex = 1;
            this.rdbIncreaseWeight105.TabStop = true;
            this.rdbIncreaseWeight105.Text = "提高权重{}（*1.05）";
            this.rdbIncreaseWeight105.UseVisualStyleBackColor = true;
            this.rdbIncreaseWeight105.CheckedChanged += new System.EventHandler(this.rdbIncreaseWeight105_CheckedChanged);
            // 
            // rdbDecreaseWeight
            // 
            this.rdbDecreaseWeight.AutoSize = true;
            this.rdbDecreaseWeight.Location = new System.Drawing.Point(5, 20);
            this.rdbDecreaseWeight.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDecreaseWeight.Name = "rdbDecreaseWeight";
            this.rdbDecreaseWeight.Size = new System.Drawing.Size(137, 16);
            this.rdbDecreaseWeight.TabIndex = 0;
            this.rdbDecreaseWeight.TabStop = true;
            this.rdbDecreaseWeight.Text = "降低权重[]（/1.05）";
            this.rdbDecreaseWeight.UseVisualStyleBackColor = true;
            this.rdbDecreaseWeight.CheckedChanged += new System.EventHandler(this.rdbDecreaseWeight_CheckedChanged);
            // 
            // lblSelectToken
            // 
            this.lblSelectToken.AutoSize = true;
            this.lblSelectToken.Location = new System.Drawing.Point(141, 25);
            this.lblSelectToken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectToken.Name = "lblSelectToken";
            this.lblSelectToken.Size = new System.Drawing.Size(65, 12);
            this.lblSelectToken.TabIndex = 3;
            this.lblSelectToken.Text = "选择关键字";
            // 
            // btnAddNegativePrompt
            // 
            this.btnAddNegativePrompt.Location = new System.Drawing.Point(199, 183);
            this.btnAddNegativePrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNegativePrompt.Name = "btnAddNegativePrompt";
            this.btnAddNegativePrompt.Size = new System.Drawing.Size(115, 33);
            this.btnAddNegativePrompt.TabIndex = 9;
            this.btnAddNegativePrompt.Text = "添加到Negative";
            this.btnAddNegativePrompt.UseVisualStyleBackColor = true;
            this.btnAddNegativePrompt.Click += new System.EventHandler(this.btnAddNegativePrompt_Click);
            // 
            // btnAddPrompt
            // 
            this.btnAddPrompt.Location = new System.Drawing.Point(199, 135);
            this.btnAddPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPrompt.Name = "btnAddPrompt";
            this.btnAddPrompt.Size = new System.Drawing.Size(115, 35);
            this.btnAddPrompt.TabIndex = 8;
            this.btnAddPrompt.Text = "添加到Prompt";
            this.btnAddPrompt.UseVisualStyleBackColor = true;
            this.btnAddPrompt.Click += new System.EventHandler(this.btnAddPrompt_Click);
            // 
            // cbbChooseToken
            // 
            this.cbbChooseToken.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbChooseToken.FormattingEnabled = true;
            this.cbbChooseToken.Location = new System.Drawing.Point(143, 50);
            this.cbbChooseToken.Margin = new System.Windows.Forms.Padding(2);
            this.cbbChooseToken.Name = "cbbChooseToken";
            this.cbbChooseToken.Size = new System.Drawing.Size(207, 22);
            this.cbbChooseToken.TabIndex = 4;
            this.cbbChooseToken.SelectionChangeCommitted += new System.EventHandler(this.cbbChooseToken_SelectionChangeCommitted);
            // 
            // lblPreviewPrompt
            // 
            this.lblPreviewPrompt.AutoSize = true;
            this.lblPreviewPrompt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPreviewPrompt.Location = new System.Drawing.Point(211, 104);
            this.lblPreviewPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreviewPrompt.Name = "lblPreviewPrompt";
            this.lblPreviewPrompt.Size = new System.Drawing.Size(84, 14);
            this.lblPreviewPrompt.TabIndex = 7;
            this.lblPreviewPrompt.Text = "(1girl:1.5)";
            this.lblPreviewPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(197, 82);
            this.lblPreview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(29, 12);
            this.lblPreview.TabIndex = 5;
            this.lblPreview.Text = "预览";
            // 
            // gpbNegativePrompt
            // 
            this.gpbNegativePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbNegativePrompt.Controls.Add(this.btnSetCommonConfigNegativePrompt);
            this.gpbNegativePrompt.Controls.Add(this.btnImportCommonConfigNegativePrompt);
            this.gpbNegativePrompt.Controls.Add(this.btnClearNegativePrompt);
            this.gpbNegativePrompt.Controls.Add(this.btnCopyNegativePrompt);
            this.gpbNegativePrompt.Controls.Add(this.txtNegativePrompt);
            this.gpbNegativePrompt.Location = new System.Drawing.Point(363, 204);
            this.gpbNegativePrompt.Margin = new System.Windows.Forms.Padding(2);
            this.gpbNegativePrompt.Name = "gpbNegativePrompt";
            this.gpbNegativePrompt.Padding = new System.Windows.Forms.Padding(2);
            this.gpbNegativePrompt.Size = new System.Drawing.Size(358, 198);
            this.gpbNegativePrompt.TabIndex = 11;
            this.gpbNegativePrompt.TabStop = false;
            this.gpbNegativePrompt.Text = "Negative Prompt";
            // 
            // btnSetCommonConfigNegativePrompt
            // 
            this.btnSetCommonConfigNegativePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCommonConfigNegativePrompt.Location = new System.Drawing.Point(260, 164);
            this.btnSetCommonConfigNegativePrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetCommonConfigNegativePrompt.Name = "btnSetCommonConfigNegativePrompt";
            this.btnSetCommonConfigNegativePrompt.Size = new System.Drawing.Size(92, 24);
            this.btnSetCommonConfigNegativePrompt.TabIndex = 4;
            this.btnSetCommonConfigNegativePrompt.Text = "设为通用配置";
            this.btnSetCommonConfigNegativePrompt.UseVisualStyleBackColor = true;
            this.btnSetCommonConfigNegativePrompt.Click += new System.EventHandler(this.btnSetCommonConfigNegativePrompt_Click);
            // 
            // btnImportCommonConfigNegativePrompt
            // 
            this.btnImportCommonConfigNegativePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportCommonConfigNegativePrompt.Location = new System.Drawing.Point(151, 164);
            this.btnImportCommonConfigNegativePrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportCommonConfigNegativePrompt.Name = "btnImportCommonConfigNegativePrompt";
            this.btnImportCommonConfigNegativePrompt.Size = new System.Drawing.Size(97, 24);
            this.btnImportCommonConfigNegativePrompt.TabIndex = 3;
            this.btnImportCommonConfigNegativePrompt.Text = "导入通用配置";
            this.btnImportCommonConfigNegativePrompt.UseVisualStyleBackColor = true;
            this.btnImportCommonConfigNegativePrompt.Click += new System.EventHandler(this.btnImportCommonConfigNegativePrompt_Click);
            // 
            // btnClearNegativePrompt
            // 
            this.btnClearNegativePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearNegativePrompt.Location = new System.Drawing.Point(78, 164);
            this.btnClearNegativePrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearNegativePrompt.Name = "btnClearNegativePrompt";
            this.btnClearNegativePrompt.Size = new System.Drawing.Size(56, 24);
            this.btnClearNegativePrompt.TabIndex = 2;
            this.btnClearNegativePrompt.Text = "清空";
            this.btnClearNegativePrompt.UseVisualStyleBackColor = true;
            this.btnClearNegativePrompt.Click += new System.EventHandler(this.btnClearNegativePrompt_Click);
            // 
            // btnCopyNegativePrompt
            // 
            this.btnCopyNegativePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyNegativePrompt.Location = new System.Drawing.Point(6, 164);
            this.btnCopyNegativePrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyNegativePrompt.Name = "btnCopyNegativePrompt";
            this.btnCopyNegativePrompt.Size = new System.Drawing.Size(56, 24);
            this.btnCopyNegativePrompt.TabIndex = 1;
            this.btnCopyNegativePrompt.Text = "复制";
            this.btnCopyNegativePrompt.UseVisualStyleBackColor = true;
            this.btnCopyNegativePrompt.Click += new System.EventHandler(this.btnCopyNegativePrompt_Click);
            // 
            // txtNegativePrompt
            // 
            this.txtNegativePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNegativePrompt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNegativePrompt.Location = new System.Drawing.Point(8, 19);
            this.txtNegativePrompt.Margin = new System.Windows.Forms.Padding(2);
            this.txtNegativePrompt.Multiline = true;
            this.txtNegativePrompt.Name = "txtNegativePrompt";
            this.txtNegativePrompt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNegativePrompt.Size = new System.Drawing.Size(344, 132);
            this.txtNegativePrompt.TabIndex = 0;
            // 
            // gpbPrompt
            // 
            this.gpbPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPrompt.Controls.Add(this.btnSetCommonConfigPrompt);
            this.gpbPrompt.Controls.Add(this.btnImportCommonConfigPrompt);
            this.gpbPrompt.Controls.Add(this.btnClearPrompt);
            this.gpbPrompt.Controls.Add(this.btnCopyPrompt);
            this.gpbPrompt.Controls.Add(this.txtPrompt);
            this.gpbPrompt.Location = new System.Drawing.Point(363, 7);
            this.gpbPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.gpbPrompt.Name = "gpbPrompt";
            this.gpbPrompt.Padding = new System.Windows.Forms.Padding(2);
            this.gpbPrompt.Size = new System.Drawing.Size(358, 195);
            this.gpbPrompt.TabIndex = 10;
            this.gpbPrompt.TabStop = false;
            this.gpbPrompt.Text = "Prompt";
            // 
            // btnSetCommonConfigPrompt
            // 
            this.btnSetCommonConfigPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCommonConfigPrompt.Location = new System.Drawing.Point(262, 166);
            this.btnSetCommonConfigPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetCommonConfigPrompt.Name = "btnSetCommonConfigPrompt";
            this.btnSetCommonConfigPrompt.Size = new System.Drawing.Size(92, 25);
            this.btnSetCommonConfigPrompt.TabIndex = 4;
            this.btnSetCommonConfigPrompt.Text = "设为通用配置";
            this.btnSetCommonConfigPrompt.UseVisualStyleBackColor = true;
            this.btnSetCommonConfigPrompt.Click += new System.EventHandler(this.btnSetCommonConfigPrompt_Click);
            // 
            // btnImportCommonConfigPrompt
            // 
            this.btnImportCommonConfigPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportCommonConfigPrompt.Location = new System.Drawing.Point(153, 166);
            this.btnImportCommonConfigPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportCommonConfigPrompt.Name = "btnImportCommonConfigPrompt";
            this.btnImportCommonConfigPrompt.Size = new System.Drawing.Size(97, 25);
            this.btnImportCommonConfigPrompt.TabIndex = 3;
            this.btnImportCommonConfigPrompt.Text = "导入通用配置";
            this.btnImportCommonConfigPrompt.UseVisualStyleBackColor = true;
            this.btnImportCommonConfigPrompt.Click += new System.EventHandler(this.btnImportCommonConfigPrompt_Click);
            // 
            // btnClearPrompt
            // 
            this.btnClearPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPrompt.Location = new System.Drawing.Point(80, 166);
            this.btnClearPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearPrompt.Name = "btnClearPrompt";
            this.btnClearPrompt.Size = new System.Drawing.Size(56, 25);
            this.btnClearPrompt.TabIndex = 2;
            this.btnClearPrompt.Text = "清空";
            this.btnClearPrompt.UseVisualStyleBackColor = true;
            this.btnClearPrompt.Click += new System.EventHandler(this.btnClearPrompt_Click);
            // 
            // btnCopyPrompt
            // 
            this.btnCopyPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyPrompt.Location = new System.Drawing.Point(8, 166);
            this.btnCopyPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyPrompt.Name = "btnCopyPrompt";
            this.btnCopyPrompt.Size = new System.Drawing.Size(56, 25);
            this.btnCopyPrompt.TabIndex = 1;
            this.btnCopyPrompt.Text = "复制";
            this.btnCopyPrompt.UseVisualStyleBackColor = true;
            this.btnCopyPrompt.Click += new System.EventHandler(this.btnCopyPrompt_Click);
            // 
            // txtPrompt
            // 
            this.txtPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrompt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrompt.Location = new System.Drawing.Point(8, 19);
            this.txtPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrompt.Multiline = true;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrompt.Size = new System.Drawing.Size(346, 140);
            this.txtPrompt.TabIndex = 0;
            // 
            // tpgSettings
            // 
            this.tpgSettings.Controls.Add(this.cbbSettingsPromptConfigFile);
            this.tpgSettings.Controls.Add(this.lblSettingPromptConfigFile);
            this.tpgSettings.Controls.Add(this.cbbSettingsLanguage);
            this.tpgSettings.Controls.Add(this.lblSettingLanguage);
            this.tpgSettings.Location = new System.Drawing.Point(4, 22);
            this.tpgSettings.Margin = new System.Windows.Forms.Padding(2);
            this.tpgSettings.Name = "tpgSettings";
            this.tpgSettings.Padding = new System.Windows.Forms.Padding(2);
            this.tpgSettings.Size = new System.Drawing.Size(733, 404);
            this.tpgSettings.TabIndex = 1;
            this.tpgSettings.Text = "设置（Settings）";
            this.tpgSettings.UseVisualStyleBackColor = true;
            // 
            // cbbSettingsPromptConfigFile
            // 
            this.cbbSettingsPromptConfigFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbSettingsPromptConfigFile.FormattingEnabled = true;
            this.cbbSettingsPromptConfigFile.Location = new System.Drawing.Point(23, 119);
            this.cbbSettingsPromptConfigFile.Name = "cbbSettingsPromptConfigFile";
            this.cbbSettingsPromptConfigFile.Size = new System.Drawing.Size(182, 22);
            this.cbbSettingsPromptConfigFile.TabIndex = 3;
            this.cbbSettingsPromptConfigFile.SelectionChangeCommitted += new System.EventHandler(this.cbbSettingsPromptConfigFile_SelectionChangeCommitted);
            // 
            // lblSettingPromptConfigFile
            // 
            this.lblSettingPromptConfigFile.AutoSize = true;
            this.lblSettingPromptConfigFile.Location = new System.Drawing.Point(23, 92);
            this.lblSettingPromptConfigFile.Name = "lblSettingPromptConfigFile";
            this.lblSettingPromptConfigFile.Size = new System.Drawing.Size(89, 12);
            this.lblSettingPromptConfigFile.TabIndex = 2;
            this.lblSettingPromptConfigFile.Text = "Prompt配置文件";
            // 
            // cbbSettingsLanguage
            // 
            this.cbbSettingsLanguage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbSettingsLanguage.FormattingEnabled = true;
            this.cbbSettingsLanguage.Location = new System.Drawing.Point(23, 52);
            this.cbbSettingsLanguage.Name = "cbbSettingsLanguage";
            this.cbbSettingsLanguage.Size = new System.Drawing.Size(182, 22);
            this.cbbSettingsLanguage.TabIndex = 1;
            this.cbbSettingsLanguage.SelectionChangeCommitted += new System.EventHandler(this.cbbSettingsLanguage_SelectionChangeCommitted);
            // 
            // lblSettingLanguage
            // 
            this.lblSettingLanguage.AutoSize = true;
            this.lblSettingLanguage.Location = new System.Drawing.Point(21, 25);
            this.lblSettingLanguage.Name = "lblSettingLanguage";
            this.lblSettingLanguage.Size = new System.Drawing.Size(101, 12);
            this.lblSettingLanguage.TabIndex = 0;
            this.lblSettingLanguage.Text = "语言（Language）";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 428);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Prompt生成器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tpgPromptGenerate.ResumeLayout(false);
            this.gpbPromptGenerate.ResumeLayout(false);
            this.gpbPromptGenerate.PerformLayout();
            this.gpbSetWeight.ResumeLayout(false);
            this.gpbSetWeight.PerformLayout();
            this.gpbNegativePrompt.ResumeLayout(false);
            this.gpbNegativePrompt.PerformLayout();
            this.gpbPrompt.ResumeLayout(false);
            this.gpbPrompt.PerformLayout();
            this.tpgSettings.ResumeLayout(false);
            this.tpgSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpgPromptGenerate;
        private System.Windows.Forms.GroupBox gpbNegativePrompt;
        private System.Windows.Forms.Button btnSetCommonConfigNegativePrompt;
        private System.Windows.Forms.Button btnImportCommonConfigNegativePrompt;
        private System.Windows.Forms.Button btnClearNegativePrompt;
        private System.Windows.Forms.Button btnCopyNegativePrompt;
        private System.Windows.Forms.TextBox txtNegativePrompt;
        private System.Windows.Forms.GroupBox gpbPrompt;
        private System.Windows.Forms.Button btnSetCommonConfigPrompt;
        private System.Windows.Forms.Button btnImportCommonConfigPrompt;
        private System.Windows.Forms.Button btnClearPrompt;
        private System.Windows.Forms.Button btnCopyPrompt;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Button btnAddNegativePrompt;
        private System.Windows.Forms.Button btnAddPrompt;
        private System.Windows.Forms.Label lblPreviewPrompt;
        private System.Windows.Forms.GroupBox gpbSetWeight;
        private System.Windows.Forms.Button btnClearWeight;
        private System.Windows.Forms.Button btnOkWeight;
        private System.Windows.Forms.RadioButton rdbCustomWeight;
        private System.Windows.Forms.RadioButton rdbIncreaseWeight110;
        private System.Windows.Forms.RadioButton rdbIncreaseWeight105;
        private System.Windows.Forms.RadioButton rdbDecreaseWeight;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.ComboBox cbbChooseToken;
        private System.Windows.Forms.Label lblSelectToken;
        private System.Windows.Forms.ComboBox cbbChooseType;
        private System.Windows.Forms.Label lblSelectType;
        private System.Windows.Forms.TabPage tpgSettings;
        private System.Windows.Forms.Button btnBatchAdd;
        private System.Windows.Forms.GroupBox gpbPromptGenerate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox cbbPromptConfigFile;
        private System.Windows.Forms.Label lblPromptConfigFile;
        private System.Windows.Forms.ComboBox cbbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cbbSettingsPromptConfigFile;
        private System.Windows.Forms.Label lblSettingPromptConfigFile;
        private System.Windows.Forms.ComboBox cbbSettingsLanguage;
        private System.Windows.Forms.Label lblSettingLanguage;
    }
}

