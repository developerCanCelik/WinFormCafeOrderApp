namespace WinFormCafeOrderApp
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_mocha = new System.Windows.Forms.Label();
            this.lbl_espresso = new System.Windows.Forms.Label();
            this.lbl_latte = new System.Windows.Forms.Label();
            this.order_ok = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.mocha_delete = new System.Windows.Forms.Button();
            this.mocha_add = new System.Windows.Forms.Button();
            this.espresso_delete = new System.Windows.Forms.Button();
            this.espresso_add = new System.Windows.Forms.Button();
            this.latte_delete = new System.Windows.Forms.Button();
            this.latte_add = new System.Windows.Forms.Button();
            this.lbl_americano = new System.Windows.Forms.Label();
            this.americano_delete = new System.Windows.Forms.Button();
            this.americano_add = new System.Windows.Forms.Button();
            this.lbl_espresso_tutar = new System.Windows.Forms.Label();
            this.lbl_latte_tutar = new System.Windows.Forms.Label();
            this.lbl_mocha_tutar = new System.Windows.Forms.Label();
            this.lbl_americano_tutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_mocha);
            this.groupBox1.Controls.Add(this.lbl_espresso);
            this.groupBox1.Controls.Add(this.lbl_latte);
            this.groupBox1.Controls.Add(this.order_ok);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.mocha_delete);
            this.groupBox1.Controls.Add(this.mocha_add);
            this.groupBox1.Controls.Add(this.espresso_delete);
            this.groupBox1.Controls.Add(this.espresso_add);
            this.groupBox1.Controls.Add(this.latte_delete);
            this.groupBox1.Controls.Add(this.latte_add);
            this.groupBox1.Controls.Add(this.lbl_americano);
            this.groupBox1.Controls.Add(this.americano_delete);
            this.groupBox1.Controls.Add(this.americano_add);
            this.groupBox1.Controls.Add(this.lbl_espresso_tutar);
            this.groupBox1.Controls.Add(this.lbl_latte_tutar);
            this.groupBox1.Controls.Add(this.lbl_mocha_tutar);
            this.groupBox1.Controls.Add(this.lbl_americano_tutar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GrupBox";
            // 
            // lbl_mocha
            // 
            this.lbl_mocha.AutoSize = true;
            this.lbl_mocha.Location = new System.Drawing.Point(379, 220);
            this.lbl_mocha.Name = "lbl_mocha";
            this.lbl_mocha.Size = new System.Drawing.Size(17, 20);
            this.lbl_mocha.TabIndex = 22;
            this.lbl_mocha.Text = "0";
            // 
            // lbl_espresso
            // 
            this.lbl_espresso.AutoSize = true;
            this.lbl_espresso.Location = new System.Drawing.Point(379, 169);
            this.lbl_espresso.Name = "lbl_espresso";
            this.lbl_espresso.Size = new System.Drawing.Size(17, 20);
            this.lbl_espresso.TabIndex = 21;
            this.lbl_espresso.Text = "0";
            // 
            // lbl_latte
            // 
            this.lbl_latte.AutoSize = true;
            this.lbl_latte.Location = new System.Drawing.Point(379, 113);
            this.lbl_latte.Name = "lbl_latte";
            this.lbl_latte.Size = new System.Drawing.Size(17, 20);
            this.lbl_latte.TabIndex = 20;
            this.lbl_latte.Text = "0";
            // 
            // order_ok
            // 
            this.order_ok.Location = new System.Drawing.Point(170, 263);
            this.order_ok.Name = "order_ok";
            this.order_ok.Size = new System.Drawing.Size(226, 29);
            this.order_ok.TabIndex = 19;
            this.order_ok.Text = "SİPARİŞ TAMAMLA";
            this.order_ok.UseVisualStyleBackColor = true;
            this.order_ok.Click += new System.EventHandler(this.order_ok_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(43, 263);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(94, 29);
            this.reset.TabIndex = 18;
            this.reset.Text = "SIFIRLA";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(420, 263);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 29);
            this.exit.TabIndex = 17;
            this.exit.Text = "ÇIKIŞ";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mocha_delete
            // 
            this.mocha_delete.Location = new System.Drawing.Point(420, 216);
            this.mocha_delete.Name = "mocha_delete";
            this.mocha_delete.Size = new System.Drawing.Size(94, 29);
            this.mocha_delete.TabIndex = 16;
            this.mocha_delete.Text = "ÇIKAR";
            this.mocha_delete.UseVisualStyleBackColor = true;
            this.mocha_delete.Click += new System.EventHandler(this.mocha_delete_Click);
            // 
            // mocha_add
            // 
            this.mocha_add.Location = new System.Drawing.Point(261, 216);
            this.mocha_add.Name = "mocha_add";
            this.mocha_add.Size = new System.Drawing.Size(94, 29);
            this.mocha_add.TabIndex = 15;
            this.mocha_add.Text = "EKLE";
            this.mocha_add.UseVisualStyleBackColor = true;
            this.mocha_add.Click += new System.EventHandler(this.mocha_add_Click);
            // 
            // espresso_delete
            // 
            this.espresso_delete.Location = new System.Drawing.Point(420, 165);
            this.espresso_delete.Name = "espresso_delete";
            this.espresso_delete.Size = new System.Drawing.Size(94, 29);
            this.espresso_delete.TabIndex = 14;
            this.espresso_delete.Text = "ÇIKAR";
            this.espresso_delete.UseVisualStyleBackColor = true;
            this.espresso_delete.Click += new System.EventHandler(this.espresso_delete_Click);
            // 
            // espresso_add
            // 
            this.espresso_add.Location = new System.Drawing.Point(261, 165);
            this.espresso_add.Name = "espresso_add";
            this.espresso_add.Size = new System.Drawing.Size(94, 29);
            this.espresso_add.TabIndex = 13;
            this.espresso_add.Text = "EKLE";
            this.espresso_add.UseVisualStyleBackColor = true;
            this.espresso_add.Click += new System.EventHandler(this.espresso_add_Click);
            // 
            // latte_delete
            // 
            this.latte_delete.Location = new System.Drawing.Point(420, 109);
            this.latte_delete.Name = "latte_delete";
            this.latte_delete.Size = new System.Drawing.Size(94, 29);
            this.latte_delete.TabIndex = 12;
            this.latte_delete.Text = "ÇIKAR";
            this.latte_delete.UseVisualStyleBackColor = true;
            this.latte_delete.Click += new System.EventHandler(this.latte_delete_Click);
            // 
            // latte_add
            // 
            this.latte_add.Location = new System.Drawing.Point(261, 109);
            this.latte_add.Name = "latte_add";
            this.latte_add.Size = new System.Drawing.Size(94, 29);
            this.latte_add.TabIndex = 11;
            this.latte_add.Text = "EKLE";
            this.latte_add.UseVisualStyleBackColor = true;
            this.latte_add.Click += new System.EventHandler(this.latte_add_Click);
            // 
            // lbl_americano
            // 
            this.lbl_americano.AutoSize = true;
            this.lbl_americano.Location = new System.Drawing.Point(379, 54);
            this.lbl_americano.Name = "lbl_americano";
            this.lbl_americano.Size = new System.Drawing.Size(17, 20);
            this.lbl_americano.TabIndex = 10;
            this.lbl_americano.Text = "0";
            // 
            // americano_delete
            // 
            this.americano_delete.Location = new System.Drawing.Point(420, 50);
            this.americano_delete.Name = "americano_delete";
            this.americano_delete.Size = new System.Drawing.Size(94, 29);
            this.americano_delete.TabIndex = 9;
            this.americano_delete.Text = "ÇIKAR";
            this.americano_delete.UseVisualStyleBackColor = true;
            this.americano_delete.Click += new System.EventHandler(this.americano_delete_Click);
            // 
            // americano_add
            // 
            this.americano_add.Location = new System.Drawing.Point(261, 50);
            this.americano_add.Name = "americano_add";
            this.americano_add.Size = new System.Drawing.Size(94, 29);
            this.americano_add.TabIndex = 8;
            this.americano_add.Text = "EKLE";
            this.americano_add.UseVisualStyleBackColor = true;
            this.americano_add.Click += new System.EventHandler(this.americano_add_Click);
            // 
            // lbl_espresso_tutar
            // 
            this.lbl_espresso_tutar.AutoSize = true;
            this.lbl_espresso_tutar.Location = new System.Drawing.Point(192, 169);
            this.lbl_espresso_tutar.Name = "lbl_espresso_tutar";
            this.lbl_espresso_tutar.Size = new System.Drawing.Size(33, 20);
            this.lbl_espresso_tutar.TabIndex = 7;
            this.lbl_espresso_tutar.Text = "20₺";
            // 
            // lbl_latte_tutar
            // 
            this.lbl_latte_tutar.AutoSize = true;
            this.lbl_latte_tutar.Location = new System.Drawing.Point(192, 113);
            this.lbl_latte_tutar.Name = "lbl_latte_tutar";
            this.lbl_latte_tutar.Size = new System.Drawing.Size(33, 20);
            this.lbl_latte_tutar.TabIndex = 6;
            this.lbl_latte_tutar.Text = "24₺";
            // 
            // lbl_mocha_tutar
            // 
            this.lbl_mocha_tutar.AutoSize = true;
            this.lbl_mocha_tutar.Location = new System.Drawing.Point(192, 220);
            this.lbl_mocha_tutar.Name = "lbl_mocha_tutar";
            this.lbl_mocha_tutar.Size = new System.Drawing.Size(33, 20);
            this.lbl_mocha_tutar.TabIndex = 5;
            this.lbl_mocha_tutar.Text = "26₺";
            // 
            // lbl_americano_tutar
            // 
            this.lbl_americano_tutar.AutoSize = true;
            this.lbl_americano_tutar.Location = new System.Drawing.Point(192, 54);
            this.lbl_americano_tutar.Name = "lbl_americano_tutar";
            this.lbl_americano_tutar.Size = new System.Drawing.Size(33, 20);
            this.lbl_americano_tutar.TabIndex = 4;
            this.lbl_americano_tutar.Text = "28₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "MOCHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ESPRESSO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LATTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AMERICANO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 343);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

   

        private GroupBox groupBox1;
        private Label lbl_espresso_tutar;
        private Label lbl_latte_tutar;
        private Label lbl_mocha_tutar;
        private Label lbl_americano_tutar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button mocha_delete;
        private Button mocha_add;
        private Button espresso_delete;
        private Button espresso_add;
        private Button latte_delete;
        private Button latte_add;
        private Label lbl_americano;
        private Button americano_delete;
        private Button americano_add;
        private Label lbl_mocha;
        private Label lbl_espresso;
        private Label lbl_latte;
        private Button order_ok;
        private Button reset;
        private Button exit;
    }
}