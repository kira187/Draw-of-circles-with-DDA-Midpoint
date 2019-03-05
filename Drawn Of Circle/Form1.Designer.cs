namespace Drawn_Of_Circle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcoordenadaC = new System.Windows.Forms.Label();
            this.lblcoordenadaR = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbltimemidpoint = new System.Windows.Forms.Label();
            this.lbltimedda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblradio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mid Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coordenadas Centrales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Coordenadas del radio";
            // 
            // lblcoordenadaC
            // 
            this.lblcoordenadaC.AutoSize = true;
            this.lblcoordenadaC.Location = new System.Drawing.Point(569, 142);
            this.lblcoordenadaC.Name = "lblcoordenadaC";
            this.lblcoordenadaC.Size = new System.Drawing.Size(52, 13);
            this.lblcoordenadaC.TabIndex = 5;
            this.lblcoordenadaC.Text = "( 00 , 00 )";
            // 
            // lblcoordenadaR
            // 
            this.lblcoordenadaR.AutoSize = true;
            this.lblcoordenadaR.Location = new System.Drawing.Point(569, 219);
            this.lblcoordenadaR.Name = "lblcoordenadaR";
            this.lblcoordenadaR.Size = new System.Drawing.Size(46, 13);
            this.lblcoordenadaR.TabIndex = 6;
            this.lblcoordenadaR.Text = "(00 , 00)";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(557, 374);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(97, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbltimemidpoint
            // 
            this.lbltimemidpoint.AutoSize = true;
            this.lbltimemidpoint.Location = new System.Drawing.Point(115, 36);
            this.lbltimemidpoint.Name = "lbltimemidpoint";
            this.lbltimemidpoint.Size = new System.Drawing.Size(40, 13);
            this.lbltimemidpoint.TabIndex = 8;
            this.lbltimemidpoint.Text = "00 : 00";
            // 
            // lbltimedda
            // 
            this.lbltimedda.AutoSize = true;
            this.lbltimedda.Location = new System.Drawing.Point(323, 36);
            this.lbltimedda.Name = "lbltimedda";
            this.lbltimedda.Size = new System.Drawing.Size(40, 13);
            this.lbltimedda.TabIndex = 9;
            this.lbltimedda.Text = "00 : 00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Radio";
            // 
            // lblradio
            // 
            this.lblradio.AutoSize = true;
            this.lblradio.Location = new System.Drawing.Point(594, 304);
            this.lblradio.Name = "lblradio";
            this.lblradio.Size = new System.Drawing.Size(0, 13);
            this.lblradio.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 363);
            this.panel1.TabIndex = 12;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblradio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltimedda);
            this.Controls.Add(this.lbltimemidpoint);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lblcoordenadaR);
            this.Controls.Add(this.lblcoordenadaC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcoordenadaC;
        private System.Windows.Forms.Label lblcoordenadaR;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbltimemidpoint;
        private System.Windows.Forms.Label lbltimedda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblradio;
        private System.Windows.Forms.Panel panel1;
    }
}

