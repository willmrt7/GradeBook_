using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class MainPage : Page
    {

        GradeBook book = new GradeBook();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void addGrade_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                book.AddGrades(float.Parse(grades_.Text));
                grades_.Text = "";
            }
            catch (Exception)
            {
                grades_.Text = "Thats not a number!";
                book.grades.Clear();
                book.AddGrades(0);
            }

        }

        private void GetAvg_Click(object sender, RoutedEventArgs e)
        {
            Avarage_.Text = "Avarage grade: " + (book.grades.Average()).ToString();
        }

        private void GetLow_Click(object sender, RoutedEventArgs e)
        {
            Lowest_.Text = "Lowest grade: " + (book.grades.Min()).ToString();

        }

        private void GetHigh_Click(object sender, RoutedEventArgs e)
        {
            Highest_.Text = "Highest grade: " + (book.grades.Max()).ToString();
        }
    }
}
