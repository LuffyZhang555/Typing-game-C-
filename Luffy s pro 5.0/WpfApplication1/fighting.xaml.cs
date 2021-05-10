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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Page1.xaml  
  
    /// </summary>
    public partial class Page1 : Page
    {
        //declare the time counter by hints
        private System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
     
        private game gaming;
        private TextBlock[] blocks = new TextBlock[5];
        private TextBox textbox;
        private int[] y = new int[5] { 30, 5, 15, 0, 10 };
        private int timer;
        private int health;
        private int score;

        //hint for more scores
        private void hint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("watchout for red ones");
        }
        //start game
        private void start_Click(object sender, RoutedEventArgs e)
        {
            
            {
                Timer.Tick += Timer_Tick;
                Timer.Interval = TimeSpan.FromSeconds(1);
                Timer.Start();
                textbox = inputbox;
                blocks[0] = box1;
                blocks[1] = box2;
                blocks[2] = box3;
                blocks[3] = box4;
                blocks[4] = box5;
              
                gaming = new game(blocks, inputbox);
                timer = gaming.Timer;
                health = gaming.Health;
            }
            hint.Visibility=Visibility.Hidden;
            start.Visibility = Visibility.Hidden;
            
        }
        public Page1()
        {
            InitializeComponent();
        }
        //changed every second 
        public void Timer_Tick(object sender, EventArgs e)
        {
            timecount.Text = timer + "s";
            timer--;
            
            HP.Text = health.ToString();
            if (health < 1||timer==0)   // conditions when game over
                gameover();
            
            
            for (int i = 0; i < 5; i++)//to have different faling speed for each block 
            {
               
                Canvas.SetTop(Canvas.Children[i], y[i]);
                if (i == 0||i==2)
                {
                    y[i] += 20;
                }
                if (i ==1||i==3)
                {
                    y[i] += 10;
                } 

                if (i == 4)//for the fifth block is for bonus and is the fatest lol
                {
                    y[i] += 30;
                }
               
                if (y[i] > 260 )
                {
                    y[i] = y[i] - 250;
                    Canvas.SetTop(blocks[i], y[i]);
                    health--;
                }
                
            }
         
        }

        
   
        //change new words
        private void changetext(object sender, TextChangedEventArgs e)
        {
            Random rnd = new Random();
            int j = rnd.Next(0, 10);
            for (int i = 0; i < 5; i++)
            {
                if (inputbox.Text == blocks[i].Text)
                {
                    blocks[i].Text = gaming.Wordlist[j];
                    inputbox.Text = "";
                    //back(blocks[i], i);
                    y[i] = 10;
                    Canvas.SetTop(blocks[i], y[i]);
                    score++;
                    if (i == 4)
                    {
                        health++;//bonus
                    }
                }
            }
        }
        //class of game
        public class game
        {
            private TextBlock[] words = new TextBlock[5];
            private TextBox textbox;

            private int timer = 30;
            public int Timer
            {
                get { return timer; }
            }

            private int health = 3;
            public int Health
            {
                get { return health; }
            }

            private int score = 0;
            public int Score
            {
                get { return score; }
            }

            private string[] wordlist = new string[] { "luffy", "IERG3080", "handsome", "fat", "pretty", "sexy", "ugly", "william", "TA", "shit" };
            public string[] Wordlist
            {
                get { return wordlist; }
            }


            public game(TextBlock[] textblocks, TextBox textbox)
            {
                this.words = textblocks;
                this.textbox = textbox;
                for (int i = 0; i < 5; i++)
                    textblocks[i].Text = wordlist[i];  // first five are static....
            }

          
        }
        //when game  over
        private void gameover()
        {
            timecountformat.Visibility = Visibility.Hidden;
            timecount.Visibility = Visibility.Hidden;
            HPformat.Visibility = Visibility.Hidden;
            HP.Visibility = Visibility.Hidden;
            string Score = score.ToString();
            string Health = health.ToString();
            play.Navigate(new Page2(Score,Health));
            
            for (int i = 0; i < 5; i++)
            {
                Canvas.Children[i].Visibility = Visibility.Hidden;
            }
            inputbox.Visibility = Visibility.Hidden;
            Timer.Stop();
        }

      
      
    }
}
