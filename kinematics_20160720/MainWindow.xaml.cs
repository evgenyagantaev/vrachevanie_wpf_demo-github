using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;

using System.Threading;
using System.IO;
//using System.IO.Ports;

using System.Runtime.InteropServices;

using OxyPlot;
using OxyPlot.Series;
using System.Text;

using System.Drawing;

namespace kinematics_20160720
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public delegate void NoArgDelegate();
    public delegate void debug_log(string message);


    public partial class MainWindow : Window
    {
        // variables ***************************
        

        // objects ***************************
        

        //                                        ********************
        //                                         PUBLIC CONSTRUCTOR
        //                                        ********************
        public MainWindow()
        {
            InitializeComponent();

            // objects *****************************
            
            

           

            
            //subscribe on ... events
            
            // threads *****************************
                        

        }// end constructor
        //***********************************************************************************************************************************


        //                                        ********************
        //                                               EVENTS
        //                                        ********************
        // Define what actions to take when the event is raised.
        

        //********************************** working threads **********************************
        
        //********************************** working threads **********************************

        

        private void UpdateUserInterface()
        {

            
        }
            

        private void start_button_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void stop_button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //dataReceivingThread.Abort();
            Thread.Sleep(2000);
            Environment.Exit(0);
        }

        private void main_window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        
        

    }//end public partial class MainWindow : Window
    //************************************************************************************************
}// end namespace kinematics_20160720
