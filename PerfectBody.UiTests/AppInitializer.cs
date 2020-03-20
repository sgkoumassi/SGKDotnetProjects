using Xamarin.UITest;

namespace PerfectBody.UiTests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            char n ='';
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile(@"C:\Users\Houssem\Desktop\PerfectBody\PerfectBody\PerfectBody.Android\bin\Release\Perfect_Body.Perfect_Body.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

