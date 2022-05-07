using Android.App;
using Android.Runtime;

namespace ChatApp;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
		Microsoft.Maui.Handlers.EntryHandler.Mapper.Add("RemoveBorder", (h, w) => {
			h.PlatformView.Background = null;
		});
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
