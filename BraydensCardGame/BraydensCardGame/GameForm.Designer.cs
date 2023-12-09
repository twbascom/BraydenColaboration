namespace BraydensCardGame
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartButton = new Button();
            Playerslistbox = new ListBox();
            Decklistbox = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(106, 846);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(150, 46);
            StartButton.TabIndex = 0;
            StartButton.Text = "StartButton";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // Playerslistbox
            // 
            Playerslistbox.FormattingEnabled = true;
            Playerslistbox.Location = new Point(106, 117);
            Playerslistbox.Name = "Playerslistbox";
            Playerslistbox.Size = new Size(240, 164);
            Playerslistbox.TabIndex = 1;
            // 
            // Decklistbox
            // 
            Decklistbox.FormattingEnabled = true;
            Decklistbox.Location = new Point(426, 117);
            Decklistbox.Name = "Decklistbox";
            Decklistbox.Size = new Size(600, 548);
            Decklistbox.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(1103, 117);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(600, 548);
            listBox2.TabIndex = 3;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1868, 960);
            Controls.Add(listBox2);
            Controls.Add(Decklistbox);
            Controls.Add(Playerslistbox);
            Controls.Add(StartButton);
            Name = "GameForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
        private ListBox Playerslistbox;
        private ListBox Decklistbox;
        private ListBox listBox2;
    }
}
