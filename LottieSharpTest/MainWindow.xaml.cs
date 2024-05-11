using LottieSharp;
using System.Windows;
using System.Windows.Forms;

namespace LottieSharpTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var urlPath = PathTextBox?.Text;
                if (string.IsNullOrEmpty(urlPath))
                    return;

                LottieAnimationView.FileName = urlPath;
                LottieAnimationView.Speed = 1.0f; //设置播放速度
                LottieAnimationView.PlayAnimation();
            }
            catch/* (Exception exception)*/
            {
                //Console.WriteLine(exception);
                //throw;
            }
        }

        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                //该值确定是否可以选择多个文件,当前不然多选
                dialog.Multiselect = false;
                dialog.Title = "请选择文件夹";
                dialog.Filter = "所有文件(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var path = dialog.FileName;
                    PathTextBox.Text = path;
                }
            }
            catch/* (Exception exception)*/
            {
                //Console.WriteLine(exception);
                //throw;
            }
        }
    }
}
