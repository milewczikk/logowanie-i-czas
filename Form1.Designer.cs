namespace WindowsFormsApplication1
{
    partial class Logow
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
            this.nierobot = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.TextBox();
            this.weryfikuj = new System.Windows.Forms.Button();
            this.robot = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.log1 = new System.Windows.Forms.GroupBox();
            this.log2 = new System.Windows.Forms.GroupBox();
            this.wyslij = new System.Windows.Forms.Button();
            this.log3 = new System.Windows.Forms.GroupBox();
            this.sprawdz = new System.Windows.Forms.Button();
            this.sprawdzenie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rejestracja = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AkcRej = new System.Windows.Forms.Button();
            this.rej5 = new System.Windows.Forms.TextBox();
            this.rej4 = new System.Windows.Forms.TextBox();
            this.rej3 = new System.Windows.Forms.TextBox();
            this.rej2 = new System.Windows.Forms.TextBox();
            this.rej1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.log1.SuspendLayout();
            this.log2.SuspendLayout();
            this.log3.SuspendLayout();
            this.rejestracja.SuspendLayout();
            this.SuspendLayout();
            // 
            // nierobot
            // 
            this.nierobot.AutoSize = true;
            this.nierobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nierobot.Location = new System.Drawing.Point(96, 175);
            this.nierobot.Name = "nierobot";
            this.nierobot.Size = new System.Drawing.Size(55, 24);
            this.nierobot.TabIndex = 0;
            this.nierobot.Text = "NIE";
            this.nierobot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(74, 16);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(106, 20);
            this.login.TabIndex = 3;
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(74, 63);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(106, 20);
            this.haslo.TabIndex = 4;
            this.haslo.UseSystemPasswordChar = true;
            this.haslo.TextChanged += new System.EventHandler(this.text_TextChanged);
            this.haslo.Enter += new System.EventHandler(this.Text_Enter);
            this.haslo.Leave += new System.EventHandler(this.haslo_Leave);
            // 
            // weryfikuj
            // 
            this.weryfikuj.Location = new System.Drawing.Point(251, 38);
            this.weryfikuj.Name = "weryfikuj";
            this.weryfikuj.Size = new System.Drawing.Size(127, 44);
            this.weryfikuj.TabIndex = 5;
            this.weryfikuj.Text = "Weryfikacja";
            this.weryfikuj.UseVisualStyleBackColor = true;
            this.weryfikuj.Click += new System.EventHandler(this.weryfikuj_Click);
            // 
            // robot
            // 
            this.robot.AutoSize = true;
            this.robot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.robot.Location = new System.Drawing.Point(16, 175);
            this.robot.Name = "robot";
            this.robot.Size = new System.Drawing.Size(58, 24);
            this.robot.TabIndex = 6;
            this.robot.Text = "TAK";
            this.robot.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Czy jesteś robotem?";
            // 
            // log1
            // 
            this.log1.Controls.Add(this.label3);
            this.log1.Controls.Add(this.robot);
            this.log1.Controls.Add(this.weryfikuj);
            this.log1.Controls.Add(this.haslo);
            this.log1.Controls.Add(this.login);
            this.log1.Controls.Add(this.label2);
            this.log1.Controls.Add(this.label1);
            this.log1.Controls.Add(this.nierobot);
            this.log1.Location = new System.Drawing.Point(13, 15);
            this.log1.Name = "log1";
            this.log1.Size = new System.Drawing.Size(436, 243);
            this.log1.TabIndex = 8;
            this.log1.TabStop = false;
            // 
            // log2
            // 
            this.log2.Controls.Add(this.wyslij);
            this.log2.Controls.Add(this.log3);
            this.log2.Controls.Add(this.email);
            this.log2.Controls.Add(this.label4);
            this.log2.Location = new System.Drawing.Point(12, 31);
            this.log2.Name = "log2";
            this.log2.Size = new System.Drawing.Size(524, 365);
            this.log2.TabIndex = 9;
            this.log2.TabStop = false;
            // 
            // wyslij
            // 
            this.wyslij.Location = new System.Drawing.Point(356, 65);
            this.wyslij.Name = "wyslij";
            this.wyslij.Size = new System.Drawing.Size(107, 28);
            this.wyslij.TabIndex = 6;
            this.wyslij.Text = "Wyślij";
            this.wyslij.UseVisualStyleBackColor = true;
            this.wyslij.Click += new System.EventHandler(this.wyslij_Click);
            // 
            // log3
            // 
            this.log3.Controls.Add(this.sprawdz);
            this.log3.Controls.Add(this.sprawdzenie);
            this.log3.Controls.Add(this.label5);
            this.log3.Location = new System.Drawing.Point(9, 117);
            this.log3.Name = "log3";
            this.log3.Size = new System.Drawing.Size(438, 128);
            this.log3.TabIndex = 5;
            this.log3.TabStop = false;
            // 
            // sprawdz
            // 
            this.sprawdz.Location = new System.Drawing.Point(243, 63);
            this.sprawdz.Name = "sprawdz";
            this.sprawdz.Size = new System.Drawing.Size(107, 28);
            this.sprawdz.TabIndex = 7;
            this.sprawdz.Text = "Sprawdz";
            this.sprawdz.UseVisualStyleBackColor = true;
            this.sprawdz.Click += new System.EventHandler(this.sprawdz_Click);
            // 
            // sprawdzenie
            // 
            this.sprawdzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sprawdzenie.Location = new System.Drawing.Point(37, 63);
            this.sprawdzenie.Name = "sprawdzenie";
            this.sprawdzenie.Size = new System.Drawing.Size(160, 26);
            this.sprawdzenie.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Wprowadz kod:";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.email.Location = new System.Drawing.Point(46, 68);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(258, 26);
            this.email.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wprowadz e-mail na który zostanie wysłany kod weryfikacyjny:";
            // 
            // rejestracja
            // 
            this.rejestracja.Controls.Add(this.label11);
            this.rejestracja.Controls.Add(this.label10);
            this.rejestracja.Controls.Add(this.label9);
            this.rejestracja.Controls.Add(this.label8);
            this.rejestracja.Controls.Add(this.label7);
            this.rejestracja.Controls.Add(this.AkcRej);
            this.rejestracja.Controls.Add(this.rej5);
            this.rejestracja.Controls.Add(this.rej4);
            this.rejestracja.Controls.Add(this.rej3);
            this.rejestracja.Controls.Add(this.rej2);
            this.rejestracja.Controls.Add(this.rej1);
            this.rejestracja.Controls.Add(this.label6);
            this.rejestracja.Location = new System.Drawing.Point(12, -1);
            this.rejestracja.Name = "rejestracja";
            this.rejestracja.Size = new System.Drawing.Size(524, 294);
            this.rejestracja.TabIndex = 10;
            this.rejestracja.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(15, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "5.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(15, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "4.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(15, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "3.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(15, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "2.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "1.";
            // 
            // AkcRej
            // 
            this.AkcRej.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AkcRej.Location = new System.Drawing.Point(326, 142);
            this.AkcRej.Name = "AkcRej";
            this.AkcRej.Size = new System.Drawing.Size(162, 45);
            this.AkcRej.TabIndex = 9;
            this.AkcRej.Text = "Akceptuj";
            this.AkcRej.UseVisualStyleBackColor = true;
            this.AkcRej.Click += new System.EventHandler(this.AkcRej_Click);
            // 
            // rej5
            // 
            this.rej5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rej5.Location = new System.Drawing.Point(46, 248);
            this.rej5.Name = "rej5";
            this.rej5.Size = new System.Drawing.Size(184, 29);
            this.rej5.TabIndex = 8;
            this.rej5.UseSystemPasswordChar = true;
            this.rej5.TextChanged += new System.EventHandler(this.text_TextChanged);
            this.rej5.Enter += new System.EventHandler(this.Text_Enter);
            this.rej5.Leave += new System.EventHandler(this.rej5_Leave);
            // 
            // rej4
            // 
            this.rej4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rej4.Location = new System.Drawing.Point(46, 204);
            this.rej4.Name = "rej4";
            this.rej4.Size = new System.Drawing.Size(184, 29);
            this.rej4.TabIndex = 7;
            this.rej4.UseSystemPasswordChar = true;
            this.rej4.TextChanged += new System.EventHandler(this.text_TextChanged);
            this.rej4.Enter += new System.EventHandler(this.Text_Enter);
            this.rej4.Leave += new System.EventHandler(this.rej4_Leave);
            // 
            // rej3
            // 
            this.rej3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rej3.Location = new System.Drawing.Point(46, 160);
            this.rej3.Name = "rej3";
            this.rej3.Size = new System.Drawing.Size(184, 29);
            this.rej3.TabIndex = 6;
            this.rej3.UseSystemPasswordChar = true;
            this.rej3.TextChanged += new System.EventHandler(this.text_TextChanged);
            this.rej3.Enter += new System.EventHandler(this.Text_Enter);
            this.rej3.Leave += new System.EventHandler(this.rej3_Leave);
            // 
            // rej2
            // 
            this.rej2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rej2.Location = new System.Drawing.Point(46, 116);
            this.rej2.Name = "rej2";
            this.rej2.Size = new System.Drawing.Size(184, 29);
            this.rej2.TabIndex = 5;
            this.rej2.UseSystemPasswordChar = true;
            this.rej2.TextChanged += new System.EventHandler(this.text_TextChanged);
            this.rej2.Enter += new System.EventHandler(this.Text_Enter);
            this.rej2.Leave += new System.EventHandler(this.rej2_Leave);
            // 
            // rej1
            // 
            this.rej1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rej1.Location = new System.Drawing.Point(46, 69);
            this.rej1.Name = "rej1";
            this.rej1.Size = new System.Drawing.Size(184, 29);
            this.rej1.TabIndex = 4;
            this.rej1.UseSystemPasswordChar = true;
            this.rej1.TextChanged += new System.EventHandler(this.text_TextChanged);
            this.rej1.Enter += new System.EventHandler(this.Text_Enter);
            this.rej1.Leave += new System.EventHandler(this.rej1_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(495, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Proszę wpisać hasło dla użytkownika admin pięciokrotnie:";
            // 
            // Logow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 457);
            this.Controls.Add(this.rejestracja);
            this.Controls.Add(this.log1);
            this.Controls.Add(this.log2);
            this.Name = "Logow";
            this.Text = "Logowanie";
            this.log1.ResumeLayout(false);
            this.log1.PerformLayout();
            this.log2.ResumeLayout(false);
            this.log2.PerformLayout();
            this.log3.ResumeLayout(false);
            this.log3.PerformLayout();
            this.rejestracja.ResumeLayout(false);
            this.rejestracja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox nierobot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.Button weryfikuj;
        private System.Windows.Forms.CheckBox robot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox log1;
        private System.Windows.Forms.GroupBox log2;
        private System.Windows.Forms.GroupBox log3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button wyslij;
        private System.Windows.Forms.Button sprawdz;
        private System.Windows.Forms.TextBox sprawdzenie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox rejestracja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AkcRej;
        private System.Windows.Forms.TextBox rej5;
        private System.Windows.Forms.TextBox rej4;
        private System.Windows.Forms.TextBox rej3;
        private System.Windows.Forms.TextBox rej2;
        private System.Windows.Forms.TextBox rej1;
    }
}

