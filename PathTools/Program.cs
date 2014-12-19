using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using PathTools.Properties;

namespace PathTools
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // コマンドライン引数チェック
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                SelectForm frm = new SelectForm();

                frm.ShowDialog();
                
                //StringBuilder buf = new StringBuilder();
                //for (int i = 1; i < args.Length; i++)
                //{
                //    buf.AppendLine(args[i].Trim());

                //    // 履歴へ登録

                //}

                //// クリップボードへ転送
                //Clipboard.SetData(DataFormats.Text, buf.ToString());
                
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
