namespace PathTools
{
    partial class SelectForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFolderName = new System.Windows.Forms.Button();
            this.btnFileName = new System.Windows.Forms.Button();
            this.btnFullPath = new System.Windows.Forms.Button();
            this.lstPath = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExt = new System.Windows.Forms.Button();
            this.grpText = new System.Windows.Forms.GroupBox();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.rdoUpper = new System.Windows.Forms.RadioButton();
            this.rdoLower = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpText.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpText);
            this.splitContainer1.Panel1.Controls.Add(this.btnExt);
            this.splitContainer1.Panel1.Controls.Add(this.btnFolderName);
            this.splitContainer1.Panel1.Controls.Add(this.btnFileName);
            this.splitContainer1.Panel1.Controls.Add(this.btnFullPath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstPath);
            this.splitContainer1.Size = new System.Drawing.Size(419, 457);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnFolderName
            // 
            this.btnFolderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderName.Location = new System.Drawing.Point(210, 12);
            this.btnFolderName.Name = "btnFolderName";
            this.btnFolderName.Size = new System.Drawing.Size(91, 26);
            this.btnFolderName.TabIndex = 2;
            this.btnFolderName.Text = "ディレクトリ名";
            this.btnFolderName.UseVisualStyleBackColor = true;
            this.btnFolderName.Click += new System.EventHandler(this.btnFolderName_Click);
            // 
            // btnFileName
            // 
            this.btnFileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileName.Location = new System.Drawing.Point(111, 12);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(91, 26);
            this.btnFileName.TabIndex = 1;
            this.btnFileName.Text = "ファイル名";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // btnFullPath
            // 
            this.btnFullPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullPath.Location = new System.Drawing.Point(12, 12);
            this.btnFullPath.Name = "btnFullPath";
            this.btnFullPath.Size = new System.Drawing.Size(91, 26);
            this.btnFullPath.TabIndex = 0;
            this.btnFullPath.Text = "フルパス";
            this.btnFullPath.UseVisualStyleBackColor = true;
            this.btnFullPath.Click += new System.EventHandler(this.btnFullPath_Click);
            // 
            // lstPath
            // 
            this.lstPath.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPath.Font = new System.Drawing.Font("ＭＳ ゴシック", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lstPath.FullRowSelect = true;
            this.lstPath.GridLines = true;
            this.lstPath.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstPath.Location = new System.Drawing.Point(0, 0);
            this.lstPath.Name = "lstPath";
            this.lstPath.Size = new System.Drawing.Size(419, 364);
            this.lstPath.TabIndex = 1;
            this.lstPath.UseCompatibleStateImageBehavior = false;
            this.lstPath.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "フルパス";
            this.columnHeader1.Width = 400;
            // 
            // btnExt
            // 
            this.btnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExt.Location = new System.Drawing.Point(307, 12);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(91, 26);
            this.btnExt.TabIndex = 2;
            this.btnExt.Text = "拡張子";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // grpText
            // 
            this.grpText.Controls.Add(this.rdoLower);
            this.grpText.Controls.Add(this.rdoUpper);
            this.grpText.Controls.Add(this.rdoNone);
            this.grpText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpText.Location = new System.Drawing.Point(13, 45);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(385, 39);
            this.grpText.TabIndex = 3;
            this.grpText.TabStop = false;
            this.grpText.Text = "テキスト編集";
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Checked = true;
            this.rdoNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoNone.Location = new System.Drawing.Point(7, 16);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(72, 16);
            this.rdoNone.TabIndex = 0;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "何もしない";
            this.rdoNone.UseVisualStyleBackColor = true;
            // 
            // rdoUpper
            // 
            this.rdoUpper.AutoSize = true;
            this.rdoUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoUpper.Location = new System.Drawing.Point(86, 16);
            this.rdoUpper.Name = "rdoUpper";
            this.rdoUpper.Size = new System.Drawing.Size(79, 16);
            this.rdoUpper.TabIndex = 0;
            this.rdoUpper.Text = "全て大文字";
            this.rdoUpper.UseVisualStyleBackColor = true;
            // 
            // rdoLower
            // 
            this.rdoLower.AutoSize = true;
            this.rdoLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoLower.Location = new System.Drawing.Point(172, 16);
            this.rdoLower.Name = "rdoLower";
            this.rdoLower.Size = new System.Drawing.Size(79, 16);
            this.rdoLower.TabIndex = 0;
            this.rdoLower.Text = "全て小文字";
            this.rdoLower.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 457);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.Text = "パス選択";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFullPath;
        private System.Windows.Forms.Button btnFolderName;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.ListView lstPath;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.GroupBox grpText;
        private System.Windows.Forms.RadioButton rdoLower;
        private System.Windows.Forms.RadioButton rdoUpper;
        private System.Windows.Forms.RadioButton rdoNone;
    }
}