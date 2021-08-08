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
using System.Media;
using Commons.Music.Midi;
using Midi;
using System.Runtime.InteropServices;
using System.Threading;

namespace Keyboard
{
    /// <summary>
    /// Interaction logic for OneOctave.xaml
    /// </summary>
    public partial class OneOctave : UserControl
    {
        public OneOctave()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            OutputDevice outputDevice = OutputDevice.InstalledDevices[0];
            if (!outputDevice.IsOpen )
            outputDevice.Open();
            outputDevice.SendNoteOn(Channel.Channel1, Pitch.A1, 100);  
            Thread.Sleep(100);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OutputDevice outputDevice = OutputDevice.InstalledDevices[0];
            if (!outputDevice.IsOpen)
                outputDevice.Open();
            outputDevice.SendNoteOn(Channel.Channel1, Pitch.B1, 100);
            Thread.Sleep(100);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OutputDevice outputDevice = OutputDevice.InstalledDevices[0];
            if (!outputDevice.IsOpen)
                outputDevice.Open();
            outputDevice.SendNoteOn(Channel.Channel1, Pitch.C1, 100);
            Thread.Sleep(100);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OutputDevice outputDevice = OutputDevice.InstalledDevices[0];
            if (!outputDevice.IsOpen)
                outputDevice.Open();
            outputDevice.SendNoteOn(Channel.Channel1, Pitch.D1, 100);
            Thread.Sleep(100);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OutputDevice outputDevice = OutputDevice.InstalledDevices[0];
            if (!outputDevice.IsOpen)
                outputDevice.Open();
            outputDevice.SendNoteOn(Channel.Channel1, Pitch.E1, 100);
            Thread.Sleep(100);

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            OutputDevice outputDevice = OutputDevice.InstalledDevices[0];
            if (!outputDevice.IsOpen)
                outputDevice.Open();
            outputDevice.SendNoteOn(Channel.Channel1, Pitch.F1, 100);
            Thread.Sleep(100);

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            OutputDevice outputDevice = OutputDevice.InstalledDevices[0];
            if (!outputDevice.IsOpen)
                outputDevice.Open();
            outputDevice.SendNoteOn(Channel.Channel1, Pitch.G1, 100);
            Thread.Sleep(100);

        }
    }
}
