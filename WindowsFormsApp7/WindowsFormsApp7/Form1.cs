using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //textBox1.BorderStyle = BorderStyle.Fixed3D;
            //textBox1.BorderStyle = BorderStyle.FixedSingle;
            //textBox1.BorderStyle = BorderStyle.None;

            string[] angrezi = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-", "..-", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----" };
            string[] temp = textBox1.Text.ToUpper().Split();
            //bool rb1 = radioButton1_CheckedChanged();


            var morsed = textBox1.Text.ToUpper().Replace(angrezi[0], morse[0]).Replace(angrezi[1], morse[1]).Replace(angrezi[2], morse[2]).Replace(angrezi[3], morse[3]).Replace(angrezi[4], morse[4]).Replace(angrezi[5], morse[5]).Replace(angrezi[6], morse[6]).Replace(angrezi[7], morse[7]).Replace(angrezi[8], morse[8]).Replace(angrezi[9], morse[9]).Replace(angrezi[10], morse[10]).Replace(angrezi[11], morse[11]).Replace(angrezi[12], morse[12]).Replace(angrezi[13], morse[13]).Replace(angrezi[14], morse[14]).Replace(angrezi[15], morse[15]).Replace(angrezi[16], morse[16]).Replace(angrezi[17], morse[17]).Replace(angrezi[18], morse[18]).Replace(angrezi[19], morse[19]).Replace(angrezi[20], morse[20]).Replace(angrezi[21], morse[20]).Replace(angrezi[21], morse[21]).Replace(angrezi[22], morse[22]).Replace(angrezi[23], morse[23]).Replace(angrezi[24], morse[25]).Replace(angrezi[26], morse[26]).Replace(angrezi[27], morse[27]).Replace(angrezi[28], morse[28]).Replace(angrezi[29], morse[29]).Replace(angrezi[30], morse[30]).Replace(angrezi[31], morse[31]).Replace(angrezi[32], morse[32]).Replace(angrezi[33], morse[33]);
            label1.Text = morsed;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (int i in label1.Text)
            {
                if (i == '.')
                {
                    Console.Beep(6000, 100);
                }
                else if (i == '-')
                {
                    Console.Beep(6000, 500);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //    foreach (int i in textBox1.Text)
            //    {
            //        SpeechSynthesizer s = new SpeechSynthesizer();
            //        string lg = "English";
            //        s.SelectVoice(lg.Text);
            //        s.SpeakAsync(textBox1.Text);

            //    
            //}
            //yet to write speechsynthesizer for textBox1

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
