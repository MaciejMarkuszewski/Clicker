using System.Collections.Generic;
using System;

namespace Clicker_2
{
    partial class Ranking
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
        private void InitializeComponent(Gracz G)
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new List<System.Windows.Forms.Label>();
            this.label6 = new List<System.Windows.Forms.Label>();
            this.label7 = new List<System.Windows.Forms.Label>();
            this.label8 = new List<System.Windows.Forms.Label>();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            Ranking_kl R=new Ranking_kl();
            for(int i = 0; i < R.liczba_graczy; i++)
            {
                label5.Add(new System.Windows.Forms.Label());
                label6.Add(new System.Windows.Forms.Label());
                label7.Add(new System.Windows.Forms.Label());
                label8.Add(new System.Windows.Forms.Label());
            }
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Powrót do gry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            for(int i = 0; i < R.liczba_graczy; i++)
            {
                this.tableLayoutPanel1.Controls.Add(this.label5[i], 0, 1+i);
                this.tableLayoutPanel1.Controls.Add(this.label6[i], 1, 1+i);
                this.tableLayoutPanel1.Controls.Add(this.label7[i], 2, 1+i);
                this.tableLayoutPanel1.Controls.Add(this.label8[i], 3, 1+i);
            }
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = R.liczba_graczy+1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            for(int i = 0; i < R.liczba_graczy; i ++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            }
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, (R.liczba_graczy + 1) * 30);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lp.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(43, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(193, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Punkty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(293, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ostatnia wizyta";
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                // 
                // label5
                // 
                this.label5[i].AutoSize = true;
                this.label5[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                this.label5[i].Location = new System.Drawing.Point(3, (1+i)*30);
                this.label5[i].Name = "label5";
                this.label5[i].Size = new System.Drawing.Size(29, 20);
                this.label5[i].TabIndex = 4+4*i;
                label5[i].Text = Convert.ToString(i + 1);
                // 
                // label6
                // 
                this.label6[i].AutoSize = true;
                this.label6[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                this.label6[i].Location = new System.Drawing.Point(43, (1 + i) * 30);
                this.label6[i].Name = "label6";
                this.label6[i].Size = new System.Drawing.Size(35, 20);
                this.label6[i].TabIndex = 5 + 4 * i;
                label6[i].Text = R.dane[i].nazwa_gracza;
                // 
                // label7
                // 
                this.label7[i].AutoSize = true;
                this.label7[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                this.label7[i].Location = new System.Drawing.Point(193, (1 + i) * 30);
                this.label7[i].Name = "label7";
                this.label7[i].Size = new System.Drawing.Size(35, 20);
                this.label7[i].TabIndex = 6 + 4 * i;
                label7[i].Text = Convert.ToString(R.dane[i].punkty);
                // 
                // label8
                // 
                this.label8[i].AutoSize = true;
                this.label8[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                this.label8[i].Location = new System.Drawing.Point(293, (1 + i) * 30);
                this.label8[i].Name = "label8";
                this.label8[i].Size = new System.Drawing.Size(35, 20);
                this.label8[i].TabIndex = 7 + 4 * i;
                DateTime czas = new DateTime(R.dane[i].ostatnia_wizyta);
                label8[i].Text = Convert.ToString(czas);

                if (R.dane[i].ID_logowania == G.ID_logowania)
                {
                    this.label5[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    this.label6[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    this.label7[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    this.label8[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    this.button2.Location = new System.Drawing.Point(515, (i+1)*30+16);
                    this.button2.Name = "button2";
                    this.button2.Size = new System.Drawing.Size(94, 23);
                    this.button2.TabIndex = 1;
                    this.button2.Text = "Usuń gracza";
                    this.button2.UseVisualStyleBackColor = true;
                    this.button2.Click += new System.EventHandler(this.button2_Click);
                }
            }
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Ranking";
            this.Text = "Ranking";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private void InitializeComponent(Administrator A)
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new List<System.Windows.Forms.Label>();
            this.label6 = new List<System.Windows.Forms.Label>();
            this.textbox7 = new List<System.Windows.Forms.TextBox>();
            this.label8 = new List<System.Windows.Forms.Label>();
            this.label9 = new System.Windows.Forms.Label();
            this.checkbox1 = new List<System.Windows.Forms.CheckBox>();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            Ranking_kl R = new Ranking_kl();
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                label5.Add(new System.Windows.Forms.Label());
                label6.Add(new System.Windows.Forms.Label());
                textbox7.Add(new System.Windows.Forms.TextBox());
                label8.Add(new System.Windows.Forms.Label());
                checkbox1.Add(new System.Windows.Forms.CheckBox());
            }
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Powrót do gry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Zapisz zmiany";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                this.tableLayoutPanel1.Controls.Add(this.label5[i], 0, 1 + i);
                this.tableLayoutPanel1.Controls.Add(this.label6[i], 1, 1 + i);
                this.tableLayoutPanel1.Controls.Add(this.textbox7[i], 2, 1 + i);
                this.tableLayoutPanel1.Controls.Add(this.label8[i], 3, 1 + i);
                this.tableLayoutPanel1.Controls.Add(this.checkbox1[i], 4, 1 + i);
            }
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = R.liczba_graczy + 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            }
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, (R.liczba_graczy + 1) * 30);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lp.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Punkty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ostatnia wizyta";
            for (int i = 0; i < R.liczba_graczy; i++)
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Usuń gracza";
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                // 
                // label5
                // 
                this.label5[i].AutoSize = true;
                this.label5[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                this.label5[i].Location = new System.Drawing.Point(3, (1 + i) * 30);
                this.label5[i].Name = "label5";
                this.label5[i].Size = new System.Drawing.Size(29, 20);
                this.label5[i].TabIndex = 5 + 5 * i;
                label5[i].Text = Convert.ToString(i + 1);
                // 
                // label6
                // 
                this.label6[i].AutoSize = true;
                this.label6[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                this.label6[i].Location = new System.Drawing.Point(43, (1 + i) * 30);
                this.label6[i].Name = "label6";
                this.label6[i].Size = new System.Drawing.Size(35, 20);
                this.label6[i].TabIndex = 6 + 5 * i;
                label6[i].Text = R.dane[i].nazwa_gracza;
                // 
                // label7
                // 
                this.textbox7[i].AutoSize = true;
                this.textbox7[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                this.textbox7[i].Location = new System.Drawing.Point(193, (1 + i) * 30);
                this.textbox7[i].Name = "textbox7";
                this.textbox7[i].Size = new System.Drawing.Size(35, 20);
                this.textbox7[i].TabIndex = 7 + 5 * i;
                textbox7[i].Text = Convert.ToString(R.dane[i].punkty);
                // 
                // label8
                // 
                this.label8[i].AutoSize = true;
                this.label8[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                this.label8[i].Location = new System.Drawing.Point(293, (1 + i) * 30);
                this.label8[i].Name = "label8";
                this.label8[i].Size = new System.Drawing.Size(35, 20);
                this.label8[i].TabIndex = 8 + 5 * i;
                DateTime czas = new DateTime(R.dane[i].ostatnia_wizyta);
                label8[i].Text = Convert.ToString(czas);
                // 
                // checkbox1
                // 
                this.checkbox1[i].AutoSize = true;
                this.checkbox1[i].Location = new System.Drawing.Point(0, (1 + i) * 30);
                this.checkbox1[i].Name = "chechbox1";
                this.checkbox1[i].Size = new System.Drawing.Size(35, 20);
                this.checkbox1[i].TabIndex = 9 + 5 * i;
                this.checkbox1[i].UseVisualStyleBackColor = true;

                if (R.dane[i].ID_logowania == A.ID_logowania)
                {
                    this.label5[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    this.label6[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    this.textbox7[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    this.label8[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                }
            }
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Ranking";
            this.Text = "Ranking";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private List<System.Windows.Forms.Label> label5;
        private List<System.Windows.Forms.Label> label6;
        private List<System.Windows.Forms.Label> label7;
        private List<System.Windows.Forms.Label> label8;
        private List<System.Windows.Forms.TextBox> textbox7;
        private System.Windows.Forms.Label label9;
        private List<System.Windows.Forms.CheckBox> checkbox1;
    }
}