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

namespace MiniProject
{
    public partial class GameForm : Form
    {
        Pallet pallet1 = new Pallet(true, 1, Status.empty);
        Pallet pallet2 = new Pallet(false, 2, Status.small);
        Pallet pallet3 = new Pallet(false, 3, Status.small);
        Pallet pallet4 = new Pallet(false, 4, Status.emptybase);

        Pallet staging1 = new Pallet(11, Status.empty);
        Pallet staging2 = new Pallet(12, Status.empty);

        bool gameOver = false;
        int lives = 3;
        string playerName = Form1.playerName;
        int score = 0;

        Queue<Pallet> pallets = new Queue<Pallet>();
        
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
                                pallet1.stuck = true;
                                staging1.status = Status.needswrap;
                                btnStaging1.Image = Properties.Resources.closed;
                                break;
                            }
                            else if (staging2.status == Status.empty)
                            {
                                pallet1.status = Status.empty;
                                btnPallet1.Image = null;
                                pallet1.stuck = true;
                                staging2.status = Status.needswrap;
                                btnStaging2.Image = Properties.Resources.closed;
                                break;
                            }
                            else
                            {
                                //print message saying there's no empty slots
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
                                pallet2.stuck = true;
                                staging1.status = Status.needswrap;
                                btnStaging1.Image = Properties.Resources.closed;
                                break;
                            }
                            else if (staging2.status == Status.empty)
                            {
                                pallet2.status = Status.empty;
                                btnPallet2.Image = null;
                                pallet2.stuck = true;
                                staging2.status = Status.needswrap;
                                btnStaging2.Image = Properties.Resources.closed;
                                break;
                            }
                            else
                            {
                                //print message saying there's no empty slots
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
                                pallet3.stuck = true;
                                staging1.status = Status.needswrap;
                                btnStaging1.Image = Properties.Resources.closed;
                                break;
                            }
                            else if (staging2.status == Status.empty)
                            {
                                pallet3.status = Status.empty;
                                btnPallet3.Image = null;
                                pallet3.stuck = true;
                                staging2.status = Status.needswrap;
                                btnStaging2.Image = Properties.Resources.closed;
                                break;
                            }
                            else
                            {
                                //print message saying there's no empty slots
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
                                pallet4.stuck = true;
                                staging1.status = Status.needswrap;
                                btnStaging1.Image = Properties.Resources.closed;
                                break;
                            }
                            else if (staging2.status == Status.empty)
                            {
                                pallet4.status = Status.empty;
                                btnPallet4.Image = null;
                                pallet4.stuck = true;
                                staging2.status = Status.needswrap;
                                btnStaging2.Image = Properties.Resources.closed;
                                break;
                            }
                            else
                            {
                                //print message saying there's no empty slots and you lost a life
                                lives--;
                                lblLives.Text = lives.ToString();
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
                            lblScore.Text = score.ToString();
                        }
                        if (staging2.status == Status.needswrap)
                        {
                            staging2.status= Status.readytomove;
                            btnStaging2.Image = Properties.Resources.topped_and_wrapped;
                        }
                        break;
                }
                pallets.Dequeue();
            }
            
            if (!pallet1.stuck || !pallet2.stuck || !pallet3.stuck || !pallet4.stuck) //not sure what this was originally for
            {
                Random rndPallet = new Random();
                int palletNum = rndPallet.Next(4);
            }
            
        }
        private void AddBoxes()
        {
            //if any pallets slots are empty base, small wrapped, or medium
            //add packages to them
            if(pallet1.status == Status.medium || pallet1.status == Status.smallWrapped || pallet1.status == Status.emptybase)
            {   //or if pallet1 status is not stuck?? might rewrite later
                if (pallet1.status == Status.medium)
                {
                    pallet1.status = Status.tall;
                    btnPallet1.Image = Properties.Resources.tall;
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
                }
            }
            if(pallet2.status == Status.medium || pallet2.status == Status.smallWrapped || pallet2.status == Status.emptybase)
            {
                if (pallet2.status == Status.medium)
                {
                    pallet2.status = Status.tall;
                    btnPallet2.Image = Properties.Resources.tall;
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
                }
            }
            if(pallet3.status == Status.medium || pallet3.status == Status.smallWrapped || pallet3.status == Status.emptybase)
            {
                if (pallet3.status == Status.medium)
                {
                    pallet3.status = Status.tall;
                    btnPallet3.Image = Properties.Resources.tall;
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
                }
            }
            if(pallet4.status == Status.medium || pallet4.status == Status.smallWrapped || pallet4.status == Status.emptybase)
            {
                if (pallet4.status == Status.medium)
                {
                    pallet4.status = Status.tall;
                    btnPallet4.Image = Properties.Resources.tall;
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
                }
            }

        }
        private void BadThings()
        {

        }
        private void btnPallet1_Click(object sender, EventArgs e)
        {
            if (pallet1.status != Status.emptybase && pallet1.status != Status.smallWrapped && pallet1.status != Status.medium)
            {
                pallets.Enqueue(pallet1);
                btnPallet1.Enabled = false;
                picPending1.Visible = true; //shows little timer picture
            }
        }

        private void btnPallet2_Click(object sender, EventArgs e)
        {
            if (pallet2.status != Status.emptybase && pallet2.status != Status.smallWrapped && pallet2.status != Status.medium)
            {
                pallets.Enqueue(pallet2);
                btnPallet2.Enabled = false;
                picPending2.Visible = true;
            }
        }

        private void btnPallet3_Click(object sender, EventArgs e)
        {
            if (pallet3.status != Status.emptybase && pallet3.status != Status.smallWrapped && pallet3.status != Status.medium)
            {
                pallets.Enqueue(pallet3);
                btnPallet3.Enabled = false;
                picPending3.Visible = true;
            }
        }

        private void btnPallet4_Click(object sender, EventArgs e)
        {
            if (pallet4.status != Status.emptybase && pallet4.status != Status.smallWrapped && pallet4.status != Status.medium)
            {
                pallets.Enqueue(pallet4);
                btnPallet4.Enabled = false;
                picPending4.Visible = true;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GameLoop();
                AddBoxes(); //put on different timer
            }
            else
            {
                //what happens for game over
            }
        }
    }
}
