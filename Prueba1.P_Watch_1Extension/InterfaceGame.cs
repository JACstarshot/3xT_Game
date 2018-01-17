using Foundation;
using System;
using WatchKit;
using UIKit;




namespace Prueba1.P_Watch_1Extension
{
    public partial class InterfaceGame : WKInterfaceController
    {
        
        bool tirada = true;
        string imagenTurno;

        // X  
        int L1x, L2x, L3x, C1x, C2x, C3x, D1x, D2x=0;

        // O
        int L1o, L2o, L3o, C1o, C2o, C3o, D1o, D2o=0;

        public InterfaceGame(IntPtr handle) : base(handle)
        {
        }

        partial void btn00_activate()
        {
            
           SepColor();
            but00.SetEnabled(false);
            but00.SetBackgroundImage(imagenTurno);

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

        }

        partial void Bur01_Activated()
        {
            SepColor();
            bur01.SetEnabled(false);
            bur01.SetBackgroundImage(imagenTurno);
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
        }

        partial void btn02_activate()
        {
            SepColor();
            butt02.SetEnabled(false);
            butt02.SetBackgroundImage(imagenTurno);
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
        }

        partial void btn10_activate()
        {
            SepColor();
            but10.SetEnabled(false);
            but10.SetBackgroundImage(imagenTurno);
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
        }

        partial void btn11_activate()
        {
            SepColor();
            butt11.SetEnabled(false);
            butt11.SetBackgroundImage(imagenTurno);
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
        }

        partial void btn12_activate()
        {
            SepColor();
            but12.SetEnabled(false);
            but12.SetBackgroundImage(imagenTurno);
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
        }

        partial void btn20_activate()
        {
            SepColor();
            but20.SetEnabled(false);
            but20.SetBackgroundImage(imagenTurno);
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
        }

        partial void btn21_activate()
        {
            SepColor();
            but21.SetEnabled(false);
            but21.SetBackgroundImage(imagenTurno);
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
        }

        partial void btn22_activate()
        {            
            SepColor();
            but22.SetEnabled(false); 
            but22.SetBackgroundImage(imagenTurno);
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

                var controllerNames = new[] { "pageController", "pageController", "pageController", "pageController", "pageController" };
                var contexts = new[] { "First", "Second", "Third", "Fourth", "Fifth" };
                PresentController(controllerNames, contexts);
            }
            if (L1o == 3 || L2o == 3 || L3o == 3 || C1o == 3 || C2o == 3 || C3o == 3 || D1o == 3 || D2o == 3)
            {
                //Win O
                var controllerNames = new[] { "pageController", "pageController", "pageController", "pageController", "pageController" };
                var contexts = new[] { "First", "Second", "Third", "Fourth", "Fifth" };
                PresentController(controllerNames, contexts);
            }

        }

    }
  
}