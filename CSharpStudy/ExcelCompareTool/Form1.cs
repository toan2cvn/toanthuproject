using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExcelCompareTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ファイル選択ダイアログを表示、ファイルパスを取得
        /// </summary>
        /// <param name="tittle">ダイアログタイトル</param>
        /// <param name="defaultFolder">初期フォルダ</param>
        /// <returns>選択されたファイルパス</returns>
        private string showOpenFileDialog(string tittle, string defaultFolder)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FileName = string.Empty;
                openFileDialog.InitialDirectory = defaultFolder;

                // Excelファイルだけ表示する
                openFileDialog.Filter = "Excelファイル2007(*.xlsx)|*.xlsx|Excelファイル2003(*.xls)|*.xls|全てのファイル(*.*)|*.*";

                // Excelファイルフィルタル
                openFileDialog.FilterIndex = 1;

                openFileDialog.Title = tittle;

                // ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
                openFileDialog.RestoreDirectory = true;

                // ダイアログを表示する
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 選択されたファイル名を取得
                    return openFileDialog.FileName;
                }
            }

            return null;
        }

        /// <summary>
        /// 実行ボタン押下
        /// </summary>
        /// <param name="sender">イベント</param>
        /// <param name="e">イベント</param>
        private void btn_File1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = showOpenFileDialog(Properties.Resources.MSG_INPUT_FILE1, this.textBox1.Text);
        }

        private void btn_File2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = showOpenFileDialog(Properties.Resources.MSG_INPUT_FILE2, this.textBox2.Text);
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            // インプットデータをチェック
            if (this.CheckInputData() != null)
            {
                MessageBox.Show(this, this.CheckInputData(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btn_run.Enabled = true;
                return;
            }

            Dictionary<string, object> dataGridCheck = GetDataGridViewData(this.itemTbl);
            List<int> error = (List<int>)dataGridCheck["error"];
            if (error != null)
            {
                MessageBox.Show(this, string.Format(Properties.Resources.MSG_ITEM_TABLE_MISS, error[0], error[1]), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btn_run.Enabled = true;
                return;
            }

            List<List<string>> gridData = (List<List<string>>)dataGridCheck["gridData"];

            if (!backgroundWorkerRun.IsBusy)
            {

                List<object> paramData = new List<object>();
                paramData.Add(gridData);
                paramData.Add(this.textBox1.Text);
                paramData.Add(this.textBox2.Text);

                // バックグラウンド処理を開始
                backgroundWorkerRun.RunWorkerAsync(paramData);
            }
        }

        private void backgroundWorkerRun_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            List<object> paramData = (List<object>)e.Argument;

            List<List<string>> gridData = (List<List<string>>)paramData[0];
            string fileName1 = (string)paramData[1];
            string fileName2 = (string)paramData[2];

            MessageBox.Show(gridData.Count.ToString());
        }

        /// <summary>
        /// 実行完了
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void backgroundWorkerRun_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                this.toolStripStatusLabel1.Text = "キャンセルされました。";
            }
            else if (!(e.Error == null))
            {
                this.toolStripStatusLabel1.Text = "エラー: " + e.Error.Message;
            }
            else
            {
                this.toolStripProgressBar1.Value = 100;
                this.toolStripStatusLabel1.Text = "100%完了しました!";
            }

            this.btn_run.Enabled = true;
            this.btn_cancel.Enabled = true;
        }

        /// <summary>
        /// プログレスバー更新
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void backgroundWorkerRun_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                this.toolStripStatusLabel1.Text = "中継サーバ使用不可能時間になっています。一時中断致します。";
            }
            else
            {
                this.toolStripStatusLabel1.Text = e.ProgressPercentage.ToString() + "%完了";
                this.toolStripProgressBar1.Value = e.ProgressPercentage;
            }
        }

        /// <summary>
        /// キャンセル
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            backgroundWorkerRun.CancelAsync();
            if (backgroundWorkerRun.IsBusy)
            {
                this.btn_cancel.Enabled = false;
            }
        }

        /// <summary>
        /// 入力データチェック
        /// </summary>
        /// <returns>メッセージ</returns>
        private string CheckInputData()
        {
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                return Properties.Resources.MSG_INPUT_FILE1;
            }

            if (string.IsNullOrEmpty(this.textBox2.Text))
            {
                return Properties.Resources.MSG_INPUT_FILE2;
            }

            if (!File.Exists(this.textBox1.Text))
            {
                return Properties.Resources.MSG_FILE1_NOT_EXISTS;
            }

            if (!File.Exists(this.textBox2.Text))
            {
                return Properties.Resources.MSG_FILE2_NOT_EXISTS;
            }

            if (this.itemTbl.Rows.Count == 1)
            {
                return Properties.Resources.MSG_ITEM_TABLE_EMPTY;
            }

            return null;
        }

        private Dictionary<string, object> GetDataGridViewData(DataGridView itemTbl)
        {
            int occRow = -1;
            int occCell = -1;
            Dictionary<string, object> rtDic = new Dictionary<string,object>();
            List<int> error = null;
            List<List<string>> gridData = new List<List<string>>();
            List<string> rowData;
            for (int row = 0; row < itemTbl.Rows.Count - 1; row++)
            {
                rowData = new List<string>();
                for (int cell = 1; cell < itemTbl.Rows[row].Cells.Count - 1; cell++)
                {
                    try
                    {
                        string value = itemTbl.Rows[row].Cells[cell].Value.ToString();
                        if (string.IsNullOrEmpty(value))
                        {
                            occRow = row;
                            occCell = cell;
                            break;
                        }
                        else
                        {
                            rowData.Add(value);
                        }
                    }
                    catch(Exception)
                    {
                        occRow = row;
                        occCell = cell;
                        break;
                    }
                }

                gridData.Add(rowData);
            }
            if (occRow != -1)
            {
                error = new List<int>();
                error.Add(occRow + 1);
                error.Add(occCell + 1);
            }

            rtDic.Add("gridData", gridData);
            rtDic.Add("error", error);
            return rtDic;
        }
    }
}
