using System;
using System.Collections.Generic;
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
using System.Threading;
using System.Windows.Media.Animation;

namespace ProjektSO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Rectangle> rectangles = new List<Rectangle>();

        public MainWindow()
        {
            InitializeComponent();

            Rectangle autko = new Rectangle();
            autko.Width = 40;
            autko.Height = 20;
            autko.Fill = Brushes.Blue;
            MainCanvas.Children.Add(autko);
            Canvas.SetTop(autko, 145);
            rectangles.Add(autko);

            Rectangle ciufa = new Rectangle();
            ciufa.Width = 20;
            ciufa.Height = 60;
            ciufa.Fill = Brushes.Red;
            MainCanvas.Children.Add(ciufa);
            Canvas.SetBottom(ciufa, 0);
            Canvas.SetRight(ciufa, 264);
            rectangles.Add(ciufa);

            Thread car1 = new Thread(Car1);
            car1.Start();

            Thread train = new Thread(Train);
            train.Start();

        }


        public void Car1()
        {
            for (int i = 0; i < 480; i++)
            {
                this.Dispatcher.Invoke(() =>
                { Canvas.SetLeft(rectangles[0], i); });
                Thread.Sleep(10);
            }         
        }

        
        public void Train()
        {
            for (int i = 0; i < 600; i++)
            {
                this.Dispatcher.Invoke(() =>
                { Canvas.SetBottom(rectangles[1], i); });
                Thread.Sleep(5);
            }
        }
    }
}    

//x i y sie przydadza potem (petla while np)