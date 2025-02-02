// <auto-generated/>
#pragma warning disable 1591
namespace Volo.Abp.AspNetCore.RazorViews
{
    #line hidden
    using System;
    using System.Threading.Tasks;
#nullable restore
#line 1 "AbpMvcLibsErrorPage.cshtml"
using Volo.Abp.AspNetCore.RazorViews;

#line default
#line hidden
#nullable disable
    internal class AbpMvcLibsErrorPage : AbpCompilationRazorPageBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "AbpMvcLibsErrorPage.cshtml"
  
    Response.ContentType = "text/html; charset=utf-8";
    Response.StatusCode = 500;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<html>
    <head>
        <meta charset=""utf-8"" />
        <title>Error - The Libs folder is missing!</title>
    </head>
    <body>
        <h1> &#9888;&#65039; The Libs folder under the <code style=""background-color: #e7e7e7;"">wwwroot/libs</code> directory is empty!</h1>

        <p>The Libs folder contains mandatory NPM Packages for running the project.</p>

        <p>Make sure you run the <code style=""background-color: #e7e7e7;"">abp install-libs</code> CLI tool command.</p>

        <p>For more information, check out the <a href=""https://abp.io/docs/latest/CLI#install-libs"">ABP CLI documentation</a></p>
    </body>
</html>
");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
