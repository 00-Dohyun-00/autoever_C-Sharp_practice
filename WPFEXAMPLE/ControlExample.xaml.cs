using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFEXAMPLE
{
    /// <summary>
    /// ControlExample.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ControlExample : Window
    {
        public ControlExample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // textbox 내용 => list 에 추가
            string s = txtbox.Text;

            txtbox.Text = "";

            if(s != "")
            {
                listbox.Items.Add(s);
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // list box에 선택된 항목을 구하기 
            string s = listbox.SelectedItem.ToString();

            combo.Items.Add(s);
        }
    }
}
// 2번 버튼 누를 때 listbox에서 선택된 것은 combo에 추가
