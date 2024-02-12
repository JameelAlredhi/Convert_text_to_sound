using System;
using System.Windows.Forms;
using SpeechLib;
using speech;


namespace speech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// /jameel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SpVoice read = new SpVoice();
            read.Speak(textBox1.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }
    }
}
