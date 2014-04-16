namespace PI
{
    partial class izbornik
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
            this.ulaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ulaz
            // 
            this.ulaz.BackColor = System.Drawing.Color.LimeGreen;
            this.ulaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ulaz.Location = new System.Drawing.Point(66, 323);
            this.ulaz.Name = "ulaz";
            this.ulaz.Size = new System.Drawing.Size(214, 56);
            this.ulaz.TabIndex = 0;
            this.ulaz.Text = "ULAZ";
            this.ulaz.UseVisualStyleBackColor = false;
            this.ulaz.Click += new System.EventHandler(this.ulaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label1.MaximumSize = new System.Drawing.Size(560, 500);
            this.label1.MinimumSize = new System.Drawing.Size(600, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMPROM PLUS d.o.o.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(352, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "IZLAZ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI.Properties.Resources.calzedonia__318_;
            this.ClientSize = new System.Drawing.Size(617, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ulaz);
            this.Controls.Add(this.label1);
            this.Name = "izbornik";
            this.Text = "izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ulaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}