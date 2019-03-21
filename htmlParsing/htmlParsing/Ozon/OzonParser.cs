using AngleSharp.Html.Dom;
using htmlParsing.Core;
using htmlParsing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace htmlParsing.Ozon
{
    class OzonParser : IParser<string[]>
    {
      //  Book phone { get; set; }

        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
       //     var booktitle = document.QuerySelectorAll("h1").Where(item => item.ClassName != null && item.ClassName.Contains("bItemName")).First();
      //      var author = document.QuerySelectorAll("div[itemprop*='author']").First();
            var img = document.QuerySelectorAll("img[itemprop*='image']").First();
            //document.querySelectorAll("div[id$='foo']")

            // foreach (var item in author)
            // {
            list.Add(img.GetAttribute("src"));
      //      list.Add(author.TextContent);
       //     list.Add(booktitle.TextContent);
          //  }
            //           foreach (var item in items)
            //           {
            //phone.author = item.TextContent;
            //               list.Add(item.TextContent);
            //          }
            return list.ToArray();
        }


    }
}

/*
 *            var list = new List<string>();
          //  var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("post__title_link"));
            var items = document.QuerySelectorAll("h1").Where(item => item.ClassName != null && item.ClassName.Contains("bItemName"));
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();

                //                phone.author = element.QuerySelector("a").GetElementsByClassName("eItemProperties_href");

               ///phone.author = item.TextContent;

    */
