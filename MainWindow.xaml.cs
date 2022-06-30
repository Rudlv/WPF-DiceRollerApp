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

namespace DiceRollerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Roller Roll = new Roller();
        Brush color = Brushes.Black;

        //string[] dice = new string[6]; //{ "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"};
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int ammount = 3;
            int sides = 6;
            TextBox1.Text = Roll.Roll(ammount, sides);
            TextBox2.Text = Roll.Roll(ammount, sides);
            TextBox3.Text = Roll.Roll(ammount, sides);
            TextBox4.Text = Roll.Roll(ammount, sides);
            TextBox5.Text = Roll.Roll(ammount, sides);
            TextBox6.Text = Roll.Roll(ammount, sides);

            ColorChange(color);
            MessageBox.Show("Rolled 3d6 Straigth");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int ammount = 4;
            int sides = 6;
            TextBox1.Text = Roll.RollDropLowest(ammount, sides);
            TextBox2.Text = Roll.RollDropLowest(ammount, sides);
            TextBox3.Text = Roll.RollDropLowest(ammount, sides);
            TextBox4.Text = Roll.RollDropLowest(ammount, sides);
            TextBox5.Text = Roll.RollDropLowest(ammount, sides);
            TextBox6.Text = Roll.RollDropLowest(ammount, sides);

            ColorChange(color);
            MessageBox.Show("Rolled 4d6 drop lowest");
        }

        public void ColorChange(Brush color)
        {
            TextBox1.Foreground = color;
            TextBox2.Foreground = color;
            TextBox3.Foreground = color;
            TextBox4.Foreground = color;
            TextBox5.Foreground = color;
            TextBox6.Foreground = color;
        }
    }
}
