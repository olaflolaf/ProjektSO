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
        public MainWindow()
        {
            InitializeComponent();

            //Rectangle autko1 = new Rectangle();
            //autko1.Width = 40;
            //autko1.Height = 20;
            //autko1.Fill = Brushes.Blue;

            //Thread car1 = new Thread(Car1);
            //car1.Start(autko1);



            //MainCanvas.Children.Add(autko1);
            //Canvas.SetTop(autko1, 140);

        }



        //public void Car1(Rectangle autko1)
        //{
        //    //Rectangle autko1 = new Rectangle();
        //    //autko1.Width = 40;
        //    //autko1.Height = 20;
        //    //autko1.Fill = Brushes.Red;

        //    MainCanvas.Children.Add(autko1);
        //    Canvas.SetTop(autko1, 140);

        //    for(int i =0; i<480;i++)
        //    {
        //        Canvas.SetLeft(autko1, i);
        //        Thread.Sleep(100);
        //    }
        //}


    }

}    

