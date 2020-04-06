namespace adventureGame
{
    partial class gameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.EventLabel = new System.Windows.Forms.Label();
            this.pauseBack = new System.Windows.Forms.Label();
            this.resumeLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.pauseRed = new System.Windows.Forms.PictureBox();
            this.pauseBlue = new System.Windows.Forms.PictureBox();
            this.ScenePictureBox = new System.Windows.Forms.PictureBox();
            this.greenButton = new System.Windows.Forms.PictureBox();
            this.blueButton = new System.Windows.Forms.PictureBox();
            this.yellowButton = new System.Windows.Forms.PictureBox();
            this.redButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pauseRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScenePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButton)).BeginInit();
            this.SuspendLayout();
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.blueLabel.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.blueLabel.Location = new System.Drawing.Point(101, 580);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(305, 67);
            this.blueLabel.TabIndex = 4;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.redLabel.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.redLabel.Location = new System.Drawing.Point(101, 665);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(305, 67);
            this.redLabel.TabIndex = 5;
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.yellowLabel.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.yellowLabel.Location = new System.Drawing.Point(511, 580);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(305, 67);
            this.yellowLabel.TabIndex = 6;
            this.yellowLabel.Visible = false;
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.greenLabel.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.greenLabel.Location = new System.Drawing.Point(511, 665);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(305, 67);
            this.greenLabel.TabIndex = 7;
            this.greenLabel.Visible = false;
            // 
            // EventLabel
            // 
            this.EventLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.EventLabel.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.EventLabel.Location = new System.Drawing.Point(12, 14);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(872, 118);
            this.EventLabel.TabIndex = 8;
            this.EventLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pauseBack
            // 
            this.pauseBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.pauseBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pauseBack.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseBack.ForeColor = System.Drawing.Color.Azure;
            this.pauseBack.Location = new System.Drawing.Point(231, 211);
            this.pauseBack.Name = "pauseBack";
            this.pauseBack.Size = new System.Drawing.Size(407, 225);
            this.pauseBack.TabIndex = 10;
            this.pauseBack.Text = "PAUSED";
            this.pauseBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pauseBack.Visible = false;
            // 
            // resumeLabel
            // 
            this.resumeLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.resumeLabel.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeLabel.ForeColor = System.Drawing.Color.Azure;
            this.resumeLabel.Location = new System.Drawing.Point(321, 277);
            this.resumeLabel.Name = "resumeLabel";
            this.resumeLabel.Size = new System.Drawing.Size(178, 55);
            this.resumeLabel.TabIndex = 13;
            this.resumeLabel.Text = "RESUME";
            this.resumeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resumeLabel.Visible = false;
            // 
            // exitLabel
            // 
            this.exitLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.exitLabel.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.Azure;
            this.exitLabel.Location = new System.Drawing.Point(333, 350);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(178, 55);
            this.exitLabel.TabIndex = 14;
            this.exitLabel.Text = "EXIT GAME";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitLabel.Visible = false;
            // 
            // pauseRed
            // 
            this.pauseRed.BackColor = System.Drawing.Color.MidnightBlue;
            this.pauseRed.BackgroundImage = global::adventureGame.Properties.Resources.red_50x50;
            this.pauseRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseRed.Location = new System.Drawing.Point(245, 350);
            this.pauseRed.Name = "pauseRed";
            this.pauseRed.Size = new System.Drawing.Size(70, 67);
            this.pauseRed.TabIndex = 11;
            this.pauseRed.TabStop = false;
            this.pauseRed.Visible = false;
            // 
            // pauseBlue
            // 
            this.pauseBlue.BackColor = System.Drawing.Color.MidnightBlue;
            this.pauseBlue.BackgroundImage = global::adventureGame.Properties.Resources.blue_50x50;
            this.pauseBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseBlue.Location = new System.Drawing.Point(245, 277);
            this.pauseBlue.Name = "pauseBlue";
            this.pauseBlue.Size = new System.Drawing.Size(70, 67);
            this.pauseBlue.TabIndex = 12;
            this.pauseBlue.TabStop = false;
            this.pauseBlue.Visible = false;
            // 
            // ScenePictureBox
            // 
            this.ScenePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScenePictureBox.InitialImage = null;
            this.ScenePictureBox.Location = new System.Drawing.Point(15, 135);
            this.ScenePictureBox.Name = "ScenePictureBox";
            this.ScenePictureBox.Size = new System.Drawing.Size(869, 430);
            this.ScenePictureBox.TabIndex = 9;
            this.ScenePictureBox.TabStop = false;
            // 
            // greenButton
            // 
            this.greenButton.BackgroundImage = global::adventureGame.Properties.Resources.green_50x50;
            this.greenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenButton.Location = new System.Drawing.Point(425, 665);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(70, 67);
            this.greenButton.TabIndex = 3;
            this.greenButton.TabStop = false;
            this.greenButton.Visible = false;
            // 
            // blueButton
            // 
            this.blueButton.BackgroundImage = global::adventureGame.Properties.Resources.blue_50x50;
            this.blueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueButton.Location = new System.Drawing.Point(15, 580);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(70, 67);
            this.blueButton.TabIndex = 2;
            this.blueButton.TabStop = false;
            // 
            // yellowButton
            // 
            this.yellowButton.BackgroundImage = global::adventureGame.Properties.Resources.yellow_50x50;
            this.yellowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowButton.Location = new System.Drawing.Point(425, 580);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(70, 67);
            this.yellowButton.TabIndex = 1;
            this.yellowButton.TabStop = false;
            this.yellowButton.Visible = false;
            // 
            // redButton
            // 
            this.redButton.BackgroundImage = global::adventureGame.Properties.Resources.red_50x50;
            this.redButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redButton.Location = new System.Drawing.Point(15, 665);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(70, 67);
            this.redButton.TabIndex = 0;
            this.redButton.TabStop = false;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.pauseRed);
            this.Controls.Add(this.pauseBlue);
            this.Controls.Add(this.resumeLabel);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.pauseBack);
            this.Controls.Add(this.ScenePictureBox);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.redButton);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "gameScreen";
            this.Size = new System.Drawing.Size(900, 750);
            this.Load += new System.EventHandler(this.gameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pauseRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScenePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redButton;
        private System.Windows.Forms.PictureBox yellowButton;
        private System.Windows.Forms.PictureBox blueButton;
        private System.Windows.Forms.PictureBox greenButton;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.PictureBox ScenePictureBox;
        private System.Windows.Forms.Label pauseBack;
        private System.Windows.Forms.PictureBox pauseRed;
        private System.Windows.Forms.PictureBox pauseBlue;
        private System.Windows.Forms.Label resumeLabel;
        private System.Windows.Forms.Label exitLabel;
    }
}
