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
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        public AddTaskWindow()
        {
            InitializeComponent();
            // заполняем ComboBox для часов значениями от 0 до 23
            FillComboBoxRange(HourComboBox, 0, 23);

            // заполняем ComboBox для минут значениями от 0 до 59
            FillComboBoxRange(MinuteComboBox, 0, 59);
        }
        private void FillComboBoxRange(ComboBox comboBox, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                comboBox.Items.Add(i.ToString("D2"));
            }
        }
        public DateTime TaskDate
        {
            get { return (DateTime)GetValue(TaskDateProperty); }
            set { SetValue(TaskDateProperty, value); }
        }
        public TimeSpan TaskTime
        {
            get { return (TimeSpan)GetValue(TaskTimeProperty); }
            set { SetValue(TaskTimeProperty, value); }
        }
        public static readonly DependencyProperty TaskDateProperty =
        DependencyProperty.Register("TaskDate", typeof(DateTime), typeof(AddTaskWindow), new PropertyMetadata(DateTime.Now));
        public static readonly DependencyProperty TaskTimeProperty =
        DependencyProperty.Register("TaskTime", typeof(TimeSpan), typeof(AddTaskWindow), new PropertyMetadata(DateTime.Now.TimeOfDay));
    }
}
