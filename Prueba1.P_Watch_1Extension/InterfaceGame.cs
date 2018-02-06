using Foundation;
using System;
using WatchKit;
using UIKit;


namespace Prueba1.P_Watch_1Extension
{
    
    public partial class InterfaceGame : WKInterfaceController
    {       
        bool _turn = true;
        string imageTurn;
        int _countTurn = 0;

        // X  
        int L1x, L2x, L3x, C1x, C2x, C3x, D1x, D2x = 0;

        // O
        int L1o, L2o, L3o, C1o, C2o, C3o, D1o, D2o = 0;

        public InterfaceGame(IntPtr handle) : base(handle)
        {
            
        }

        partial void btn1_activate()
        {
            SeparatorColor();
            btn1.SetEnabled(false);
            btn1.SetBackgroundImage(imageTurn);

            if (_turn == true) {
                L1x++;
                C1x++;
                D1x++;
            }
            else{
                L1o++;
                C1o++;
                D1o++;
            }
            CheckGame();

        }

        partial void btn2_activate()
        {
            SeparatorColor();
            btn2.SetEnabled(false);
            btn2.SetBackgroundImage(imageTurn);
            if (_turn == true)
            {
                L1x++;
                C2x++;
            }
            else
            {
                L1o++;
                C2o++;
            }
            CheckGame();
        }

        partial void btn3_activate()
        {
            SeparatorColor();
            btn3.SetEnabled(false);
            btn3.SetBackgroundImage(imageTurn);
            if (_turn == true)
            {
                L1x++;
                C3x++;
                D2x++;
            }
            else
            {
                L1o++;
                C3o++;
                D2o++;
            }
            CheckGame();
        }

        partial void btn4_activate()
        {
            SeparatorColor();
            btn4.SetEnabled(false);
            btn4.SetBackgroundImage(imageTurn);
            if (_turn == true)
            {
                L2x++;
                C1x++;
            }
            else
            {
                L2o++;
                C1o++;
            }
            CheckGame();
        }

        partial void btn5_activate()
        {
            SeparatorColor();
            btn5.SetEnabled(false);
            btn5.SetBackgroundImage(imageTurn);
            if (_turn == true)
            {
                L2x++;
                C2x++;
                D1x++;
                D2x++;
            }
            else
            {
                L2o++;
                C2o++;
                D1o++;
                D2o++;
            }
            CheckGame();
        }

        partial void btn6_activate()
        {
            SeparatorColor();
            btn6.SetEnabled(false);
            btn6.SetBackgroundImage(imageTurn);
            if (_turn == true)
            {
                L2x++;
                C3x++;
            }
            else
            {
                L2o++;
                C3o++;
            }
            CheckGame();
        }

        partial void btn7_activate()
        {
            SeparatorColor();
            btn7.SetEnabled(false);
            btn7.SetBackgroundImage(imageTurn);
            if (_turn == true)
            {
                L3x++;
                C1x++;
                D2x++;
            }
            else
            {
                L3o++;
                C1o++;
                D2o++;
            }
            CheckGame();
        }

        partial void btn8_activate()
        {
            SeparatorColor();
            btn8.SetEnabled(false);
            btn8.SetBackgroundImage(imageTurn);
            if (_turn == true)
            {
                L3x++;
                C2x++;
            }
            else
            {
                L3o++;
                C2o++;
            }
            CheckGame();           
        }

        partial void btn9_activate()
        {            
            SeparatorColor();
            btn9.SetEnabled(false); 
            btn9.SetBackgroundImage(imageTurn);
            if (_turn == true)
            {
                L3x++;
                C3x++;
                D1x++;
            }
            else
            {
                L3o++;
                C3o++;
                D1o++;
            }
            CheckGame();
        }

        public void SeparatorColor()
        {
            if (_turn == true)
            {
                sep1.SetColor(UIColor.Red);
                _turn = false;
                imageTurn = "Oval.png";
            }
            else
            {
                sep1.SetColor(UIColor.Green);
                _turn = true;
                imageTurn = "Combined Shape.png";
            }   
        }

        public void CheckGame()
        {  
            _countTurn++;

            if (L1x == 3 || L2x == 3 || L3x == 3 || C1x == 3 || C2x == 3 || C3x == 3 || D1x == 3 || D2x == 3)
            {
                //Win X  
                btnWin2.SetHidden(false);
                btnWin2.SetTitle("Win X!");
            }
            else if (_countTurn > 8)
            {
                btnWin2.SetHidden(false);
                btnWin2.SetTitle("Tie!");
            }


            if (L1o == 3 || L2o == 3 || L3o == 3 || C1o == 3 || C2o == 3 || C3o == 3 || D1o == 3 || D2o == 3)
            {
                //Win O
                btnWin2.SetHidden(false);
                btnWin2.SetTitle("Win O!");
            }
            else if (_countTurn > 8)
            {
                btnWin2.SetHidden(false);
                btnWin2.SetTitle("Tie!");
            }
        }

    }
  
}