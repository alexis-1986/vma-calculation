namespace VmaCalculation
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
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtNbRepetitions = new System.Windows.Forms.TextBox();
            this.txtVma = new System.Windows.Forms.TextBox();
            this.CmdGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(106, 12);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(97, 20);
            this.txtDistance.TabIndex = 0;
            this.txtDistance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDistance_KeyDown);
            this.txtDistance.Validated += new System.EventHandler(this.txtDistance_Validated);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(106, 40);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(39, 20);
            this.txtMin.TabIndex = 1;
            this.txtMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMin_KeyDown);
            this.txtMin.Validated += new System.EventHandler(this.txtMin_Validated);
            // 
            // txtNbRepetitions
            // 
            this.txtNbRepetitions.Location = new System.Drawing.Point(106, 69);
            this.txtNbRepetitions.Name = "txtNbRepetitions";
            this.txtNbRepetitions.Size = new System.Drawing.Size(97, 20);
            this.txtNbRepetitions.TabIndex = 2;
            this.txtNbRepetitions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNbRepetitions_KeyDown);
            this.txtNbRepetitions.Validated += new System.EventHandler(this.txtNbRepetitions_Validated);
            // 
            // txtVma
            // 
            this.txtVma.Location = new System.Drawing.Point(106, 95);
            this.txtVma.Name = "txtVma";
            this.txtVma.Size = new System.Drawing.Size(97, 20);
            this.txtVma.TabIndex = 3;
            // 
            // CmdGo
            // 
            this.CmdGo.Location = new System.Drawing.Point(128, 128);
            this.CmdGo.Name = "CmdGo";
            this.CmdGo.Size = new System.Drawing.Size(75, 23);
            this.CmdGo.TabIndex = 4;
            this.CmdGo.Text = "Go";
            this.CmdGo.UseVisualStyleBackColor = true;
            this.CmdGo.Click += new System.EventHandler(this.CmdGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Distance [ m ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temps [ min:s ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nb répétitions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vma [ km/h ]";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(165, 40);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(38, 20);
            this.txtSec.TabIndex = 9;
            this.txtSec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSec_KeyDown);
            this.txtSec.Validated += new System.EventHandler(this.txtSec_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 163);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdGo);
            this.Controls.Add(this.txtVma);
            this.Controls.Add(this.txtNbRepetitions);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtDistance);
            this.Name = "Form1";
            this.Text = "Calcul VMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtNbRepetitions;
        private System.Windows.Forms.TextBox txtVma;
        private System.Windows.Forms.Button CmdGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label label5;
    }
}

