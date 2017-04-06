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
using System.Threading;

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
            var utterances = AlexEx.ExtractUtterances(textBox1.Text);

            var intents = AlexEx.ExtractIntents(textBox3.Text);

            var slots = (from p in intents.intents
                         where p.slots != null
                         select p).ToList();


           AlexEx.ExtractSlots(textBox2.Text, slots);

            //Full string generation 
            // All utterances with all possible parameter values

            StringBuilder sb = new StringBuilder();

            foreach (var intent in intents.intents)
            {
                if (intent.intent.StartsWith("AMAZON"))
                {
                    continue;
                }
                foreach (var utt in utterances)
                {
                    if(utt.Intent != intent.intent)
                    {
                        continue;
                    }
                    if (intent.slots.Count == 1)
                    {
                        foreach (var individualSlot in intent.slots)
                        {

                            foreach (var slt in individualSlot.slots)
                            {
                                // replace with intentslot
                                sb.AppendLine(utt.Sentence.Replace("{" + individualSlot.name + "}", slt));
                            }
                        }
                    }
                    
                }
            }

            var rstStr = sb.ToString();

            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -1;     // -10...10
            synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            // Synchronous

            foreach (string str in rstStr.Split('\n'))
            {

                //VOICE SUCKS!
                // TODO we need a human voice... like many with different accents
               synthesizer.Speak("Alexah!");
                Thread.Sleep(500);
                synthesizer.Speak(str);
                // Wait for answer and validate it according to code!
                Thread.Sleep(500);
            }
            

            System.IO.File.WriteAllText(@"D:\FullUtterances.txt", rstStr);

        }

    }
}
