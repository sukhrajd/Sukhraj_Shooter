using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukhraj_Shooter
{
    public partial class Form1 : Form
    {
        int x = 0;
        int voice = 0;
        int alert = 0;
        int shootaway = 0,shootAwayCount=0;
        abstractClass obj = null;

        public Form1()
        {
            InitializeComponent();

            //initilize the object 
            obj=new abstractClass();
            
            // get the random no to fire 
            voice =obj.dead();
            shootaway = obj.shootAway();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            x=3;
            //code to spin the bullet and load the gun
            pictureBox2.Image = Sukhraj_Shooter.Properties.Resources.gun;
            MessageBox.Show("Now you have six trigger to fire and one bullet in the gun");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x=1;
            // start to play the game of the first click freely 
            pictureBox2.Image = Sukhraj_Shooter.Properties.Resources.khali;
            MessageBox.Show("Load the empty gun with bullets");
            button4.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            x=2;
            // code to load the bullet in the gun
            pictureBox2.Image = Sukhraj_Shooter.Properties.Resources.bulletpareha;
            MessageBox.Show("Spin the bullet ");
            button3.Enabled = true;

        }

        //code to reset the game after using frst chance 
        public void reset() {

            x = 0;
            alert = 0;
            voice = obj.dead();
            obj = new abstractClass();

        }
        //after winning the game 
        public void winner() {
            //after winning the game trigger button will be disabled
            
            MessageBox.Show("win the game ");
        }


        private void button2_Click(object sender, EventArgs e)
        {


            if (x == 3)
            {
                alert = obj.result(voice);

                if (alert == 0)
                {
                    System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Sukhraj_Shooter.Properties.Resources.trigger);
                    obj.Play();

                    
                    //calling the method of  the winner
                    winner();
                }

                else if (alert == 1)
                {
                    //when u use six trigger 
                    MessageBox.Show("your game is over now ");
                    //confirmation about the game get from the user 
                    DialogResult dr = MessageBox.Show("You want to play again.", "Information", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);
                    //if the user want to play again 
                    if (dr == DialogResult.Yes)
                    {
                        // then reset the whole process
                        MessageBox.Show("you have two trigger and one bullet");
                        reset();
                        button4.Enabled = false;
                        button3.Enabled = false;
                        button5.Enabled = true;

                    }
                    else if (dr == DialogResult.No)
                    {
                        //if the user doesnot want to play  then exit from the game 

                        System.Environment.Exit(0);
                    }
                    else {
                        //if he press cancel then give a message and exit from the game 
                        MessageBox.Show("Thanks for playing ");
                        System.Environment.Exit(0);
                    }
                }
                else {
                    // when the user use empty trigger 
                    MessageBox.Show("Empty Trigger ");
                }
            }
            else
            {
                //when the user try to click again
                MessageBox.Show("Follow all the steps of the game to play otherwise you can't play");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this code is used to develop the concept of shootaway 
            shootAwayCount++;
            if (shootAwayCount== shootaway) {
                System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Sukhraj_Shooter.Properties.Resources.trigger);
                obj.Play();
                winner();
            }
            //after using the 2 trigger then app is automatically closed 
            if (shootAwayCount==2) {
                MessageBox.Show("Your Chances are over ");
                
                System.Environment.Exit(0);
            }

        }
    }
}
