using System;
using Foundation;
using UIKit;

namespace Binding
{
	// @interface SwiftFrameworkProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface SwiftFrameworkProxy
	{
		// -(NSString * _Nonnull)initForApiKey:(NSString * _Nonnull)apiKey __attribute__((objc_method_family("none"))) __attribute__((warn_unused_result));
		[Export ("initForApiKey:")]
		string InitForApiKey (string apiKey);

		// -(void)loginWithProvider:(enum GigyaSocialProvidersProxy)provider viewController:(UIViewController * _Nonnull)viewController completion:(void (^ _Nonnull)(void))completion;
		[Export ("loginWithProvider:viewController:completion:")]
		void LoginWithProvider (GigyaSocialProvidersProxy provider, UIViewController viewController, Action completion);
	}
}
