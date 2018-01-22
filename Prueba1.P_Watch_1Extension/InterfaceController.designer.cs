// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
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
        WatchKit.WKInterfaceSeparator sep { get; set; }

        [Outlet]
        WatchKit.WKInterfaceSKScene skScene { get; set; }

        [Action ("Butt_1_Activated")]
        partial void Butt_1_Activated ();

        [Action ("Butt_2_Activated")]
        partial void Butt_2_Activated ();

        [Action ("Button1_Activated")]
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

            if (sep != null) {
                sep.Dispose ();
                sep = null;
            }

            if (skScene != null) {
                skScene.Dispose ();
                skScene = null;
            }
        }
    }
}
