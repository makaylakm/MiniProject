using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        public static string playerName;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtboxName_Validating(object sender, CancelEventArgs e)
        {
            if(txtboxName.TextLength > 20 || txtboxName.TextLength == 0)
            {
                MessageBox.Show("Please enter name between 1 and 20 characters.");
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            InstructionsForm instructions = new InstructionsForm();
            instructions.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            playerName = txtboxName.Text;
            GameForm gameForm = new GameForm();
            gameForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
