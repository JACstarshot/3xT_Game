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
    [Register ("InterfaceGame")]
    partial class InterfaceGame
    {
        [Outlet]
        WatchKit.WKInterfaceButton bur01 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceButton but00 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceButton but10 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceButton but12 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceButton but20 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceButton but21 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceButton but22 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceButton butt02 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceButton butt11 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceGroup horizontal1 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceGroup horizontal2 { get; set; }

        [Outlet]
        WatchKit.WKInterfaceGroup horizontal3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceSeparator sep1 { get; set; }

        [Action ("m1")]
        partial void m1 ();

        [Action ("btn00_activate")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btn00_activate ();

        [Action ("btn02_activate")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btn02_activate ();

        [Action ("btn10_activate")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btn10_activate ();

        [Action ("btn11_activate")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btn11_activate ();

        [Action ("btn12_activate")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btn12_activate ();

        [Action ("btn20_activate")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btn20_activate ();

        [Action ("btn21_activate")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btn21_activate ();

        [Action ("btn22_activate")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btn22_activate ();

        [Action ("Bur01_Activated")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Bur01_Activated ();

        void ReleaseDesignerOutlets ()
        {
            if (bur01 != null) {
                bur01.Dispose ();
                bur01 = null;
            }

            if (but00 != null) {
                but00.Dispose ();
                but00 = null;
            }

            if (but10 != null) {
                but10.Dispose ();
                but10 = null;
            }

            if (but12 != null) {
                but12.Dispose ();
                but12 = null;
            }

            if (but20 != null) {
                but20.Dispose ();
                but20 = null;
            }

            if (but21 != null) {
                but21.Dispose ();
                but21 = null;
            }

            if (but22 != null) {
                but22.Dispose ();
                but22 = null;
            }

            if (butt02 != null) {
                butt02.Dispose ();
                butt02 = null;
            }

            if (butt11 != null) {
                butt11.Dispose ();
                butt11 = null;
            }

            if (horizontal1 != null) {
                horizontal1.Dispose ();
                horizontal1 = null;
            }

            if (horizontal2 != null) {
                horizontal2.Dispose ();
                horizontal2 = null;
            }

            if (horizontal3 != null) {
                horizontal3.Dispose ();
                horizontal3 = null;
            }

            if (sep1 != null) {
                sep1.Dispose ();
                sep1 = null;
            }
        }
    }
}