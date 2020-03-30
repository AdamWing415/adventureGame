using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace adventureGame
{
    
    public partial class gameScreen : UserControl
    {
        Random randCheck = new Random();
        double scene = 0;
        int rand;
        public gameScreen()
        {
            InitializeComponent();
        }

        private void gameScreen_Load(object sender, EventArgs e)
        {

        }

       

        private void gameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)//blue button press
            {
                if (scene == 1) { scene = 2; }

                else if (scene == 2)
                {
                    rand = randCheck.Next(1, 4);

                    if (rand == 1) { scene = 9; }
                    else if (rand == 2) { scene = 7; }
                    else if (rand == 3) { scene = 6; }
                }
            

                else if (scene == 3) { scene = 4; }

                else if (scene == 4)
                {
                    rand = randCheck.Next(1, 4);
                    if (rand == 1) { scene = 9; }
                    else if (rand == 2) { scene = 7; }
                    else if (rand == 3) { scene = 6; }
                }

                else if (scene == 5)
                {
                    rand = randCheck.Next(1, 11);
                    if (rand <= 5) { scene = 5.1; }
                    else if (rand == 10) { scene = 5.3; }
                    else { scene = 5.2; }
                }
                else if (scene == 5.1) { scene = 99; }
                else if (scene == 5.2) { scene = 4; }
                else if (scene == 5.3) { scene = 99; }



                else if (scene == 6) { scene = 6.1; }
                else if (scene == 6.1) { scene = 9; }

                else if (scene == 7) { scene = 9; }

                else if (scene == 8) { scene = 8.1; }
                else if (scene == 8.1) { scene = 98; }

                else if (scene == 9) { scene = 10; }

                else if (scene == 10) { scene = 10.1; }
                else if (scene == 10.1) { scene = 13; }

                else if (scene == 11) { scene = 12; }

                else if (scene == 12) { scene = 13; }

                else if (scene == 13) { scene = 13.1; }
                else if (scene == 13.1) { scene = 13.2; }
                else if (scene == 13.2)
                {
                    rand = randCheck.Next(1, 11);
                    if (rand == 1) { scene = 13.3; }
                    else  { scene = 13.4; }
                }
                else if (scene == 13.3) { scene = 99; }
                else if (scene == 13.4) { scene = 14; }

                else if (scene == 14) { scene = 17; }

                else if (scene == 15) { scene = 99; }

                else if (scene == 16) { scene = 16.1; }
                else if (scene == 16.1) { scene = 99; }

                else if (scene == 17) { scene = 18; }

                else if (scene == 18) { scene = 181; }
                else if (scene == 18.1) { scene = 18.2; }
                else if (scene == 18.2) { scene = 20; }

                else if (scene == 19) { scene = 19.1; }
                else if (scene == 19.1) { scene = 21; }

                else if (scene == 20) { scene = 20.1; }
                else if (scene == 20.1) { scene = 20.2; }
                else if (scene == 20.2) { scene = 99; }

                else if (scene == 21) { scene = 23; }

                else if (scene == 22) { scene = 22.1; }
                else if (scene == 22.1) { scene = 22.2; }
                else if (scene == 22.2)
                {
                    rand = randCheck.Next(1, 4);
                    if (rand == 1 ) { scene = 22.3; }
                    else if (rand == 2) { scene = 22.4; }
                    else if (rand == 3) { scene = 22.5; }
                }
                else if (scene == 22.3) { scene = 99; }
                else if (scene == 22.4) { scene = 99; }
                else if (scene == 22.5) { scene = 99; }

                else if (scene == 23) { scene = 27; }

                else if (scene == 24) { scene = 24.1; }
                else if (scene == 24.1) { scene = 26; }

                else if (scene == 25) { scene = 25.1; }
                else if (scene == 25.1) { scene = 99; }

                else if (scene == 26) { scene = 26.1; }
                else if (scene == 26.1) { scene = 29; }

                else if (scene == 27) { scene = 27.1; }
                else if (scene == 27.1) { scene = 22.2; }
                else if (scene == 27.2)
                {
                    rand = randCheck.Next(1, 3);
                       if (rand == 1 ) { scene = 27.3; }
                    else if (rand == 2) { scene = 27.4; }
                
                }
                else if (scene == 27.3) { scene = 99; }
                else if (scene == 27.4) { scene = 98; }

                else if (scene == 28) { scene = 28.1; }
                else if (scene == 28.1) { scene = 99; }

                else if (scene == 29) { scene = 32; }

                else if (scene == 30) { scene = 37.3; }

                else if (scene == 31) { scene = 37.4; }

                else if (scene == 32) { scene = 33; }

                else if (scene == 33) { scene = 34; }

                else if (scene == 34) { scene = 35; }

                else if (scene == 35) { scene = 35.1; }
                else if (scene == 35.1) { scene = 35.2; }
                else if (scene == 35.2) { scene = 35.3; }
                else if (scene == 35.3) { scene = 27.4; }

                else if (scene == 36) { scene = 99; }

                else if (scene == 37) { scene = 37.1; }
                else if (scene == 37.1)
                {
                    rand = randCheck.Next(1, 6);
                    if (rand == 1 || rand == 2 || rand == 3) { scene = 37.3; }
                    else if (rand == 4 || rand == 5) { scene = 37.2; }
                }
                else if (scene == 37.2) { scene = 99; }
                else if (scene == 37.3) { scene = 37.4; }
                else if (scene == 37.4) { scene = 39; }

                else if (scene == 38) { scene = 38.1; }
                else if (scene == 38.1) { scene = 38.2; }
                else if (scene == 38.2) { scene = 38.3; }
                else if (scene == 38.3)
                {
                    rand = randCheck.Next(1, 6);
                    if (rand == 1) { scene = 38.4; }
                    else if (rand == 2||rand == 3) { scene = 38.5; }
                    else if (rand == 4 || rand == 5) { scene = 38.6; }
                }
                else if (scene == 38.4) { scene = 99; }
                else if (scene == 38.5) { scene = 38.6; }
                else if (scene == 38.6) { scene = 38.7; }
                else if (scene == 38.7) { scene = 40; }

                else if (scene == 39) { scene = 39.1; }
                else if (scene == 39.1) { scene = 39.2; }
                else if (scene == 39.2) { scene = 99; }

                else if (scene == 40) { scene = 40.1; }
                else if (scene == 40.1) { scene = 40.2; }
                else if (scene == 40.2) { scene = 40.3; }
                else if (scene == 40.3) { scene = 97; }

                else if (scene == 41) { scene = 41.1; }
                else if (scene == 41.1) { scene = 40.1; }

                else if (scene == 97) { scene = 1; }

                else if (scene == 98) { scene = 1; }

                else if (scene == 99) { scene = 1; }
                

            }
            else if (e.KeyCode == Keys.M) //red button pressed
            {
                if (scene == 1) { }

                else if (scene == 2) { }

                else if (scene == 3) { }

                else if (scene == 7) { }

                else if (scene == 8.1) { }

                else if (scene == 9) { }

                else if (scene == 11) { }

                else if (scene == 13.4) { }

                else if (scene == 14) { }

                else if (scene == 17) { }

                else if (scene == 18.2) { }

                else if (scene == 21) { }

                else if (scene == 23) { }

                else if (scene == 24.1) { }

                else if (scene == 26.1) { }

                else if (scene == 29) { }

                else if (scene == 32) { }

                else if (scene == 33) { }

                else if (scene == 34) { }

                else if (scene == 37.4) { }

                else if (scene == 38.7) { }

                else if (scene == 97) { System.Windows.Forms.Application.Exit(); }

                else if (scene == 98) { System.Windows.Forms.Application.Exit(); }

                else if (scene == 99) { System.Windows.Forms.Application.Exit(); }
            }
            else if (e.KeyCode == Keys.N) //yellow button pressed
            {
                if (scene == 14) { }

                else if (scene == 26.1) { }

                else if (scene == 29) { }

                else if (scene == 32) { }

                else if (scene == 33) { }

                else if (scene == 34) { }
            }
            else if (e.KeyCode == Keys.Space) //green button pressed
            {
               
                if (scene == 26.1) { }

            }
            else if (e.KeyCode == Keys.Escape) //pause button pressed
            {

            }

            switch (scene)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;
                case 5.1:
                    break;
                case 5.2:
                    break;
                case 5.3:
                    break;

                case 6:
                    break;
                case 6.1:
                    break;

                case 7:
                    break;

                case 8:
                    break;
                case 8.1:
                    break;

                case 9:
                    break;

                case 10:
                    break;
                case 10.1:
                    break;

                case 11:
                    break;

                case 12:
                    break;

                case 13:
                    break;
                case 13.1:
                    break;
                case 13.2:
                    break;
                case 13.3:
                    break;
                case 13.4:
                    break;

                case 14:
                    break;

                case 15:
                    break;

                case 16:
                    break;
                case 16.1:
                    break;

                case 17:
                    break;

                case 18:
                    break;
                case 18.1:
                    break;
                case 18.2:
                    break;

                case 19:
                    break;
                case 19.1:
                    break;

                case 20:
                    break;
                case 20.1:
                    break;
                case 20.2:
                    break;

                case 21:
                    break;

                case 22:
                    break;
                case 22.1:
                    break;
                case 22.2:
                    break;
                case 22.3:
                    break;
                case 22.4:
                    break;
                case 22.5:
                    break;

                case 23:
                    break;

                case 24:
                    break;
                case 24.1:
                    break;

                case 25:
                    break;
                case 25.1:
                    break;

                case 26:
                    break;
                case 26.1:
                    break;

                case 27:
                    break;
                case 27.1:
                    break;
                case 27.2:
                    break;
                case 27.3:
                    break;
                case 27.4:
                    break;

                case 28:
                    break;
                case 28.1:
                    break;

                case 29:
                    break;

                case 30:
                    break;

                case 31:
                    break;

                case 32:
                    break;

                case 33:
                    break;

                case 34:
                    break;

                case 35:
                    break;
                case 35.1:
                    break;
                case 35.2:
                    break;
                case 35.3:
                    break;

                case 36:
                    break;

                case 37:
                    break;
                case 37.1:
                    break;
                case 37.2:
                    break;
                case 37.3:
                    break;
                case 37.4:
                    break;

                case 38:
                    break;
                case 38.1:
                    break;
                case 38.2:
                    break;
                case 38.3:
                    break;
                case 38.4:
                    break;
                case 38.5:
                    break;
                case 38.6:
                    break;
                case 38.7:
                    break;

                case 39:
                    break;
                case 39.1:
                    break;
                case 39.2:
                    break;

                case 40:
                    break;
                case 40.1:
                    break;
                case 40.2:
                    break;
                case 40.3:
                    break;

                case 41:
                    break;
                case 41.1:
                    break;

                case 97:
                    break;

                case 98:
                    break;

                case 99:
                    break;
            }
        }
    }
}
