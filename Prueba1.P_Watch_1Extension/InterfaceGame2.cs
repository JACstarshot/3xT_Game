using Foundation;
using System;
using WatchKit;
using UIKit;
using System.Collections.Generic;

namespace Prueba1.P_Watch_1Extension
{
    public partial class InterfaceGame2 : WKInterfaceController
    {
        public InterfaceGame2 (IntPtr handle) : base (handle)
        {
        }
        int  _countTurn = 0;
        bool _isTurn = true;
        bool _isCpuTurn = true;
        string imageTurn;
        List<bool> listButton = new List<bool> { true, true, true, true, true, true, true, true, true };

        // X  
        int L1x, L2x, L3x, C1x, C2x, C3x, D1x, D2x = 0;

        // O
        int L1o, L2o, L3o, C1o, C2o, C3o, D1o, D2o = 0;


        //------------------But_activate------------

        partial void btn1_activate(){ _isCpuTurn = true;  Btn1(); }

        partial void btn2_activate(){ _isCpuTurn = true;  Btn2(); }

        partial void btn3_activate(){ _isCpuTurn = true;  Btn3(); }

        partial void btn4_activate(){ _isCpuTurn = true;  Btn4(); }

        partial void btn5_activate(){ _isCpuTurn = true;  Btn5(); }

        partial void btn6_activate(){ _isCpuTurn = true;  Btn6(); }

        partial void btn7_activate(){ _isCpuTurn = true;  Btn7(); }

        partial void btn8_activate(){ _isCpuTurn = true;  Btn8(); }

        partial void btn9_activate(){ _isCpuTurn = true;  Btn9(); }


        //------------------Function_But------------

        public void Btn1()
        {
            SepColor();
            listButton[0]=false;    
            btn1.SetEnabled(false);
            btn1.SetBackgroundImage(imageTurn);

            if (_isTurn == true) {L1x++;C1x++;D1x++;}
            else {L1o++;C1o++;D1o++;}

            checkGame();
            if (_isCpuTurn == true) {  cpu_on(); }
        }

        public void Btn2()
        {
            SepColor();
            listButton[1]=false;  
            btn2.SetEnabled(false);
            btn2.SetBackgroundImage(imageTurn);

            if (_isTurn == true) {L1x++;C2x++;}
            else {L1o++;C2o++;}

            checkGame();
            if (_isCpuTurn == true){  cpu_on(); }
        }

        public void Btn3()
        {
            SepColor();
            listButton[2]=false;  
            btn3.SetEnabled(false);
            btn3.SetBackgroundImage(imageTurn);

            if (_isTurn == true) {L1x++;C3x++;D2x++;}
            else {L1o++;C3o++;D2o++;}

            checkGame();
            if (_isCpuTurn == true){cpu_on();}
        }

        public void Btn4()
        {
            SepColor();
            listButton[3]=false;  
            btn4.SetEnabled(false);
            btn4.SetBackgroundImage(imageTurn);

            if (_isTurn == true) {L2x++;C1x++;}
            else {L2o++;C1o++;}

            checkGame();
            if (_isCpuTurn == true) {cpu_on();}
        }

        public void Btn5()
        {
            SepColor();
            listButton[4]=false;  
            btn5.SetEnabled(false);
            btn5.SetBackgroundImage(imageTurn);

            if (_isTurn == true) {L2x++;C2x++;D1x++;D2x++;}
            else {L2o++;C2o++;D1o++;D2o++;}

            checkGame();
            if (_isCpuTurn == true) {cpu_on();}
        }

        public void Btn6()
        {
            SepColor();
            listButton[5]=false;  
            btn6.SetEnabled(false);
            btn6.SetBackgroundImage(imageTurn);

            if (_isTurn == true) {L2x++;C3x++;}
            else {L2o++;C3o++;}

            checkGame();
            if (_isCpuTurn == true) {cpu_on();}
        }

        public void Btn7()
        {
            SepColor();
            listButton[6]=false;  
            btn7.SetEnabled(false);
            btn7.SetBackgroundImage(imageTurn);

            if (_isTurn == true) {L3x++;C1x++;D2x++;}
            else {L3o++;C1o++;D2o++;}

            checkGame();
            if (_isCpuTurn == true) {cpu_on();}
        }

        public void Btn8()
        {
            SepColor();
            listButton[7]=false;  
            btn8.SetEnabled(false);
            btn8.SetBackgroundImage(imageTurn);

            if (_isTurn == true) {L3x++;C2x++;}
            else {L3o++;C2o++;}

            checkGame();
            if (_isCpuTurn == true) {cpu_on();}
        }

        public void Btn9()
        {
            SepColor();
            listButton[8]=false;  
            btn9.SetEnabled(false);
            btn9.SetBackgroundImage(imageTurn);

            if (_isTurn == true) {L3x++;C3x++;D1x++;}
            else {L3o++;C3o++;D1o++;}

            checkGame();
            if (_isCpuTurn == true) {cpu_on();}
        }


        //------------------Function_Game------------

        public void SepColor()
        {
            if (_isTurn == true)
            {
                sep1.SetColor(UIColor.Red);
                _isTurn = false;
                imageTurn = "Oval.png";
            }
            else
            {
                sep1.SetColor(UIColor.Green);
                _isTurn = true;
                imageTurn = "Combined Shape.png";
            }   
        }

        public void checkGame()
        {
            _countTurn ++;

            if (L1x == 3 || L2x == 3 || L3x == 3 || C1x == 3 || C2x == 3 || C3x == 3 || D1x == 3 || D2x == 3)
            {
                //Win X  
                btnWin.SetHidden(false);
                btnWin.SetTitle("Win X!");
            }
            else if (_countTurn > 8)
            {
                btnWin.SetHidden(false);
                btnWin.SetTitle("Tie!");
                _isCpuTurn = false;
            }
                

            if (L1o == 3 || L2o == 3 || L3o == 3 || C1o == 3 || C2o == 3 || C3o == 3 || D1o == 3 || D2o == 3)
            {
                //Win O
                btnWin.SetHidden(false);
                btnWin.SetTitle("Win O!");
            }
            else if (_countTurn > 8)
            {
                btnWin.SetHidden(false);
                btnWin.SetTitle("Tie!");
                _isCpuTurn = false;
            }

        }

        public void cpu_on()
        {
            Random rnd = new Random();
            int numberRnd = rnd.Next(0, 8);

            var arrayBtn = new[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            while (_isCpuTurn == true)
            {

                if (listButton[numberRnd] == true)
                {
                    var bot = arrayBtn[numberRnd];
                    _isCpuTurn = false;
                    listButton[numberRnd] = false;

                    if (bot == btn1) { Btn1(); }
                    if (bot == btn2) { Btn2(); }
                    if (bot == btn3) { Btn3(); }
                    if (bot == btn4) { Btn4(); }
                    if (bot == btn5) { Btn5(); }
                    if (bot == btn6) { Btn6(); }
                    if (bot == btn7) { Btn7(); }
                    if (bot == btn8) { Btn8(); }
                    if (bot == btn9) { Btn9(); }

                }

                numberRnd = rnd.Next(0, 8);               
            }

        }

    }
  
}