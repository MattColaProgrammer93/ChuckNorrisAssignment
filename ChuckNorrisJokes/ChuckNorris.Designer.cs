namespace ChuckNorrisJokes
{
    partial class ChuckNorris
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
            this.Instructions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFetchJoke = new System.Windows.Forms.Button();
            this.cboCatergories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Location = new System.Drawing.Point(38, 39);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(387, 80);
            this.Instructions.TabIndex = 0;
            this.Instructions.Text = "Hello, welcome to Chuck Norris Jokes. Press the button to\r\nmake a random joke. Yo" +
    "u can also select a catergory in\r\ndropdown list and you can fetch the joke based" +
    " on the\r\ncatergory\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // btnFetchJoke
            // 
            this.btnFetchJoke.Location = new System.Drawing.Point(38, 159);
            this.btnFetchJoke.Name = "btnFetchJoke";
            this.btnFetchJoke.Size = new System.Drawing.Size(186, 45);
            this.btnFetchJoke.TabIndex = 2;
            this.btnFetchJoke.Text = "Click for random joke";
            this.btnFetchJoke.UseVisualStyleBackColor = true;
            this.btnFetchJoke.Click += new System.EventHandler(this.btnFetchJoke_Click);
            // 
            // cboCatergories
            // 
            this.cboCatergories.FormattingEnabled = true;
            this.cboCatergories.Location = new System.Drawing.Point(274, 168);
            this.cboCatergories.Name = "cboCatergories";
            this.cboCatergories.Size = new System.Drawing.Size(151, 28);
            this.cboCatergories.TabIndex = 3;
            this.cboCatergories.SelectedIndexChanged += new System.EventHandler(this.cboCatergories_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 248);
            this.Controls.Add(this.cboCatergories);
            this.Controls.Add(this.btnFetchJoke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Instructions);
            this.Name = "Form1";
            this.Text = "ChuckNorris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Instructions;
        private Label label1;
        private Button btnFetchJoke;
        private ComboBox cboCatergories;
    }
}