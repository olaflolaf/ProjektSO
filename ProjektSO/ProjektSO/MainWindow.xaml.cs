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
        double xa = 0;
        double ya = 0;
        double x = 0;
        double y = 0;
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
            ya = 145;

            for (int i = 0; i < 490; i++)
            {
                this.Dispatcher.Invoke(() =>
                { Canvas.SetLeft(rectangles[0], i); });
                xa++;
                Thread.Sleep(10);
            }

            

            Thread turn = new Thread(Turn1);
            turn.Start();
        }

        public void Turn1()
        {
            double angle=3.6;
            double r = 91;

            while(angle>-0.3)
            {
                angle = angle-0.1;
                x = xa + r * Math.Sin(angle);
                y = ya + r * Math.Cos(angle);

                this.Dispatcher.Invoke(() =>
                {
                    Canvas.SetLeft(rectangles[0], x+30);
                    Canvas.SetTop(rectangles[0], y+91);
                }); 
                Thread.Sleep(40);
            }

            Thread autko2 = new Thread(Car2);
            autko2.Start();

        }

        public void Car2()
        {
            xa = x + 30;
            ya = y + 91;

            this.Dispatcher.Invoke(() =>
            { rectangles[0].Fill = Brushes.Green; }
            );


            this.Dispatcher.Invoke(() =>
            {
                Canvas.SetLeft(rectangles[0], xa);
                Canvas.SetTop(rectangles[0], ya);
            });

            for (double i = xa; i > 160; i--)
            {
                
                this.Dispatcher.Invoke(()=>
                {
                    Canvas.SetLeft(rectangles[0], i);
                });
                xa--;
                Thread.Sleep(10);
            }

            Thread turn2 = new Thread(Turn2);
            turn2.Start();

        }
        

        public void Turn2()
        {
            double angle = 3.6;
            double r = 62;

            while (angle <6)
            {
                angle = angle + 0.1;
                x = xa + r * Math.Sin(angle);
                y = ya + r * Math.Cos(angle);

                this.Dispatcher.Invoke(() =>
                {
                    Canvas.SetLeft(rectangles[0], x + 15);
                    Canvas.SetTop(rectangles[0], y + 62);
                });
                Thread.Sleep(40);
            }

            Thread autko3 = new Thread(Car3);
            autko3.Start();

        }

        public void Car3()
        {
            xa = x + 15;
            ya = y + 62;

            this.Dispatcher.Invoke(() =>
            {
                Canvas.SetLeft(rectangles[0], xa);
                Canvas.SetTop(rectangles[0], ya);
            });

            for (double i = xa; i < 800; i++)
            {

                this.Dispatcher.Invoke(() =>
                {
                    Canvas.SetLeft(rectangles[0], i);
                });
                xa++;
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