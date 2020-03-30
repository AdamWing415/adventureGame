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
            this.label4 = new System.Windows.Forms.Label();
            this.greenButton = new System.Windows.Forms.PictureBox();
            this.blueButton = new System.Windows.Forms.PictureBox();
            this.yellowButton = new System.Windows.Forms.PictureBox();
            this.redButton = new System.Windows.Forms.PictureBox();
            this.EventLabel = new System.Windows.Forms.Label();
            this.ScenePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.greenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScenePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.blueLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.blueLabel.Location = new System.Drawing.Point(101, 580);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(305, 67);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Text = "label1";
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.redLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.redLabel.Location = new System.Drawing.Point(101, 665);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(305, 67);
            this.redLabel.TabIndex = 5;
            this.redLabel.Text = "label2";
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.yellowLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.yellowLabel.Location = new System.Drawing.Point(511, 580);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(305, 67);
            this.yellowLabel.TabIndex = 6;
            this.yellowLabel.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(511, 665);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 67);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
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
            // EventLabel
            // 
            this.EventLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.EventLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.EventLabel.Location = new System.Drawing.Point(12, 14);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(872, 67);
            this.EventLabel.TabIndex = 8;
            this.EventLabel.Text = "label1";
            // 
            // ScenePictureBox
            // 
            this.ScenePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScenePictureBox.InitialImage = null;
            this.ScenePictureBox.Location = new System.Drawing.Point(15, 101);
            this.ScenePictureBox.Name = "ScenePictureBox";
            this.ScenePictureBox.Size = new System.Drawing.Size(869, 464);
            this.ScenePictureBox.TabIndex = 9;
            this.ScenePictureBox.TabStop = false;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.ScenePictureBox);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.label4);
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
            ((System.ComponentModel.ISupportInitialize)(this.greenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScenePictureBox)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.PictureBox ScenePictureBox;
    }
}
