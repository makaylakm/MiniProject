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
using System.Xml.Serialization;

namespace MiniProject
{
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            //read file, sort, print
            string filepath = @"C:\Files\highscores.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
            TextReader reader = new StreamReader(filepath);
            var highScores = (List<Player>)serializer.Deserialize(reader);
            reader.Close();
            highScores.Sort();
            
            dataGridView1.DataSource = highScores;
        }
    }
}
