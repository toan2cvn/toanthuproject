namespace WindowsFormsApplication2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.itemTbl = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.項目名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.シート名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.対象列1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.対象列2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.タイプ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.削除 = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.差異 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.backgroundWorkerRun = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemTbl)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultTbl)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            // itemTbl
            // 
            this.itemTbl.AllowUserToOrderColumns = true;
            this.itemTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.項目名,
            this.シート名,
            this.対象列1,
            this.対象列2,
            this.タイプ,
            this.削除});
            this.itemTbl.Location = new System.Drawing.Point(1, 151);
            this.itemTbl.Name = "itemTbl";
            this.itemTbl.RowTemplate.Height = 21;
            this.itemTbl.Size = new System.Drawing.Size(602, 299);
            this.itemTbl.TabIndex = 22;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 30;
            // 
            // 項目名
            // 
            this.項目名.HeaderText = "項目名";
            this.項目名.Name = "項目名";
            this.項目名.Width = 120;
            // 
            // シート名
            // 
            this.シート名.HeaderText = "シート名";
            this.シート名.Name = "シート名";
            this.シート名.Width = 120;
            // 
            // 対象列1
            // 
            this.対象列1.HeaderText = "対象列1";
            this.対象列1.Name = "対象列1";
            this.対象列1.Width = 80;
            // 
            // 対象列2
            // 
            this.対象列2.HeaderText = "対象列2";
            this.対象列2.Name = "対象列2";
            this.対象列2.Width = 80;
            // 
            // タイプ
            // 
            this.タイプ.HeaderText = "タイプ";
            this.タイプ.Items.AddRange(new object[] {
            "値",
            "式"});
            this.タイプ.Name = "タイプ";
            this.タイプ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.タイプ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.タイプ.Width = 60;
            // 
            // 削除
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "削除";
            this.削除.DefaultCellStyle = dataGridViewCellStyle4;
            this.削除.HeaderText = "削除";
            this.削除.Name = "削除";
            this.削除.Text = "削除";
            this.削除.Width = 65;
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
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "目的ファイル";
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
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "元ファイル";
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.差異});
            this.resultTbl.Location = new System.Drawing.Point(2, 6);
            this.resultTbl.Name = "resultTbl";
            this.resultTbl.RowTemplate.Height = 21;
            this.resultTbl.Size = new System.Drawing.Size(598, 493);
            this.resultTbl.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "項目名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "シート名";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "対象列1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "対象列2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "タイプ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // 差異
            // 
            this.差異.HeaderText = "差異";
            this.差異.Items.AddRange(new object[] {
            "有",
            "無"});
            this.差異.Name = "差異";
            this.差異.Width = 65;
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
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(456, 108);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(145, 23);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "キャンセル";
            this.btn_cancel.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.itemTbl)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultTbl)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn 差異;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn 項目名;
        private System.Windows.Forms.DataGridViewTextBoxColumn シート名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 対象列1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 対象列2;
        private System.Windows.Forms.DataGridViewComboBoxColumn タイプ;
        private System.Windows.Forms.DataGridViewButtonColumn 削除;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRun;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_cancel;

    }
}

