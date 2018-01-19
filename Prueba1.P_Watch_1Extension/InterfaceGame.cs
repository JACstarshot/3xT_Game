using Foundation;
using System;
using WatchKit;
using UIKit;


namespace Prueba1.P_Watch_1Extension
{
    public partial class InterfaceGame : WKInterfaceController
    {       
        bool tirada = true;
        bool cpu = true;
        string imagenTurno;

        // X  
        int L1x, L2x, L3x, C1x, C2x, C3x, D1x, D2x=0;

        // O
        int L1o, L2o, L3o, C1o, C2o, C3o, D1o, D2o=0;

        public InterfaceGame(IntPtr handle) : base(handle)
        {
            
        }

        partial void btn1_activate()
        {
            SepColor();
            btn1.SetEnabled(false);
            btn1.SetBackgroundImage(imagenTurno);

            Console.WriteLine("{0,1}", "winz");

            Random rnd = new Random();
            rnd.Next(1, 8);
            rnd.Next(1, 8);

            if (tirada == true) {
                L1x++;
                C1x++;
                D1x++;
            }
            else{
                L1o++;
                C1o++;
                D1o++;
            }

            checkGame();

            if (cpu == true)
            {
                cpu_on();    
            }


        }

        partial void btn2_activate()
        {
            SepColor();
            btn2.SetEnabled(false);
            btn2.SetBackgroundImage(imagenTurno);
            if (tirada == true)
            {
                L1x++;
                C2x++;
            }
            else
            {
                L1o++;
                C2o++;
            }
            checkGame();
            if (cpu == true)
            {
                cpu_on();
            }
        }

        partial void btn3_activate()
        {
            SepColor();
            btn3.SetEnabled(false);
            btn3.SetBackgroundImage(imagenTurno);
            if (tirada == true)
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
            checkGame();
            if (cpu == true)
            {
                cpu_on();
            }
        }

        partial void btn4_activate()
        {
            SepColor();
            btn4.SetEnabled(false);
            btn4.SetBackgroundImage(imagenTurno);
            if (tirada == true)
            {
                L2x++;
                C1x++;
            }
            else
            {
                L2o++;
                C1o++;
            }
            checkGame();
            if (cpu == true)
            {
                cpu_on();
            }
        }

        partial void btn5_activate()
        {
            SepColor();
            btn5.SetEnabled(false);
            btn5.SetBackgroundImage(imagenTurno);
            if (tirada == true)
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
            checkGame();
            if (cpu == true)
            {
                cpu_on();
            }
        }

        partial void btn6_activate()
        {
            SepColor();
            btn6.SetEnabled(false);
            btn6.SetBackgroundImage(imagenTurno);
            if (tirada == true)
            {
                L2x++;
                C3x++;
            }
            else
            {
                L2o++;
                C3o++;
            }
            checkGame();
            if (cpu == true)
            {
                cpu_on();
            }
        }

        partial void btn7_activate()
        {
            SepColor();
            btn7.SetEnabled(false);
            btn7.SetBackgroundImage(imagenTurno);
            if (tirada == true)
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
            checkGame();
            if (cpu == true)
            {
                cpu_on();
            }
        }

        partial void btn8_activate()
        {
            SepColor();
            btn8.SetEnabled(false);
            btn8.SetBackgroundImage(imagenTurno);
            if (tirada == true)
            {
                L3x++;
                C2x++;
            }
            else
            {
                L3o++;
                C2o++;
            }
            checkGame();
            if (cpu == true)
            {
                cpu_on();
            }
        }

        partial void btn9_activate()
        {            
            SepColor();
            btn9.SetEnabled(false); 
            btn9.SetBackgroundImage(imagenTurno);
            if (tirada == true)
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
            checkGame();
            if (cpu == true)
            {
                cpu_on();
            }
        }

        public void SepColor()
        {
            if (tirada == true)
            {
                sep1.SetColor(UIColor.Red);
                tirada = false;
                imagenTurno = "o.png";
            }
            else
            {
                sep1.SetColor(UIColor.Green);
                tirada = true;
                imagenTurno = "x.png";
            }   
        }

        public void checkGame()
        {      
            
            if (L1x == 3 || L2x == 3 || L3x == 3 || C1x == 3 || C2x == 3 || C3x == 3 || D1x == 3 || D2x == 3)
            {
                //Win X  

                var controllerNames = new[] { "InterfaceController", "InterfaceGame" };
                var contexts = new[] { "First", "Second"};
                //PresentController(controllerNames, contexts);
                this.PushController("InterfaceController", "First");
            }
            if (L1o == 3 || L2o == 3 || L3o == 3 || C1o == 3 || C2o == 3 || C3o == 3 || D1o == 3 || D2o == 3)
            {
                //Win O
                var controllerNames = new[] { "InterfaceController" };
                var contexts = new[] { "First"};
                PresentController(controllerNames, contexts);
            }

        }

        public void cpu_on()
        {
            //var arrayBtn = new[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            //Random rnd = new Random();
            //int rndBtn = rnd.Next(1,8);

            //var bot = arrayBtn[rndBtn]; 

            //if (bot.IsAccessibilityElement == false)
            //{
            //    bot.SetEnabled(false);
            //    string xyz = bot + "_activate()";
            //    //Self[xyz](); 
            //}

        }

    }
  
}