namespace WindowsFormsApplication1
{
    partial class Media
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media));
            this.txt_BoxNota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BoxNota2 = new System.Windows.Forms.TextBox();
            this.txt_BoxNota3 = new System.Windows.Forms.TextBox();
            this.btn_CalcMedia = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_BoxNota1
            // 
            this.txt_BoxNota1.Location = new System.Drawing.Point(38, 110);
            this.txt_BoxNota1.Name = "txt_BoxNota1";
            this.txt_BoxNota1.Size = new System.Drawing.Size(143, 20);
            this.txt_BoxNota1.TabIndex = 0;
            this.txt_BoxNota1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BoxNota1_KeyDown);
            this.txt_BoxNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BoxNota1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite sua 1ª nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cálculo da média";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite sua 2ª nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Digite sua 3ª nota";
            // 
            // txt_BoxNota2
            // 
            this.txt_BoxNota2.Location = new System.Drawing.Point(37, 178);
            this.txt_BoxNota2.Name = "txt_BoxNota2";
            this.txt_BoxNota2.Size = new System.Drawing.Size(143, 20);
            this.txt_BoxNota2.TabIndex = 11;
            this.txt_BoxNota2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BoxNota2_KeyDown_1);
            // 
            // txt_BoxNota3
            // 
            this.txt_BoxNota3.Location = new System.Drawing.Point(37, 240);
            this.txt_BoxNota3.Name = "txt_BoxNota3";
            this.txt_BoxNota3.Size = new System.Drawing.Size(143, 20);
            this.txt_BoxNota3.TabIndex = 12;
            // 
            // btn_CalcMedia
            // 
            this.btn_CalcMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcMedia.Image = ((System.Drawing.Image)(resources.GetObject("btn_CalcMedia.Image")));
            this.btn_CalcMedia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CalcMedia.Location = new System.Drawing.Point(279, 108);
            this.btn_CalcMedia.Name = "btn_CalcMedia";
            this.btn_CalcMedia.Size = new System.Drawing.Size(141, 64);
            this.btn_CalcMedia.TabIndex = 13;
            this.btn_CalcMedia.Text = "Calcular média";
            this.btn_CalcMedia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CalcMedia.UseVisualStyleBackColor = true;
            this.btn_CalcMedia.Click += new System.EventHandler(this.btn_CalcMedia_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpar.Image")));
            this.btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Limpar.Location = new System.Drawing.Point(279, 187);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(141, 64);
            this.btn_Limpar.TabIndex = 14;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click_1);
            // 
            // Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 302);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_CalcMedia);
            this.Controls.Add(this.txt_BoxNota3);
            this.Controls.Add(this.txt_BoxNota2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BoxNota1);
            this.Name = "Media";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BoxNota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BoxNota2;
        private System.Windows.Forms.TextBox txt_BoxNota3;
        private System.Windows.Forms.Button btn_CalcMedia;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

