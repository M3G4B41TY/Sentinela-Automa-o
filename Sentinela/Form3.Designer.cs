﻿
namespace Sentinela
{
    partial class FormMenu
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
            this.panelcabeçalho = new System.Windows.Forms.Panel();
            this.btnrestaurar = new System.Windows.Forms.Button();
            this.btnmaximizar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelcabeçalho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcabeçalho
            // 
            this.panelcabeçalho.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelcabeçalho.Controls.Add(this.label1);
            this.panelcabeçalho.Controls.Add(this.btnrestaurar);
            this.panelcabeçalho.Controls.Add(this.btnmaximizar);
            this.panelcabeçalho.Controls.Add(this.btnfechar);
            this.panelcabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcabeçalho.Location = new System.Drawing.Point(0, 0);
            this.panelcabeçalho.Name = "panelcabeçalho";
            this.panelcabeçalho.Size = new System.Drawing.Size(800, 88);
            this.panelcabeçalho.TabIndex = 0;
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnrestaurar.FlatAppearance.BorderSize = 0;
            this.btnrestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnrestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnrestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestaurar.Image = global::Sentinela.Properties.Resources.p2_1;
            this.btnrestaurar.Location = new System.Drawing.Point(478, 12);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(75, 71);
            this.btnrestaurar.TabIndex = 3;
            this.btnrestaurar.UseVisualStyleBackColor = true;
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmaximizar.FlatAppearance.BorderSize = 0;
            this.btnmaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnmaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaximizar.Image = global::Sentinela.Properties.Resources.p3_1;
            this.btnmaximizar.Location = new System.Drawing.Point(597, 12);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(75, 71);
            this.btnmaximizar.TabIndex = 2;
            this.btnmaximizar.UseVisualStyleBackColor = true;
            // 
            // btnfechar
            // 
            this.btnfechar.BackgroundImage = global::Sentinela.Properties.Resources.p1;
            this.btnfechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnfechar.FlatAppearance.BorderSize = 0;
            this.btnfechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.Image = global::Sentinela.Properties.Resources.p1_1;
            this.btnfechar.Location = new System.Drawing.Point(713, 12);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 71);
            this.btnfechar.TabIndex = 1;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de CAdastro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 362);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 79);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelcabeçalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panelcabeçalho.ResumeLayout(false);
            this.panelcabeçalho.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcabeçalho;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnrestaurar;
        private System.Windows.Forms.Button btnmaximizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}