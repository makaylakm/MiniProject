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
                        //remove timer picture from pallet1
                        btnPallet1.Enabled = true;
                        if (pallet1.status == Status.empty)
                        {
                            pallet1.status = Status.emptybase;
                            //change picture to empty base
                            break;
                        }
                        if(pallet1.status == Status.small)
                        {
                            pallet1.status = Status.smallWrapped;
                            //change picture to smalled wrapped
                            break;
                        }
                        if(pallet1.status == Status.tall)
                        {
                            pallet1.status = Status.closed;
                            //change picture to closed
                            break;
                        }
                        if(pallet1.status == Status.bustedSmall)
                        {
                            pallet1.status = Status.smallWrapped;
                            //change picture to small wrapped
                            break;
                        }
                        if(pallet1.status == Status.bustedTall)
                        {
                            pallet1.status = Status.closed;
                            //change picture to closed
                            break;
                        }
                        if(pallet1.status == Status.closed)
                        {
                            if (staging1.status == Status.empty)
                            {
                                pallet1.status = Status.empty;
                                pallet1.stuck = true;
                                staging1.status = Status.needswrap;
                                break;
                            }
                            else if (staging2.status == Status.empty)
                            {
                                pallet1.status = Status.empty;
                                pallet1.stuck = true;
                                staging2.status = Status.needswrap;
                                break;
                            }
                            else
                            {
                                //print message saying there's no empty slots
                                break;
                            }
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 11:
                        if(staging1.status == Status.needswrap)
                        {
                            
                        }
                        if(staging1.status == Status.readytomove)
                        {

                        }
                        break;
                    case 12:
                        if (staging2.status == Status.needswrap)
                        {
                            
                        }
                        if (staging2.status == Status.readytomove)
                        {

                        }
                        break;
                }

            }
            pallets.Dequeue();
            
            if (!pallet1.stuck || !pallet2.stuck || !pallet3.stuck || !pallet4.stuck) //not sure what this was originally for
            {
                Random rndPallet = new Random();
                int palletNum = rndPallet.Next(4);
            }
            
        }
        private void btnPallet1_Click(object sender, EventArgs e)
        {
            if (pallet1.status != Status.emptybase && pallet1.status != Status.smallWrapped && pallet1.status != Status.medium)
            {
                pallets.Enqueue(pallet1);
                btnPallet1.Enabled = false;
                //show a little timer picture
            }
        }

        private void btnPallet2_Click(object sender, EventArgs e)
        {
            if (pallet2.status != Status.emptybase && pallet2.status != Status.smallWrapped && pallet2.status != Status.medium)
            {
                pallets.Enqueue(pallet2);
                btnPallet2.Enabled = false;
                //show a little timer picture
            }
        }

        private void btnPallet3_Click(object sender, EventArgs e)
        {
            if (pallet3.status != Status.emptybase && pallet3.status != Status.smallWrapped && pallet3.status != Status.medium)
            {
                pallets.Enqueue(pallet3);
                btnPallet3.Enabled = false;
                //show a little timer picture
            }
        }

        private void btnPallet4_Click(object sender, EventArgs e)
        {
            if (pallet4.status != Status.emptybase && pallet4.status != Status.smallWrapped && pallet4.status != Status.medium)
            {
                pallets.Enqueue(pallet4);
                btnPallet4.Enabled = false;
                //show a little timer picture
            }
        }

        private void btnStaging1_Click(object sender, EventArgs e)
        {
            if(staging1.status == Status.needswrap || staging1.status == Status.readytomove)
            {
                pallets.Enqueue(staging1);
                btnStaging1.Enabled = false;
                //show a little timer picture
            }
        }

        private void btnStaging2_Click(object sender, EventArgs e)
        {
            if (staging2.status == Status.needswrap || staging2.status == Status.readytomove)
            {
                pallets.Enqueue(staging2);
                btnStaging2.Enabled = false;
                //show a little timer picture
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                GameLoop();
            }
            else
            {
                //what happens for game over
            }
        }
    }
}
