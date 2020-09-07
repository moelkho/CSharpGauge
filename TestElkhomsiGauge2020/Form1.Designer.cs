namespace TestElkhomsiGauge2020
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.userControl11 = new ElkhomsiGauge2020.UserControl1();
            this.SuspendLayout();
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(11, 25);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(108, 23);
            this.btnCalculer.TabIndex = 1;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(47, 66);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(149, 23);
            this.btnEffacer.TabIndex = 3;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 160);
            this.listBox1.TabIndex = 4;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(151, 12);
            this.userControl11.Max = 100F;
            this.userControl11.Min = 0F;
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(230, 360);
            this.userControl11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 382);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElkhomsiGauge2020.UserControl1 userControl11;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.ListBox listBox1;
    }
}

