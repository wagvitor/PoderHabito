namespace PoderDoHabito
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(43, 258);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 40);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(39, 84);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(140, 20);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Digite seu Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(43, 107);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(127, 31);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(43, 200);
            this.txtAltura.Multiline = true;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(127, 31);
            this.txtAltura.TabIndex = 5;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(39, 177);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(148, 20);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Digite sua Altura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seu IMC:";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImc.Location = new System.Drawing.Point(350, 251);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(46, 31);
            this.lblImc.TabIndex = 7;
            this.lblImc.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Criando Hábito - Para melhorar IMC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular sua Reconpesa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PoderDoHabito.Properties.Resources.balança_e1386946728643;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(253, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

