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

        public InterfaceGame(IntPtr handle) : base(handle)
        {
        }

        partial void btn00_activate()
        {
            SepColor();
            but00.SetEnabled(false);
            but00.SetBackgroundImage(imagenTurno);
        }

        partial void btn01_activate()
        {
            SepColor();
            bur01.SetEnabled(false);
            bur01.SetBackgroundImage(imagenTurno);
        }

        partial void btn02_activate()
        {
            SepColor();
            butt02.SetEnabled(false);
            butt02.SetBackgroundImage(imagenTurno);
        }

        partial void btn10_activate()
        {
            SepColor();
            but10.SetEnabled(false);
            but10.SetBackgroundImage(imagenTurno);
        }

        partial void btn11_activate()
        {
            SepColor();
            butt11.SetEnabled(false);
            butt11.SetBackgroundImage(imagenTurno);
        }

        partial void btn12_activate()
        {
            SepColor();
            but12.SetEnabled(false);
            but12.SetBackgroundImage(imagenTurno);
        }

        partial void btn20_activate()
        {
            SepColor();
            but20.SetEnabled(false);
            but20.SetBackgroundImage(imagenTurno);
        }

        partial void btn21_activate()
        {
            SepColor();
            but21.SetEnabled(false);
            but21.SetBackgroundImage(imagenTurno);
        }

        partial void btn22_activate()
        {            
            SepColor();
            but22.SetEnabled(false); 
            but22.SetBackgroundImage(imagenTurno);
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

        public void testerGame()
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

    }
  
}