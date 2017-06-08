namespace PoderDoHabito
{
    partial class Incetivo
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(33, 244);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(461, 40);
            label1.TabIndex = 0;
            label1.Text = "º Voce sabia que subir tres lances de escada equivale a \r\numa caminhada moderada " +
    "de 10 Minutos.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(33, 302);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(455, 40);
            label2.TabIndex = 1;
            label2.Text = "º Voce sabia que subir entre 10 e 20 degraus ja resulta \r\nem beneficios para todo" +
    " sistema cardiovascular.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(60, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(391, 42);
            label3.TabIndex = 2;
            label3.Text = "Sinto muito, mais seu IMC e de kg/m2,\r\npor isso voce esta acima do peso!\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(33, 373);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(516, 40);
            label4.TabIndex = 4;
            label4.Text = "º Sempre lembrado que qualque atividade fisica  ou retrição da \r\nalimentação,tem " +
    "que ser acompanhado por um profissional.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PoderDoHabito.Properties.Resources.correndo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(169, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 145);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Red;
            this.btnVoltar.Location = new System.Drawing.Point(356, 127);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 32);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Incetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 502);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "Incetivo";
            this.Text = "Icentivo";
            this.Load += new System.EventHandler(this.Incetivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
    }
}