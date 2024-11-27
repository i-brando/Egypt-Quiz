using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1
{
    //This form works as the quiz screen
    public partial class Form2 : Form
    {
        List<string> questions;
        List<string> questionLabel;
        List<string> answers;
        List<string> hint;
        List<string> fact;
        List<string> images;

        // Use a single instance of Random for the entire class
        static Random rnd = new Random();

        static int score = 0;
        static int skips = 4;
        int qNum;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Sure You Want To Quit?", "Exit Egypt Quiz?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Sure You Want To Quit?", "Exit Egypt Quiz?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string answer = txtAnswer.Text;

            if (answer == "")
            {
                MessageBox.Show("Please enter an answer into the answer box");
                txtAnswer.Focus();
                return;
            }
            else
            {

                if (answer == answers[qNum])
                {
                    score = score + 1;
                    MessageBox.Show("Correct !\n" + fact[qNum]);
                }
                else
                {
                    MessageBox.Show("Wrong!\nThe Correct Answer Is:\n" + answers[qNum]);
                }
            }

            lblScore.Text = score.ToString();

            //Removes the used content from the lists
            questions.RemoveAt(qNum);
            answers.RemoveAt(qNum);
            hint.RemoveAt(qNum);
            fact.RemoveAt(qNum);
            images.RemoveAt(qNum);

            //Focus the question box
            txtAnswer.Focus();

            if (questions.Count == 0)
            {
                int percentage = score * 10;
                MessageBox.Show("Quiz Completed!\nCorrect Answers: " + score + "\nPercentage Score: " + percentage.ToString("F0") + "%");
                var menu = new Form1();
                menu.Show();
                Hide();
            }
            else
            {
                // Generates content for remaining next question
                qNum = rnd.Next(0, questions.Count);
                lblQuestion.Text = questions[qNum];
                pictureBox1.ImageLocation = "..\\Debug\\quiz_pics\\" + images[qNum];
                lblTitle.Text = questionLabel[qNum];
                txtAnswer.Text = "";
                lblHint.Text = "Need a hint? Press the hint button";
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var menu = new Form1();
            menu.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            questions = new List<string>()
            {
                "What were the pyramids used to store?",
                "What direction were all the pyramids built to face \ntowards North, East, West or South?",
                "What is the biggest pyramid in Egypt?",
                "How much did the doors to pyramids weigh in \ntonnes?",
                "How many years did it take to build a pyramid?",
                "Who Is known as the God of the Sun?",
                "Who Is known as the God of Vengeance?",
                "Who Is known as the God of Knowledge and \nWisdom?",
                "Who Is known as the Goddess of War and Healing?",
                "Who Is known as the God of Earth?"
            };

            questionLabel = new List<string>()
            {
                "Question 1",
                "Question 2",
                "Question 3",
                "Question 4",
                "Question 5",
                "Question 6",
                "Question 7",
                "Question 8",
                "Question 9",
                "Question 10"
            };

            answers = new List<string>()
            {
                "Tombs",
                "North",
                "Giza",
                "20",
                "200",
                "Ra",
                "Horus",
                "Thoth",
                "Sekhmet",
                "Geb"
            };

            hint = new List<string>()
            {
                "Another word for an ancient casket",
                "Opposite of south",
                "4 Letters, Starts with 'G'",
                "More than 18. Less than 22.",
                "More than 195. Less than 205.",
                "Fill in the blank...R-",
                "Fill in the blank...H-r-s",
                "Fill in the blank...T-o-h",
                "Fill in the blank...S-kh-m-t",
                "Fill in the blank...G-b",
            };

            fact = new List<string>()
            {
                "The pharaohs’ tombs were meant to preserve their bodies and souls. The Egyptians had a very strong belief in the afterlife and thought the dead would continue to live as they had on earth.\r\n",
                "Most of the pyramids that were made were built on the west bank of the river Nile, the only river that flowed through Egypt. It was also considered the national highway at that time as people felt that waterways were the best way to transport goods.\r\n",
                "The Great Pyramid of Giza is the oldest and sole remnant of the Seven Wonders of the Ancient World. Over 2 million blocks of stone were used to construct the pyramid, during a 20 year period concluding around 2560 BC.\r\n",
                "Their opening mechanism was only discovered when the Great Pyramid was being studied by scientists who realised that they were huge swivel doors. The door had the strange feature of being very easy to open with just one hand from the inside but almost impossible to open from the outside.\r\n",
                "A lot of time and effort was required to build these beautiful pyramids, each one averaging about two centuries. About 138 pyramids were built in ancient Egypt and their beauty lies not only in their construction but also in the phenomenal amount of thought that went into their positioning in relation to the stars.\r\n",
                "The god of the sun, Ra, has a sun disk around his head and is believed to have created this world. Every sunrise and sunset were seen as a process of renewal.",
                "This falcon-headed god with a crown of red and white was worshipped as the god of sky, war, protection, and light.",
                "Thoth is considered as a self-created god. Master of both physical and divine laws, along with his counterpart Ma’at, he maintained the universe by his mastery of calculations\r\n",
                "Sekhmet, the daughter of Ra, is depicted as a lioness and is known for her fierce character. She is also known as the Powerful One and is capable of destroying the enemies of her allies.\r\n",
                "Also described as the Father of Snakes, Geb represented crops and healing. With a goose on his head, this bearded god was believed to have caused earthquakes whenever he laughed.",
            };

            images = new List<string>()
            {
                "1.jpeg",
                "2.jpg",
                "3.jpg",
                "4.jpg",
                "5.jpg",
                "6.jpg",
                "7.jpg",
                "8.jpg",
                "9.jpg",
                "10.jpg",
            };

            lblTitle.Text = questionLabel[0];
            lblQuestion.Text = questions[0];
            pictureBox1.ImageLocation = "..\\Debug\\quiz_pics\\" + images[0];
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            lblHint.Text = hint[qNum];
            score = score - 1;
            lblScore.Text = score.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblSkips.Text = skips.ToString();
            if (skips > 0)
            {
                skips--;
                qNum = rnd.Next(0, questions.Count);
                pictureBox1.ImageLocation = "..\\Debug\\quiz_pics\\" + images[qNum];
                lblQuestion.Text = questions[qNum];
                lblTitle.Text = questionLabel[qNum];
                txtAnswer.Text = "";
            }
            else
            {
                MessageBox.Show("Sorry You're All Out Of Skips");
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    }
}
