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
        Book phone { get; set; }

        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            // var booktitle = document.QuerySelectorAll("h1").Where(item => item.ClassName != null && item.ClassName.Contains("bItemName")).First();
            //var author = document.QuerySelectorAll("div[itemprop*='author']").First();
            //var author = document.QuerySelectorAll(".eItemProperties_href");
            //var author = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("eItemProperties_text")).First();
            // var img = document.QuerySelectorAll("img").Where(item => item.ClassName != null && item.ClassName.Contains("eMicroGallery_fullImage mVisible")).First();
            //document.querySelectorAll("div[id$='foo']")
            var img = document.QuerySelectorAll("img[itemprop*='image']").First();

            //       var items = document.QuerySelectorAll("h1").Where(item => item.ClassName != null && item.ClassName.Contains("bItemName"));
            //   var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("eItemProperties_href"));
            //var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("eItemProperties_href")).First();
            //  var items = document.QuerySelector("h1").GetElementsByClassName("bItemName");
            //var items = document.QuerySelectorAll("a").Where(item => item.);
            //            foreach (IElement element in document.QuerySelector("a").GetElementsByClassName("eItemProperties_href"))
            //            {
            //}

            // foreach (var item in author)
            // {
            list.Add(img.GetAttribute("src"));
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
