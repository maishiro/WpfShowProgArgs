using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfShowProgArg
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public string GetProgArgString()
        {
            // プログラム起動引数を取得
            string[] args = Environment.GetCommandLineArgs();

            // コレクションを使用して、配列の要素を削除
            List<string> listArgs = new List<string>( args );
            listArgs.RemoveAt( 0 );     // プログラムパスの要素を除く
            args = listArgs.ToArray();

            // スペース区切りで配列文字列を再結合して文字列にする
            return string.Join( " ", args );
        }

        public MainWindow()
        {
            InitializeComponent();

            string sProgArg = GetProgArgString();

            this.DataContext = new { ProgArgs = sProgArg };
        }
    }
}
