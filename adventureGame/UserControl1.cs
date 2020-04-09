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
using System.Media;

namespace adventureGame
{

    public partial class gameScreen : UserControl
    {
       
        //creates random  variable
        Random randCheck = new Random();
        //initializes variable for scene
        double scene = 1;
        //initializes variable for my random
        int rand;
        //initializes bool for if the game is paused
        bool pause = false;
        //adds a sound to be played when first loaded and later in other scenes
        SoundPlayer warp = new SoundPlayer(Properties.Resources.warp_sound);

        public gameScreen()
        {
            InitializeComponent();
        }

        private void gameScreen_Load(object sender, EventArgs e)
        {
            //activates events for scene 1 on loadup as the case is contained in a keypress event, meaning a key must be pressed for the case to load, which means taht the scene wouldn't display on boot up
            EventLabel.Text = "You enter a new star system";
            redLabel.Text = "Stop here";
            blueLabel.Text = "Continue onward";
            warp.Play();
            ScenePictureBox.Image = Properties.Resources._3planets_enter;
            Refresh();
        }


        //initializes key presses
        private void gameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            //blue button press and subsequent scene changes
            if (e.KeyCode == Keys.B && pause == false)
            {
                if (scene == 1) { scene = 2; }

                else if (scene == 2)
                {
                    //random check for which scene  to continue on to
                    rand = randCheck.Next(1, 4);
                    if (rand == 1) { scene = 9; }
                    else if (rand == 2) { scene = 7; }
                    else if (rand == 3) { scene = 6; }
                }


                else if (scene == 3) { scene = 4; }

                else if (scene == 4)
                {
                    //random check for which scene  to continue on to
                    rand = randCheck.Next(1, 4);
                    if (rand == 1) { scene = 9; }
                    else if (rand == 2) { scene = 7; }
                    else if (rand == 3) { scene = 6; }
                }

                else if (scene == 5)
                {
                    //random check for which scene  to continue on to
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
                    //random check for which scene  to continue on to
                    rand = randCheck.Next(1, 11);
                    if (rand == 1) { scene = 13.3; }
                    else { scene = 13.4; }
                }
                else if (scene == 13.3) { scene = 99; }
                else if (scene == 13.4) { scene = 14; }

                else if (scene == 14) { scene = 17; }

                else if (scene == 15) { scene = 99; }

                else if (scene == 16) { scene = 16.1; }
                else if (scene == 16.1) { scene = 99; }

                else if (scene == 17) { scene = 18; }

                else if (scene == 18) { scene = 18.1; }
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
                    //random check for which scene  to continue on to
                    rand = randCheck.Next(1, 4);
                    if (rand == 1) { scene = 22.3; }
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
                    //random check for which scene  to continue on to
                    rand = randCheck.Next(1, 3);
                    if (rand == 1) { scene = 27.3; }
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
                    //random check for which scene  to continue on to
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
                    //random check for which scene  to continue on to
                    rand = randCheck.Next(1, 6);
                    if (rand == 1) { scene = 38.4; }
                    else if (rand == 2 || rand == 3) { scene = 38.5; }
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

            //red button pressed
            else if (e.KeyCode == Keys.M && pause == false) 
            {
                if (scene == 1) { scene = 3; }

                else if (scene == 2) { scene = 3; }

                else if (scene == 3) { scene = 5; }

                else if (scene == 7) { scene = 8; }

                else if (scene == 8.1) { scene = 21; }

                else if (scene == 9) { scene = 11; }

                else if (scene == 11) { scene = 10; }

                else if (scene == 13.4) { scene = 98; }

                else if (scene == 14) { scene = 16; }

                else if (scene == 17) { scene = 15; }

                else if (scene == 18.2) { scene = 19; }

                else if (scene == 21) { scene = 22; }

                else if (scene == 23) { scene = 24; }

                else if (scene == 24.1) { scene = 25; }

                else if (scene == 26.1) { scene = 36; }

                else if (scene == 29) { scene = 30; }

                else if (scene == 32) { scene = 30; }

                else if (scene == 33) { scene = 30; }

                else if (scene == 34) { scene = 30; }

                else if (scene == 37.4) { scene = 38; }

                else if (scene == 38.7) { scene = 41; }

                //scenes where you can quit, and close the application are here
                else if (scene == 97) { System.Windows.Forms.Application.Exit(); }

                else if (scene == 98) { System.Windows.Forms.Application.Exit(); }

                else if (scene == 99) { System.Windows.Forms.Application.Exit(); }

            }

            //yellow button pressed
            else if (e.KeyCode == Keys.N) 
            {
                if (scene == 14) { scene = 15; }

                else if (scene == 26.1) { scene = 37; }

                else if (scene == 29) { scene = 31; }

                else if (scene == 32) { scene = 31; }

                else if (scene == 33) { scene = 31; }

                else if (scene == 34) { scene = 31; }
            }

            //green button pressed
            else if (e.KeyCode == Keys.Space) 
            {

                if (scene == 26.1) { scene = 28; }

            }

            //pause button pressed
            else if (e.KeyCode == Keys.Escape) //pause button pressed
            {
                //brings up the pause menu 
                pause = true;

                pauseBlue.Show();
                pauseRed.Show();
                resumeLabel.Show();
                exitLabel.Show();
                pauseBack.Show();
                Refresh();
            }
            if (e.KeyCode == Keys.B && pause == true)
            {
                //checks for button press when the game is paused
                pauseBack.Hide();
                pauseBlue.Hide();
                pauseRed.Hide();
                resumeLabel.Hide();
                exitLabel.Hide();
                Refresh();
                pause = false;
            }
            if (e.KeyCode == Keys.M && pause == true)
            {
                //exits the program if teh red button is pressed while paused
                System.Windows.Forms.Application.Exit();
            }
             
            //adds sounds to be used and re-used throughout the scenes
            SoundPlayer whiteNoise = new SoundPlayer(Properties.Resources.spaceWhiteNoise);
            SoundPlayer engine = new SoundPlayer(Properties.Resources.engineNoise);
            SoundPlayer explosion = new SoundPlayer(Properties.Resources.explosion);
            SoundPlayer death = new SoundPlayer(Properties.Resources.deathsound);
            SoundPlayer beep = new SoundPlayer(Properties.Resources.beep);
            SoundPlayer shipFiring = new SoundPlayer(Properties.Resources.ship_shots);
            SoundPlayer crash = new SoundPlayer(Properties.Resources.crash);
            SoundPlayer step = new SoundPlayer(Properties.Resources.footstep);
            SoundPlayer aim = new SoundPlayer(Properties.Resources.gunReady);
            SoundPlayer shoot = new SoundPlayer(Properties.Resources.laser);
            SoundPlayer impact = new SoundPlayer(Properties.Resources.shotimpact);
            SoundPlayer ingameWin = new SoundPlayer(Properties.Resources.win_ingame);
            SoundPlayer kick = new SoundPlayer(Properties.Resources.snowKick);
            SoundPlayer snowman = new SoundPlayer(Properties.Resources.snowman);
            SoundPlayer winScreen = new SoundPlayer(Properties.Resources.win_screen);
            SoundPlayer deathScreen = new SoundPlayer(Properties.Resources.deathScreen);

            //switch statement for scene,  displays propper text, image, buttons, and sound for each scenario
            switch (scene)
            {
                case 1:
                    ScenePictureBox.Image = Properties.Resources._3planets_enter;
                    EventLabel.Text = "You enter a new star system";
                    redLabel.Text = "Stop here";
                    blueLabel.Text = "Continue onward";
                    warp.Play();
                    Refresh();
                    break;

                case 2:
                    ScenePictureBox.Image = Properties.Resources._3planets_enter;
                    EventLabel.Text = "You pass three small planets and continue towards the blackness of empty space";
                    redLabel.Text = "Don't jump to next system";
                    blueLabel.Text = "Jump to next system";
                    whiteNoise.Play();
                    Refresh();
                    break;

                case 3:
                    ScenePictureBox.Image = Properties.Resources._3planets;
                    EventLabel.Text = "You look around and see 3 planets in close orbit to each other around a small star";
                    redLabel.Text = "Move closer";
                    blueLabel.Text = "Continue onward";
                    whiteNoise.Play();
                    Refresh();
                    break;

                case 4:
                    ScenePictureBox.Image = Properties.Resources.warp1;
                    EventLabel.Text = "You warp out of the system";
                    blueLabel.Text = "Continue";
                    redButton.Hide();
                    redLabel.Hide();
                    warp.Play();
                    Refresh();
                    break;

                case 5:
                    ScenePictureBox.Image = Properties.Resources.gravity_pull;
                    EventLabel.Text = "The gravity of the planets proves to great for your ship's engines \n You can feel yourself getting pulled in";
                    blueLabel.Text = "Continue";
                    redButton.Hide();
                    redLabel.Hide();
                    engine.Play();
                    Refresh();
                    break;
                case 5.1:
                    ScenePictureBox.Image = Properties.Resources.explosionPic;
                    EventLabel.Text = "Your ship 's engines fail and you plummet to your death on the planets below";
                    blueLabel.Text = "Continue";
                    explosion.Play();
                    Refresh();
                    break;
                case 5.2:
                    ScenePictureBox.Image = Properties.Resources.warp2;
                    EventLabel.Text = "You steady your throttle and slip ot of the gravitation pull of the planets safely";
                    blueLabel.Text = "Continue";
                    engine.Play();
                    Refresh();
                    break;
                case 5.3:
                    ScenePictureBox.Image = Properties.Resources.explosionPic;
                    EventLabel.Text = "Your ship 's engines fail and you plummet to your death on the planets below";
                    blueLabel.Text = "Continue";
                    explosion.Play();
                    Refresh();
                    break;

                case 6:
                    ScenePictureBox.Image = Properties.Resources.nebula;
                    EventLabel.Text = "You end your jump to find yourself facing the edge of a great nebula";
                    blueLabel.Text = "Continue";
                    warp.Play();
                    redButton.Hide();
                    redLabel.Hide();
                    Refresh();
                    break;
                case 6.1:
                    EventLabel.Text = "Though the sight is pleasing, there is nothing of value in this sector \n  You warp away";
                    blueLabel.Text = "Continue";
                    warp.Play();
                    Refresh();
                    break;

                case 7:
                    ScenePictureBox.Image = Properties.Resources.deadstar_Warp;
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "You arrive in a new system to see a dying star and a few trade vessels still orbiting around some of the dead worlds";
                    blueLabel.Text = "Leave the system";
                    redLabel.Text = "Stay";
                    warp.Play();
                    Refresh();
                    break;

                case 8:
                    ScenePictureBox.Image = Properties.Resources.deadstar_Warp_plus_ships;
                    redButton.Hide();
                    redLabel.Hide();
                    EventLabel.Text = "The dead star looms in front of you, and you see two slick, black ships warp into the system behind you";
                    blueLabel.Text = "Continue";
                    warp.Play();
                    Refresh();
                    break;
                case 8.1:
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "The two ships seem to be headed straight for you";
                    blueLabel.Text = "Warp away";
                    redLabel.Text = "Hold your ground";
                    whiteNoise.Play();
                    Refresh();
                    break;

                case 9:
                    ScenePictureBox.Image = Properties.Resources.warp_trade;
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "You warp to a new star system and see a trade frigate ahead";
                    blueLabel.Text = "Stay put";
                    redLabel.Text = "Approach the frigate";
                    warp.Play();
                    Refresh();
                    break;

                case 10:
                    ScenePictureBox.Image = Properties.Resources.warp_trade_plus_ships;
                    redButton.Hide();
                    redLabel.Hide();
                    EventLabel.Text = "As you prepare to move on, you see a few more ships enter the system, catching your eye";
                    blueLabel.Text = "Continue";
                    warp.Play();
                    Refresh();
                    break;
                case 10.1:
                    EventLabel.Text = "The ships approach the frigate, which you are now just passing on your way out of the system";
                    blueLabel.Text = "Continue";
                    engine.Play();
                    Refresh();
                    break;

                case 11:
                    ScenePictureBox.Image = Properties.Resources.evil_enter;
                    EventLabel.Text = "You fly towards the frigate and see a few more ships warp into the system, clearly eager to trade";
                    blueLabel.Text = "Hail the frigate";
                    redLabel.Text = "Dont hail the frigate";
                    engine.Play();
                    Refresh();
                    break;

                case 12:
                    ScenePictureBox.Image = Properties.Resources.warp_trade_plus_ships;
                    redButton.Hide();
                    redLabel.Hide();
                    EventLabel.Text = "you flip the switch  to open your comms but before you say anything, the new arrivals once again catch  your eye";
                    blueLabel.Text = "Continue";
                    beep.Play();
                    Refresh();
                    break;

                case 13:
                    ScenePictureBox.Image = Properties.Resources.evil_closeup;
                    EventLabel.Text = "The ships are black and shimmering \n Now that they are so close, you can see they appear to be fighters";
                    blueLabel.Text = "Continue";
                    whiteNoise.Play();
                    Refresh();
                    break;
                case 13.1:
                    EventLabel.Text = "Flying in tight formation, the ships don't appear to be slowing as they approach the frigate \n  You see one fly ahead slightly and it disappears behind the bridge of the frigate";
                    blueLabel.Text = "Continue";
                    whiteNoise.Play();
                    Refresh();
                    break;
                case 13.2:
                    ScenePictureBox.Image = Properties.Resources.bridge_closeup;
                    EventLabel.Text = "Suddenly the bridge errupts in a massive explosion, oxygen ripping out from the gaping hole left where the bridge was only moments ago";
                    blueLabel.Text = "Continue";
                    explosion.Play();
                    Refresh();
                    break;
                case 13.3:
                    ScenePictureBox.Image = Properties.Resources.explosionPic;
                    EventLabel.Text = "Your ship is caught in the explosion and you perish";
                    blueLabel.Text = "Continue";
                    death.Play();
                    Refresh();
                    break;
                case 13.4:
                    ScenePictureBox.Image = Properties.Resources.bridge_closeup;
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "You are thrown away from the frigate by the force of the blast and see the black ships soar through the debris, counting four in total";
                    blueLabel.Text = "Pursue the ships";
                    redLabel.Text = "Don't pursue the ships";
                    engine.Play();
                    Refresh();
                    break;

                case 14:
                    ScenePictureBox.Image = Properties.Resources.evil_closeup;
                    yellowButton.Show();
                    yellowLabel.Show();
                    EventLabel.Text = "You slowly begin your approach on the ships, they've slowed their flight and are beginning to group up";
                    blueLabel.Text = "Continue your approach";
                    redLabel.Text = "Fire upon the ships";
                    yellowLabel.Text = "Hail the ships";
                    engine.Play();
                    Refresh();
                    break;

                case 15:
                    ScenePictureBox.Image = Properties.Resources.explosionPic;
                    yellowButton.Hide();
                    yellowLabel.Hide();
                    redLabel.Hide();
                    redButton.Hide();
                    EventLabel.Text = "You open all common channels and ask the ships if they got out of the explosion OK \n They do not respond, instead spinning their ship around and firing on you";
                    blueLabel.Text = "Continue";
                    beep.Play();
                    Refresh();
                    break;

                case 16:
                    ScenePictureBox.Image = Properties.Resources.evil_firing;
                    yellowButton.Hide();
                    yellowLabel.Hide();
                    redLabel.Hide();
                    redButton.Hide();
                    EventLabel.Text = "You lock on and fire, but before the plasma bolt reaches the group of ships, they break into evasive maneuvers \n Your bolt flies straight through the pack and the ships whip around to face you  ";
                    blueLabel.Text = "Continue";
                    shipFiring.Play();
                    Refresh();
                    break;
                case 16.1:
                    EventLabel.Text = "They don't hesitate to fire, ripping your craft to shreds in an instant";
                    blueLabel.Text = "Continue";
                    explosion.Play();
                    Refresh();
                    break;

                case 17:
                    ScenePictureBox.Image = Properties.Resources.approach_in_ship;
                    yellowLabel.Hide();
                    yellowButton.Hide();
                    EventLabel.Text = "Slowly, you continue your flight towards the now near stationary group of ships";
                    blueLabel.Text = "Fire";
                    redLabel.Text = "Hail";
                    whiteNoise.Play();
                    Refresh();
                    break;

                case 18:
                    ScenePictureBox.Image = Properties.Resources.evil_explode;
                    redLabel.Hide();
                    redButton.Hide();
                    yellowLabel.Hide();
                    yellowButton.Hide();
                    EventLabel.Text = "You are close enough to the group now that there is no need to lock on \n You fire on the group, hitting on ship, destroying it instantly";
                    blueLabel.Text = "Continue";
                    shipFiring.Play();
                    Refresh();
                    break;
                case 18.1:
                    EventLabel.Text = "The explosion of the ship's boost drive rips across your vision, engulfing the ship beside it, ripping it's wing straight off, disabling the ship";
                    blueLabel.Text = "Continue";
                    explosion.Play();
                    Refresh();
                    break;
                case 18.2:
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "The two remaining ship whip around to face you and open fire";
                    blueLabel.Text = "Return fire";
                    redLabel.Text = "Flee";
                    shipFiring.Play();
                    Refresh();
                    break;

                case 19:
                    ScenePictureBox.Image = Properties.Resources.warp2;
                    redLabel.Hide();
                    redButton.Hide();
                    EventLabel.Text = "You select a recent destination from your console and warp out, seeing the remaining two ships close behind as you leave the system";
                    blueLabel.Text = "Continue";
                    warp.Play();
                    Refresh();
                    break;
                case 19.1:
                    ScenePictureBox.Image = Properties.Resources.deadstar_Warp_plus_ships;
                    EventLabel.Text = "You arrive to see a dead star looming in front of you \n You also see the black ships arrive behind you";
                    blueLabel.Text = "Continue";
                    whiteNoise.Play();
                    Refresh();
                    break;

                case 20:
                    ScenePictureBox.Image = Properties.Resources.evil_explode;
                    redLabel.Hide();
                    redButton.Hide();
                    EventLabel.Text = "You fire off as much of your arsenal as you can in one burst, striking the ship on the left \n  The ship on the right still stands.";
                    blueLabel.Text = "Continue";
                    shipFiring.Play();
                    Refresh();
                    break;
                case 20.1:
                    EventLabel.Text = "The remaining ship pauses its assault to evade your shots, quickly resuming fire afterwards";
                    blueLabel.Text = "Continue";
                    engine.Play();
                    Refresh();
                    break;
                case 20.2:
                    ScenePictureBox.Image = Properties.Resources.explosionPic;
                    EventLabel.Text = "The ship doesn't slow it's attack, overwhelming you and destroying your ship completely ";
                    blueLabel.Text = "Continue";
                    explosion.Play();
                    Refresh();
                    break;

                case 21:
                    ScenePictureBox.Image = Properties.Resources.evil_firing;
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "The two ship open fire on you, damaging your right engine, forcing you to head towards one of the near-by planets";
                    blueLabel.Text = "Head left";
                    redLabel.Text = "Head right";
                    shipFiring.Play();
                    Refresh();
                    break;

                case 22:
                    ScenePictureBox.Image = Properties.Resources.rock_crash;
                    redLabel.Hide();
                    redButton.Hide();
                    EventLabel.Text = "You hurtle towards a rocky planet, smashing into the surface with considerable force.";
                    blueLabel.Text = "Continue";
                    crash.Play();
                    Refresh();
                    break;
                case 22.1:
                    EventLabel.Text = "You are dashed on the rocks, but barely survive \n As you crawl from the burnt hull of your ship, you discover that your leg is broken.";
                    blueLabel.Text = "Continue";
                    step.Play();
                    step.Play();
                    Refresh();
                    break;
                case 22.2:
                    EventLabel.Text = "The two ships land nearby, and out climb two figures clad in all black armor, they approach you";
                    blueLabel.Text = "Continue";
                    step.Play();
                    step.Play();
                    Refresh();
                    break;
                case 22.3:
                    ScenePictureBox.Image = Properties.Resources.death;
                    EventLabel.Text = "They observe your state silently, before walking off, leaving you to die";
                    blueLabel.Text = "Continue";
                    death.Play();
                    Refresh();
                    break;
                case 22.4:
                    ScenePictureBox.Image = Properties.Resources.death;
                    EventLabel.Text = "As the figures draw near, one draws a sidearm, and fires";
                    blueLabel.Text = "Continue";
                    death.Play();
                    Refresh();
                    break;
                case 22.5:
                    ScenePictureBox.Image = Properties.Resources.death;
                    EventLabel.Text = "As the figures near your location, one draws a knife, hurling it with considerable force into your chest, killing you";
                    blueLabel.Text = "Continue";
                    death.Play();
                    Refresh();
                    break;

                case 23:
                    ScenePictureBox.Image = Properties.Resources.ice_crash;
                    EventLabel.Text = "You land hot on a planet draped in snow \n Exiting your ship, you see the two black ships landing a few hundred meters away ";
                    blueLabel.Text = "Hide";
                    redLabel.Text = "Approach the ships";
                    crash.Play();
                    Refresh();
                    break;

                case 24:
                    ScenePictureBox.Image = Properties.Resources.approach;
                    redLabel.Hide();
                    redButton.Hide();
                    EventLabel.Text = "You climb from the wreckage of your ship, drawing your weapon and advancing towards the pair of sinister black ships";
                    blueLabel.Text = "Continue";
                    aim.Play();
                    Refresh();
                    break;
                case 24.1:
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "A large figure covered in black armor resembling their ship rises from each of the two vessels, rifles in hand";
                    blueLabel.Text = "Aim left";
                    redLabel.Text = "Aim right";
                    Refresh();
                    break;

                case 25:
                    ScenePictureBox.Image = Properties.Resources.stumble;
                    redLabel.Hide();
                    redButton.Hide();
                    EventLabel.Text = "You swing your weapon towards the right figure, firing as it stands \n The shot hits thick armor";
                    blueLabel.Text = "Continue";
                    shoot.Play();
                    Refresh();
                    break;
                case 25.1:
                    EventLabel.Text = "The figure stumbles, but doesn't fall \n The figure on the left has his weapon drawn at this point, it aims and fires.";
                    blueLabel.Text = "Continue";
                    shoot.Play();
                    Refresh();
                    break;

                case 26:
                    ScenePictureBox.Image = Properties.Resources.stumble;
                    redLabel.Hide();
                    redButton.Hide();
                    EventLabel.Text = "You aim and fire at the left figure, you shot glancing off of one of the plates covering the figure's abdomen";
                    blueLabel.Text = "Continue";
                    shoot.Play();
                    Refresh();
                    break;
                case 26.1:
                    redButton.Show();
                    redLabel.Show();
                    yellowLabel.Show();
                    yellowButton.Show();
                    greenButton.Show();
                    greenLabel.Show();
                    EventLabel.Text = "The figure recoils slightly at the impact but remains unharmed \n The figure on the right begins to climb down from his ship, you realize you need a new strategy";
                    blueLabel.Text = "Kick up a cloud of snow";
                    redLabel.Text = "Take cover";
                    yellowLabel.Text = "Fire again";
                    greenLabel.Text = "Charge towards the enemies";
                    impact.Play();
                    Refresh();
                    break;

                case 27:
                    ScenePictureBox.Image = Properties.Resources.hiding;
                    redLabel.Hide();
                    redButton.Hide();
                    EventLabel.Text = "You quickly duck behind the wreckage of your ship and bury yourself in the snow";
                    blueLabel.Text = "Continue";
                    step.Play();
                    Refresh();
                    break;
                case 27.1:
                    EventLabel.Text = "A long time passes where you can hear two entities searching the area \n You feel very cold, but don't dare reveal yourself, they don't seem to be leaving anytime soon.";
                    blueLabel.Text = "Continue";
                    step.Play();
                    step.Play();
                    Refresh();
                    break;
                case 27.2:
                    EventLabel.Text = "You stay still for what feels like eternity before you finally hear the two figures walking off and their ships leaving";
                    blueLabel.Text = "Continue";
                    step.Play();
                    step.Play();
                    Refresh();
                    break;
                case 27.3:
                    ScenePictureBox.Image = Properties.Resources.hiding_dead;
                    EventLabel.Text = "You find yourself unable to move, and suddenly realize that you cannot feel any of your extremities \n You die of hypothermia";
                    blueLabel.Text = "Continue";
                    death.Play();
                    Refresh();
                    break;
                case 27.4:
                    ScenePictureBox.Image = Properties.Resources.trade_post;
                    EventLabel.Text = "You stand up and shake off the snow, spying a trade post in the distance \n You begin your trek towards it, free of the mysterious ships that have caused your current situation.";
                    blueLabel.Text = "Continue";
                    ingameWin.Play();
                    Refresh();
                    break;

                case 28:
                    ScenePictureBox.Image = Properties.Resources.run;
                    redButton.Hide();
                    redLabel.Hide();
                    yellowLabel.Hide();
                    yellowButton.Hide();
                    greenButton.Hide();
                    greenLabel.Hide();
                    EventLabel.Text = "You launch yourself towards the enemy descending the ladder on the right \n Just before you reach him, you spy the figure on the left recovering";
                    blueLabel.Text = "Continue";
                    step.Play();
                    step.Play();
                    step.Play();
                    step.Play();
                    Refresh();
                    break;
                case 28.1:
                    ScenePictureBox.Image = Properties.Resources.death;
                    EventLabel.Text = "The figure stands tall once more, aiming its rifle straight at your head, a red laser burning into your retinas \n It fires.";
                    blueLabel.Text = "Continue";
                    shoot.Play();
                    Refresh();
                    break;

                case 29:
                    ScenePictureBox.Image = Properties.Resources.kickpic;
                    greenButton.Hide();
                    greenLabel.Hide();
                    EventLabel.Text = "You swing your leg in a wide arc around your base, sending a thick mist of white snow shooting off ten feet from you";
                    blueLabel.Text = "Kick more snow";
                    redLabel.Text = "Take cover";
                    yellowLabel.Text = "Charge";
                    kick.Play();
                    Refresh();
                    break;

                case 30:
                    ScenePictureBox.Image = Properties.Resources.aim;
                    redButton.Hide();
                    redLabel.Hide();
                    yellowLabel.Hide();
                    yellowButton.Hide();
                    EventLabel.Text = "You use the white smog to sneak behind a nearby rock and lie in wait \n The smoke begins to clear and you line up a clear shot on the right side enemy";
                    blueLabel.Text = "Continue";
                    step.Play();
                    step.Play();
                    step.Play();
                    step.Play();
                    Refresh();
                    break;

                case 31:
                    ScenePictureBox.Image = Properties.Resources.run;
                    redButton.Hide();
                    redLabel.Hide();
                    yellowLabel.Hide();
                    yellowButton.Hide();
                    EventLabel.Text = "You pierce through the cloud of white haze you've created and catch the enemy on the right by surprise \n throwing it to the ground, you stick your gun between its armor plates, pulling the trigger, killing it ";
                    blueLabel.Text = "Continue";
                    shoot.Play();
                    Refresh();
                    break;

                case 32:
                    ScenePictureBox.Image = Properties.Resources.kickpic;
                    EventLabel.Text = "You repeat your last action, prolonging the mist hanginging around you";
                    blueLabel.Text = "Kick more snow";
                    redLabel.Text = "Take cover";
                    yellowLabel.Text = "Charge";
                    kick.Play();
                    Refresh();
                    break;

                case 33:
                    ScenePictureBox.Image = Properties.Resources.kickpic;
                    EventLabel.Text = "You repeat your last action, prolonging the mist hanginging around you";
                    blueLabel.Text = "Kick more snow";
                    redLabel.Text = "Take cover";
                    yellowLabel.Text = "Charge";
                    kick.Play();
                    Refresh();
                    break;

                case 34:
                    ScenePictureBox.Image = Properties.Resources.kickpic;
                    EventLabel.Text = "You repeat your last action, prolonging the mist hanginging around you";
                    blueLabel.Text = "Kick more snow";
                    redLabel.Text = "Take cover";
                    yellowLabel.Text = "Charge";
                    kick.Play();
                    Refresh();
                    break;

                case 35:
                    ScenePictureBox.Image = Properties.Resources.snowmanPic;
                    redButton.Hide();
                    redLabel.Hide();
                    yellowLabel.Hide();
                    yellowButton.Hide();
                    EventLabel.Text = "There is no more snow for you to kick, your foot sweeps through air \n  The mist settles, revealing...  A snowman!  ";
                    blueLabel.Text = "Continue";
                    snowman.Play();
                    Refresh();
                    break;
                case 35.1:
                    EventLabel.Text = "Your kicks had such precision to them that they managed to create a crude, but recognizable snowman!";
                    blueLabel.Text = "Continue";
                    Refresh();
                    break;
                case 35.2:
                    EventLabel.Text = "Slightly stunned, your armor-clad adversaries stride towards your creation, marveling \n They examine it, giving a nod of approval";
                    blueLabel.Text = "Continue";
                    Refresh();
                    break;
                case 35.3:
                    EventLabel.Text = "They walk back to their ships, satisfied with what they've seen, leaving you sitting in stunned silence for a moment";
                    blueLabel.Text = "Continue";
                    Refresh();
                    break;

                case 36:
                    ScenePictureBox.Image = Properties.Resources.death;
                    redButton.Hide();
                    redLabel.Hide();
                    yellowLabel.Hide();
                    yellowButton.Hide();
                    greenButton.Hide();
                    greenLabel.Hide();
                    EventLabel.Text = "You sprint towards the nearest boulder, but are caught out by the left enemy, recovered from the shot they took \n Their bullets rip through you, killing you instantly";
                    blueLabel.Text = "Continue";
                    shoot.Play();
                    Refresh();
                    break;

                case 37:
                    ScenePictureBox.Image = Properties.Resources.firing;
                    redButton.Hide();
                    redLabel.Hide();
                    yellowLabel.Hide();
                    yellowButton.Hide();
                    greenButton.Hide();
                    greenLabel.Hide();
                    EventLabel.Text = "You fire another shot at the staggered enemy on the left, knocking them over and off their ship \n You turn your attention towards the right side enemy";
                    blueLabel.Text = "Continue";
                    shoot.Play();
                    Refresh();
                    break;
                case 37.1:
                    EventLabel.Text = "It reaches the bottom of the ladder from its ship and reaches up to draw its weapon from its back, exposing its un-armored underarm";
                    blueLabel.Text = "Continue";
                    aim.Play();
                    Refresh();
                    break;
                case 37.2:
                    ScenePictureBox.Image = Properties.Resources.death;
                    EventLabel.Text = "You miss slightly, the shot hitting the cold metal of the ship behind the figure, who finishes drawing its weapon, shooting to kill";
                    blueLabel.Text = "Continue";
                    shoot.Play();
                    Refresh();
                    break;
                case 37.3:
                    ScenePictureBox.Image = Properties.Resources.enemy_death;
                    EventLabel.Text = "You score a hit, sending the figure reeling, blood dripping from the wound, you quickly sprint over finishing the job";
                    blueLabel.Text = "Continue";
                    impact.Play();
                    Refresh();
                    break;
                case 37.4:
                    ScenePictureBox.Image = Properties.Resources.enemy_closeup;
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "There is now only one enemy left, you spin around to face it, standing, seething at the foot of its ship's landing gear \n A scuff is visible on its right abdominal plate";
                    blueLabel.Text = "Pick up the fallen enemy's rifle";
                    redLabel.Text = "Keep your handgun";
                    step.Play();
                    Refresh();
                    break;

                case 38:
                    ScenePictureBox.Image = Properties.Resources.firing;
                    redButton.Hide();
                    redLabel.Hide();
                    EventLabel.Text = "You carefully check your weapon's battery \n Seeing it has seven shots left, you raise your weapon and fire three shots quickly";
                    blueLabel.Text = "Continue";
                    aim.Play();
                    Refresh();
                    break;
                case 38.1:
                    EventLabel.Text = "The shots ring out, striking the chest of the figure, sending it back into the leg of the landing gear";
                    blueLabel.Text = "Continue";
                    impact.Play();
                    Refresh();
                    break;
                case 38.2:
                    ScenePictureBox.Image = Properties.Resources.hang_from_ship;
                    EventLabel.Text = "Suddenly, the ship begins to rise, and you see that the figure has a glowing panel on its arm, controlling the ship remotely \n Grasping the leg of the landing gear, the figure rises into the air, drawing its weapon";
                    blueLabel.Text = "Continue";
                    engine.Play();
                    Refresh();
                    break;
                case 38.3:
                    EventLabel.Text = "It lets loose 7 shots, and you throw yourself to the ground, narrowly avoiding the being hit \n You get back up and face the ship, which is now circling the area";
                    blueLabel.Text = "Continue";
                    shipFiring.Play();
                    Refresh();
                    break;
                case 38.4:
                    ScenePictureBox.Image = Properties.Resources.death;
                    EventLabel.Text = "The ship turns to face you, the main forward guns spark up, eviscerating you in an instant";
                    blueLabel.Text = "Continue";
                    death.Play();
                    Refresh();
                    break;
                case 38.5:
                    EventLabel.Text = "The figure activates the ship's side cannons, but you are prepared and dodge behind a rock, the blasts erupting around you \n You duck back out from behind your cover for only a second";
                    blueLabel.Text = "Continue";
                    step.Play();
                    step.Play();
                    step.Play();
                    step.Play();
                    Refresh();
                    break;
                case 38.6:
                    ScenePictureBox.Image = Properties.Resources.firing;
                    EventLabel.Text = "You raise you gun at the ship and fire two of your last 4 shot, scoring a hit on an exposed area of the engine \n The figure drops from the smoking ship, landing with a crunch in the fresh snow.";
                    blueLabel.Text = "Continue";
                    shoot.Play();
                    Refresh();
                    break;
                case 38.7:
                    ScenePictureBox.Image = Properties.Resources.onworld_explode;
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "The ship begins an uncontrollable spin, sending in into a line of dead trees a few hundred meters away, spewing fire a skyscraper's height into the sky";
                    blueLabel.Text = "Attack";
                    redLabel.Text = "Make for cover";
                    explosion.Play();
                    Refresh();
                    break;

                case 39:
                    ScenePictureBox.Image = Properties.Resources.enemy_closeup;
                    redButton.Hide();
                    redLabel.Hide();
                    EventLabel.Text = "You reach down to pick up the fallen figure's rifle, keeping eyes on the enraged figure the whole while";
                    blueLabel.Text = "Continue";
                    aim.Play();
                    Refresh();
                    break;
                case 39.1:
                    ScenePictureBox.Image = Properties.Resources.death;
                    EventLabel.Text = "You suddenly feel a sharp pain in your neck, no weapon has been draw on your foe's side, you look down slowly.";
                    blueLabel.Text = "Continue";
                    death.Play();
                    Refresh();
                    break;
                case 39.2:
                    EventLabel.Text = "With its last breath, the enemy you thought was finished stabbed you through the base of your neck with a large combat knife \n You fall to the ground shaking and bleed out";
                    blueLabel.Text = "Continue";
                    death.Play();
                    Refresh();
                    break;

                case 40:
                    ScenePictureBox.Image = Properties.Resources.aim;
                    redButton.Hide();
                    redLabel.Hide();
                    EventLabel.Text = "You wait for the figure to rise to its full height, exposing a chip in a plate right at the base of its neck";
                    blueLabel.Text = "Continue";
                    step.Play();
                    Refresh();
                    break;
                case 40.1:
                    ScenePictureBox.Image = Properties.Resources.firing;
                    EventLabel.Text = "You shoot just once and aim to kill";
                    blueLabel.Text = "Continue";
                    shoot.Play();
                    Refresh();
                    break;
                case 40.2:
                    ScenePictureBox.Image = Properties.Resources.enemy_death;
                    EventLabel.Text = "You hit the figure right in the weak link in its armor \n It crumples to the floor, motionless";
                    blueLabel.Text = "Continue";
                    impact.Play();
                    Refresh();
                    break;
                case 40.3:
                    ScenePictureBox.Image = Properties.Resources.landinggear;
                    EventLabel.Text = "It is finally over, you look around at the chaos surrounding you \n You turn back to the only ship left standing and climb in, now free to continue your voyage across the cosmos unheeded \n For now.";
                    blueLabel.Text = "Continue";
                    ingameWin.Play();
                    Refresh();
                    break;

                case 41:
                    ScenePictureBox.Image = Properties.Resources.aim;
                    EventLabel.Text = "You duck behind a rock just as a shot whizzes past you ear \n You wait only a moment before thrusting your gun out ahead of the rest of your body.";
                    blueLabel.Text = "Continue";
                    impact.Play();
                    Refresh();
                    break;
                case 41.1:
                    EventLabel.Text = "You catch the figure reloading and notice a crack in a panel just below the figure's neck";
                    blueLabel.Text = "Continue";
                    aim.Play();
                    Refresh();
                    break;

                case 97:
                    ScenePictureBox.Image = Properties.Resources.fly_off_win;
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "You fly off without looking back, off into the blackness of space \n \n  Congratulations on surviving!";
                    blueLabel.Text = "Play again";
                    redLabel.Text = "Exit game";
                    winScreen.Play();
                    Refresh();
                    break;

                case 98:
                    ScenePictureBox.Image = Properties.Resources.fly_off_runaway;
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "You continue on your way, hoping to put this day's events behind you";
                    blueLabel.Text = "Play again";
                    redLabel.Text = "Exit game";
                    winScreen.Play();
                    Refresh();
                    break;

                case 99:
                    ScenePictureBox.Image = Properties.Resources.death_screen;
                    redButton.Show();
                    redLabel.Show();
                    EventLabel.Text = "You have died.";
                    blueLabel.Text = "Play again";
                    redLabel.Text = "Exit game";
                    deathScreen.Play();
                    Refresh();
                    break;

            }
        }
    }
}
