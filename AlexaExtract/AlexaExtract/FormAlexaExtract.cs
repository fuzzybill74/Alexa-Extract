using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexaExtract
{
    public partial class FormAlexaExtract : Form
    {
        public FormAlexaExtract()
        {
            InitializeComponent();
        }


        private void buttonIntents_Click(object sender, EventArgs e)
        {

        }

        private void buttonIntentsUtterances_Click(object sender, EventArgs e)
        {

        }

        private void buttonSlots_Click(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            var AlexEx = new AlexaExtraction.Extract();
            AlexEx.ExtractUtterances(textBox1.Text);

            AlexEx.ExtractIntents(textBox3.Text);
        }

    }
}
