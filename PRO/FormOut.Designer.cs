namespace PRO
{
    partial class FormOut
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
            this.Out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Out
            // 
            this.Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Out.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out.Location = new System.Drawing.Point(0, 0);
            this.Out.Multiline = true;
            this.Out.Name = "Out";
            this.Out.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Out.Size = new System.Drawing.Size(800, 450);
            this.Out.TabIndex = 0;
            this.Out.WordWrap = false;
            // 
            // FormOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Out);
            this.Name = "FormOut";
            this.Text = "FormOut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Out;
    }
}