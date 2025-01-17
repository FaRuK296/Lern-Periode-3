namespace WinFormsAppTextAnzeigen
{
    partial class Form1
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
            txtEingabe = new TextBox();
            btnReveal = new Button();
            lblReveal = new Label();
            SuspendLayout();
            // 
            // txtEingabe
            // 
            txtEingabe.Location = new Point(261, 62);
            txtEingabe.Name = "txtEingabe";
            txtEingabe.Size = new Size(257, 31);
            txtEingabe.TabIndex = 0;
            txtEingabe.TextChanged += textBox1_TextChanged;
            // 
            // btnReveal
            // 
            btnReveal.Location = new Point(297, 216);
            btnReveal.Name = "btnReveal";
            btnReveal.Size = new Size(201, 55);
            btnReveal.TabIndex = 1;
            btnReveal.Text = "reveal";
            btnReveal.UseVisualStyleBackColor = true;
            btnReveal.Click += btnReveal_Click;
            // 
            // lblReveal
            // 
            lblReveal.AutoSize = true;
            lblReveal.BackColor = Color.White;
            lblReveal.Location = new Point(288, 357);
            lblReveal.Name = "lblReveal";
            lblReveal.Size = new Size(210, 25);
            lblReveal.TabIndex = 2;
            lblReveal.Text = "Your text shows up here: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblReveal);
            Controls.Add(btnReveal);
            Controls.Add(txtEingabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEingabe;
        private Button btnReveal;
        private Label lblReveal;
    }
}
