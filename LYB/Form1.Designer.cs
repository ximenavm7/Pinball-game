﻿namespace LYB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.BTN_EXE = new System.Windows.Forms.Button();
            this.CHK_GENERATE = new System.Windows.Forms.CheckBox();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.PNL_HEADER = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.PNL_HEADER.SuspendLayout();
            this.SuspendLayout();
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 15;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(417, 58);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(336, 468);
            this.PCT_CANVAS.TabIndex = 2;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseClick);
            this.PCT_CANVAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDown);
            this.PCT_CANVAS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseMove);
            this.PCT_CANVAS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseUp);
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BTN_EXE.FlatAppearance.BorderSize = 0;
            this.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXE.ForeColor = System.Drawing.Color.Silver;
            this.BTN_EXE.Location = new System.Drawing.Point(31, 11);
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(80, 42);
            this.BTN_EXE.TabIndex = 0;
            this.BTN_EXE.Text = "EXE";
            this.BTN_EXE.UseVisualStyleBackColor = false;
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // CHK_GENERATE
            // 
            this.CHK_GENERATE.AutoSize = true;
            this.CHK_GENERATE.Checked = true;
            this.CHK_GENERATE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_GENERATE.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_GENERATE.ForeColor = System.Drawing.Color.Silver;
            this.CHK_GENERATE.Location = new System.Drawing.Point(299, 18);
            this.CHK_GENERATE.Name = "CHK_GENERATE";
            this.CHK_GENERATE.Size = new System.Drawing.Size(137, 28);
            this.CHK_GENERATE.TabIndex = 1;
            this.CHK_GENERATE.Text = "GENERATE ";
            this.CHK_GENERATE.UseVisualStyleBackColor = true;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.ForeColor = System.Drawing.Color.Silver;
            this.LBL_STATUS.Location = new System.Drawing.Point(562, 24);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(36, 19);
            this.LBL_STATUS.TabIndex = 2;
            this.LBL_STATUS.Text = "PTS";
            // 
            // PNL_HEADER
            // 
            this.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PNL_HEADER.Controls.Add(this.LBL_STATUS);
            this.PNL_HEADER.Controls.Add(this.CHK_GENERATE);
            this.PNL_HEADER.Controls.Add(this.BTN_EXE);
            this.PNL_HEADER.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEADER.Name = "PNL_HEADER";
            this.PNL_HEADER.Size = new System.Drawing.Size(1155, 52);
            this.PNL_HEADER.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 538);
            this.Controls.Add(this.PNL_HEADER);
            this.Controls.Add(this.PCT_CANVAS);
            this.Name = "Form1";
            this.Text = "VERLET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.PNL_HEADER.ResumeLayout(false);
            this.PNL_HEADER.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Button BTN_EXE;
        private System.Windows.Forms.CheckBox CHK_GENERATE;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Panel PNL_HEADER;
    }
}

