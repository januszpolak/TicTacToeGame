using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Brush Green;

        public bool isTurnPlayer1 { get; set; }
        public int Counter { get; set; }
      

        public MainWindow()
        {
            InitializeComponent();

            NewGame();
           
        }


        // new game function (reset buttons content and background)
        public void NewGame()
        {
            Counter = 0;

            btn1.Content = string.Empty;
            btn2.Content = string.Empty;
            btn3.Content = string.Empty;
            btn4.Content = string.Empty;
            btn5.Content = string.Empty;
            btn6.Content = string.Empty;
            btn7.Content = string.Empty;
            btn8.Content = string.Empty;
            btn9.Content = string.Empty;

            btn1.Background = Brushes.White;
            btn2.Background = Brushes.White;
            btn3.Background = Brushes.White;
            btn4.Background = Brushes.White;
            btn5.Background = Brushes.White;
            btn6.Background = Brushes.White;
            btn7.Background = Brushes.White;
            btn8.Background = Brushes.White;
            btn9.Background = Brushes.White;
            

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            isTurnPlayer1 ^= true;

            var button = sender as Button;

            button.Content = isTurnPlayer1 ? "X" : "O";
            
            // After 9 clicks check who wins or start new game
            Counter++;
            if (Counter > 9)
            {
              
                if (Message())
                {
                    NewGame();
                }
            }

            if (Winner())
            {
                Message();
                NewGame();
            }
        }

        // This function check buttons content "X" or "O" to find winner in row or column
        private bool Winner()
        {
            if (btn1.Content != string.Empty && btn1.Content == btn2.Content && btn2.Content == btn3.Content)
            {
                btn1.Background = Brushes.Green;
                btn2.Background = Brushes.Green;
                btn3.Background = Brushes.Green;
                MessageBox.Show(btn1.Content +  " winner");
                return true;
            }
            if (btn4.Content != string.Empty && btn4.Content == btn5.Content && btn5.Content == btn6.Content)
            {
                btn4.Background = Brushes.Green;
                btn5.Background = Brushes.Green;
                btn6.Background = Brushes.Green;
                MessageBox.Show(btn4.Content + " winner");
                return true;
            }
            if (btn7.Content != string.Empty && btn7.Content == btn8.Content && btn8.Content == btn9.Content)
            {
                btn7.Background = Brushes.Green;
                btn8.Background = Brushes.Green;
                btn9.Background = Brushes.Green;
                MessageBox.Show(btn7.Content + " winner");
                return true;
            }
            if (btn1.Content != string.Empty && btn1.Content == btn4.Content && btn4.Content == btn7.Content)
            {
                btn1.Background = Brushes.Green;
                btn4.Background = Brushes.Green;
                btn7.Background = Brushes.Green;
                MessageBox.Show(btn1.Content + " winner");
                return true;
            }
            if (btn2.Content != string.Empty && btn2.Content == btn5.Content && btn5.Content == btn8.Content)
            {
                btn2.Background = Brushes.Green;
                btn5.Background = Brushes.Green;
                btn8.Background = Brushes.Green;
                MessageBox.Show(btn2.Content + " winner");
                return true;
            }
            if (btn3.Content != string.Empty && btn3.Content == btn6.Content && btn6.Content == btn9.Content)
            {
                btn3.Background = Brushes.Green;
                btn6.Background = Brushes.Green;
                btn9.Background = Brushes.Green;
                MessageBox.Show(btn3.Content + " winner");
                return true;
            }
            if (btn1.Content != string.Empty && btn1.Content == btn5.Content && btn5.Content == btn9.Content)
            {
                btn1.Background = Brushes.Green;
                btn5.Background = Brushes.Green;
                btn9.Background = Brushes.Green;
                MessageBox.Show("winner");
                return true;
            }
            if (btn3.Content != string.Empty && btn3.Content == btn5.Content && btn5.Content == btn7.Content)
            {
                btn3.Background = Brushes.Green;
                btn5.Background = Brushes.Green;
                btn7.Background = Brushes.Green;
                MessageBox.Show(btn3.Content + " winner");
                return true;
            }
            return false;
        }

        // Ask player to start game again when draw or someone win
        private bool Message()
        {
            MessageBox.Show("Start Again?");
            return true;
        }
        
    }
}
