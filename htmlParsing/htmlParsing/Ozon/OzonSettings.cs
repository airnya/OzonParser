using htmlParsing.Core;


namespace htmlParsing.Ozon
{
    class OzonSettings : IParserSettings
    {
 //       public OzonSettings(int start, int end)
        public OzonSettings(string id)
        {
            Prefix = id;             
        }

        public string BaseUrl { get; set; } = "https://www.ozon.ru/context/detail/id/";


        public string Prefix { get; set; }
        //        public string Prefix { get; set; } = "31249554";
        public int StartPoint { get; set; }

        public int EndPoint { get; set; } 
    }
}
