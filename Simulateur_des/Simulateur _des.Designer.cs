using System;

namespace Simulateur_des
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AffRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.piped_values = new System.Windows.Forms.TextBox();
            this.nb_des = new System.Windows.Forms.TextBox();
            this.obj_sup = new System.Windows.Forms.Button();
            this.obj_egal = new System.Windows.Forms.Button();
            this.obj_inf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.obj_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.jeu_421 = new System.Windows.Forms.Button();
            this.soustraction_de = new System.Windows.Forms.Button();
            this.ajout_de = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.historique = new System.Windows.Forms.Button();
            this.Jeter = new System.Windows.Forms.Button();
            this.d100 = new System.Windows.Forms.Button();
            this.d20 = new System.Windows.Forms.Button();
            this.d12 = new System.Windows.Forms.Button();
            this.d10 = new System.Windows.Forms.Button();
            this.d8 = new System.Windows.Forms.Button();
            this.d6 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AffRes
            // 
            this.AffRes.Location = new System.Drawing.Point(5, 355);
            this.AffRes.Name = "AffRes";
            this.AffRes.Size = new System.Drawing.Size(561, 20);
            this.AffRes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Veuillez choisir le nombre de dés à lancer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Veuillez choisir le type de dés à lancer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Voici votre résultat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ou définissez votre propre dé, en séparant les valeurs par des points-virgules :";
            // 
            // piped_values
            // 
            this.piped_values.Location = new System.Drawing.Point(6, 147);
            this.piped_values.Name = "piped_values";
            this.piped_values.Size = new System.Drawing.Size(560, 20);
            this.piped_values.TabIndex = 12;
            // 
            // nb_des
            // 
            this.nb_des.Location = new System.Drawing.Point(53, 198);
            this.nb_des.Name = "nb_des";
            this.nb_des.Size = new System.Drawing.Size(129, 20);
            this.nb_des.TabIndex = 14;
            this.nb_des.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // obj_sup
            // 
            this.obj_sup.Location = new System.Drawing.Point(502, 294);
            this.obj_sup.Name = "obj_sup";
            this.obj_sup.Size = new System.Drawing.Size(40, 20);
            this.obj_sup.TabIndex = 27;
            this.obj_sup.Text = ">";
            this.obj_sup.UseVisualStyleBackColor = true;
            this.obj_sup.Click += new System.EventHandler(this.obj_sup_Click);
            // 
            // obj_egal
            // 
            this.obj_egal.Location = new System.Drawing.Point(456, 294);
            this.obj_egal.Name = "obj_egal";
            this.obj_egal.Size = new System.Drawing.Size(40, 20);
            this.obj_egal.TabIndex = 26;
            this.obj_egal.Text = "=";
            this.obj_egal.UseVisualStyleBackColor = true;
            this.obj_egal.Click += new System.EventHandler(this.obj_egal_Click);
            // 
            // obj_inf
            // 
            this.obj_inf.Location = new System.Drawing.Point(410, 294);
            this.obj_inf.Name = "obj_inf";
            this.obj_inf.Size = new System.Drawing.Size(40, 20);
            this.obj_inf.TabIndex = 24;
            this.obj_inf.Text = "<";
            this.obj_inf.UseVisualStyleBackColor = true;
            this.obj_inf.Click += new System.EventHandler(this.obj_inf_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 20);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // obj_text
            // 
            this.obj_text.Location = new System.Drawing.Point(410, 268);
            this.obj_text.Name = "obj_text";
            this.obj_text.Size = new System.Drawing.Size(132, 20);
            this.obj_text.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fixez un objectif:";
            // 
            // jeu_421
            // 
            this.jeu_421.Image = global::Simulateur_des.Resource._421;
            this.jeu_421.Location = new System.Drawing.Point(28, 26);
            this.jeu_421.Name = "jeu_421";
            this.jeu_421.Size = new System.Drawing.Size(113, 64);
            this.jeu_421.TabIndex = 31;
            this.jeu_421.UseVisualStyleBackColor = true;
            this.jeu_421.Click += new System.EventHandler(this.jeu_421_Click);
            // 
            // soustraction_de
            // 
            this.soustraction_de.Image = global::Simulateur_des.Resource.minus_512;
            this.soustraction_de.Location = new System.Drawing.Point(3, 184);
            this.soustraction_de.Name = "soustraction_de";
            this.soustraction_de.Size = new System.Drawing.Size(44, 46);
            this.soustraction_de.TabIndex = 30;
            this.soustraction_de.UseVisualStyleBackColor = true;
            this.soustraction_de.Click += new System.EventHandler(this.soustraction_de_Click);
            // 
            // ajout_de
            // 
            this.ajout_de.Image = global::Simulateur_des.Resource.plus_512;
            this.ajout_de.Location = new System.Drawing.Point(188, 184);
            this.ajout_de.Name = "ajout_de";
            this.ajout_de.Size = new System.Drawing.Size(44, 46);
            this.ajout_de.TabIndex = 29;
            this.ajout_de.UseVisualStyleBackColor = true;
            this.ajout_de.Click += new System.EventHandler(this.ajout_de_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(839, 184);
            this.label6.MinimumSize = new System.Drawing.Size(64, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 64);
            this.label6.TabIndex = 28;
            // 
            // historique
            // 
            this.historique.Image = ((System.Drawing.Image)(resources.GetObject("historique.Image")));
            this.historique.Location = new System.Drawing.Point(248, 235);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(75, 94);
            this.historique.TabIndex = 16;
            this.historique.UseVisualStyleBackColor = true;
            this.historique.Click += new System.EventHandler(this.historique_Click);
            // 
            // Jeter
            // 
            this.Jeter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Jeter.BackgroundImage")));
            this.Jeter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Jeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jeter.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Jeter.FlatAppearance.BorderSize = 0;
            this.Jeter.Location = new System.Drawing.Point(28, 235);
            this.Jeter.Name = "Jeter";
            this.Jeter.Size = new System.Drawing.Size(86, 94);
            this.Jeter.TabIndex = 15;
            this.Jeter.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Jeter.UseVisualStyleBackColor = true;
            this.Jeter.Click += new System.EventHandler(this.jeter_Click);
            // 
            // d100
            // 
            this.d100.Image = ((System.Drawing.Image)(resources.GetObject("d100.Image")));
            this.d100.Location = new System.Drawing.Point(491, 20);
            this.d100.Name = "d100";
            this.d100.Size = new System.Drawing.Size(75, 108);
            this.d100.TabIndex = 8;
            this.d100.UseVisualStyleBackColor = true;
            this.d100.Click += new System.EventHandler(this.d100_Click);
            // 
            // d20
            // 
            this.d20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d20.Image = ((System.Drawing.Image)(resources.GetObject("d20.Image")));
            this.d20.Location = new System.Drawing.Point(410, 20);
            this.d20.Name = "d20";
            this.d20.Size = new System.Drawing.Size(75, 108);
            this.d20.TabIndex = 7;
            this.d20.UseVisualStyleBackColor = true;
            this.d20.Click += new System.EventHandler(this.d20_Click);
            // 
            // d12
            // 
            this.d12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d12.Image = ((System.Drawing.Image)(resources.GetObject("d12.Image")));
            this.d12.Location = new System.Drawing.Point(329, 20);
            this.d12.Name = "d12";
            this.d12.Size = new System.Drawing.Size(75, 108);
            this.d12.TabIndex = 6;
            this.d12.UseVisualStyleBackColor = true;
            this.d12.Click += new System.EventHandler(this.d12_Click);
            // 
            // d10
            // 
            this.d10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d10.Image = ((System.Drawing.Image)(resources.GetObject("d10.Image")));
            this.d10.Location = new System.Drawing.Point(248, 20);
            this.d10.Name = "d10";
            this.d10.Size = new System.Drawing.Size(75, 108);
            this.d10.TabIndex = 5;
            this.d10.UseVisualStyleBackColor = true;
            this.d10.Click += new System.EventHandler(this.d10_Click);
            // 
            // d8
            // 
            this.d8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d8.Image = ((System.Drawing.Image)(resources.GetObject("d8.Image")));
            this.d8.Location = new System.Drawing.Point(167, 20);
            this.d8.Name = "d8";
            this.d8.Size = new System.Drawing.Size(75, 108);
            this.d8.TabIndex = 4;
            this.d8.UseVisualStyleBackColor = true;
            this.d8.Click += new System.EventHandler(this.d8_Click);
            // 
            // d6
            // 
            this.d6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d6.Image = ((System.Drawing.Image)(resources.GetObject("d6.Image")));
            this.d6.Location = new System.Drawing.Point(86, 20);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(75, 108);
            this.d6.TabIndex = 3;
            this.d6.UseVisualStyleBackColor = true;
            this.d6.Click += new System.EventHandler(this.d6_Click);
            // 
            // d4
            // 
            this.d4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d4.Image = ((System.Drawing.Image)(resources.GetObject("d4.Image")));
            this.d4.Location = new System.Drawing.Point(5, 20);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(75, 108);
            this.d4.TabIndex = 0;
            this.d4.UseVisualStyleBackColor = true;
            this.d4.Click += new System.EventHandler(this.d4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 413);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.d4);
            this.tabPage1.Controls.Add(this.soustraction_de);
            this.tabPage1.Controls.Add(this.AffRes);
            this.tabPage1.Controls.Add(this.ajout_de);
            this.tabPage1.Controls.Add(this.d6);
            this.tabPage1.Controls.Add(this.d8);
            this.tabPage1.Controls.Add(this.obj_sup);
            this.tabPage1.Controls.Add(this.d10);
            this.tabPage1.Controls.Add(this.obj_egal);
            this.tabPage1.Controls.Add(this.d12);
            this.tabPage1.Controls.Add(this.obj_inf);
            this.tabPage1.Controls.Add(this.d20);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.d100);
            this.tabPage1.Controls.Add(this.obj_text);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.historique);
            this.tabPage1.Controls.Add(this.piped_values);
            this.tabPage1.Controls.Add(this.Jeter);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nb_des);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generation de dés";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.jeu_421);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jeux Divers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(612, 425);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Simulateur de dés";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.TextBox AffRes;
        private System.Windows.Forms.Button d6;
        private System.Windows.Forms.Button d8;
        private System.Windows.Forms.Button d10;
        private System.Windows.Forms.Button d12;
        private System.Windows.Forms.Button d20;
        private System.Windows.Forms.Button d100;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox piped_values;
        private System.Windows.Forms.TextBox nb_des;
        private System.Windows.Forms.Button Jeter;
        private System.Windows.Forms.Button historique;
        private System.Windows.Forms.Button obj_sup;
        private System.Windows.Forms.Button obj_egal;
        private System.Windows.Forms.Button obj_inf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox obj_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ajout_de;
        private System.Windows.Forms.Button soustraction_de;
        private System.Windows.Forms.Button jeu_421;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

