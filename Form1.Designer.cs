using System;

namespace WindowsFormsApp6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.tbNume_Carte = new System.Windows.Forms.TextBox();
            this.tbCod_Carte = new System.Windows.Forms.TextBox();
            this.tbPerioada_Imprumut = new System.Windows.Forms.TextBox();
            this.tbPerioada_Ramasa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprumutMaximToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "nume_Carte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "cod_Carte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "perioada_Imprumut(luni)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "perioada_Ramasa(luni)";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(364, 154);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 26);
            this.tbNume.TabIndex = 7;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(364, 209);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(100, 26);
            this.tbVarsta.TabIndex = 8;
            this.tbVarsta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVarsta_KeyPress);
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cbSex.Location = new System.Drawing.Point(364, 267);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 28);
            this.cbSex.TabIndex = 9;
            // 
            // tbNume_Carte
            // 
            this.tbNume_Carte.Location = new System.Drawing.Point(364, 325);
            this.tbNume_Carte.Name = "tbNume_Carte";
            this.tbNume_Carte.Size = new System.Drawing.Size(100, 26);
            this.tbNume_Carte.TabIndex = 10;
            // 
            // tbCod_Carte
            // 
            this.tbCod_Carte.Location = new System.Drawing.Point(364, 375);
            this.tbCod_Carte.Name = "tbCod_Carte";
            this.tbCod_Carte.Size = new System.Drawing.Size(100, 26);
            this.tbCod_Carte.TabIndex = 11;
            this.tbCod_Carte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCod_Carte_KeyPress);
            // 
            // tbPerioada_Imprumut
            // 
            this.tbPerioada_Imprumut.Location = new System.Drawing.Point(834, 124);
            this.tbPerioada_Imprumut.Name = "tbPerioada_Imprumut";
            this.tbPerioada_Imprumut.Size = new System.Drawing.Size(100, 26);
            this.tbPerioada_Imprumut.TabIndex = 12;
            this.tbPerioada_Imprumut.TextChanged += new System.EventHandler(this.tbPerioada_Imprumut_TextChanged);
            this.tbPerioada_Imprumut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPerioada_Imprumut_KeyPress);
            // 
            // tbPerioada_Ramasa
            // 
            this.tbPerioada_Ramasa.Location = new System.Drawing.Point(834, 255);
            this.tbPerioada_Ramasa.Name = "tbPerioada_Ramasa";
            this.tbPerioada_Ramasa.Size = new System.Drawing.Size(100, 26);
            this.tbPerioada_Ramasa.TabIndex = 13;
            this.tbPerioada_Ramasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPerioada_Ramasa_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Deschide Form2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(765, 81);
            this.vScrollBar1.Maximum = 12;
            this.vScrollBar1.Minimum = 1;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 104);
            this.vScrollBar1.TabIndex = 16;
            this.vScrollBar1.Value = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setariToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setariToolStripMenuItem
            // 
            this.setariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprumutMaximToolStripMenuItem});
            this.setariToolStripMenuItem.Name = "setariToolStripMenuItem";
            this.setariToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.setariToolStripMenuItem.Text = "Setari";
            // 
            // imprumutMaximToolStripMenuItem
            // 
            this.imprumutMaximToolStripMenuItem.Name = "imprumutMaximToolStripMenuItem";
            this.imprumutMaximToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.imprumutMaximToolStripMenuItem.Text = "Imprumut Maxim";
            this.imprumutMaximToolStripMenuItem.Click += new System.EventHandler(this.imprumut_MaximToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(628, 374);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 24);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Abonament";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.LargeChange = 1;
            this.vScrollBar2.Location = new System.Drawing.Point(765, 228);
            this.vScrollBar2.Minimum = 1;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(26, 103);
            this.vScrollBar2.TabIndex = 19;
            this.vScrollBar2.Value = 1;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 34);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1135, 32);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(185, 29);
            this.toolStripButton1.Text = "Creeaza imprumut";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 40);
            this.button3.TabIndex = 22;
            this.button3.Text = "Deschide Form4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(549, 453);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 40);
            this.button4.TabIndex = 23;
            this.button4.Text = "Deschide Form3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(672, 531);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 45);
            this.button5.TabIndex = 24;
            this.button5.Text = "Deschide Form5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1075, 375);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 206);
            this.button6.TabIndex = 25;
            this.button6.Text = "GRAFIC   2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 621);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPerioada_Ramasa);
            this.Controls.Add(this.tbPerioada_Imprumut);
            this.Controls.Add(this.tbCod_Carte);
            this.Controls.Add(this.tbNume_Carte);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }







        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox tbNume_Carte;
        private System.Windows.Forms.TextBox tbCod_Carte;
        private System.Windows.Forms.TextBox tbPerioada_Imprumut;
        private System.Windows.Forms.TextBox tbPerioada_Ramasa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprumutMaximToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

