// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <WatchKit/WatchKit.h>


@interface InterfaceController : WKInterfaceController {
	WKInterfaceButton *_butt_1;
	WKInterfaceButton *_butt_2;
}

@property (nonatomic, retain) IBOutlet WKInterfaceButton *butt_1;

@property (nonatomic, retain) IBOutlet WKInterfaceButton *butt_2;

- (IBAction)Butt_1_Activated;

- (IBAction)Butt_2_Activated;

- (IBAction)Button1_Activated;
@property (unsafe_unretained, nonatomic) IBOutlet WKInterfaceSKScene *skScene;

@end
