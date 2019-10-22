using AutoUpdate.Common;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
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

namespace AutoUpdate
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
        private IEnumerable<FileResult> Files { get; set; }
        private BackgroundWorker worker = new BackgroundWorker();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.worker.DoWork += Worker_DoWork;
            this.worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            if (!this.worker.IsBusy)
            {
                this.worker.RunWorkerAsync();
            }
        }

        private void UnistallService(FileResult file)
        {
            ServiceInstaller ServiceInstallerObj = new ServiceInstaller();
            ServiceInstallerObj.ServiceName = "MyService";
            ServiceInstallerObj.Uninstall(null);
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            
        }
        private void CallBack(Action action)
        {
            this.Dispatcher.Invoke(action);
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var dem = 30;
            for (int i = 0; i < 10; i++)
            {
                this.CallBack(() =>
                {
                    var label = new Label();
                    label.Width = 10;
                    label.Height = 20;
                    label.Margin = new Thickness(dem, 448, 691, 32);
                    dem += 15;
                    label.Background = new SolidColorBrush(Colors.Blue);
                    this.g.Children.Add(label);
                });
            }
        }
    }
}
