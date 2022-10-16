namespace Oowada.PromptsGenerator.Forms
{
    partial class BatchAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBatchAddPrompt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnBatchAddNegativePrompt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBatchAddPrompt
            // 
            this.btnBatchAddPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchAddPrompt.Location = new System.Drawing.Point(466, 385);
            this.btnBatchAddPrompt.Name = "btnBatchAddPrompt";
            this.btnBatchAddPrompt.Size = new System.Drawing.Size(122, 31);
            this.btnBatchAddPrompt.TabIndex = 3;
            this.btnBatchAddPrompt.Text = "添加到Prompt";
            this.btnBatchAddPrompt.UseVisualStyleBackColor = true;
            this.btnBatchAddPrompt.Click += new System.EventHandler(this.btnBatchAddPrompt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(97, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.Location = new System.Drawing.Point(4, 385);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 31);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnBatchAddNegativePrompt
            // 
            this.btnBatchAddNegativePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchAddNegativePrompt.Location = new System.Drawing.Point(604, 385);
            this.btnBatchAddNegativePrompt.Name = "btnBatchAddNegativePrompt";
            this.btnBatchAddNegativePrompt.Size = new System.Drawing.Size(122, 31);
            this.btnBatchAddNegativePrompt.TabIndex = 4;
            this.btnBatchAddNegativePrompt.Text = "添加到Negative";
            this.btnBatchAddNegativePrompt.UseVisualStyleBackColor = true;
            this.btnBatchAddNegativePrompt.Click += new System.EventHandler(this.btnBatchAddNegativePrompt_Click);
            // 
            // BatchAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 428);
            this.Controls.Add(this.btnBatchAddNegativePrompt);
            this.Controls.Add(this.btnBatchAddPrompt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelectAll);
            this.Name = "BatchAddForm";
            this.Text = "批量添加";
            this.Load += new System.EventHandler(this.BatchAddForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBatchAddPrompt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnBatchAddNegativePrompt;
    }
}