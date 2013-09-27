using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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
            
        }

        private void backgroundWorkerRun_DoWork(object sender, DoWorkEventArgs e)
        {

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
    }
}
