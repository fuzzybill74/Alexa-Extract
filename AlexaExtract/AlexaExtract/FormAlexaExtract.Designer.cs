namespace AlexaExtract
{
    partial class FormAlexaExtract
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIntentsUtterances = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonSlots = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonIntents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIntentsUtterances
            // 
            this.buttonIntentsUtterances.Location = new System.Drawing.Point(681, 62);
            this.buttonIntentsUtterances.Name = "buttonIntentsUtterances";
            this.buttonIntentsUtterances.Size = new System.Drawing.Size(75, 23);
            this.buttonIntentsUtterances.TabIndex = 0;
            this.buttonIntentsUtterances.Text = "Select...";
            this.buttonIntentsUtterances.UseVisualStyleBackColor = true;
            this.buttonIntentsUtterances.Click += new System.EventHandler(this.buttonIntentsUtterances_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(635, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "D:\\Dropbox\\Daforno\\Alexa\\Formation Code\\alexa-skills-kit-js-deprecated\\3_minecraf" +
    "tHelper\\speechAssets\\SampleUtterances.txt";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(635, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "D:\\Dropbox\\Daforno\\Alexa\\Formation Code\\alexa-skills-kit-js-deprecated\\3_minecraf" +
    "tHelper\\speechAssets\\customSlotTypes";
            // 
            // buttonSlots
            // 
            this.buttonSlots.Location = new System.Drawing.Point(681, 108);
            this.buttonSlots.Name = "buttonSlots";
            this.buttonSlots.Size = new System.Drawing.Size(75, 23);
            this.buttonSlots.TabIndex = 2;
            this.buttonSlots.Text = "Select...";
            this.buttonSlots.UseVisualStyleBackColor = true;
            this.buttonSlots.Click += new System.EventHandler(this.buttonSlots_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Utterances file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slot types folder";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(681, 144);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "GO!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Intents file";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(635, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "D:\\Dropbox\\Daforno\\Alexa\\Formation Code\\alexa-skills-kit-js-deprecated\\3_minecraf" +
    "tHelper\\speechAssets\\IntentSchema.json";
            // 
            // buttonIntents
            // 
            this.buttonIntents.Location = new System.Drawing.Point(681, 17);
            this.buttonIntents.Name = "buttonIntents";
            this.buttonIntents.Size = new System.Drawing.Size(75, 23);
            this.buttonIntents.TabIndex = 7;
            this.buttonIntents.Text = "Select...";
            this.buttonIntents.UseVisualStyleBackColor = true;
            this.buttonIntents.Click += new System.EventHandler(this.buttonIntents_Click);
            // 
            // FormAlexaExtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 179);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonIntents);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonSlots);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonIntentsUtterances);
            this.Name = "FormAlexaExtract";
            this.Text = "Alexa Etract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIntentsUtterances;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonSlots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonIntents;
    }
}

