
namespace SNAKE_GAME
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timersaat = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Location = new System.Drawing.Point(12, 78);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(400, 360);
            this.pnl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puan";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.BackColor = System.Drawing.Color.White;
            this.lblpuan.Location = new System.Drawing.Point(80, 26);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(17, 20);
            this.lblpuan.TabIndex = 3;
            this.lblpuan.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(283, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Süre";
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.BackColor = System.Drawing.Color.White;
            this.lblsure.Location = new System.Drawing.Point(338, 26);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(17, 20);
            this.lblsure.TabIndex = 5;
            this.lblsure.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timersaat
            // 
            this.timersaat.Interval = 1000;
            this.timersaat.Tick += new System.EventHandler(this.timersaat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timersaat;
    }
}

