using Foundation;
using System;
using WatchKit;
using UIKit;



namespace Prueba1.P_Watch_1Extension
{
    public partial class InterfaceGame : WKInterfaceController
    {
        bool tirada = true;

        public InterfaceGame(IntPtr handle) : base(handle)
        {
        }

        partial void btn00_activate()
        {
            SepColor();
            but00.SetEnabled(false);
        }

        partial void btn01_activate()
        {
            SepColor();
            bur01.SetEnabled(false);
        }

        partial void btn02_activate()
        {
            SepColor();
            butt02.SetEnabled(false);
        }

        partial void btn10_activate()
        {
            SepColor();
            but10.SetEnabled(false);
        }

        partial void btn11_activate()
        {
            SepColor();
            butt11.SetEnabled(false);
        }

        partial void btn12_activate()
        {
            SepColor();
            but12.SetEnabled(false);
        }

        partial void btn20_activate()
        {
            SepColor();
            but20.SetEnabled(false);
        }

        partial void btn21_activate()
        {
            SepColor();
            but21.SetEnabled(false);
        }

        partial void btn22_activate()
        {            
            SepColor();
            but22.SetEnabled(false); 
            //but22.SetBackgroundImage("x.png");
        }

        public void SepColor()
        {
            if (tirada == true)
            {
                sep1.SetColor(UIKit.UIColor.Red);
                tirada = false;
            }
            else
            {
                sep1.SetColor(UIKit.UIColor.Green);
                tirada = true;
            }   
        }

    }
  
}