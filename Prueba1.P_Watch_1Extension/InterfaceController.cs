﻿using System;
using UIKit;
using WatchKit;
using Foundation;

namespace Prueba1.P_Watch_1Extension
{
  

    public partial class InterfaceController : WKInterfaceController
    {
        protected InterfaceController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        partial void Butt_1_Activated()
        {
            switch1p_2p.SetOn(false);
        }


        partial void Butt_2_Activated()
        {
            switch1p_2p.SetOn(true);
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine("{0} awake with context", this);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine("{0} will activate", this);
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }
       
    }
}
