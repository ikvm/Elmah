#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elmah
{
    
    #line 2 "..\..\MasterPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\MasterPage.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 4 "..\..\MasterPage.cshtml"
    using Elmah;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.3.2.0")]
    internal partial class MasterPage : WebTemplateBase
    {
#line hidden

        #line 7 "..\..\MasterPage.cshtml"

    public string Title { get; set; }
    public object Footnote { get; set; }
    public IEnumerable<SpeedBar.FormattedItem> SpeedBarItems { get; set; }

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






WriteLiteral("\r\n");


            
            #line 12 "..\..\MasterPage.cshtml"
  
    var basePageName = Request.ServerVariables["URL"];
    
    var now = DateTime.Now;
    var tz = TimeZone.CurrentTimeZone;
    
    var about = PoweredBy.GetAbout(Context.Cache, (version, fileVersion, product, copyright) => new
    {
        Version   = version != null
                  ? version.ToString()
                  : fileVersion != null 
                  ? fileVersion.ToString() 
                  : "?.?.?.?",
        Product   = Mask.EmptyString(product, "(product)"),
        Copyright = copyright,
    });

    var speedBarItems = (SpeedBarItems ?? Enumerable.Empty<SpeedBar.FormattedItem>()).ToArray();


            
            #line default
            #line hidden
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    <head>\r\n");


            
            #line 34 "..\..\MasterPage.cshtml"
         if (!string.IsNullOrEmpty(Title))
        {

            
            #line default
            #line hidden
WriteLiteral("            <title>");


            
            #line 36 "..\..\MasterPage.cshtml"
              Write(Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n");


            
            #line 37 "..\..\MasterPage.cshtml"
        }
        
            
            #line default
            #line hidden

            
            #line 38 "..\..\MasterPage.cshtml"
                                                  

            
            #line default
            #line hidden
WriteLiteral(@"        <!-- Le HTML5 shim, for IE6-8 support of HTML elements -->
        <!--[if lt IE 9]>
          <script src=""http://html5shim.googlecode.com/svn/trunk/html5.js""></script>
        <![endif]-->
        <link rel=""stylesheet"" type=""text/css"" href=""");


            
            #line 43 "..\..\MasterPage.cshtml"
                                                Write(basePageName);

            
            #line default
            #line hidden
WriteLiteral("/stylesheet?h=");


            
            #line 43 "..\..\MasterPage.cshtml"
                                                                           Write(Uri.EscapeDataString(StyleSheetHelper.StylesheetHash));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n        <style type=\"text/css\">\r\n          body {\r\n            padding-top:" +
" 60px;\r\n          }\r\n        </style>\r\n    </head>\r\n    <body>\r\n");


            
            #line 51 "..\..\MasterPage.cshtml"
         if (speedBarItems.Any())
        {

            
            #line default
            #line hidden
WriteLiteral(@"            <div id=""topnavbar"" class=""navbar navbar-fixed-top"">
                <div class=""navbar-inner"">
                    <div class=""container"">
                        <a class=""brand"" href=""http://elmah.googlecode.com/"">ELMAH</a>
                        ");


            
            #line 57 "..\..\MasterPage.cshtml"
                   Write(SpeedBar.Render(Request.Browser, speedBarItems));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");


            
            #line 61 "..\..\MasterPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div class=\"container-fluid\">\r\n            \r\n            ");


            
            #line 64 "..\..\MasterPage.cshtml"
       Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            \r\n            <footer id=\"Footer\">\r\n                <span>Powered b" +
"y <a href=\"http://elmah.googlecode.com/\">");


            
            #line 67 "..\..\MasterPage.cshtml"
                                                                   Write(about.Product);

            
            #line default
            #line hidden
WriteLiteral("</a>, \r\n                    version ");


            
            #line 68 "..\..\MasterPage.cshtml"
                       Write(about.Version);

            
            #line default
            #line hidden
WriteLiteral(".\r\n                    ");


            
            #line 69 "..\..\MasterPage.cshtml"
               Write(about.Copyright);

            
            #line default
            #line hidden
WriteLiteral(" \r\n                    Licensed under <a href=\"http://www.apache.org/licenses/LIC" +
"ENSE-2.0\">Apache License, Version 2.0</a>. \r\n                </span>\r\n          " +
"      Server date is ");


            
            #line 72 "..\..\MasterPage.cshtml"
                          Write(now.ToString("D", CultureInfo.InvariantCulture));

            
            #line default
            #line hidden
WriteLiteral(". \r\n                Server time is ");


            
            #line 73 "..\..\MasterPage.cshtml"
                          Write(now.ToString("T", CultureInfo.InvariantCulture));

            
            #line default
            #line hidden
WriteLiteral(". \r\n                All dates and times displayed are in the \r\n                ");


            
            #line 75 "..\..\MasterPage.cshtml"
            Write(tz.IsDaylightSavingTime(now) ? tz.DaylightName : tz.StandardName);

            
            #line default
            #line hidden
WriteLiteral(" zone. \r\n                ");


            
            #line 76 "..\..\MasterPage.cshtml"
           Write(Footnote);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </footer>\r\n        </div>\r\n    </body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
