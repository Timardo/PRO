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
            this.Output = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.ShowOutput = new System.Windows.Forms.Button();
            this.Nahrad = new System.Windows.Forms.Button();
            this.NahradPosledny = new System.Windows.Forms.Button();
            this.AkoVeta = new System.Windows.Forms.Button();
            this.ObratVetu = new System.Windows.Forms.Button();
            this.Samohlasky = new System.Windows.Forms.Button();
            this.SamostatneZnaky = new System.Windows.Forms.Button();
            this.ZenitOne = new System.Windows.Forms.Button();
            this.Soupa = new System.Windows.Forms.Button();
            this.Zdvoj = new System.Windows.Forms.Button();
            this.PrvePismena = new System.Windows.Forms.Button();
            this.Menic = new System.Windows.Forms.Button();
            this.Zhoda = new System.Windows.Forms.Button();
            this.Otacac = new System.Windows.Forms.Button();
            this.Inicialy = new System.Windows.Forms.Button();
            this.Anagramy = new System.Windows.Forms.Button();
            this.yToZToY = new System.Windows.Forms.Button();
            this.slovakize = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(10, 94);
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
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(13, 110);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(758, 438);
            this.Output.TabIndex = 5;
            this.Output.WordWrap = false;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(224, 11);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(271, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
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
            // Nahrad
            // 
            this.Nahrad.Location = new System.Drawing.Point(64, 39);
            this.Nahrad.Name = "Nahrad";
            this.Nahrad.Size = new System.Drawing.Size(88, 23);
            this.Nahrad.TabIndex = 13;
            this.Nahrad.Text = "1. Nahraď prvý";
            this.Nahrad.UseVisualStyleBackColor = true;
            this.Nahrad.Click += new System.EventHandler(this.Nahrad_Click);
            // 
            // NahradPosledny
            // 
            this.NahradPosledny.Location = new System.Drawing.Point(158, 39);
            this.NahradPosledny.Name = "NahradPosledny";
            this.NahradPosledny.Size = new System.Drawing.Size(110, 23);
            this.NahradPosledny.TabIndex = 14;
            this.NahradPosledny.Text = "2. Nahraď posledný";
            this.NahradPosledny.UseVisualStyleBackColor = true;
            this.NahradPosledny.Click += new System.EventHandler(this.NahradPosledny_Click);
            // 
            // AkoVeta
            // 
            this.AkoVeta.Location = new System.Drawing.Point(274, 39);
            this.AkoVeta.Name = "AkoVeta";
            this.AkoVeta.Size = new System.Drawing.Size(73, 23);
            this.AkoVeta.TabIndex = 15;
            this.AkoVeta.Text = "3. Ako veta";
            this.AkoVeta.UseVisualStyleBackColor = true;
            this.AkoVeta.Click += new System.EventHandler(this.AkoVeta_Click);
            // 
            // ObratVetu
            // 
            this.ObratVetu.Location = new System.Drawing.Point(353, 39);
            this.ObratVetu.Name = "ObratVetu";
            this.ObratVetu.Size = new System.Drawing.Size(79, 23);
            this.ObratVetu.TabIndex = 16;
            this.ObratVetu.Text = "4. Obráť Vetu";
            this.ObratVetu.UseVisualStyleBackColor = true;
            this.ObratVetu.Click += new System.EventHandler(this.ObratVetu_Click);
            // 
            // Samohlasky
            // 
            this.Samohlasky.Location = new System.Drawing.Point(438, 39);
            this.Samohlasky.Name = "Samohlasky";
            this.Samohlasky.Size = new System.Drawing.Size(116, 23);
            this.Samohlasky.TabIndex = 17;
            this.Samohlasky.Text = "6. Počet Samohlások";
            this.Samohlasky.UseVisualStyleBackColor = true;
            this.Samohlasky.Click += new System.EventHandler(this.Samohlasky_Click);
            // 
            // SamostatneZnaky
            // 
            this.SamostatneZnaky.Location = new System.Drawing.Point(560, 39);
            this.SamostatneZnaky.Name = "SamostatneZnaky";
            this.SamostatneZnaky.Size = new System.Drawing.Size(116, 23);
            this.SamostatneZnaky.TabIndex = 18;
            this.SamostatneZnaky.Text = "7. Samostatné znaky";
            this.SamostatneZnaky.UseVisualStyleBackColor = true;
            this.SamostatneZnaky.Click += new System.EventHandler(this.SamostatneZnaky_Click);
            // 
            // ZenitOne
            // 
            this.ZenitOne.Location = new System.Drawing.Point(682, 39);
            this.ZenitOne.Name = "ZenitOne";
            this.ZenitOne.Size = new System.Drawing.Size(89, 23);
            this.ZenitOne.TabIndex = 19;
            this.ZenitOne.Text = "8. Zenit 18";
            this.ZenitOne.UseVisualStyleBackColor = true;
            this.ZenitOne.Click += new System.EventHandler(this.ZenitOne_Click);
            // 
            // Soupa
            // 
            this.Soupa.Location = new System.Drawing.Point(64, 68);
            this.Soupa.Name = "Soupa";
            this.Soupa.Size = new System.Drawing.Size(114, 23);
            this.Soupa.TabIndex = 20;
            this.Soupa.Text = "9. Gaučová Funkcia";
            this.Soupa.UseVisualStyleBackColor = true;
            this.Soupa.Click += new System.EventHandler(this.Soupa_Click);
            // 
            // Zdvoj
            // 
            this.Zdvoj.Location = new System.Drawing.Point(184, 68);
            this.Zdvoj.Name = "Zdvoj";
            this.Zdvoj.Size = new System.Drawing.Size(91, 23);
            this.Zdvoj.TabIndex = 21;
            this.Zdvoj.Text = "Zdvoj písmená";
            this.Zdvoj.UseVisualStyleBackColor = true;
            this.Zdvoj.Click += new System.EventHandler(this.Zdvoj_Click);
            // 
            // PrvePismena
            // 
            this.PrvePismena.Location = new System.Drawing.Point(281, 68);
            this.PrvePismena.Name = "PrvePismena";
            this.PrvePismena.Size = new System.Drawing.Size(82, 23);
            this.PrvePismena.TabIndex = 22;
            this.PrvePismena.Text = "Prvé Písmená";
            this.PrvePismena.UseVisualStyleBackColor = true;
            this.PrvePismena.Click += new System.EventHandler(this.PrvePismena_Click);
            // 
            // Menic
            // 
            this.Menic.Location = new System.Drawing.Point(369, 68);
            this.Menic.Name = "Menic";
            this.Menic.Size = new System.Drawing.Size(45, 23);
            this.Menic.TabIndex = 23;
            this.Menic.Text = "Menič";
            this.Menic.UseVisualStyleBackColor = true;
            this.Menic.Click += new System.EventHandler(this.Menic_Click);
            // 
            // Zhoda
            // 
            this.Zhoda.Location = new System.Drawing.Point(420, 68);
            this.Zhoda.Name = "Zhoda";
            this.Zhoda.Size = new System.Drawing.Size(46, 23);
            this.Zhoda.TabIndex = 24;
            this.Zhoda.Text = "Zhoda";
            this.Zhoda.UseVisualStyleBackColor = true;
            this.Zhoda.Click += new System.EventHandler(this.Zhoda_Click);
            // 
            // Otacac
            // 
            this.Otacac.Location = new System.Drawing.Point(472, 68);
            this.Otacac.Name = "Otacac";
            this.Otacac.Size = new System.Drawing.Size(50, 23);
            this.Otacac.TabIndex = 25;
            this.Otacac.Text = "Otáčač";
            this.Otacac.UseVisualStyleBackColor = true;
            this.Otacac.Click += new System.EventHandler(this.Otacac_Click);
            // 
            // Inicialy
            // 
            this.Inicialy.Location = new System.Drawing.Point(528, 68);
            this.Inicialy.Name = "Inicialy";
            this.Inicialy.Size = new System.Drawing.Size(50, 23);
            this.Inicialy.TabIndex = 26;
            this.Inicialy.Text = "Iniciály";
            this.Inicialy.UseVisualStyleBackColor = true;
            this.Inicialy.Click += new System.EventHandler(this.Inicialy_Click);
            // 
            // Anagramy
            // 
            this.Anagramy.Location = new System.Drawing.Point(584, 68);
            this.Anagramy.Name = "Anagramy";
            this.Anagramy.Size = new System.Drawing.Size(64, 23);
            this.Anagramy.TabIndex = 27;
            this.Anagramy.Text = "Anagramy";
            this.Anagramy.UseVisualStyleBackColor = true;
            this.Anagramy.Click += new System.EventHandler(this.Anagramy_Click);
            // 
            // yToZToY
            // 
            this.yToZToY.Location = new System.Drawing.Point(654, 68);
            this.yToZToY.Name = "yToZToY";
            this.yToZToY.Size = new System.Drawing.Size(50, 23);
            this.yToZToY.TabIndex = 28;
            this.yToZToY.Text = "Y <-> Z";
            this.yToZToY.UseVisualStyleBackColor = true;
            this.yToZToY.Click += new System.EventHandler(this.yToZToY_Click);
            // 
            // slovakize
            // 
            this.slovakize.Location = new System.Drawing.Point(710, 68);
            this.slovakize.Name = "slovakize";
            this.slovakize.Size = new System.Drawing.Size(61, 23);
            this.slovakize.TabIndex = 29;
            this.slovakize.Text = "9 -> í..";
            this.slovakize.UseVisualStyleBackColor = true;
            this.slovakize.Click += new System.EventHandler(this.slovakize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.slovakize);
            this.Controls.Add(this.yToZToY);
            this.Controls.Add(this.Anagramy);
            this.Controls.Add(this.Inicialy);
            this.Controls.Add(this.Otacac);
            this.Controls.Add(this.Zhoda);
            this.Controls.Add(this.Menic);
            this.Controls.Add(this.PrvePismena);
            this.Controls.Add(this.Zdvoj);
            this.Controls.Add(this.Soupa);
            this.Controls.Add(this.ZenitOne);
            this.Controls.Add(this.SamostatneZnaky);
            this.Controls.Add(this.Samohlasky);
            this.Controls.Add(this.ObratVetu);
            this.Controls.Add(this.AkoVeta);
            this.Controls.Add(this.NahradPosledny);
            this.Controls.Add(this.Nahrad);
            this.Controls.Add(this.ShowOutput);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Output);
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
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ShowOutput;
        private System.Windows.Forms.Button Nahrad;
        private System.Windows.Forms.Button NahradPosledny;
        private System.Windows.Forms.Button AkoVeta;
        private System.Windows.Forms.Button ObratVetu;
        private System.Windows.Forms.Button Samohlasky;
        private System.Windows.Forms.Button SamostatneZnaky;
        private System.Windows.Forms.Button ZenitOne;
        private System.Windows.Forms.Button Soupa;
        private System.Windows.Forms.Button Zdvoj;
        private System.Windows.Forms.Button PrvePismena;
        private System.Windows.Forms.Button Menic;
        private System.Windows.Forms.Button Zhoda;
        private System.Windows.Forms.Button Otacac;
        private System.Windows.Forms.Button Inicialy;
        private System.Windows.Forms.Button Anagramy;
        private System.Windows.Forms.Button yToZToY;
        private System.Windows.Forms.Button slovakize;
    }
}

