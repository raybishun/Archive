﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PopQuiz_AsyncIsNotParallel
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

        Stopwatch sw = new Stopwatch();
        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StatusTextBox.Text = "Started";
            sw.Restart();
            Task t1 = DoWorkAsync(Colors.Red, 0, 200);
            Task t2 = DoWorkAsync(Colors.Blue, 1, 300);
            Task t3 = DoWorkAsync(Colors.Green, 2, 500);
            await Task.WhenAll(t1, t2, t3);
            sw.Stop();
            StatusTextBox.Text = $"Finished after {sw.ElapsedMilliseconds}";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            RootCanvas.Children.Clear();
        }

        private async Task DoWorkAsync(Color color, int column, int delay)
        {
            for (int i = 0; i < 5; i++)
            {
                // perform some asynchronous task in various ways
                // await Task.Yield();       // yields immediately
                // await Task.Delay(0);      // continues synchronously
                // await Task.Delay(100);     // continues asynchronously on UI thread
                // await Task.Delay(0).ConfigureAwait(false);    // continues synchronously
                await Task.Delay(100).ConfigureAwait(false);   // continues asynchronously on any thread

                var startTime = sw.ElapsedMilliseconds;

                // spin here for 'delay' milliseconds just to keep busy
                while (sw.ElapsedMilliseconds < startTime + delay) { /* do nothing */ }

                var endTime = sw.ElapsedMilliseconds;

                int threadId = Thread.CurrentThread.ManagedThreadId;

                Dispatcher.BeginInvoke((Action)(() => AddTimeRectangle(
                                                startTime, endTime, color, column, threadId)));
            }
        }

        /// <summary>
        /// add a rectangle that whose height & position represents the start and end time
        /// of an activity
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="color"></param>
        /// <param name="column"></param>
        private void AddTimeRectangle(double startTime, double endTime, Color color, int column, int threadId)
        {
            const int columnWidth = 50;
            Debug.WriteLine("Adding Rect {0} {1} {2} from thread:{3}", startTime, endTime, color, threadId);

            double left = column * (columnWidth * 2 / 3);
            double height = endTime - startTime;

            Rectangle r = new Rectangle()
            {
                Fill = new SolidColorBrush(color),
                Width = columnWidth,
                Height = height,
            };
            Canvas.SetLeft(r, left);
            Canvas.SetTop(r, startTime);

            RootCanvas.Children.Add(r);

            if (RootCanvas.Height < endTime)
            {
                RootCanvas.Height = endTime;
            }
            if (RootCanvas.Width < left + columnWidth)
            {
                RootCanvas.Width = left + columnWidth;
            }
        }
    }
}
