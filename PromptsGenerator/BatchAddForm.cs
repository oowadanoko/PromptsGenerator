using Oowada.PromptsGenerator.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oowada.PromptsGenerator.Forms
{
    public partial class BatchAddForm : Form
    {
        private TabControl tab = new TabControl();
        private GroupBox gpb = new GroupBox();
        private TableLayoutPanel tlp = new TableLayoutPanel();

        public BatchAddForm()
        {
            InitializeComponent();
        }

        private void BatchAddForm_Load(object sender, EventArgs e)
        {
            tab.SuspendLayout();
            gpb.SuspendLayout();
            tlp.SuspendLayout();

            SetTab();
            SetGpb();
            SetTlp();;

            GenerateTabPage();
            Controls.Add(tab);
            tab_SelectedIndexChanged(this, null);

            tab.ResumeLayout();
            gpb.ResumeLayout();
            tlp.ResumeLayout();

            SetText();
        }

        private void GenerateTabPage()
        {
            foreach (string type in PromptManager.GetConfig().Keys)
            {
                TabPage tpg = new TabPage();
                tpg.SuspendLayout();
                tpg.Location = new Point(4, 22);
                tpg.Name = type;
                tpg.Padding = new Padding(3);
                tpg.Size = new Size(732, 350);
                tpg.TabIndex = 0;
                tpg.Text = type;
                tpg.UseVisualStyleBackColor = true;
                tab.Controls.Add(tpg);
                tpg.ResumeLayout();
            }
        }

        private void SetTab()
        {
            tab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tab.Location = new Point(0, 0);
            tab.Margin = new Padding(0);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(740, 376);
            tab.TabIndex = 0;
            tab.SelectedIndexChanged += new EventHandler(tab_SelectedIndexChanged);
        }

        private void SetGpb()
        {
            gpb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpb.Location = new Point(3, 7);
            gpb.Name = "gpb";
            gpb.Size = new Size(726, 337);
            gpb.TabIndex = 0;
            gpb.TabStop = false;
            gpb.Text = "选择";
            gpb.Controls.Add(tlp);
        }

        private void SetTlp()
        {
            tlp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp.ColumnCount = 5;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.2f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.2f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.2f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.2f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.2f));
            tlp.Location = new Point(6, 20);
            tlp.Name = "tlp";
            tlp.RowCount = 2;
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp.Size = new Size(716, 311);
            tlp.TabIndex = 0;
        }

        private void SetText()
        {
            Text = LocaleManager.Get("BatchAddFormTitle");

            btnSelectAll.Text = LocaleManager.Get("btnSelectAll");
            btnClear.Text = LocaleManager.Get("btnClear");
            btnBatchAddPrompt.Text = LocaleManager.Get("btnBatchAddPrompt");
            btnBatchAddNegativePrompt.Text = LocaleManager.Get("btnBatchAddNegativePrompt");
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            tlp.AutoScroll = false;
            tab.SelectedTab.Controls.Add(gpb);
            tlp.Controls.Clear();
            foreach (string token in PromptManager.GetTokenPrompts(tab.SelectedTab.Text).Keys)
            {
                CheckBox chk = new CheckBox();
                chk.Text = token;
                chk.Width = tab.SelectedTab.Width;
                tlp.Controls.Add(chk);
            }
            tlp.AutoScroll = true;
        }

        private void SetAllCheckBox(bool isChecked)
        {
            foreach (CheckBox chk in tlp.Controls)
            {
                chk.Checked = isChecked;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SetAllCheckBox(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetAllCheckBox(false);
        }

        private void btnBatchAddPrompt_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chk in tlp.Controls)
            {
                if (chk.Checked)
                {
                    (Owner as MainForm).AddToPrompt(PromptManager.GetPrompt(tab.SelectedTab.Text, chk.Text));
                }
            }
            Close();
        }

        private void btnBatchAddNegativePrompt_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chk in tlp.Controls)
            {
                if (chk.Checked)
                {
                    (Owner as MainForm).AddToNegativePrompt(PromptManager.GetPrompt(tab.SelectedTab.Text, chk.Text));
                }
            }
            Close();
        }
    }
}
