﻿namespace IUFormulario
{
    partial class FrmMainTaller
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
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnRetiro = new System.Windows.Forms.Button();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.TxtRetiro = new System.Windows.Forms.TextBox();
            this.TxtMensajeCajero = new System.Windows.Forms.TextBox();
            this.BtnArray = new System.Windows.Forms.Button();
            this.TxtListaArray = new System.Windows.Forms.TextBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.TxtList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(102, 52);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(75, 23);
            this.BtnConsulta.TabIndex = 0;
            this.BtnConsulta.Text = "Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // BtnRetiro
            // 
            this.BtnRetiro.Location = new System.Drawing.Point(102, 102);
            this.BtnRetiro.Name = "BtnRetiro";
            this.BtnRetiro.Size = new System.Drawing.Size(75, 23);
            this.BtnRetiro.TabIndex = 1;
            this.BtnRetiro.Text = "Retiro";
            this.BtnRetiro.UseVisualStyleBackColor = true;
            this.BtnRetiro.Click += new System.EventHandler(this.BtnRetiro_Click);
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(219, 52);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(100, 23);
            this.TxtConsulta.TabIndex = 2;
            // 
            // TxtRetiro
            // 
            this.TxtRetiro.Location = new System.Drawing.Point(219, 102);
            this.TxtRetiro.Name = "TxtRetiro";
            this.TxtRetiro.Size = new System.Drawing.Size(100, 23);
            this.TxtRetiro.TabIndex = 3;
            // 
            // TxtMensajeCajero
            // 
            this.TxtMensajeCajero.Location = new System.Drawing.Point(106, 156);
            this.TxtMensajeCajero.Multiline = true;
            this.TxtMensajeCajero.Name = "TxtMensajeCajero";
            this.TxtMensajeCajero.Size = new System.Drawing.Size(345, 69);
            this.TxtMensajeCajero.TabIndex = 4;
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(106, 244);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(75, 23);
            this.BtnArray.TabIndex = 5;
            this.BtnArray.Text = "Lista Array";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // TxtListaArray
            // 
            this.TxtListaArray.Location = new System.Drawing.Point(219, 245);
            this.TxtListaArray.Name = "TxtListaArray";
            this.TxtListaArray.Size = new System.Drawing.Size(232, 23);
            this.TxtListaArray.TabIndex = 6;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(106, 294);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(75, 23);
            this.BtnList.TabIndex = 7;
            this.BtnList.Text = "Lista List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // TxtList
            // 
            this.TxtList.Location = new System.Drawing.Point(219, 294);
            this.TxtList.Name = "TxtList";
            this.TxtList.Size = new System.Drawing.Size(232, 23);
            this.TxtList.TabIndex = 8;
            // 
            // FrmMainTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtList);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.TxtListaArray);
            this.Controls.Add(this.BtnArray);
            this.Controls.Add(this.TxtMensajeCajero);
            this.Controls.Add(this.TxtRetiro);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.BtnRetiro);
            this.Controls.Add(this.BtnConsulta);
            this.Name = "FrmMainTaller";
            this.Text = "Taller";
            //this.Load += new System.EventHandler(this.FrmMainTaller);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnRetiro;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.TextBox TxtRetiro;
        private System.Windows.Forms.TextBox TxtMensajeCajero;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.TextBox TxtListaArray;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.TextBox TxtList;
    }
}