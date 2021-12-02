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

namespace _021_Challenge
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
        public DateTime startDate, endDate;
        //Get dates
        private void startCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            startDate = startCalendar.SelectedDate.Value;
        }
        private void endCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            endDate = endCalendar.SelectedDate.Value;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //variables
            string driverName;

            double phone= double.Parse(phoneBox.Text);
            string phone2 = string.Format("{0:(###)###-####}", phone);

            int ss = int.Parse(ssnBox.Text);
            string ssn = string.Format("{0: 000-00-0000}", ss);

            double start;
            double end;
            double miles;

            DateTime leave;
            leave = startCalendar.SelectedDate.Value;
            DateTime back;
            back = endCalendar.SelectedDate.Value;

            double payDue;

            int vacation;


            //converting information to variables
            driverName = nameBox.Text;
           
            start = Convert.ToInt32(startBox.Text);
            end = Convert.ToInt32(endBox.Text);
            miles = end - start;

            TimeSpan daysOut = back-leave;
            int x = (int)daysOut.TotalDays;

            vacation = (x / 5)*(2);

            if (radioButton.IsChecked == true)
            {
                payDue = (double) (miles * (0.25+ 0.12));
            }
            else
            {
                payDue = (double)(miles * 0.25);
            }


            //label content
            driverAnswer.Content =  driverName;

            sSAnswer.Content = ssn;
            
            phoneAnswer.Content = phone2;
            
            milesAnswer.Content =  miles;
            
            daysOutAnswer.Content = daysOut.TotalDays;
            
            payDueAnswer.Content = payDue;

            vacationDays.Content = vacation;

        }
    }
}
