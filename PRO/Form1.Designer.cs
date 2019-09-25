namespace PRO
{
    partial class Form1
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
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MocninyXOd0Po10 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Mocniny2PoX = new System.Windows.Forms.Button();
            this.Stvorec = new System.Windows.Forms.Button();
            this.Obdlznik = new System.Windows.Forms.Button();
            this.Trojuholnik = new System.Windows.Forms.Button();
            this.Kosostvorec = new System.Windows.Forms.Button();
            this.ShowOutput = new System.Windows.Forms.Button();
            this.Kruh = new System.Windows.Forms.Button();
            this.PresypacieHodiny = new System.Windows.Forms.Button();
            this.Turtle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(53, 13);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(164, 20);
            this.Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Actions:";
            // 
            // MocninyXOd0Po10
            // 
            this.MocninyXOd0Po10.Location = new System.Drawing.Point(64, 39);
            this.MocninyXOd0Po10.Name = "MocninyXOd0Po10";
            this.MocninyXOd0Po10.Size = new System.Drawing.Size(120, 23);
            this.MocninyXOd0Po10.TabIndex = 4;
            this.MocninyXOd0Po10.Text = "Mocniny X od 0 po 10";
            this.MocninyXOd0Po10.UseVisualStyleBackColor = true;
            this.MocninyXOd0Po10.Click += new System.EventHandler(this.MocninyXOd0Po10_Click);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(13, 86);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(758, 462);
            this.Output.TabIndex = 5;
            this.Output.WordWrap = false;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(223, 11);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(271, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Mocniny2PoX
            // 
            this.Mocniny2PoX.AccessibleDescription = "ň";
            this.Mocniny2PoX.Location = new System.Drawing.Point(190, 39);
            this.Mocniny2PoX.Name = "Mocniny2PoX";
            this.Mocniny2PoX.Size = new System.Drawing.Size(89, 23);
            this.Mocniny2PoX.TabIndex = 7;
            this.Mocniny2PoX.Text = "Mocniny 2 po X";
            this.Mocniny2PoX.UseVisualStyleBackColor = true;
            this.Mocniny2PoX.Click += new System.EventHandler(this.Mocniny2PoX_Click);
            // 
            // Stvorec
            // 
            this.Stvorec.Location = new System.Drawing.Point(285, 39);
            this.Stvorec.Name = "Stvorec";
            this.Stvorec.Size = new System.Drawing.Size(53, 23);
            this.Stvorec.TabIndex = 8;
            this.Stvorec.Text = "Štvorec";
            this.Stvorec.UseVisualStyleBackColor = true;
            this.Stvorec.Click += new System.EventHandler(this.Stvorec_Click);
            // 
            // Obdlznik
            // 
            this.Obdlznik.Location = new System.Drawing.Point(344, 39);
            this.Obdlznik.Name = "Obdlznik";
            this.Obdlznik.Size = new System.Drawing.Size(57, 23);
            this.Obdlznik.TabIndex = 9;
            this.Obdlznik.Text = "Obdĺžnik";
            this.Obdlznik.UseVisualStyleBackColor = true;
            this.Obdlznik.Click += new System.EventHandler(this.Obdlznik_Click);
            // 
            // Trojuholnik
            // 
            this.Trojuholnik.Location = new System.Drawing.Point(407, 39);
            this.Trojuholnik.Name = "Trojuholnik";
            this.Trojuholnik.Size = new System.Drawing.Size(70, 23);
            this.Trojuholnik.TabIndex = 10;
            this.Trojuholnik.Text = "Trojuholník";
            this.Trojuholnik.UseVisualStyleBackColor = true;
            this.Trojuholnik.Click += new System.EventHandler(this.Trojuholnik_Click);
            // 
            // Kosostvorec
            // 
            this.Kosostvorec.Location = new System.Drawing.Point(483, 39);
            this.Kosostvorec.Name = "Kosostvorec";
            this.Kosostvorec.Size = new System.Drawing.Size(74, 23);
            this.Kosostvorec.TabIndex = 11;
            this.Kosostvorec.Text = "Kosoštvorec";
            this.Kosostvorec.UseVisualStyleBackColor = true;
            this.Kosostvorec.Click += new System.EventHandler(this.Kosostvorec_Click);
            // 
            // ShowOutput
            // 
            this.ShowOutput.Location = new System.Drawing.Point(500, 10);
            this.ShowOutput.Name = "ShowOutput";
            this.ShowOutput.Size = new System.Drawing.Size(271, 23);
            this.ShowOutput.TabIndex = 12;
            this.ShowOutput.Text = "Show Output";
            this.ShowOutput.UseVisualStyleBackColor = true;
            this.ShowOutput.Click += new System.EventHandler(this.ShowOutput_Click);
            // 
            // Kruh
            // 
            this.Kruh.Location = new System.Drawing.Point(673, 39);
            this.Kruh.Name = "Kruh";
            this.Kruh.Size = new System.Drawing.Size(39, 23);
            this.Kruh.TabIndex = 13;
            this.Kruh.Text = "Kruh";
            this.Kruh.UseVisualStyleBackColor = true;
            this.Kruh.Click += new System.EventHandler(this.Kruh_Click);
            // 
            // PresypacieHodiny
            // 
            this.PresypacieHodiny.Location = new System.Drawing.Point(563, 39);
            this.PresypacieHodiny.Name = "PresypacieHodiny";
            this.PresypacieHodiny.Size = new System.Drawing.Size(104, 23);
            this.PresypacieHodiny.TabIndex = 14;
            this.PresypacieHodiny.Text = "Presýpacie Hodiny";
            this.PresypacieHodiny.UseVisualStyleBackColor = true;
            this.PresypacieHodiny.Click += new System.EventHandler(this.PresypacieHodiny_Click);
            // 
            // Turtle
            // 
            this.Turtle.Location = new System.Drawing.Point(718, 39);
            this.Turtle.Name = "Turtle";
            this.Turtle.Size = new System.Drawing.Size(53, 23);
            this.Turtle.TabIndex = 15;
            this.Turtle.Text = "Turtle";
            this.Turtle.UseVisualStyleBackColor = true;
            this.Turtle.Click += new System.EventHandler(this.Turtle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Turtle);
            this.Controls.Add(this.PresypacieHodiny);
            this.Controls.Add(this.Kruh);
            this.Controls.Add(this.ShowOutput);
            this.Controls.Add(this.Kosostvorec);
            this.Controls.Add(this.Trojuholnik);
            this.Controls.Add(this.Obdlznik);
            this.Controls.Add(this.Stvorec);
            this.Controls.Add(this.Mocniny2PoX);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.MocninyXOd0Po10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MocninyXOd0Po10;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Mocniny2PoX;
        private System.Windows.Forms.Button Stvorec;
        private System.Windows.Forms.Button Obdlznik;
        private System.Windows.Forms.Button Trojuholnik;
        private System.Windows.Forms.Button Kosostvorec;
        private System.Windows.Forms.Button ShowOutput;
        private System.Windows.Forms.Button Kruh;
        private System.Windows.Forms.Button PresypacieHodiny;
        private System.Windows.Forms.Button Turtle;
    }
}

