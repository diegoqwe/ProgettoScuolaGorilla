namespace ModuloForm
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
            btnPostStudente = new Button();
            SuspendLayout();
            // 
            // btnPostStudente
            // 
            btnPostStudente.Location = new Point(513, 317);
            btnPostStudente.Name = "btnPostStudente";
            btnPostStudente.Size = new Size(129, 23);
            btnPostStudente.TabIndex = 0;
            btnPostStudente.Text = "Nuovo Studente";
            btnPostStudente.UseVisualStyleBackColor = true;
            btnPostStudente.Click += btnPostStudente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPostStudente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPostStudente;
    }
}