using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

namespace ContractTest
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「＝」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(this.divisor.Text, out var divisor);
            Double.TryParse(this.dividend.Text, out var dividend);
            var divided = div(divisor, dividend);
            this.divided.Content = divided;
        }

        /// <summary>
        /// 割り算
        /// </summary>
        /// <param name="divisor">割られる数</param>
        /// <param name="dividend">割る数</param>
        /// <returns></returns>
        private double div(double divisor, double dividend)
        {
            Contract.Requires(dividend != 0);
            return divisor / dividend;
        }
    }
}
