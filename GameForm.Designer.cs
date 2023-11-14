namespace MiniProject
{
    partial class GameForm
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
            this.btnPallet1 = new System.Windows.Forms.Button();
            this.btnPallet2 = new System.Windows.Forms.Button();
            this.btnPallet3 = new System.Windows.Forms.Button();
            this.btnPallet4 = new System.Windows.Forms.Button();
            this.btnStaging1 = new System.Windows.Forms.Button();
            this.btnStaging2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPallet1
            // 
            this.btnPallet1.Location = new System.Drawing.Point(402, 100);
            this.btnPallet1.Name = "btnPallet1";
            this.btnPallet1.Size = new System.Drawing.Size(140, 128);
            this.btnPallet1.TabIndex = 0;
            this.btnPallet1.Text = "Pallet 1";
            this.btnPallet1.UseVisualStyleBackColor = true;
            this.btnPallet1.Click += new System.EventHandler(this.btnPallet1_Click);
            // 
            // btnPallet2
            // 
            this.btnPallet2.Location = new System.Drawing.Point(591, 100);
            this.btnPallet2.Name = "btnPallet2";
            this.btnPallet2.Size = new System.Drawing.Size(140, 128);
            this.btnPallet2.TabIndex = 1;
            this.btnPallet2.Text = "Pallet 2";
            this.btnPallet2.UseVisualStyleBackColor = true;
            this.btnPallet2.Click += new System.EventHandler(this.btnPallet2_Click);
            // 
            // btnPallet3
            // 
            this.btnPallet3.Location = new System.Drawing.Point(402, 260);
            this.btnPallet3.Name = "btnPallet3";
            this.btnPallet3.Size = new System.Drawing.Size(140, 128);
            this.btnPallet3.TabIndex = 2;
            this.btnPallet3.Text = "Pallet 3";
            this.btnPallet3.UseVisualStyleBackColor = true;
            this.btnPallet3.Click += new System.EventHandler(this.btnPallet3_Click);
            // 
            // btnPallet4
            // 
            this.btnPallet4.Location = new System.Drawing.Point(591, 260);
            this.btnPallet4.Name = "btnPallet4";
            this.btnPallet4.Size = new System.Drawing.Size(140, 128);
            this.btnPallet4.TabIndex = 3;
            this.btnPallet4.Text = "Pallet4";
            this.btnPallet4.UseVisualStyleBackColor = true;
            this.btnPallet4.Click += new System.EventHandler(this.btnPallet4_Click);
            // 
            // btnStaging1
            // 
            this.btnStaging1.Location = new System.Drawing.Point(87, 70);
            this.btnStaging1.Name = "btnStaging1";
            this.btnStaging1.Size = new System.Drawing.Size(140, 128);
            this.btnStaging1.TabIndex = 4;
            this.btnStaging1.Text = "Staging 1";
            this.btnStaging1.UseVisualStyleBackColor = true;
            this.btnStaging1.Click += new System.EventHandler(this.btnStaging1_Click);
            // 
            // btnStaging2
            // 
            this.btnStaging2.Location = new System.Drawing.Point(87, 303);
            this.btnStaging2.Name = "btnStaging2";
            this.btnStaging2.Size = new System.Drawing.Size(140, 128);
            this.btnStaging2.TabIndex = 5;
            this.btnStaging2.Text = "Staging 2";
            this.btnStaging2.UseVisualStyleBackColor = true;
            this.btnStaging2.Click += new System.EventHandler(this.btnStaging2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 521);
            this.Controls.Add(this.btnStaging2);
            this.Controls.Add(this.btnStaging1);
            this.Controls.Add(this.btnPallet4);
            this.Controls.Add(this.btnPallet3);
            this.Controls.Add(this.btnPallet2);
            this.Controls.Add(this.btnPallet1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPallet1;
        private System.Windows.Forms.Button btnPallet2;
        private System.Windows.Forms.Button btnPallet3;
        private System.Windows.Forms.Button btnPallet4;
        private System.Windows.Forms.Button btnStaging1;
        private System.Windows.Forms.Button btnStaging2;
        private System.Windows.Forms.Timer timer1;
    }
}