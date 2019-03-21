using HtmlAgilityPack;
using htmlParsing.Core;
using htmlParsing.Models;
using htmlParsing.Ozon;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace htmlParsing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        ParserWorker<string[]> parser;
//        int startInt = 0;
//        int endInt = 1;
//        ListView listitems;
//        public String labelText;
        public Book phone { get; set; }

        public AboutPage()
        {
            InitializeComponent();

            phone = new Book
            {
                bookId = "31249554",
                Title = "",
                imgUrl = "ozon-st.cdn.ngenix.net/multimedia/1022948366.jpg"
            };
            BindingContext = this;


            parser = new ParserWorker<string[]>(
                new OzonParser()
                );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
          //  string html = @"<!DOCTYPE html>  
//<html>  
//<body>  
//<h2>HTML Image Parsing</h2>  
//<img src='https://www.w3schools.com/html/img_girl.jpg' alt='Girl in a jacket' width='500' height='600'>  
//</body>  
//</html>  ";
//            var url = "https://oilprice.com/oil-price-charts#prices";
//            var web = new HtmlWeb();
//            var htmlDoc = web.Load(url);
     //       myImage.Source = HtmlParsing(html);
//            myLabel.Text = HtmlParsing(url);
            
        }

/*        string HtmlParsing(string url)
        {
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(url);
            //Getting img src value    
            var imgUrl = document.DocumentNode.Descendants("img").FirstOrDefault().GetAttributeValue("src", null);
            string name = document.DocumentNode
                        .SelectSingleNode("//*[@class='oilprices__table'][1]/tbody/tr[6]/td[2]").InnerText;
            return name;
        }
*/
        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            //  listView.ItemsSource.Add(arg2);
            try
            {
                string h = "https:";
                var BookName = (arg2);
                string newStr = String.Join(" ", BookName);
                Title = newStr;
                myImage.Source = h+newStr;
                phone.imgUrl = h+newStr;
                //                string.Join(",", BookName);
            }
            catch (Exception e)
            {
            throw e;
            }
        }

        private void Parser_OnCompleted(object obj)
        {
            DisplayAlert("Alert", "all works is done", "OK");
        }

        private IParserSettings OzonSettings()
        {
            throw new NotImplementedException();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //           parser.Settings = new OzonSettings(startInt,endInt);

 //           this.BindingContext = new BookViewModel
            parser.Settings = new OzonSettings(phone.bookId);
            parser.Start();
        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

    }
}