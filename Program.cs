using System.Reflection;
using System.Resources;
using System.Globalization;
using System.Text;


namespace com.qualitest.test.csharp.examples {
    class Program {

        static ResourceManager resmgr = new ResourceManager("localizationproj.resource", 
                              Assembly.GetExecutingAssembly());


        public static void Main(string[] args) {

            var language = "en";

            if (args.Length != 0)
                language = args[0];

            PrintLocalizationValues("Menu1", language);
            PrintLocalizationValues("Menu2", language);
            PrintLocalizationValues("Button1", language);
            PrintLocalizationValues("Button2", language);

            Console.WriteLine("Program ended.");
        }

        public static void PrintLocalizationValues(String key, String language) {
            var token = resmgr.GetString(key,GetCultureInfo(language));

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Value for {key} in {language} is {token}");
        }

        public static CultureInfo GetCultureInfo(String language) {
            CultureInfo ci;

            switch(language) {
                case "en":
                    ci = new CultureInfo("en-GB");
                    break;
                case "fr":
                    ci = new CultureInfo("fr-FR");
                    break;
                case "zh":
                    ci = new CultureInfo("zh-CN");
                    break;
                default:
                    ci = new CultureInfo("en-GB");
                    break;
            }

            return ci;
        }


    }
}
