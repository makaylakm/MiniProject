using MiniProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace MiniProject
{
    public partial class GameForm : Form
    {
        Pallet pallet1 = new Pallet(1, Status.empty);
        Pallet pallet2 = new Pallet(2, Status.medium);
        Pallet pallet3 = new Pallet(3, Status.smallWrapped);
        Pallet pallet4 = new Pallet(4, Status.emptybase);

        Pallet staging1 = new Pallet(11, Status.empty);
        Pallet staging2 = new Pallet(12, Status.empty);

        string playerName = Form1.playerName;
        int lives = 3;
        int score = 0;

        Queue<Pallet> pallets = new Queue<Pallet>();
        
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timerAddBoxes.Start();
        }
        private void GameLoop()
        {
            if (pallets.Count != 0) //using class queue
            {
                int nextLocation = pallets.Peek().location;
                switch (nextLocation)
                {
                    case 1:
                        picPending1.Visible = false; //removes pending icon
                        btnPallet1.Enabled = true;
                        if (pallet1.status == Status.empty)
                        {
                            pallet1.status = Status.emptybase;
                            btnPallet1.Image = Properties.Resources.empty_base;//changes picture
                            break;
                        }
                        if(pallet1.status == Status.small || pallet1.status == Status.bustedSmall)
                        {
                            pallet1.status = Status.smallWrapped;
                            btnPallet1.Image = Properties.Resources.small_wrapped;
                            break;
                        }
                        if(pallet1.status == Status.tall || pallet1.status == Status.bustedTall)
                        {
                            pallet1.status = Status.closed;
                            btnPallet1.Image = Properties.Resources.closed;
                            break;
                        }
                        if(pallet1.status == Status.closed)
                        {
                            if (staging1.status == Status.empty)
                            {
                                pallet1.status = Status.empty;
                                btnPallet1.Image = null;
                                staging1.status = Status.needswrap;
                                btnStaging1.Image = Properties.Resources.closed;
                                break;
                            }
                            else if (staging2.status == Status.empty)
                            {
                                pallet1.status = Status.empty;
                                btnPallet1.Image = null;
                                staging2.status = Status.needswrap;
                                btnStaging2.Image = Properties.Resources.closed;
                                break;
                            }
                            else
                            {
                                //print message saying there's no empty slots
                                lblInfo.Text = "No empty staging slots. -1";
                                lblInfo.ForeColor = Color.Red;
                                lives--;
                                break;
                            }
                        }
                        break;
                    case 2:
                        picPending2.Visible = false;
                        btnPallet2.Enabled = true;
                        if (pallet2.status == Status.empty)
                        {
                            pallet2.status = Status.emptybase;
                            btnPallet2.Image = Properties.Resources.empty_base;
                            break;
                        }
                        if (pallet2.status == Status.small || pallet2.status == Status.bustedSmall)
                        {
                            pallet2.status = Status.smallWrapped;
                            btnPallet2.Image = Properties.Resources.small_wrapped;
                            break;
                        }
                        if (pallet2.status == Status.tall || pallet2.status == Status.bustedTall)
                        {
                            pallet2.status = Status.closed;
                            btnPallet2.Image = Properties.Resources.closed;
                            break;
                        }
                        if (pallet2.status == Status.closed)
                        {
                            if (staging1.status == Status.empty)
                            {
                                pallet2.status = Status.empty;
                                btnPallet2.Image = null;
                                staging1.status = Status.needswrap;
                                btnStaging1.Image = Properties.Resources.closed;
                                break;
                            }
                            else if (staging2.status == Status.empty)
                            {
                                pallet2.status = Status.empty;
                                btnPallet2.Image = null;
                                staging2.status = Status.needswrap;
                                btnStaging2.Image = Properties.Resources.closed;
                                break;
                            }
                            else
                            {
                                lblInfo.Text = "No empty staging slots. -1";
                                lblInfo.ForeColor = Color.Red;
                                lives--;
                                break;
                            }
                        }
                        break;
                    case 3:
                        picPending3.Visible = false;
                        btnPallet3.Enabled = true;
                        if (pallet3.status == Status.empty)
                        {
                            pallet3.status = Status.emptybase;
                            btnPallet3.Image = Properties.Resources.empty_base;
                            break;
                        }
                        if (pallet3.status == Status.small || pallet3.status == Status.bustedSmall)
                        {
                            pallet3.status = Status.smallWrapped;
                            btnPallet3.Image = Properties.Resources.small_wrapped;
                            break;
                        }
                        if (pallet3.status == Status.tall || pallet3.status == Status.bustedTall)
                        {
                            pallet3.status = Status.closed;
                            btnPallet3.Image = Properties.Resources.closed;
                            break;
                        }
                        if (pallet3.status == Status.closed)
                        {
                            if (staging1.status == Status.empty)
                            {
                                pallet3.status = Status.empty;
                                btnPallet3.Image = null;
                                staging1.status = Status.needswrap;
                                btnStaging1.Image = Properties.Resources.closed;
                                break;
                            }
                            else if (staging2.status == Status.empty)
                            {
                                pallet3.status = Status.empty;
                                btnPallet3.Image = null;
                                staging2.status = Status.needswrap;
                                btnStaging2.Image = Properties.Resources.closed;
                                break;
                            }
                            else
                            {
                                lblInfo.Text = "No empty staging slots. -1";
                                lblInfo.ForeColor = Color.Red;
                                lives--;
                                break;
                            }
                        }
                        break;
                    case 4:
                        picPending4.Visible = false;
                        btnPallet4.Enabled = true;
                        if (pallet4.status == Status.empty)
                        {
                            pallet4.status = Status.emptybase;
                            btnPallet4.Image = Properties.Resources.empty_base;
                            break;
                        }
                        if (pallet4.status == Status.small || pallet4.status == Status.bustedSmall)
                        {
                            pallet4.status = Status.smallWrapped;
                            btnPallet4.Image = Properties.Resources.small_wrapped;
                            break;
                        }
                        if (pallet4.status == Status.tall || pallet4.status == Status.bustedTall)
                        {
                            pallet4.status = Status.closed;
                            btnPallet4.Image = Properties.Resources.closed;
                            break;
                        }
                        if (pallet4.status == Status.closed)
                        {
                            if (staging1.status == Status.empty)
                            {
                                pallet4.status = Status.empty;
                                btnPallet4.Image = null;
                                staging1.status = Status.needswrap;
                                btnStaging1.Image = Properties.Resources.closed;
                                break;
                            }
                            else if (staging2.status == Status.empty)
                            {
                                pallet4.status = Status.empty;
                                btnPallet4.Image = null;
                                staging2.status = Status.needswrap;
                                btnStaging2.Image = Properties.Resources.closed;
                                break;
                            }
                            else
                            {
                                lblInfo.Text = "No empty staging slots. -1";
                                lblInfo.ForeColor = Color.Red;
                                lives--;
                                break;
                            }
                        }
                        break;
                    case 11:
                        picPending11.Visible = false;
                        btnStaging1.Enabled = true;
                        if (staging1.status == Status.readytomove)
                        {
                            staging1.status = Status.empty;
                            btnStaging1.Image = null;
                            score++; //increases score
                            lblInfo.Text = "Completed pallet sent to truck. +1";
                            lblInfo.ForeColor = Color.Green;
                            lblScore.Text = score.ToString();
                        }
                        if (staging1.status == Status.needswrap)
                        {
                            staging1.status = Status.readytomove;
                            btnStaging1.Image = Properties.Resources.topped_and_wrapped;
                        }
                        break;
                    case 12:
                        picPending12.Visible = false;
                        btnStaging2.Enabled = true;
                        if (staging2.status == Status.readytomove)
                        {
                            staging2.status = Status.empty;
                            btnStaging2.Image = null;
                            score++; //increases score
                            lblInfo.Text = "Completed pallet sent to truck. +1";
                            lblInfo.ForeColor = Color.Green;
                            lblScore.Text = score.ToString();
                        }
                        if (staging2.status == Status.needswrap)
                        {
                            staging2.status= Status.readytomove;
                            btnStaging2.Image = Properties.Resources.topped_and_wrapped;
                        }
                        break;
                }
                lblLives.Text = lives.ToString();
                if (lives == 0)
                    GameOver();
                pallets.Dequeue();
            }
        }
        private void AddBoxes()
        {
            //if any pallet slots are empty base, small wrapped, or medium, add boxes to them
            if(!pallet1.stuck || !pallet2.stuck || !pallet3.stuck || !pallet4.stuck)
            {
                timerOverflow.Stop();
                if (!pallet1.stuck)
                {
                    if (pallet1.status == Status.medium)
                    {
                        pallet1.status = Status.tall;
                        btnPallet1.Image = Properties.Resources.tall;
                        timerFall1.Start();
                    }
                    else if (pallet1.status == Status.smallWrapped)
                    {
                        pallet1.status = Status.medium;
                        btnPallet1.Image = Properties.Resources.medium;
                    }
                    else
                    {
                        pallet1.status = Status.small;
                        btnPallet1.Image = Properties.Resources.small;
                        timerFall1.Start();
                    }
                }
                if (!pallet2.stuck)
                {
                    if (pallet2.status == Status.medium)
                    {
                        pallet2.status = Status.tall;
                        btnPallet2.Image = Properties.Resources.tall;
                        timerFall2.Start();
                    }
                    else if (pallet2.status == Status.smallWrapped)
                    {
                        pallet2.status = Status.medium;
                        btnPallet2.Image = Properties.Resources.medium;
                    }
                    else
                    {
                        pallet2.status = Status.small;
                        btnPallet2.Image = Properties.Resources.small;
                        timerFall2.Start();
                    }
                }
                if (!pallet3.stuck)
                {
                    if (pallet3.status == Status.medium)
                    {
                        pallet3.status = Status.tall;
                        btnPallet3.Image = Properties.Resources.tall;
                        timerFall3.Start();
                    }
                    else if (pallet3.status == Status.smallWrapped)
                    {
                        pallet3.status = Status.medium;
                        btnPallet3.Image = Properties.Resources.medium;
                    }
                    else
                    {
                        pallet3.status = Status.small;
                        btnPallet3.Image = Properties.Resources.small;
                        timerFall3.Start();
                    }
                }
                if (!pallet4.stuck)
                {
                    if (pallet4.status == Status.medium)
                    {
                        pallet4.status = Status.tall;
                        btnPallet4.Image = Properties.Resources.tall;
                        timerFall4.Start();
                    }
                    else if (pallet4.status == Status.smallWrapped)
                    {
                        pallet4.status = Status.medium;
                        btnPallet4.Image = Properties.Resources.medium;
                    }
                    else
                    {
                        pallet4.status = Status.small;
                        btnPallet4.Image = Properties.Resources.small;
                        timerFall4.Start();
                    }
                }
            }
            //if there's nowhere to add boxes/all pallets stuck for too long
            else if(!timerOverflow.Enabled) //start timer for overflow if it isn't started already
            {
                timerOverflow.Start();
            }
        }
        private void btnPallet1_Click(object sender, EventArgs e)
        {
            if (pallet1.status != Status.emptybase && pallet1.status != Status.smallWrapped && pallet1.status != Status.medium)
            {
                pallets.Enqueue(pallet1);
                btnPallet1.Enabled = false;
                picPending1.Visible = true; //shows little timer picture
                if (pallet1.status == Status.small || pallet1.status == Status.tall)
                {
                    timerFall1.Stop(); //stop fall1 timer, could probably delete the if statement
                }
            }
        }

        private void btnPallet2_Click(object sender, EventArgs e)
        {
            if (pallet2.status != Status.emptybase && pallet2.status != Status.smallWrapped && pallet2.status != Status.medium)
            {
                pallets.Enqueue(pallet2);
                btnPallet2.Enabled = false;
                picPending2.Visible = true;
                if (pallet2.status == Status.small || pallet2.status == Status.tall)
                {
                    timerFall2.Stop();
                }
            }
        }

        private void btnPallet3_Click(object sender, EventArgs e)
        {
            if (pallet3.status != Status.emptybase && pallet3.status != Status.smallWrapped && pallet3.status != Status.medium)
            {
                pallets.Enqueue(pallet3);
                btnPallet3.Enabled = false;
                picPending3.Visible = true;
                if (pallet3.status == Status.small || pallet3.status == Status.tall)
                {
                    timerFall3.Stop(); 
                }
            }
        }

        private void btnPallet4_Click(object sender, EventArgs e)
        {
            if (pallet4.status != Status.emptybase && pallet4.status != Status.smallWrapped && pallet4.status != Status.medium)
            {
                pallets.Enqueue(pallet4);
                btnPallet4.Enabled = false;
                picPending4.Visible = true;
                if (pallet4.status == Status.small || pallet4.status == Status.tall)
                {
                    timerFall4.Stop();
                }
            }
        }

        private void btnStaging1_Click(object sender, EventArgs e)
        {
            if(staging1.status == Status.needswrap || staging1.status == Status.readytomove)
            {
                pallets.Enqueue(staging1);
                btnStaging1.Enabled = false;
                picPending11.Visible = true;
            }
        }

        private void btnStaging2_Click(object sender, EventArgs e)
        {
            if (staging2.status == Status.needswrap || staging2.status == Status.readytomove)
            {
                pallets.Enqueue(staging2);
                btnStaging2.Enabled = false;
                picPending12.Visible = true;
            }
        }
        private void GameOver()
        {
            //stop all timers
            timer1.Stop();
            timerFall1.Stop();
            timerFall2.Stop();
            timerFall3.Stop();
            timerFall4.Stop();
            timerOverflow.Stop();
            timerAddBoxes.Stop();

            //display game over
            MessageBox.Show("Game over.");

            //display try again and high scores buttons
            btnTryAgain.Visible = true;
            btnHighScores.Visible = true;

            //add this high score to the high scores file
            string filepath = @"C:\Files\highscores.xml";
            List<Player> highScores = new List<Player>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));

            //read file if it exists
            if (File.Exists(filepath))
            {
                TextReader reader = new StreamReader(filepath);
                highScores = (List<Player>)serializer.Deserialize(reader);
                reader.Close();
            }
            
            //write file
            var player1 = new Player(playerName, this.score);
            highScores.Add(player1);
            TextWriter filestream = new StreamWriter(filepath);
            serializer.Serialize(filestream, highScores);
            filestream.Close();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GameLoop();
        }

        private void timerFall1_Tick(object sender, EventArgs e)
        {
            //if a pallet is tall for too long: make busted tall, lives--
            //if a pallet is small for too long: make busted small, lives--
            //timer for each pallet, start timer when pallet is small or tall, restart when it's been clicked, 10 seconds
            if(pallet1.status == Status.small)
            {
                pallet1.status = Status.bustedSmall;
                btnPallet1.Image = Properties.Resources.busted;
                lives--;
                lblInfo.Text = "Pallet 1 fell. -1";
                lblInfo.ForeColor = Color.Red;
                lblLives.Text = lives.ToString();
            }
            else if(pallet1.status == Status.tall)
            {
                pallet1.status = Status.bustedTall;
                btnPallet1.Image = Properties.Resources.busted;
                lives--;
                lblInfo.Text = "Pallet 1 fell. -1";
                lblInfo.ForeColor = Color.Red;
                lblLives.Text = lives.ToString();
            }
            timerFall1.Stop();
            if (lives == 0)
                GameOver();
        }

        private void timerFall2_Tick(object sender, EventArgs e)
        {
            if (pallet2.status == Status.small)
            {
                pallet2.status = Status.bustedSmall;
                btnPallet2.Image = Properties.Resources.busted;
                lives--;
                lblInfo.Text = "Pallet 2 fell. -1";
                lblInfo.ForeColor = Color.Red;
                lblLives.Text = lives.ToString();
            }
            else if (pallet2.status == Status.tall)
            {
                pallet2.status = Status.bustedTall;
                btnPallet2.Image = Properties.Resources.busted;
                lives--;
                lblInfo.Text = "Pallet 2 fell. -1";
                lblInfo.ForeColor = Color.Red;
                lblLives.Text = lives.ToString();
            }
            timerFall2.Stop();
            if (lives == 0)
                GameOver();
        }

        private void timerFall3_Tick(object sender, EventArgs e)
        {
            if (pallet3.status == Status.small)
            {
                pallet3.status = Status.bustedSmall;
                btnPallet3.Image = Properties.Resources.busted;
                lives--;
                lblInfo.Text = "Pallet 3 fell. -1";
                lblInfo.ForeColor = Color.Red;
                lblLives.Text = lives.ToString();
            }
            else if (pallet3.status == Status.tall)
            {
                pallet3.status = Status.bustedTall;
                btnPallet3.Image = Properties.Resources.busted;
                lives--;
                lblInfo.Text = "Pallet 3 fell. -1";
                lblInfo.ForeColor = Color.Red;
                lblLives.Text = lives.ToString();
            }
            timerFall3.Stop();
            if (lives == 0)
                GameOver();
        }

        private void timerFall4_Tick(object sender, EventArgs e)
        {
            if (pallet4.status == Status.small)
            {
                pallet4.status = Status.bustedSmall;
                btnPallet4.Image = Properties.Resources.busted;
                lives--;
                lblInfo.Text = "Pallet 4 fell. -1";
                lblInfo.ForeColor = Color.Red;
                lblLives.Text = lives.ToString();
            }
            else if (pallet4.status == Status.tall)
            {
                pallet4.status = Status.bustedTall;
                btnPallet4.Image = Properties.Resources.busted;
                lives--;
                lblInfo.Text = "Pallet 4 fell. -1";
                lblInfo.ForeColor = Color.Red;
                lblLives.Text = lives.ToString();
            }
            timerFall4.Stop();
            if (lives == 0)
                GameOver();
        }

        private void timerAddBoxes_Tick(object sender, EventArgs e)
        {
            AddBoxes();
        }

        private void timerOverflow_Tick(object sender, EventArgs e)
        {
            picBelt.Image = Properties.Resources.overflow2;
            lblInfo.Text = "Conveyor belt overflowed. Game over.";
            lblInfo.ForeColor = Color.Red;
            GameOver();
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            //refresh everything
            GameForm gameForm = new GameForm();
            gameForm.Show();
            this.Close();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            HighScores highscoresform = new HighScores();
            highscoresform.Show();
        }
    }
}
