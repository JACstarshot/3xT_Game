// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Prueba1.P_Watch_1Extension
{
    [Register ("InterfaceController")]
    partial class InterfaceController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton butt_1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton butt_2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceSwitch switch1p_2p { get; set; }

        [Action ("Butt_1_Activated")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Butt_1_Activated ();

        [Action ("Butt_2_Activated")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Butt_2_Activated ();

        [Action ("Button1_Activated")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Button1_Activated ();

        void ReleaseDesignerOutlets ()
        {
            if (butt_1 != null) {
                butt_1.Dispose ();
                butt_1 = null;
            }

            if (butt_2 != null) {
                butt_2.Dispose ();
                butt_2 = null;
            }

            if (switch1p_2p != null) {
                switch1p_2p.Dispose ();
                switch1p_2p = null;
            }
        }
    }
}