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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnPallet1 = new System.Windows.Forms.Button();
            this.btnPallet2 = new System.Windows.Forms.Button();
            this.btnPallet3 = new System.Windows.Forms.Button();
            this.btnPallet4 = new System.Windows.Forms.Button();
            this.btnStaging1 = new System.Windows.Forms.Button();
            this.btnStaging2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picPending1 = new System.Windows.Forms.PictureBox();
            this.picPending2 = new System.Windows.Forms.PictureBox();
            this.picPending3 = new System.Windows.Forms.PictureBox();
            this.picPending4 = new System.Windows.Forms.PictureBox();
            this.picPending11 = new System.Windows.Forms.PictureBox();
            this.picPending12 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.timerFall1 = new System.Windows.Forms.Timer(this.components);
            this.timerFall2 = new System.Windows.Forms.Timer(this.components);
            this.timerFall3 = new System.Windows.Forms.Timer(this.components);
            this.timerFall4 = new System.Windows.Forms.Timer(this.components);
            this.timerAddBoxes = new System.Windows.Forms.Timer(this.components);
            this.timerOverflow = new System.Windows.Forms.Timer(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.picBelt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPending1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPending2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPending3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPending4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPending11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPending12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBelt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPallet1
            // 
            this.btnPallet1.BackColor = System.Drawing.Color.Transparent;
            this.btnPallet1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPallet1.FlatAppearance.BorderSize = 5;
            this.btnPallet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPallet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPallet1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPallet1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPallet1.Location = new System.Drawing.Point(369, 77);
            this.btnPallet1.Name = "btnPallet1";
            this.btnPallet1.Size = new System.Drawing.Size(170, 255);
            this.btnPallet1.TabIndex = 0;
            this.btnPallet1.Text = "Pallet 1";
            this.btnPallet1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPallet1.UseVisualStyleBackColor = false;
            this.btnPallet1.Click += new System.EventHandler(this.btnPallet1_Click);
            // 
            // btnPallet2
            // 
            this.btnPallet2.BackColor = System.Drawing.Color.Transparent;
            this.btnPallet2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPallet2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPallet2.FlatAppearance.BorderSize = 5;
            this.btnPallet2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPallet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPallet2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPallet2.Image = global::MiniProject.Properties.Resources.medium;
            this.btnPallet2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPallet2.Location = new System.Drawing.Point(569, 77);
            this.btnPallet2.Name = "btnPallet2";
            this.btnPallet2.Size = new System.Drawing.Size(170, 255);
            this.btnPallet2.TabIndex = 1;
            this.btnPallet2.Text = "Pallet 2";
            this.btnPallet2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPallet2.UseVisualStyleBackColor = false;
            this.btnPallet2.Click += new System.EventHandler(this.btnPallet2_Click);
            // 
            // btnPallet3
            // 
            this.btnPallet3.BackColor = System.Drawing.Color.Transparent;
            this.btnPallet3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPallet3.FlatAppearance.BorderSize = 5;
            this.btnPallet3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPallet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPallet3.Image = global::MiniProject.Properties.Resources.small_wrapped;
            this.btnPallet3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPallet3.Location = new System.Drawing.Point(369, 355);
            this.btnPallet3.Name = "btnPallet3";
            this.btnPallet3.Size = new System.Drawing.Size(170, 255);
            this.btnPallet3.TabIndex = 2;
            this.btnPallet3.Text = "Pallet 3";
            this.btnPallet3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPallet3.UseVisualStyleBackColor = false;
            this.btnPallet3.Click += new System.EventHandler(this.btnPallet3_Click);
            // 
            // btnPallet4
            // 
            this.btnPallet4.BackColor = System.Drawing.Color.Transparent;
            this.btnPallet4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPallet4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPallet4.FlatAppearance.BorderSize = 5;
            this.btnPallet4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPallet4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPallet4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPallet4.Image = global::MiniProject.Properties.Resources.empty_base;
            this.btnPallet4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPallet4.Location = new System.Drawing.Point(569, 355);
            this.btnPallet4.Name = "btnPallet4";
            this.btnPallet4.Size = new System.Drawing.Size(170, 255);
            this.btnPallet4.TabIndex = 3;
            this.btnPallet4.Text = "Pallet 4";
            this.btnPallet4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPallet4.UseVisualStyleBackColor = false;
            this.btnPallet4.Click += new System.EventHandler(this.btnPallet4_Click);
            // 
            // btnStaging1
            // 
            this.btnStaging1.BackColor = System.Drawing.Color.Transparent;
            this.btnStaging1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStaging1.FlatAppearance.BorderSize = 5;
            this.btnStaging1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaging1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaging1.Location = new System.Drawing.Point(87, 77);
            this.btnStaging1.Name = "btnStaging1";
            this.btnStaging1.Size = new System.Drawing.Size(170, 255);
            this.btnStaging1.TabIndex = 4;
            this.btnStaging1.Text = "Staging 1";
            this.btnStaging1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaging1.UseVisualStyleBackColor = false;
            this.btnStaging1.Click += new System.EventHandler(this.btnStaging1_Click);
            // 
            // btnStaging2
            // 
            this.btnStaging2.BackColor = System.Drawing.Color.Transparent;
            this.btnStaging2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStaging2.FlatAppearance.BorderSize = 5;
            this.btnStaging2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaging2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaging2.Location = new System.Drawing.Point(87, 355);
            this.btnStaging2.Name = "btnStaging2";
            this.btnStaging2.Size = new System.Drawing.Size(170, 255);
            this.btnStaging2.TabIndex = 5;
            this.btnStaging2.Text = "Staging 2";
            this.btnStaging2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaging2.UseVisualStyleBackColor = false;
            this.btnStaging2.Click += new System.EventHandler(this.btnStaging2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picPending1
            // 
            this.picPending1.BackColor = System.Drawing.Color.LightGray;
            this.picPending1.Image = global::MiniProject.Properties.Resources.timer_icon;
            this.picPending1.Location = new System.Drawing.Point(427, 60);
            this.picPending1.Name = "picPending1";
            this.picPending1.Size = new System.Drawing.Size(61, 61);
            this.picPending1.TabIndex = 7;
            this.picPending1.TabStop = false;
            this.picPending1.Visible = false;
            // 
            // picPending2
            // 
            this.picPending2.BackColor = System.Drawing.Color.LightGray;
            this.picPending2.Image = global::MiniProject.Properties.Resources.timer_icon;
            this.picPending2.Location = new System.Drawing.Point(631, 60);
            this.picPending2.Name = "picPending2";
            this.picPending2.Size = new System.Drawing.Size(61, 61);
            this.picPending2.TabIndex = 8;
            this.picPending2.TabStop = false;
            this.picPending2.Visible = false;
            // 
            // picPending3
            // 
            this.picPending3.BackColor = System.Drawing.Color.LightGray;
            this.picPending3.Image = global::MiniProject.Properties.Resources.timer_icon;
            this.picPending3.Location = new System.Drawing.Point(427, 338);
            this.picPending3.Name = "picPending3";
            this.picPending3.Size = new System.Drawing.Size(61, 61);
            this.picPending3.TabIndex = 9;
            this.picPending3.TabStop = false;
            this.picPending3.Visible = false;
            // 
            // picPending4
            // 
            this.picPending4.BackColor = System.Drawing.Color.LightGray;
            this.picPending4.Image = global::MiniProject.Properties.Resources.timer_icon;
            this.picPending4.Location = new System.Drawing.Point(631, 338);
            this.picPending4.Name = "picPending4";
            this.picPending4.Size = new System.Drawing.Size(61, 61);
            this.picPending4.TabIndex = 10;
            this.picPending4.TabStop = false;
            this.picPending4.Visible = false;
            // 
            // picPending11
            // 
            this.picPending11.BackColor = System.Drawing.Color.LightGray;
            this.picPending11.Image = global::MiniProject.Properties.Resources.timer_icon;
            this.picPending11.Location = new System.Drawing.Point(142, 60);
            this.picPending11.Name = "picPending11";
            this.picPending11.Size = new System.Drawing.Size(61, 61);
            this.picPending11.TabIndex = 11;
            this.picPending11.TabStop = false;
            this.picPending11.Visible = false;
            // 
            // picPending12
            // 
            this.picPending12.BackColor = System.Drawing.Color.LightGray;
            this.picPending12.Image = global::MiniProject.Properties.Resources.timer_icon;
            this.picPending12.Location = new System.Drawing.Point(142, 338);
            this.picPending12.Name = "picPending12";
            this.picPending12.Size = new System.Drawing.Size(61, 61);
            this.picPending12.TabIndex = 12;
            this.picPending12.TabStop = false;
            this.picPending12.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, -5);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(93, 31);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "Score:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 26);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(86, 31);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "Lives:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(111, -5);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(29, 31);
            this.lblScore.TabIndex = 16;
            this.lblScore.Text = "0";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.Color.Transparent;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(111, 26);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(29, 31);
            this.lblLives.TabIndex = 17;
            this.lblLives.Text = "3";
            // 
            // timerFall1
            // 
            this.timerFall1.Interval = 10000;
            this.timerFall1.Tick += new System.EventHandler(this.timerFall1_Tick);
            // 
            // timerFall2
            // 
            this.timerFall2.Interval = 10000;
            this.timerFall2.Tick += new System.EventHandler(this.timerFall2_Tick);
            // 
            // timerFall3
            // 
            this.timerFall3.Interval = 10000;
            this.timerFall3.Tick += new System.EventHandler(this.timerFall3_Tick);
            // 
            // timerFall4
            // 
            this.timerFall4.Interval = 10000;
            this.timerFall4.Tick += new System.EventHandler(this.timerFall4_Tick);
            // 
            // timerAddBoxes
            // 
            this.timerAddBoxes.Interval = 10000;
            this.timerAddBoxes.Tick += new System.EventHandler(this.timerAddBoxes_Tick);
            // 
            // timerOverflow
            // 
            this.timerOverflow.Interval = 21000;
            this.timerOverflow.Tick += new System.EventHandler(this.timerOverflow_Tick);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(232, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(346, 31);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = "Get packages to the trucks!";
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.Location = new System.Drawing.Point(225, 405);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(178, 83);
            this.btnTryAgain.TabIndex = 19;
            this.btnTryAgain.Text = "Try Again";
            this.btnTryAgain.UseVisualStyleBackColor = false;
            this.btnTryAgain.Visible = false;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.Location = new System.Drawing.Point(545, 405);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(187, 83);
            this.btnHighScores.TabIndex = 20;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = false;
            this.btnHighScores.Visible = false;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // picBelt
            // 
            this.picBelt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBelt.BackColor = System.Drawing.Color.Transparent;
            this.picBelt.Image = global::MiniProject.Properties.Resources.normal_belt;
            this.picBelt.Location = new System.Drawing.Point(882, -5);
            this.picBelt.Name = "picBelt";
            this.picBelt.Size = new System.Drawing.Size(138, 530);
            this.picBelt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBelt.TabIndex = 21;
            this.picBelt.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1032, 635);
            this.Controls.Add(this.picBelt);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.picPending12);
            this.Controls.Add(this.picPending11);
            this.Controls.Add(this.picPending4);
            this.Controls.Add(this.picPending3);
            this.Controls.Add(this.picPending2);
            this.Controls.Add(this.picPending1);
            this.Controls.Add(this.btnStaging2);
            this.Controls.Add(this.btnStaging1);
            this.Controls.Add(this.btnPallet4);
            this.Controls.Add(this.btnPallet3);
            this.Controls.Add(this.btnPallet2);
            this.Controls.Add(this.btnPallet1);
            this.Name = "GameForm";
            this.Text = "Sortation Scurry";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPending1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPending2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPending3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPending4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPending11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPending12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBelt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPallet1;
        private System.Windows.Forms.Button btnPallet2;
        private System.Windows.Forms.Button btnPallet3;
        private System.Windows.Forms.Button btnPallet4;
        private System.Windows.Forms.Button btnStaging1;
        private System.Windows.Forms.Button btnStaging2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picPending1;
        private System.Windows.Forms.PictureBox picPending2;
        private System.Windows.Forms.PictureBox picPending3;
        private System.Windows.Forms.PictureBox picPending4;
        private System.Windows.Forms.PictureBox picPending11;
        private System.Windows.Forms.PictureBox picPending12;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer timerFall1;
        private System.Windows.Forms.Timer timerFall2;
        private System.Windows.Forms.Timer timerFall3;
        private System.Windows.Forms.Timer timerFall4;
        private System.Windows.Forms.Timer timerAddBoxes;
        private System.Windows.Forms.Timer timerOverflow;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.PictureBox picBelt;
    }
}