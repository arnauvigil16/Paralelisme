using System;

namespace Paralelisme
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargar = new System.Windows.Forms.Button();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.colDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUserParalel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCargar.Location = new System.Drawing.Point(354, 12);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(130, 23);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar Dades";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // listViewUser
            // 
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDNI,
            this.colNom,
            this.colEmail});
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(12, 73);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(403, 342);
            this.listViewUser.TabIndex = 1;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            this.listViewUser.SelectedIndexChanged += new System.EventHandler(this.listViewUser_SelectedIndexChanged);
            // 
            // colDNI
            // 
            this.colDNI.Text = "DNI";
            this.colDNI.Width = 80;
            // 
            // colNom
            // 
            this.colNom.Text = "Nom";
            this.colNom.Width = 80;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 180;
            // 
            // listViewUserParalel
            // 
            this.listViewUserParalel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewUserParalel.HideSelection = false;
            this.listViewUserParalel.Location = new System.Drawing.Point(421, 73);
            this.listViewUserParalel.Name = "listViewUserParalel";
            this.listViewUserParalel.Size = new System.Drawing.Size(385, 343);
            this.listViewUserParalel.TabIndex = 3;
            this.listViewUserParalel.UseCompatibleStateImageBehavior = false;
            this.listViewUserParalel.View = System.Windows.Forms.View.Details;
            this.listViewUserParalel.SelectedIndexChanged += new System.EventHandler(this.listViewUserParalel_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 180;
            // 
            // timer1
            // 
            this.timer1.AutoSize = true;
            this.timer1.Location = new System.Drawing.Point(166, 432);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(49, 13);
            this.timer1.TabIndex = 4;
            this.timer1.Text = "00:00:00";
            // 
            // timer2
            // 
            this.timer2.AutoSize = true;
            this.timer2.Location = new System.Drawing.Point(603, 432);
            this.timer2.Name = "timer2";
            this.timer2.Size = new System.Drawing.Size(49, 13);
            this.timer2.TabIndex = 5;
            this.timer2.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Carga de dades normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Carga de dades amb paralelisme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(854, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timer2);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.listViewUserParalel);
            this.Controls.Add(this.listViewUser);
            this.Controls.Add(this.btnCargar);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ColumnHeader colDNI;
        private System.Windows.Forms.ColumnHeader colNom;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ListView listViewUserParalel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label timer1;
        private System.Windows.Forms.Label timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

