namespace CorreiosUI
{
    partial class Main
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
            this.TxtTrechos = new System.Windows.Forms.TextBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEncomendas = new System.Windows.Forms.TextBox();
            this.BtnEncomendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTrechos
            // 
            this.TxtTrechos.Location = new System.Drawing.Point(99, 21);
            this.TxtTrechos.Name = "TxtTrechos";
            this.TxtTrechos.Size = new System.Drawing.Size(265, 23);
            this.TxtTrechos.TabIndex = 0;
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(370, 21);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(29, 23);
            this.BtnFind.TabIndex = 1;
            this.BtnFind.Text = "...";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(169, 79);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trechos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encomendas:";
            // 
            // TxtEncomendas
            // 
            this.TxtEncomendas.Location = new System.Drawing.Point(99, 50);
            this.TxtEncomendas.Name = "TxtEncomendas";
            this.TxtEncomendas.Size = new System.Drawing.Size(265, 23);
            this.TxtEncomendas.TabIndex = 5;
            // 
            // BtnEncomendas
            // 
            this.BtnEncomendas.Location = new System.Drawing.Point(370, 49);
            this.BtnEncomendas.Name = "BtnEncomendas";
            this.BtnEncomendas.Size = new System.Drawing.Size(29, 23);
            this.BtnEncomendas.TabIndex = 6;
            this.BtnEncomendas.Text = "...";
            this.BtnEncomendas.UseVisualStyleBackColor = true;
            this.BtnEncomendas.Click += new System.EventHandler(this.BtnEncomendas_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 129);
            this.Controls.Add(this.BtnEncomendas);
            this.Controls.Add(this.TxtEncomendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.TxtTrechos);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTrechos;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEncomendas;
        private System.Windows.Forms.Button BtnEncomendas;
    }
}

