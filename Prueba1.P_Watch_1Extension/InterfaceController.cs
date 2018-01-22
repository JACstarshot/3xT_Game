using System;
using UIKit;
using WatchKit;
using Foundation;
using CoreGraphics;
using UIKit;
using CoreMotion;
using SpriteKit;


namespace Prueba1.P_Watch_1Extension
{
  

    public partial class InterfaceController : WKInterfaceController
    {
        
        protected InterfaceController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
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

            Animation2();

            WKRefreshBackgroundTask compass = new WKRefreshBackgroundTask();

        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }


        void Animation2()
        {

            //Create scene
            SKScene escena = new SKScene(size: new CGSize(134, 134));

            escena.ScaleMode = SKSceneScaleMode.AspectFit;
            skScene.PresentScene(escena);


            //Add something
            SKSpriteNode image = SKSpriteNode.FromImageNamed("o.png");

            escena.BackgroundColor = new UIColor(red: 0, green: 0, blue: 0, alpha: 0);
            image.Color = new UIColor(red: 0, green: 0, blue: 0, alpha: 0);
            image.Position = new CGPoint(67, 67);
            image.Size = new CGSize(escena.Size.Width, escena.Size.Height);


            image.RunAction(SKAction.RepeatActionForever(SKAction.RotateToAngle((nfloat)1.55, 2)));// (Grades/60)+(Grades/1800)
            image.RunAction(SKAction.RepeatActionForever(SKAction.RotateToAngle((nfloat)1.55, 2)));
            image.RunAction(SKAction.RepeatActionForever(SKAction.RotateToAngle((nfloat)(6.29 * -1), 4)));


            escena.AddChild(image);
        }

       
    }
}
