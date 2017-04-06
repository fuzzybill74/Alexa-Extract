using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaExtraction
{
    public class Extract
    {

        public List<Utterance> ExtractUtterances(String path)
        {
            List<Utterance> lstUtterances = new List<Utterance>();
        
            // Read Utterances.txt file
            // For each line,
            // Remove 1st word, and use it as "Key"  keep the rest, linked to that key

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(path);

            // Display the file contents by using a foreach loop.
            var cpt = 0;

            var parameters =
                    from ln in lines
                    let split = ln.Split(' ')
                    select new { name = split.First(), value = split.Skip(1) };

            foreach (var line in parameters)
            {
                
                var utt = new Utterance();
                utt.id = cpt;
                utt.Intent = line.name;
                utt.Sentence = String.Join(" " , line.value.ToArray());

                lstUtterances.Add(utt);
                cpt++;
            }

            return lstUtterances;
        }

        public sc_intents ExtractIntents(String path)
        {
            // Read IntentSchema.json file
            // For each line,
            // Remove 1st word, and use it as "Key"  keep the rest, linked to that key

            string text = System.IO.File.ReadAllText(path);


            //JavaScriptSerializer jss = new JavaScriptSerializer();
            //List<sc_intents> rstPatient = jss.Deserialize(text);

            sc_intents rstPatient = JsonConvert.DeserializeObject<sc_intents>(text);

            return rstPatient;
        }

        public void ExtractSlots(String folder, List<scIntent> intents )
        {
            List<String> rstLines = new List<String>();
            // MUST BE DONE AFTER INTENTS
            // Read all Slot in the designed folder
            // ADD each word to the defined SlotType
            var files = Directory.GetFiles(folder);


            foreach (var fichier in files)
            {
                foreach (var intent in intents)
                {
                    foreach (var slot in intent.slots)
                    {
                        if (Path.GetFileName(fichier) == slot.type)
                        {
                            string[] lines = System.IO.File.ReadAllLines(fichier);
                            slot.slots.AddRange(lines);
                        }
                    }
                }               
            }
        }
    } 
}
