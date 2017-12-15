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

        [Action ("m1")]
        partial void m1 ();
        
        void ReleaseDesignerOutlets ()
        {
            if (horizontal1 != null) {
                horizontal1.Dispose ();
                horizontal1 = null;
            }

            if (but00 != null) {
                but00.Dispose ();
                but00 = null;
            }

            if (bur01 != null) {
                bur01.Dispose ();
                bur01 = null;
            }

            if (butt02 != null) {
                butt02.Dispose ();
                butt02 = null;
            }

            if (horizontal2 != null) {
                horizontal2.Dispose ();
                horizontal2 = null;
            }

            if (but10 != null) {
                but10.Dispose ();
                but10 = null;
            }

            if (butt11 != null) {
                butt11.Dispose ();
                butt11 = null;
            }

            if (but12 != null) {
                but12.Dispose ();
                but12 = null;
            }

            if (horizontal3 != null) {
                horizontal3.Dispose ();
                horizontal3 = null;
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
        }
    }
}
