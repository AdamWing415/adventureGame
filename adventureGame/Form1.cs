﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adventureGame
{
    /// <summary>
    /// Adam Wingert 
    /// Adventure Game
    /// 7/4/2020
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //code to load the usercontrol centred on the screen and shift control to the user control
            Form Form1 = this.FindForm();
            Form1.Controls.Remove(this);
            gameScreen s1 = new gameScreen();
            Form1.Controls.Add(s1);
            s1.Location = new Point((Form1.Width - s1.Width) / 2, (Form1.Height - s1.Height) / 2);

        }
    }
}
