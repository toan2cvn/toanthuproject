namespace ExcelCompareTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemTbl = new System.Windows.Forms.DataGridView();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_saveItem = new System.Windows.Forms.Button();
            this.btn_readItem = new System.Windows.Forms.Button();
            this.btn_File2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_File1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.resultTbl = new System.Windows.Forms.DataGridView();
            this.rsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsSheetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsArea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsArea2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difference = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.backgroundWorkerRun = new System.ComponentModel.BackgroundWorker();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.delBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemTbl)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 472);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_cancel);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.itemTbl);
            this.tabPage1.Controls.Add(this.btn_run);
            this.tabPage1.Controls.Add(this.btn_saveItem);
            this.tabPage1.Controls.Add(this.btn_readItem);
            this.tabPage1.Controls.Add(this.btn_File2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_File1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "メイン";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(456, 108);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(145, 23);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "キャンセル";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(597, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // itemTbl
            // 
            this.itemTbl.AllowUserToOrderColumns = true;
            this.itemTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.itemName,
            this.sheetName,
            this.area1,
            this.area2,
            this.type,
            this.delBtn});
            this.itemTbl.Location = new System.Drawing.Point(1, 151);
            this.itemTbl.Name = "itemTbl";
            this.itemTbl.RowTemplate.Height = 21;
            this.itemTbl.Size = new System.Drawing.Size(602, 299);
            this.itemTbl.TabIndex = 22;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(305, 108);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(145, 23);
            this.btn_run.TabIndex = 20;
            this.btn_run.Text = "比較実行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_saveItem
            // 
            this.btn_saveItem.Location = new System.Drawing.Point(154, 108);
            this.btn_saveItem.Name = "btn_saveItem";
            this.btn_saveItem.Size = new System.Drawing.Size(145, 23);
            this.btn_saveItem.TabIndex = 19;
            this.btn_saveItem.Text = "項目ファイル保存";
            this.btn_saveItem.UseVisualStyleBackColor = true;
            // 
            // btn_readItem
            // 
            this.btn_readItem.Location = new System.Drawing.Point(3, 108);
            this.btn_readItem.Name = "btn_readItem";
            this.btn_readItem.Size = new System.Drawing.Size(145, 23);
            this.btn_readItem.TabIndex = 18;
            this.btn_readItem.Text = "項目ファイル参照";
            this.btn_readItem.UseVisualStyleBackColor = true;
            // 
            // btn_File2
            // 
            this.btn_File2.Location = new System.Drawing.Point(495, 50);
            this.btn_File2.Name = "btn_File2";
            this.btn_File2.Size = new System.Drawing.Size(75, 23);
            this.btn_File2.TabIndex = 16;
            this.btn_File2.Text = "参照";
            this.btn_File2.UseVisualStyleBackColor = true;
            this.btn_File2.Click += new System.EventHandler(this.btn_File2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox2.Location = new System.Drawing.Point(100, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(366, 21);
            this.textBox2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(-2, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "比較先ファイル";
            // 
            // btn_File1
            // 
            this.btn_File1.Location = new System.Drawing.Point(495, 3);
            this.btn_File1.Name = "btn_File1";
            this.btn_File1.Size = new System.Drawing.Size(75, 23);
            this.btn_File1.TabIndex = 13;
            this.btn_File1.Text = "参照";
            this.btn_File1.UseVisualStyleBackColor = true;
            this.btn_File1.Click += new System.EventHandler(this.btn_File1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(100, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(-2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "比較元ファイル";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resultTbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "結果";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // resultTbl
            // 
            this.resultTbl.AllowUserToOrderColumns = true;
            this.resultTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rsNo,
            this.rsItemName,
            this.rsSheetName,
            this.rsArea1,
            this.rsArea2,
            this.rsType,
            this.difference});
            this.resultTbl.Location = new System.Drawing.Point(2, 6);
            this.resultTbl.Name = "resultTbl";
            this.resultTbl.RowTemplate.Height = 21;
            this.resultTbl.Size = new System.Drawing.Size(598, 493);
            this.resultTbl.TabIndex = 22;
            // 
            // rsNo
            // 
            this.rsNo.HeaderText = "No";
            this.rsNo.Name = "rsNo";
            this.rsNo.Width = 30;
            // 
            // rsItemName
            // 
            this.rsItemName.HeaderText = "項目名";
            this.rsItemName.Name = "rsItemName";
            this.rsItemName.Width = 120;
            // 
            // rsSheetName
            // 
            this.rsSheetName.HeaderText = "シート名";
            this.rsSheetName.Name = "rsSheetName";
            this.rsSheetName.Width = 120;
            // 
            // rsArea1
            // 
            this.rsArea1.HeaderText = "対象列1";
            this.rsArea1.Name = "rsArea1";
            this.rsArea1.Width = 80;
            // 
            // rsArea2
            // 
            this.rsArea2.HeaderText = "対象列2";
            this.rsArea2.Name = "rsArea2";
            this.rsArea2.Width = 80;
            // 
            // rsType
            // 
            this.rsType.HeaderText = "タイプ";
            this.rsType.Name = "rsType";
            this.rsType.Width = 60;
            // 
            // difference
            // 
            this.difference.HeaderText = "差異";
            this.difference.Items.AddRange(new object[] {
            "有",
            "無"});
            this.difference.Name = "difference";
            this.difference.Width = 65;
            // 
            // backgroundWorkerRun
            // 
            this.backgroundWorkerRun.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRun_DoWork);
            this.backgroundWorkerRun.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerRun_ProgressChanged);
            this.backgroundWorkerRun.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerRun_RunWorkerCompleted);
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 30;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "項目名";
            this.itemName.Name = "itemName";
            this.itemName.Width = 120;
            // 
            // sheetName
            // 
            this.sheetName.DataPropertyName = "sheetName";
            this.sheetName.HeaderText = "シート名";
            this.sheetName.Name = "sheetName";
            this.sheetName.Width = 120;
            // 
            // area1
            // 
            this.area1.HeaderText = "Range1";
            this.area1.Name = "area1";
            this.area1.Width = 80;
            // 
            // area2
            // 
            this.area2.HeaderText = "Range2";
            this.area2.Name = "area2";
            this.area2.Width = 80;
            // 
            // type
            // 
            this.type.HeaderText = "タイプ";
            this.type.Items.AddRange(new object[] {
            "値",
            "式"});
            this.type.Name = "type";
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.type.Width = 60;
            // 
            // delBtn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "削除";
            this.delBtn.DefaultCellStyle = dataGridViewCellStyle1;
            this.delBtn.HeaderText = "削除";
            this.delBtn.Name = "delBtn";
            this.delBtn.Text = "削除";
            this.delBtn.Width = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel比較ツール";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemTbl)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView itemTbl;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_saveItem;
        private System.Windows.Forms.Button btn_readItem;
        private System.Windows.Forms.Button btn_File2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_File1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView resultTbl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRun;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsSheetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsArea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsArea2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsType;
        private System.Windows.Forms.DataGridViewComboBoxColumn difference;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn area1;
        private System.Windows.Forms.DataGridViewTextBoxColumn area2;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private System.Windows.Forms.DataGridViewButtonColumn delBtn;

    }
}

