﻿
namespace kevin01.VISTA
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickParaMasInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATEMATICASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cONEXIONESDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cROUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asercaDeToolStripMenuItem,
            this.arreglosToolStripMenuItem,
            this.mATEMATICASToolStripMenuItem,
            this.cONEXIONESDBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asercaDeToolStripMenuItem
            // 
            this.asercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickParaMasInformacionToolStripMenuItem});
            this.asercaDeToolStripMenuItem.Name = "asercaDeToolStripMenuItem";
            this.asercaDeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.asercaDeToolStripMenuItem.Text = "Aserca de ";
            // 
            // clickParaMasInformacionToolStripMenuItem
            // 
            this.clickParaMasInformacionToolStripMenuItem.Name = "clickParaMasInformacionToolStripMenuItem";
            this.clickParaMasInformacionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.clickParaMasInformacionToolStripMenuItem.Text = "click para mas informacion";
            this.clickParaMasInformacionToolStripMenuItem.Click += new System.EventHandler(this.clickParaMasInformacionToolStripMenuItem_Click);
            // 
            // arreglosToolStripMenuItem
            // 
            this.arreglosToolStripMenuItem.Name = "arreglosToolStripMenuItem";
            this.arreglosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.arreglosToolStripMenuItem.Text = "Arreglos";
            this.arreglosToolStripMenuItem.Click += new System.EventHandler(this.arreglosToolStripMenuItem_Click);
            // 
            // mATEMATICASToolStripMenuItem
            // 
            this.mATEMATICASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem});
            this.mATEMATICASToolStripMenuItem.Name = "mATEMATICASToolStripMenuItem";
            this.mATEMATICASToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.mATEMATICASToolStripMenuItem.Text = "MATEMATICAS";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumaToolStripMenuItem.Text = "suma ";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaToolStripMenuItem.Text = "resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // cONEXIONESDBToolStripMenuItem
            // 
            this.cONEXIONESDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cROUDToolStripMenuItem});
            this.cONEXIONESDBToolStripMenuItem.Name = "cONEXIONESDBToolStripMenuItem";
            this.cONEXIONESDBToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.cONEXIONESDBToolStripMenuItem.Text = "CONEXIONES DB";
            // 
            // cROUDToolStripMenuItem
            // 
            this.cROUDToolStripMenuItem.Name = "cROUDToolStripMenuItem";
            this.cROUDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cROUDToolStripMenuItem.Text = "CRUD";
            this.cROUDToolStripMenuItem.Click += new System.EventHandler(this.cROUDToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickParaMasInformacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mATEMATICASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONEXIONESDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cROUDToolStripMenuItem;
    }
}