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
        WatchKit.WKInterfaceImage imgPad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel label1 { get; set; }

        [Action ("Button1_Activated")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Button1_Activated ();

        void ReleaseDesignerOutlets ()
        {
            if (imgPad != null) {
                imgPad.Dispose ();
                imgPad = null;
            }

            if (label1 != null) {
                label1.Dispose ();
                label1 = null;
            }
        }
    }
}