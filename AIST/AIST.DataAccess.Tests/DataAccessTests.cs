using Microsoft.VisualStudio.TestTools.UnitTesting;
using AIST.DataAccess.AISTDatabaseContext;
using AIST.DataAccess.Repository;
using AIST.DataAccess.AISTModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AIST.DataAccess.Tests
{
    [TestClass]
    public class DataAccessTests
    {
        private DbContextOptionsBuilder<DataAccessDbContext> optionsBuilder;
        private AISTRepository _testAistRepository;

        [TestInitialize]
        public void FixtureSetup()
        {
            //Created DB shell - For testing
            optionsBuilder = new DbContextOptionsBuilder<DataAccessDbContext>();
            optionsBuilder.UseSqlServer("Server=franciscotw7x17;Database=AISTDB;User Id=dev; Password=usg;Trusted_Connection=True;MultipleActiveResultSets=true");

            _testAistRepository = new AISTRepository(new DataAccessDbContext(optionsBuilder.Options));                            
        }

        [TestCleanup]
        public void CleanUp()
        {
            //_dbcontext.Database.Delete();
            //_dbcontext.Database.ExecuteSqlCommand("Delete PagesDatas");
        }

        //[TestMethod, Ignore]
        //public void CreateEmptyDatabaseAndTables()
        //{
        //    using (var context = new DataAccessDbContext(optionsBuilder.Options))
        //    {
        //        context.Database.Create();
        //    }
        //    Console.WriteLine("Database created with empty tables.");
        //}

        [TestMethod]
        public void InsertRangeData()
        {
            var tests = new List<PagesData>();
            tests.Add(new PagesData() { Url = "http://www.ultimatesoftware.com/", HtmlString = HtmlStr, PageType = "Login" });
            tests.Add(new PagesData() { Url = "http://www.ultimatesoftware2.com/", HtmlString = HtmlStr, PageType = "Login2" });
            _testAistRepository.AddRange(tests);
            var allData = _testAistRepository.Get();
            var obj = allData.ElementAt(allData.Count() - 1);

            Assert.AreEqual(obj.Url, "http://www.ultimatesoftware2.com/");
            Assert.AreEqual(obj.HtmlString, HtmlStr);
            Assert.AreEqual(obj.PageType, "Login2");
            _testAistRepository.Delete(obj);
        }

        [TestMethod]
        public void InsertSingleData()
        {
            _testAistRepository.Add(new PagesData() { Url = "http://www.ultimatesoftware3.com/", HtmlString = HtmlStr, PageType = "Login3" });
            var allData = _testAistRepository.Get();
            var obj = allData.ElementAt(allData.Count() - 1);

            Assert.AreEqual(obj.Url, "http://www.ultimatesoftware3.com/");
            Assert.AreEqual(obj.HtmlString, HtmlStr);
            Assert.AreEqual(obj.PageType, "Login3");
            _testAistRepository.Delete(obj);
        }

        string HtmlStr = @"<html class="" js""><head>



<link rel=""canonical"" href=""//www.ultimatesoftware.com"">

<title>
HR Software Solutions &amp; Payroll for Human Capital Management - Ultimate Software</title>


<link rel=""alternate"" href=""http://www.ultimatesoftware.com"" hreflang=""en"">
<link rel=""alternate"" href=""http://es.ultimatesoftware.com"" hreflang=""es"">
<link rel=""alternate"" href=""http://pt.ultimatesoftware.com"" hreflang=""pt"">
<link rel=""alternate"" href=""http://fr.ultimatesoftware.com"" hreflang=""fr"">


<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, minimal-ui, initial-scale=1"">

<meta name=""description"" content=""Ultimate Software specializes in HR software solutions and HR payroll to help you improve your company’s human capital management and benefits administration."">
<meta name=""keywords"" content="""">
<meta name=""verify-v1"" content=""lnPZRfp0sZWjLNzmJeOGL38BKFX8bg4gMRNSMMOlcqU="">
<meta name=""google-site-verification"" content=""SGMr36PYbmrPg4tgTF_Z6sH1yIXPbR6zGlNA7cimVLs"">
<meta name=""msvalidate.01"" content=""1B71286C76146B0B2E2248C548BECCE8"">
<meta property=""og:site_name"" content=""Ultimate Software"">
<meta property=""og:title"" content-type=""string"" content=""Ultimate Software - HR Software Solutions &amp; Payroll for Human Capital Management - Ultimate Software"">
<meta property=""og:type"" content=""website"">
<meta property=""og:description"" content-type=""string"" content=""Ultimate Software specializes in HR software solutions and HR payroll to help you improve your company’s human capital management and benefits administration."">



<meta property=""og:image"" content=""http://ultimarketingweb.blob.core.windows.net/static/images/sharing/ultimate_software_green_white_1200x628.jpg"">
<meta property=""og:image"" content=""http://ultimarketingweb.blob.core.windows.net/static/images/sharing/ultimate_software_green_white_1200x1200.jpg"">
<meta property=""og:image"" content=""http://ultimarketingweb.blob.core.windows.net/static/images/ulti-logo-200x200-2016.jpg"">



<meta name=""twitter:card"" content=""summary"">
<meta name=""twitter:title"" content=""HR Software Solutions &amp; Payroll for Human Capital Management - Ultimate Software"">
<meta name=""twitter:description"" content=""Ultimate Software specializes in HR software solutions and HR payroll to help you improve your company’s human capital management and benefits administration."">
<meta name=""twitter:image"" content=""http://ultimarketingweb.blob.core.windows.net/static/images/ulti-logo-200x200-2016.jpg"">

<meta property=""fb:app_id"" content=""254545457900481"">

<link rel=""dns-prefetch"" href=""//fast.fonts.net"">
<!--[if lte IE 7]>
<link rel=""stylesheet"" href=""/css/styles-ie7.min.css"">
<script src=""/js/ie.min.js""></script>
<![endif]-->

<!--[if (lt IE 9)&(gt IE 7)]>
<link rel=""stylesheet"" href=""/css/styles-ie.min.css"">
<script src=""/js/ie.min.js""></script><![endif]-->
<!--[if gte IE 9]><!-->
<link rel=""stylesheet"" href=""/css/styles.min.css"">
<!-- <![endif]-->


<script src=""http://connect.facebook.net/signals/config/838490652908552?v=2.7.20"" async=""""></script><script async="""" src=""//connect.facebook.net/en_US/fbevents.js""></script><script async="""" id=""demandbase_js_lib"" src=""https://scripts.demandbase.com/5c6f14ad.min.js""></script><script src=""http://pixel.quantserve.com/aquant.js?a=p-87LMPPVKzr-KV"" async="""" type=""text/javascript""></script><script type=""text/javascript"" async="""" src=""//static.hotjar.com/c/hotjar-171677.js?sv=5""></script><script type=""text/javascript"" async="""" src=""http://a.adroll.com/j/roundtrip.js""></script><script type=""text/javascript"" async="""" src=""http://js.bizographics.com/insight.min.js""></script><script type=""text/javascript"" async="""" src=""//www.googleadservices.com/pagead/conversion_async.js""></script><script type=""text/javascript"" async="""" src=""http://www.google-analytics.com/analytics.js""></script><script type=""text/javascript"" async="""" src=""//tag.retargeter.com/rt/1985/rt.min.js?t=17409""></script><script src=""http://pixel.quantserve.com/aquant.js?a=p-87LMPPVKzr-KV"" async="""" type=""text/javascript""></script><script async="""" src=""//www.googletagmanager.com/gtm.js?id=GTM-NJTJ9T""></script><script src=""https://apis.google.com/_/scs/apps-static/_/js/k=oz.gapi.es.b4g76BYrtDE.O/m=plusone/rt=j/sv=1/d=1/ed=1/am=AQ/rs=AGLTcCOsDLTg7l6PUXXam04wE-F5xI1bYA/cb=gapi.loaded_0"" async=""""></script><script>
var language_code = ""EN"";
</script>

<link rel=""stylesheet"" href=""//fast.fonts.net/cssapi/5db5176c-4f30-4d17-bc84-3bec6b00f8ca.css"">

<link rel=""stylesheet"" href=""/css/styles_deltas.min.css"">
<link rel=""stylesheet"" href=""/css/Modules/StockQuote.css"">



<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<link rel=""stylesheet"" href=""//ajax.googleapis.com/ajax/libs/jqueryui/1.11.0/themes/smoothness/jquery-ui.min.css"">
<script src=""//ajax.googleapis.com/ajax/libs/jqueryui/1.11.0/jquery-ui.min.js""></script>


<script src=""/js/utilities.min.js#4""></script>
<script src=""https://apis.google.com/js/plusone.js"" gapi_processed=""true""></script>
<script src=""/js/mp_linkcode.js""></script>
<!--– mp_snippet_begins -->
<script>
MP.UrlLang = 'mp_js_current_lang';
MP.SrcUrl = decodeURIComponent('mp_js_orgin_url');
MP.oSite = decodeURIComponent('mp_js_origin_baseUrl');
MP.tSite = decodeURIComponent('mp_js_translated_baseUrl');
MP.init();
</script>
<!--– mp_snippet_ends -->

<link rel=""stylesheet"" href=""/css/MainMaster.min.css"">

<script>
function switchLanguage(lang) {
MP.SrcUrl = decodeURIComponent('mp_js_orgin_url'); MP.UrlLang = 'mp_js_current_lang'; MP.init();
MP.switchLanguage(MP.UrlLang == lang ? 'en' : lang);
return false;
}
</script>


<meta name=""google-site-verification"" content=""Zgv_R3jHHX-VNV-uDJk2HCNnU6I_WBVOwfN_Uzfq53Y"">
<meta name=""msvalidate.01"" content=""9B4920307FAACD33306C3FF0039919C2"">
<meta property=""twitter:account_id"" content=""24889076"">
<meta name=""p:domain_verify"" content=""ece4b422e2fb03c534e846fe3d90bcbd"">




<!--000000 -->


<style>
/*Banner/Hero Images*/

#carousel-item-1 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-MBanner-1280x445-stress-free-year-end.jpg"");
background-repeat: no-repeat;
background-position: center;
}

#carousel-item-2 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-MBanner-1280x445-gartner-report.jpg"");
background-repeat: no-repeat;
background-position: center;
}

#carousel-item-3 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-MBanner-1280x445-Overview-Tour.jpg"");
background-repeat: no-repeat;
background-position: center;
}

#carousel-item-4 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-MBanner-1280-x-445-top-7-trending-hcm-whitepapers.jpg"");
background-repeat: no-repeat;
background-position: center;
}

#carousel-item-5 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-MBanner-1280-x-445-mobile-ultipro-new.gif"");
background-repeat: no-repeat;
background-position: center;
}

#carousel-item-6 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2016-MBanner-1280-x-445-payroll-tour.jpg"");
background-repeat: no-repeat;
background-position: center;
}


@media (min-width: 1281px)
{


#carousel-item-1 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-LBanner-2560x445-stress-free-year-end.jpg"");
background-repeat: no-repeat;
background-position: center;
}

#carousel-item-2 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-LBanner-2560x445-gartner-report.jpg"");
background-repeat: no-repeat;
background-position: center;
}

#carousel-item-3 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-LBanner-2560x445-Overview-Tour.jpg"");
background-repeat: no-repeat;
background-position: center;
}

#carousel-item-4 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-LBanner-2560-x-445-top-7-trending-hcm-whitepapers.jpg"");
background-repeat: no-repeat;
background-position: center;
}

#carousel-item-5 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-LBanner-2560-x-445-mobile-ultipro-new.gif"");
background-repeat: no-repeat;
background-position: center;
}

#carousel-item-6 
{
background-image: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2016-LBanner-2560-x-445-payroll-tour.jpg"");
background-repeat: no-repeat;
background-position: center;
}

}

@media (max-width: 960px)
{


#carousel-item-1 
{
background: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-Mobile-719x436-stress-free-year-end.jpg"") no-repeat right 20% top;
}


#carousel-item-2 
{
background: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-Mobile-719x436-gartner-report.jpg"") no-repeat right 20% top;
}


#carousel-item-3 
{
background: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-Mobile-719x436-Overview-Tour.jpg"") no-repeat right 20% top;
}


#carousel-item-4 
{
background: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-Mobile-719-x-436-top-7-trending-hcm-whitepapers.jpg"") no-repeat right 20% top;
}


#carousel-item-5 
{
background: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2017-Mobile-719-x-436-mobile-ultipro-new.jpg"") no-repeat right 20% top;
}


#carousel-item-6 
{
background: url(""https://ultimarketingweb.blob.core.windows.net/static/images/banner/2016-Mobile-719-x-436-payroll-tour.jpg"") no-repeat right 20% top;
}


}

</style>
<style>
.callout-line1 {
font-size: 3em !important;
white-space: nowrap;
}

.callout-line2 {
font-size: 2em !important;
}

.callouts__item a {
font-size: 0.5em !important;
text-transform: none;
}
</style>

<script type=""text/javascript"" language=""javascript"">
$(""#hero"").ready(function () {
//alert(navigator.userAgent);
$('#hero').show();
});





</script>

<script>
document.documentElement.className += "" js"";
</script>
<link rel=""alternate"" hreflang=""en"" href=""//www.ultimatesoftware.com"">
<link rel=""alternate"" hreflang=""fr"" href=""//fr.ultimatesoftware.com"">
<link rel=""alternate"" hreflang=""es"" href=""//es.ultimatesoftware.com"">
<link rel=""alternate"" hreflang=""pt"" href=""//pt.ultimatesoftware.com"">

<style>
.h1div {
font-size: 1.8em !important;
}

.h1div h2, .h1div h3 {
font-size: initial !important;
}

.footer a:hover {
color: #00757d !important;
}

.special-footer

{
display: block;
width: 100%;
margin-left: auto;
margin-right: auto;
font-size: small;
color: white;
vertical-align: middle;
text-align: center;
height: 3em;
padding-top: 1em;
padding-bottom: 1em;
}



</style>

<script src=""/Scripts/CustomFunctions.js""></script>

<script>
//// To hide the top menu.
//$(document).ready(function() {
//	$('.utility-nav').hide();
//	$('.mega-nav').hide();
//});

function dropdownNavigate(url) {
if (browserWidth >= 1133) {
window.location = url;
//return facebook_like_link;
}

return true;
}

//function playVideoFromMenu(videoId)
//	{
//	alert(videoId);
//	}
</script>



<script type=""text/javascript"" src=""//cdn.syndication.twimg.com/widgets/timelines/459351629095907328?&amp;lang=en&amp;callback=twitterFetcher.callback&amp;suppress_response_codes=true&amp;rnd=0.669898767679342""></script><script src=""https://s3.amazonaws.com/V3-Assets/prod/client_super_tag/init_super_tag.js""></script><script async=""true"" type=""text/javascript"" src=""https://d.adroll.com/pixel/R7LEOQOQNFEFZMZDEHYTPJ/WWRASU5MLJCIXM2BLHVO62?pv=16538253992.67841&amp;cookie=&amp;adroll_s_ref=&amp;keyw=&amp;arrfrr=http%3A%2F%2Fwww.ultimatesoftware.com%2F""></script><script async="""" src=""https://script.hotjar.com/modules-ceeb053feb6b1e7a866afcb520236aa4.js""></script><style type=""text/css"">iframe#_hjRemoteVarsFrame {display: none !important; width: 1px !important; height: 1px !important; opacity: 0 !important; pointer-events: none !important;}</style><div style=""width: 1px; height: 1px; display: inline; position: absolute;""><img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/aol/out""><img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/index/out""><img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/n/out""><img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/pubmatic/out""><img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/taboola/out""></div><div style=""width: 1px; height: 1px; display: inline; position: absolute;""><img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/r/out"">
<img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/f/out"">
<img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/b/out"">
<img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/w/out"">
<img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/x/out"">
<img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/l/out"">
<img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/o/out"">
<img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""https://d.adroll.com/cm/g/out?google_nid=adroll5"">
</div></head>
<body>
<!-- Google Tag Manager -->
<noscript>
&lt;iframe src=""//www.googletagmanager.com/ns.html?id=GTM-NJTJ9T""
height=""0"" width=""0"" style=""display: none; visibility: hidden""&gt;&lt;/iframe&gt;
</noscript>
<script>(function (w, d, s, l, i) {
w[l] = w[l] || []; w[l].push({
'gtm.start':
new Date().getTime(), event: 'gtm.js'
}); var f = d.getElementsByTagName(s)[0],
j = d.createElement(s), dl = l != 'dataLayer' ? '&l=' + l : ''; j.async = true; j.src =
'//www.googletagmanager.com/gtm.js?id=' + i + dl; f.parentNode.insertBefore(j, f);
})(window, document, 'script', 'dataLayer', 'GTM-NJTJ9T');</script>
<!-- End Google Tag Manager -->

<div class=""noindex"">
<!--[if (lte IE 8)]>
<div style=""background-color: darkred; color: white; font-size: 20px; padding: 3px;"">
Please upgrade your browser to Internet Explorer 9.0 or higher, ensure you are not in ""Compatability Mode"", or use another modern browser, like Chrome or Firefox.
</div>
<![endif]-->


<header class=""page-header"">
<div class=""page-header__utility-bar"">
<div class=""page-header__wrapper"">

<!--mp_global_switch_begins-->
<a mporgnav="""" class=""user-locale"" href=""#"" onclick=""return chooser();
function chooser(){
var script=document.createElement('SCRIPT');
script.src='https://ultimatesoftwarecom.mpeasylink.com/mpel/mpel_chooser.js';
document.body.appendChild(script);
return false;
}"" title=""Switch Languages"">LANGUAGE</a>
<!--mp_global_switch_ends-->


<nav class=""utility-nav"">
<ul>
<!-- mp_trans_remove_start -->
<li class=""utility-nav__item"">
<a title=""Ultimate Software's Blog – Human Capital Management, HR, and Talent Management Topics."" href=""http://www.ultimatesoftware.com/blog"" target=""_blank"">Blog</a>
</li>
<li class=""utility-nav__item"">
<a title=""Explore social media with Ultimate Software to stay up to date on the HR software and payroll software provider
"" href=""/Social"">Social</a>
</li>
<li class=""utility-nav__item"">
<a title=""Stay up to date on all things Ultimate Software to discover the added benefits a HRMS can bring to your company
"" href=""/PR/Newsroom"">Newsroom</a>
</li>
<!-- mp_trans_remove_end -->
<li class=""utility-nav__item"">
<a title=""Contact us to find out to talk to an expert about the added benefits HR, payroll, and talent management software can bring
"" href=""/ContactUs"">Contact</a>
</li>
<!-- mp_trans_remove_start -->
<li class=""utility-nav__item"">
<a title=""Explore the endless possibilites that come from working for the leading HCM software provider
"" href=""/careers-at-ultimate"">Careers</a>
</li>
<!-- mp_trans_remove_end -->
<li class=""utility-nav__item--tan"">
<a target=""_blank"" title=""Log in to your customer account to view your HR and payroll data from anywhere
"" href=""https://ultimate.force.com/csp/s/login/"">Customer Success Portal</a>
</li>
</ul>
</nav>
</div>
</div>
<div class=""page-header__main"">
<div class=""page-header__wrapper"">
<div class=""page-header__logo""><a title=""Ultimate Software - Human Capital Management, HR Software, Payroll Software, Talent Management, and HRIS/HRMS Solutions"" href=""/"">Ultimate Software<!--[if lt IE 9]><img src=""/images/logo.png"" width=""143"" height=""47"" alt=""Ultimate Software logo""/><![endif]--><!--[if gte IE 9]><!--><img alt=""Ultimate Software - Human Capital Management, HR Software, Payroll Software, Talent Management, and HRIS/HRMS Solutions"" src=""/images/logo.svg"" width=""143"" height=""47""><!-- <![endif]--></a></div>
<button id=""hamburger"" class=""hamburger nav-toggle"" aria-hidden=""true""><span></span></button>

<nav class=""mega-nav nav-collapse nav-collapse-0 closed"" aria-hidden=""false"" style=""transition: max-height 284ms; position: relative;"">
<ul>
<!-- mp_trans_remove_start -->
<li class=""mega-nav__item search"">
<form class=""search__form"" action=""/Search_Results.aspx"" method=""post"">
<input id=""searchText"" name=""searchText"" type=""search"" placeholder=""What are you looking for?"" class=""search__input"">
</form>
</li>
<!-- mp_trans_remove_end -->


<li class=""mega-nav__item dropdown"">
<a title=""Cloud based HRIS, UltiPro, to make your payroll software and HR software more efficient."" href=""/HCM-Solutions"" class=""dropdown-toggle"" onclick=""return dropdownNavigate('/HCM-Solutions');"">HCM Solutions</a>


<ul><li class=""mega-nav__special-sub-item""><a href=""/HCM-Solutions"" class=""mega-nav__sub-item"">HCM Solutions</a></li>



<li data-website-menu-id=""0"" class=""mega-nav__sub-item fake-section""><a title=""Cloud based HRIS, UltiPro, to make your payroll software and HR software more efficient."" href=""/HCM-Solutions"" target=""_top"">HCM Solutions Page</a></li>



<li data-website-menu-id=""11"" class=""mega-nav__sub-item ""><a title=""The most flexible, functional payroll software engine on the market, UltiPro does it all"" href=""/UltiPro-Solution-Features"" target=""_top"">UltiPro HCM Features</a></li>



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""1"" class=""mega-nav__sub-item ""><a title=""Video tours to help you learn about human resources management, payroll software, talent management and more
"" href=""/UltiPro-Solution-Tours"" target=""_top"">UltiPro HCM Tours</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""125"" class=""mega-nav__sub-item ""><a title=""UltiPro Services include managed human resource functions, payment services, and printing services 
"" href=""/UltiPro-Services"" target=""_top"">UltiPro Services</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""522"" class=""mega-nav__sub-item ""><a title=""UltiPro Customer Reviews"" href=""/hcm-software-customer-reviews"" target=""_top"">UltiPro Customer Reviews</a></li>

<!-- mp_trans_remove_end -->


</ul>

<aside class=""promos--nav"">
<!-- mp_trans_remove_start -->
<figure class=""promo--vert promo--green-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-180x215-overview-tour.png"" alt=""Discover why when it comes to human capital management (HCM), we believe that technology should work for people — not the other way around."" title=""Discover why when it comes to human capital management (HCM), we believe that technology should work for people — not the other way around."" class=""promo__img--corner"">
<figcaption class=""promo__caption"">
<div class=""h1div"">HCM Solution &amp; Human Resources<br> Software Product Tour</div>
<h2><br><a href=""/contact/hcm-human-resources-payroll-software-tour"">Watch Overview Tour Now </a></h2>
</figcaption>
</figure>


<!-- mp_trans_remove_end -->
<!-- mp_trans_add=""ES,PT,FR""
<figure class=""promo--vert promo--green-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/spotlight/2014-125X153-spotlight-compensation-management.png"" alt=""aquarium"" class=""promo__img--corner"">
<figcaption class=""promo__caption"">
<div class=""h1div"">HCM Solutions</div>
<h2><a href=""/HCM-Solutions?from=menu-promo"">Learn More</a></h2>
</figcaption>
</figure>-->
<figure class=""promo--hori promo--green-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2016-350x100-Customer-Reviews.png"" alt=""Take a look at reviews of Ultimate Software on TrustRadius.com from these companies and more."" title=""Take a look at reviews of Ultimate Software on TrustRadius.com from these companies and more."" class=""promo__img--right"">
<figcaption class=""promo__caption"">
<div class=""h1div"">HR and Payroll Software<br> Customer Reviews
</div>
<h2><a href=""/hcm-software-customer-reviews"">See Ultimate's Reviews</a></h2>
</figcaption>
</figure>

<!-- mp_trans_remove_start -->
<figure class=""promo--hori promo--teal-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/page-content/300x100-Perception-Tour.png"" alt=""UltiPro Perception makes it easy to survey your workforce and gain real-time analysis of employee feedback and sentiment"" title=""UltiPro Perception makes it easy to survey your workforce and gain real-time analysis of employee feedback and sentiment"" class=""promo__img--right"">
<figcaption class=""promo__caption"">
<div class=""h1div"">UltiPro Perception Tour</div>
<h2><br><a href=""/Contact/employee-survey-feedback-software-perception"">Watch Product Tour Now</a></h2>
</figcaption>
</figure>


<!-- mp_trans_remove_end -->
<!-- mp_trans_add=""ES,PT,FR""
<figure class=""promo--hori promo--green-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2014-115X102-Promo-Overview-Spotlight.png"" alt=""man"" class=""promo__img--right"">
<figcaption class=""promo__caption"">
<div class=""h1div"">ROI on HR Software</div>
<h2><a href=""/UltiPro-Solution-Features"">Learn More</a></h2>
</figcaption>
</figure>
-->


</aside>
</li>



<li class=""mega-nav__item dropdown"">
<a title=""UltiPro human capital management (HCM) customers tell their triumphant tales of overcoming HR payroll solution challenges."" href=""/Customer-Stories"" class=""dropdown-toggle"" onclick=""return dropdownNavigate('/Customer-Stories');"">Customer Stories</a>


<ul><li class=""mega-nav__special-sub-item""><a href=""/Customer-Stories"" class=""mega-nav__sub-item"">Customer Stories</a></li>



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""0"" class=""mega-nav__sub-item fake-section""><a title=""UltiPro human capital management (HCM) customers tell their triumphant tales of overcoming HR payroll solution challenges."" href=""/Customer-Stories"" target=""_top"">Customer Stories Page</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""24"" class=""mega-nav__sub-item ""><a title=""See the outstanding HCM accomplishments of those utilizing UltiPro's HR, payroll, and talent management solution
"" href=""/Customer-Stories-HR-Heroes"" target=""_top"">HR Heroes</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""23"" class=""mega-nav__sub-item ""><a title=""Discover those who have utilized UltiPro's HCM software to better manage their business
"" href=""/Workforce-Management-Innovation-Awards"" target=""_top"">Innovation Awards</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""439"" class=""mega-nav__sub-item ""><a title=""Customer Reviews"" href=""/hcm-software-customer-reviews"" target=""_top"">Customer Reviews</a></li>

<!-- mp_trans_remove_end -->


</ul>

<aside class=""promos--nav"">
<figure class=""promo--vert promo--teal-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2016-115X102-Customer-Stories.png"" alt=""Find out why customers choose us for our sophisticated people management technology delivered in the cloud."" title=""Find out why customers choose us for our sophisticated people management technology delivered in the cloud."" class=""promo__img--corner"">
<figcaption class=""promo__caption"">
<div class=""h1div"">HR Technology Success Stories<br>
Learn how UltiPro can drive smarter, people focused<br> business results.</div>
<h2><a href=""/Customer-Stories"">Read the Stories</a></h2>
</figcaption>
</figure>
<figure class=""promo--hori promo--teal-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-350x100-Red-Roof.png"" alt=""Learn why UltiPro was the driving force in managing growth with Red Roof's new HCM Solution"" title=""Learn why UltiPro was the driving force in managing growth with Red Roof's new HCM Solution"" class=""promo__img--full"">
<figcaption class=""promo__caption"">
<div class=""h1div"">Red Roof gains from data-driven insights</div>
<h2><a href=""/UltiPro-Case-Study/Red-Roof-Inn"">Read Success Story</a></h2>
</figcaption>
</figure>
<figure class=""promo--hori promo--green-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-350x100-Ameripride.png"" alt=""Discover how AmeriPride drives business improvements with HR and Payroll software solution UltiPro"" title=""Discover how AmeriPride drives business improvements with HR and Payroll software solution UltiPro"" class=""promo__img--full"">
<figcaption class=""promo__caption"">
<div class=""h1div"">AmeriPride drives business improvements</div><br><br>
<h2><a href=""/UltiPro-Case-Study/AmeriPride"">Read Success Story</a></h2>
</figcaption>
</figure>



</aside>
</li>



<li class=""mega-nav__item dropdown"">
<a title=""HCM and HR talent management whitepapers, videos, webcasts, infographics, and more, to aid your continuing HCM education."" href=""/Resources"" class=""dropdown-toggle"" onclick=""return dropdownNavigate('/Resources');"">Resources</a>


<ul><li class=""mega-nav__special-sub-item""><a href=""/Resources"" class=""mega-nav__sub-item"">Resources</a></li>



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""0"" class=""mega-nav__sub-item fake-section""><a title=""HCM and HR talent management whitepapers, videos, webcasts, infographics, and more, to aid your continuing HCM education."" href=""/Resources"" target=""_top"">Resources Page</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""525"" class=""mega-nav__sub-item ""><a title=""Service Matters"" href=""/servicematters"" target=""_top"">Service Matters</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""28"" class=""mega-nav__sub-item ""><a title=""Explore the depth of knowledge, from talent management to HRIS, available in a leading HCM provider's whitepaper library
"" href=""/HCM-Whitepaper-Library-Human-Capital-Management-Topics"" target=""_top"">Whitepapers</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""96"" class=""mega-nav__sub-item ""><a title=""From HR and payroll to Global HCM, Ultimate Software's webcasts keep you informed
"" href=""/Events-Webcasts"" target=""_top"">HR/Payroll Webcasts</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""38"" class=""mega-nav__sub-item ""><a title=""Earn HR credits and gain detailed knowledge of the most important HCM topics through this distance learning community
"" href=""/Resources-HCMAcademy"" target=""_top"">HCM Academy</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""87"" class=""mega-nav__sub-item ""><a title=""See the HR, payroll, and talent management knowledge Ultimate Software provides in its video room
"" href=""/Video-Room"" target=""_top"">Video Room</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""92"" class=""mega-nav__sub-item ""><a title=""Find the tools necessary to deal with all things healthcare and discover how an HCM Solution can help
"" href=""/canada-hr-and-payroll-software-resource-center"" target=""_top"">Canadian Resource Center</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""526"" class=""mega-nav__sub-item ""><a title=""HCM Interactive Content"" href=""/human-capital-management-interactive-content-center"" target=""_top"">HCM Interactive Content</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""88"" class=""mega-nav__sub-item ""><a title=""Visual HCM guides to understand trends of the HR software and payroll software industries
"" href=""/resources-infographics"" target=""_top"">Infographics</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""520"" class=""mega-nav__sub-item ""><a title=""Case Studies"" href=""/Customer-Stories"" target=""_top"">Case Studies</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""436"" class=""mega-nav__sub-item ""><a title=""Millennial Research"" href=""/MillennialResearch"" target=""_top"">Millennial Research</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""521"" class=""mega-nav__sub-item ""><a title=""HCM Buyer's Kit"" href=""/hcm-buyers-kit"" target=""_top"">HCM Buyer's Kit</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""523"" class=""mega-nav__sub-item ""><a title=""Hot HCM Topics"" href=""/hot-hcm-topics"" target=""_top"">Hot HCM Topics</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""97"" class=""mega-nav__sub-item ""><a title=""HCM Podcasts"" href=""/Human-capital-management-podcasts"" target=""_top"">HCM Podcasts</a></li>

<!-- mp_trans_remove_end -->


</ul>

<aside class=""promos--nav"">
<!-- mp_trans_remove_start -->
<figure class=""promo--vert promo--teal-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-180X215-missing-factor-whitepaper-drop.png"" alt=""Learn more about payroll, talent management, compliance, healthcare reform, and how UltiPro’s features can produce results for your business."" title=""Learn more about payroll, talent management, compliance, healthcare reform, and how UltiPro’s features can produce results for your business."" class=""promo__img--corner"">
<figcaption class=""promo__caption"">
<div class=""h1div"">Service<br>The Missing Factor in<br>HCM Software Satisfaction</div>
<h2><a href=""/Contact/The-Missing-Factor-in-HCM-Software-Satisfaction-Whitepaper"">Download Whitepaper</a></h2>
</figcaption>
</figure>


<!-- mp_trans_remove_end -->
<!-- mp_trans_add=""FR""
<figure class=""promo--vert promo--teal-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-180X215-canadian-hr-law-fr.png"" alt=""Download the Canadian HR Law - HCM Whitepaper"" title=""Download the Canadian HR Law - HCM Whitepaper"" class=""promo__img--corner"">
<figcaption class=""promo__caption"">
<div class=""h1div"">HCM Whitepaper:<br />Canadian HR Law</div>
<h2><a href=""/Contact/CA-canadian-HR-law-essential-reference-guide?from=menu-promo"">Read Whitepaper</a></h2>
</figcaption>
</figure>
-->
<!-- mp_trans_remove_start -->
<figure class=""promo--hori promo--green-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2016-350x100-Podcast.png"" alt=""This HCM Podcast will discuss how culture impacts the overall business health and success."" title=""This HCM Podcast will discuss how culture impacts the overall business health and success."" class=""promo__img--right"">
<figcaption class=""promo__caption"">
<div class=""h1div"">Podcast: Impact of Culture on<br> Business Health and Success</div>
<h2><a href=""/Impact-of-Culture-on-Business-Podcast"">HCM Podcasts - Listen Now</a></h2>
</figcaption>
</figure>


<!-- mp_trans_remove_end -->
<!-- mp_trans_add=""FR""
<figure class=""promo--hori promo--green-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-350x100-10-ways-to-wow-your-new-hire-fr.png"" alt=""Download the 10 Ways to wow your new hire - HCM Whitepaper"" title=""Download the 10 Ways to wow your new hire - HCM Whitepaper"" class=""promo__img--right"">
<figcaption class=""promo__caption"">
<div class=""h1div"">HCM Whitepaper:<br />10 Ways to wow<br>your hew hire</div>
<h2><a href=""/Contact/hr-management-guide-10-more-ways-to-wow-your-new-hire?from=menu-promo"">Download Whitepaper</a></h2>
</figcaption>
</figure>
-->
<!-- mp_trans_remove_start -->
<figure class=""promo--hori promo--teal-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-350x100-top-5-acquisition.png"" alt=""Download the Top 5 Talent Acquisition Trends - HCM Whitepaper"" title=""Download the Top 5 Talent Acquisition Trends - HCM Whitepaper"" class=""promo__img--right"">
<figcaption class=""promo__caption"">
<div class=""h1div"">HCM Report:<br>Top 5 Talent Acquisition Trends</div>
<h2><a href=""/Contact/hcm-whitepapers-top-5-talent-acquisition-trends"">Read Report</a></h2>
</figcaption>
</figure>


<!-- mp_trans_remove_end -->
<!-- mp_trans_add=""FR""
<figure class=""promo--hori promo--teal-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-350x100-fr-payroll-counts.png"" alt=""Download the Payroll Counts - HCM Whitepaper"" title=""Download the Payroll Counts - HCM Whitepaper"" class=""promo__img--right"">
<figcaption class=""promo__caption"">
<div class=""h1div"">HCM Whitepaper:<br />Payroll<br>Counts</div>
<h2><a href=""/Contact/payroll-as-strategic-asset?from=menu-promo"">Read Report</a></h2>
</figcaption>
</figure>

-->



</aside>
</li>



<li class=""mega-nav__item dropdown"">
<a title=""HR, payroll, and talent management-focused events by HCM professionals, sponsored and produced by Ultimate Software."" href=""/Events"" class=""dropdown-toggle"" onclick=""return dropdownNavigate('/Events');"">Events</a>


<ul><li class=""mega-nav__special-sub-item""><a href=""/Events"" class=""mega-nav__sub-item"">Events</a></li>



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""0"" class=""mega-nav__sub-item fake-section""><a title=""HR, payroll, and talent management-focused events by HCM professionals, sponsored and produced by Ultimate Software."" href=""/Events"" target=""_top"">Events Page</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""34"" class=""mega-nav__sub-item ""><a title=""From HR and payroll to Global HCM, Ultimate Software's webcasts keep you informed
"" href=""/Events-Webcasts"" target=""_top"">HR/Payroll Webcasts</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""33"" class=""mega-nav__sub-item ""><a title=""Gain essential strategies from industry leaders and find out how to increase HR and payroll efficiency
"" href=""/Events-HR-Workshops"" target=""_top"">HR Workshops</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""35"" class=""mega-nav__sub-item ""><a title=""Find a seminar near you to discover more about the most comprehensive HR, payroll, and talent management solution
"" href=""/Events-Seminars"" target=""_top"">Seminars</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""36"" class=""mega-nav__sub-item ""><a title=""Stop by our booth at a local tradeshow to experience Ultimate Software's award-winning, comprehensive HCM solution
"" href=""/Events-Trade-Shows"" target=""_top"">Trade Shows</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""29"" class=""mega-nav__sub-item ""><a title=""Earn HR credits and gain detailed knowledge of the most important HCM topics through this distance learning community
"" href=""/Events-HCMAcademy"" target=""_top"">HCM Academy</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""86"" class=""mega-nav__sub-item ""><a title=""Join us for the Connections Conference to keep up to date on the most comprehensive HCM solution, UltiPro
"" href=""/Events-Connections-Conference"" target=""_blank"">Connections Conference</a></li>

<!-- mp_trans_remove_end -->


</ul>

<aside class=""promos--nav"">
<figure class=""promo--vert promo--teal-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-180X215-perception-webcast.png"" alt=""UltiPro Perception makes it easy to survey your workforce and gain real-time analysis of employee feedback and sentiment"" title=""UltiPro Perception makes it easy to survey your workforce and gain real-time analysis of employee feedback and sentiment"" class=""promo__img--corner"">
<figcaption class=""promo__caption"">
<div class=""h1div"">On-Demand HCM Webcast:<br>The Power of Perception</div>
<h2>Insight to Enhance <br>the Employee Experience<br><br><a href=""/Contact/the-power-of-perception-hcm-webcast"">Watch Now</a></h2>
</figcaption>
</figure>

<figure class=""promo--hori promo--teal"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2016-hr-workshop-promo.png"" alt="" Learn how top companies are solving their toughest organizational problems—and get HRCI, SHRM PDCs, and APA recertification credits for attendance at U.S. workshops!"" href=""/Events-HR-Workshopsfrom=menu-promo"" class=""promo__img--full"">
<figcaption class=""promo__caption"">
<div class=""h1div"">View Our Upcoming<br> HR Workshops
</div>
<h2><a title=""Learn how top companies are solving their toughest organizational problems—and get HRCI, SHRM PDCs, and APA recertification credits for attendance at U.S. workshops!"" href=""/Events-HR-Workshops"">Register for HR Workshops</a></h2>
</figcaption>
</figure>
<figure class=""promo--hori promo--teal-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-350x100-web-demo-promo.png"" alt=""Learn More about UltiPro and discover features like you've never seen before for unified human capital management"" title=""Learn More about UltiPro and discover features like you've never seen before for unified human capital management"" class=""promo__img--full"">
<figcaption class=""promo__caption"">
<div class=""h1div"">Live UltiPro Web Demo</div>
<h2><a href=""/contact/hrms-hr-payroll-demo-webcast"" alt=""Learn More about UltiPro and discover features like you've never seen before for unified human capital management"" title=""Learn More about UltiPro and discover features like you've never seen before for unified human capital management"">Sign Up for Live Demo</a></h2>
</figcaption>
</figure>


</aside>
</li>



<li class=""mega-nav__item dropdown"" style=""margin-right: 162px;"">
<a title=""Award-winning HRIS / HRMS provider of human capital management solutions in the cloud."" href=""/About-Us"" class=""dropdown-toggle"" onclick=""return dropdownNavigate('/About-Us');"">About Us</a>


<ul><li class=""mega-nav__special-sub-item""><a href=""/About-Us"" class=""mega-nav__sub-item"">About Us</a></li>



<li data-website-menu-id=""0"" class=""mega-nav__sub-item fake-section""><a title=""Award-winning HRIS / HRMS provider of human capital management solutions in the cloud."" href=""/About-Us"" target=""_top"">About Us Page</a></li>



<li data-website-menu-id=""43"" class=""mega-nav__sub-item ""><a title=""Learn about the unique culture of Ultimate Software that helps create HR and payroll software that puts people first
"" href=""/Ultimate-Company-Culture"" target=""_top"">Company Culture</a></li>



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""437"" class=""mega-nav__sub-item ""><a title=""Our Mission"" href=""/Ultimate-Our-Mission"" target=""_top"">Our Mission</a></li>

<!-- mp_trans_remove_end -->



<li data-website-menu-id=""42"" class=""mega-nav__sub-item ""><a title=""Experience how putting people first made Ultimate Software leaders in HR, payroll, and talent management software
"" href=""/Ultimate-Awards-Recognition"" target=""_top"">Awards &amp; Recognition</a></li>



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""40"" class=""mega-nav__sub-item ""><a title=""Stay up to date on all things Ultimate Software to discover the added benefits a HRMS can bring to your company
"" href=""/PR/Newsroom"" target=""_top"">Newsroom</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""39"" class=""mega-nav__sub-item ""><a title=""Stay current on this human resource management software providers financial history and continued growth
"" href=""/Ultimate-Investor-Relations"" target=""_top"">Investor Relations</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""524"" class=""mega-nav__sub-item ""><a title=""G2 Crowd Reports"" href=""/g2-crowd-compares-the-best-hcm-solutions"" target=""_top"">G2 Crowd Reports</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""434"" class=""mega-nav__sub-item ""><a title=""HCM Analyst Reports"" href=""/ultimate-analyst-relations"" target=""_top"">HCM Analyst Reports</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""438"" class=""mega-nav__sub-item ""><a title=""Ultimate Software's Blog"" href=""http://www.ultimatesoftware.com/blog?m=438"" target=""_blank"">Blog</a></li>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""45"" class=""mega-nav__sub-item ""><a title=""Explore social media with Ultimate Software to stay up to date on the HR software and payroll software provider
"" href=""/Ultimate-Connect-With-Us"" target=""_top"">Social Media</a></li>

<!-- mp_trans_remove_end -->



<li data-website-menu-id=""44"" class=""mega-nav__sub-item ""><a title=""Committed to sustainable strategies that produce ROI in your HR and payroll 
"" href=""/Ultimate-Paperless-HR-Payroll"" target=""_top"">Paperless HR &amp; Payroll</a></li>



<li data-website-menu-id=""17"" class=""mega-nav__sub-item ""><a title=""UltiPro's HCM Software protects your HR and payroll data with industry best-practices"" href=""/Data-Security"" target=""_top"">Data Security</a></li>



<!-- mp_trans_remove_start -->

<li data-website-menu-id=""41"" class=""mega-nav__sub-item ""><a title=""Explore the possibility of working for the leading HCM software provider
"" href=""/careers-at-ultimate"" target=""_top"">Careers</a></li>

<!-- mp_trans_remove_end -->



<li data-website-menu-id=""83"" class=""mega-nav__sub-item ""><a title=""Customers choose Ultimate for our sophisticated people management technology delivered in the cloud"" href=""/Partners"" target=""_top"">Partners</a></li>


</ul>

<aside class=""promos--nav"">
<!-- mp_trans_remove_start -->
<figure class=""promo--vert promo--green-pattern"">
<a href=""/PR/Press-Release/Ultimate-Software-Named-7-Best-Company-to-Work-For-by-Fortune-Marking-Highest-Ever-Ranking-Sixth-Consecutive-Year-on-List""><img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2017-300x215-fortune-about-us.png"" alt=""Ultimate is Named on the FORTUNE Best Places to Work List for the 6th Year In a Row"" title=""Ultimate is Named on the FORTUNE Best Places to Work List for the 6th Year In a Row"" class=""promo__img--corner""></a>

</figure>
<!-- mp_trans_remove_end -->
<!-- mp_trans_add=""ES,PT,FR""

<figure class=""promo--vert promo--teal-pattern"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/spotlight/2014-180x215-Spotlight-Trans-red-hair-sitting-on-desk.png"" alt=""aquarium"" class=""promo__img--corner"">
<figcaption class=""promo__caption"">
<div class=""h1div"">About Ultimate Software</div>
<h2><a href=""/About-Us"">Learn More</a></h2>
</figcaption>
</figure>
-->
<!-- mp_trans_remove_start -->
<figure class=""promo--hori promo--bray"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2016-350x100-Podcast-Blog-Promo.jpg"" alt=""Workplace topics including HR and Payroll software, HCM solutions, and HRIS"" title=""Workplace topics including HR and Payroll software, HCM solutions, and HRIS"" class=""promo__img--full"">
<figcaption class=""promo__caption"">
<div class=""h1div"">Ultimate Software Blog: <br>Thoughts on Putting People First in the Workplace
</div>
<h2><a href=""//ultimatesoftware.com/blog/"" target=""_blank"">Read HCM Blog</a></h2>
</figcaption>
</figure>

<!-- mp_trans_remove_end -->
<!-- mp_trans_add=""ES,PT,FR""

<figure class=""promo--hori"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2014-300x100-Promo-Green-large-group.jpg"" alt=""man"" class=""promo__img--full"">
<figcaption class=""promo__caption"">
<div class=""h1div"">Product Leadership</div>
<h2><a href=""/Ultimate-Product-Leadership"">Learn More</a></h2>
</figcaption>
</figure>-->
<!-- mp_trans_remove_start -->

<figure class=""promo--hori promo--teal-pattern"">

<figcaption class=""promo__caption"">
<div class=""h1div"">Human Capital Management Solution
Industry Awards and Recognition </div>
<h2><a href=""/Ultimate-Awards-Recognition"">See our Awards</a></h2>
</figcaption>
</figure>
<!-- mp_trans_remove_end -->
<!-- mp_trans_add=""ES,PT,FR""
<figure class=""promo--hori promo--bray"">
<img src=""https://ultimarketingweb.blob.core.windows.net/static/images/promo/2014-300x100-Promo-Couple-News.jpg"" alt=""Learn More about Ultimate's Mobile Technology"" class=""promo__img--full"">
<figcaption class=""promo__caption"">
<div class=""h1div"">Mobile HRMS</div>
<h2><a href=""/Mobile-Technology"">Get Informed Now</a></h2>
</figcaption>
</figure>-->


</aside>
</li>


<!-- mp_trans_remove_start -->
<li class=""mega-nav__item--tan""><a title=""Customer Success Portal"" href=""https://ultimate.force.com/csp/s/login/"">Customer Success Portal</a></li>
<li class=""mega-nav__item--teal product-tour"">
<a style=""text-transform: none;"" title=""Spend 5 minutes with us and discover the difference that a truly comprehensive human resources solution can make."" href=""/contact/hcm-human-resources-payroll-software-tour"">Tour</a>
</li>
<!-- mp_trans_remove_end -->
</ul>
</nav>

</div>
</div>
</header>

</div>

<!-- Language = EN -->
<main id=""homePage"" class=""page-background"">

<section class=""hero"" id=""hero"" style="""">
<div class=""carousel--hero owl-carousel owl-theme"" style=""opacity: 1; display: block;"">


<!-- mp_trans_remove_start -->
<div class=""owl-wrapper-outer""><div class=""owl-wrapper"" style=""width: 22836px; left: 0px; display: block; transition: all 800ms ease; transform: translate3d(-1903px, 0px, 0px);""><div class=""owl-item"" style=""width: 1903px;""><div><div style=""cursor: pointer; background-color: white;"" class=""carousel__item carousel--hero__item-1"" id=""carousel-item-1"" alt="" Don’t stress! Join us and prepare for your most successful year end yet."" onclick=""ga('gtm1.send', 'event', 'Banners', 'Click', '/Contact/secrets-to-a-stress-free-year-end-payroll-webcast'); window.location = '/Contact/secrets-to-a-stress-free-year-end-payroll-webcast';"" data-url=""/Contact/secrets-to-a-stress-free-year-end-payroll-webcast""><div class=""carousel__item-wrapper""><p style="""" id=""carousel-item-line1-1""><br><br></p><p style="""" id=""carousel-item-line2-1""><strong> </strong></p><p style="""" id=""carousel-item-desc-1"" class=""desc""></p><a style="" display: none;"" href=""/Contact/secrets-to-a-stress-free-year-end-payroll-webcast"" title="""" target=""_top""></a></div></div></div></div><div class=""owl-item active"" style=""width: 1903px;""><div><div style=""cursor: pointer; background-color: white;"" class=""carousel__item carousel--hero__item-1"" id=""carousel-item-2"" alt="" Read report to see why Ultimate was named a leader based on ability to execute and completeness of vision. "" onclick=""ga('gtm1.send', 'event', 'Banners', 'Click', '/Contact/Ultimate-named-a-leader-in-cloud-HCM-suites'); window.location = '/Contact/Ultimate-named-a-leader-in-cloud-HCM-suites';"" data-url=""/Contact/Ultimate-named-a-leader-in-cloud-HCM-suites""><div class=""carousel__item-wrapper""><p style="""" id=""carousel-item-line1-2""><br><br></p><p style="""" id=""carousel-item-line2-2""><strong> </strong></p><p style="""" id=""carousel-item-desc-2"" class=""desc""></p><a style="" display: none;"" href=""/Contact/Ultimate-named-a-leader-in-cloud-HCM-suites"" title="""" target=""_top""></a></div></div></div></div><div class=""owl-item"" style=""width: 1903px;""><div><div style=""cursor: pointer; background-color: white;"" class=""carousel__item carousel--hero__item-1"" id=""carousel-item-3"" alt=""HR and Payroll Solution Overview Tour"" onclick=""ga('gtm1.send', 'event', 'Banners', 'Click', '/contact/hcm-human-resources-payroll-software-tour'); window.location = '/contact/hcm-human-resources-payroll-software-tour';"" data-url=""/contact/hcm-human-resources-payroll-software-tour""><div class=""carousel__item-wrapper""><p style="""" id=""carousel-item-line1-3""></p><p style="""" id=""carousel-item-line2-3""><strong> </strong></p><p style="""" id=""carousel-item-desc-3"" class=""desc""></p><a style="" display: none;"" href=""/contact/hcm-human-resources-payroll-software-tour"" title=""HR and Payroll Solution Overview Tour"" target=""_top""></a></div></div></div></div><div class=""owl-item"" style=""width: 1903px;""><div><div style=""cursor: pointer; background-color: white;"" class=""carousel__item carousel--hero__item-1"" id=""carousel-item-4"" alt=""Discover top human capital management whitepapers for 2017!"" onclick=""ga('gtm1.send', 'event', 'Banners', 'Click', '/top-7-hcm-whitepapers-of-2017'); window.location = '/top-7-hcm-whitepapers-of-2017';"" data-url=""/top-7-hcm-whitepapers-of-2017""><div class=""carousel__item-wrapper""><p style="""" id=""carousel-item-line1-4""><br><br></p><p style="""" id=""carousel-item-line2-4""><strong> </strong></p><p style="""" id=""carousel-item-desc-4"" class=""desc""></p><a style="" display: none;"" href=""/top-7-hcm-whitepapers-of-2017"" title=""Discover top human capital management whitepapers for 2017!"" target=""_top""></a></div></div></div></div><div class=""owl-item"" style=""width: 1903px;""><div><div style=""cursor: pointer; background-color: white;"" class=""carousel__item carousel--hero__item-1"" id=""carousel-item-5"" alt=""Help your employees get the job done from anywhere with UltiPro Mobile, give them access to their Human Capital Management tools on the move."" onclick=""ga('gtm1.send', 'event', 'Banners', 'Click', '/Contact/mobile-app-hcm-solution-tour'); window.location = '/Contact/mobile-app-hcm-solution-tour';"" data-url=""/Contact/mobile-app-hcm-solution-tour""><div class=""carousel__item-wrapper""><p style="""" id=""carousel-item-line1-5""><br><br></p><p style="""" id=""carousel-item-line2-5""><strong> </strong></p><p style="""" id=""carousel-item-desc-5"" class=""desc""></p><a style="" display: none;"" href=""/Contact/mobile-app-hcm-solution-tour"" title=""Help your employees get the job done from anywhere with UltiPro Mobile, give them access to their Human Capital Management tools on the move."" target=""_top""></a></div></div></div></div><div class=""owl-item"" style=""width: 1903px;""><div><div style=""cursor: pointer; background-color: white;"" class=""carousel__item carousel--hero__item-1"" id=""carousel-item-6"" alt=""UltiPro Payroll Product Tour "" onclick=""ga('gtm1.send', 'event', 'Banners', 'Click', '/contact/hcm-payroll-software-tour'); window.location = '/contact/hcm-payroll-software-tour';"" data-url=""/contact/hcm-payroll-software-tour""><div class=""carousel__item-wrapper""><p style="""" id=""carousel-item-line1-6""></p><p style="""" id=""carousel-item-line2-6""><strong></strong></p><p style="""" id=""carousel-item-desc-6"" class=""desc""></p><a style="" display: none;"" href=""/contact/hcm-payroll-software-tour"" title=""UltiPro Payroll Product Tour "" target=""_top""></a></div></div></div></div></div></div>
<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<!-- mp_trans_remove_end -->


<div class=""owl-controls clickable""><div class=""owl-pagination""><div class=""owl-page""><span class=""""></span></div><div class=""owl-page active""><span class=""""></span></div><div class=""owl-page""><span class=""""></span></div><div class=""owl-page""><span class=""""></span></div><div class=""owl-page""><span class=""""></span></div><div class=""owl-page""><span class=""""></span></div></div></div></div>
</section>


<section class=""callouts"">


<!-- mp_trans_remove_start -->
<div class=""callouts__item"" style=""background-image: url(&quot;https://ultimarketingweb.blob.core.windows.net/static/images/hp-promo/2014-378X171-HP-Promo-woman-with-suit.jpg&quot;) !important; height: 150px;""><div class=""callouts__item-text""><p class=""callout-line1"" style="""">UltiPro Payroll Software Tour</p><p class=""callout-line2"" style="""">HR technology to make payroll processing easier, flexible, and simple.</p><p><a title=""Find out why UltiPro is the most flexible, functional HCM payroll management solution on the market. "" class=""button button-green"" style="""" onclick=""javascript: ga('gtm1.send', 'event', 'Callouts', 'Click', '/contact/hcm-payroll-software-tour'); window.location = '/contact/hcm-payroll-software-tour';"">Watch Tour</a></p></div></div>
<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->
<div class=""callouts__item"" style=""background-image: url(&quot;https://ultimarketingweb.blob.core.windows.net/static/images/hp-promo/2014-378X171-HP-Promo-woman-standing-laptop.jpg&quot;) !important; height: 150px;""><div class=""callouts__item-text""><p class=""callout-line1"" style="""">Top 7 HCM Whitepapers of 2017</p><p class=""callout-line2"" style="""">Discover our top human capital management whitepapers for 2017.</p><p><a title=""Top 7 HCM Whitepapers of 2017"" class=""button button-green"" style="""" onclick=""javascript: ga('gtm1.send', 'event', 'Callouts', 'Click', '/top-7-hcm-whitepapers-of-2017'); window.location = '/top-7-hcm-whitepapers-of-2017';"">Read Now</a></p></div></div>
<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->
<div class=""callouts__item"" style=""background-image: url(&quot;https://ultimarketingweb.blob.core.windows.net/static/images/hp-promo/2014-378X171-HP-Promo-woman-standing-laptop.jpg&quot;) !important; height: 150px;""><div class=""callouts__item-text""><p class=""callout-line1"" style="""">Secrets to a Stress-Free Year-End</p><p class=""callout-line2"" style="""">Join this live HR and payroll webcast on<br>September 21st at 2pm ET. </p><p><a title=""Closing out the payroll year and starting a new one is an exciting time, and a great opportunity to get organized and ensure a smooth year-end."" class=""button button-green"" style="""" onclick=""javascript: ga('gtm1.send', 'event', 'Callouts', 'Click', '/Contact/secrets-to-a-stress-free-year-end-payroll-webcast'); window.location = '/Contact/secrets-to-a-stress-free-year-end-payroll-webcast';"">Register Now</a></p></div></div>
<!-- mp_trans_remove_end -->


</section>





<section class=""promos"">
<div class=""carousel--promos owl-carousel owl-theme"" style=""opacity: 1; display: block;"">


<!-- mp_trans_remove_start -->
<div class=""owl-wrapper-outer""><div class=""owl-wrapper"" style=""width: 1986px; left: 0px; display: block;""><div class=""owl-item"" style=""width: 993px;""><div class=""carousel__item carousel--promos__item"" onclick=""ga('gtm1.send', 'event', 'Promos', 'Click', '/contact/hrms-hr-payroll-demo-webcast'), window.location = '/contact/hrms-hr-payroll-demo-webcast';"" title=""Discover UltiPro our HR, payroll, and talent management software for your human capital management needs. ""><img src=""https://ultimarketingweb.blob.core.windows.net/static/images/hp-promo/2017-470X217-HP-Promo-Web-Demo.jpg"" alt=""Live UltiPro Web Demo"" width=""470px"" height=""217px""><p><strong>Live UltiPro Web Demo</strong></p><p class=""desc"">HR, payroll, and talent management software for your human capital management needs. <br>Thursday, September 7th at 2PM ET</p><a title=""Discover UltiPro our HR, payroll, and talent management software for your human capital management needs. "" href=""/contact/hrms-hr-payroll-demo-webcast"">Register Today</a></div></div></div></div>
<!-- mp_trans_remove_end -->



<!-- mp_trans_add=""ES,PT,FR""
<div class=""carousel__item carousel--promos__item"" onclick=""ga('gtm1.send', 'event', 'Promos', 'Click', '/UltiPro-Solution-Features-Payroll-Administration-Tax-Management'), window.location = '/UltiPro-Solution-Features-Payroll-Administration-Tax-Management';"" title=""Learn More""><img src=""https://ultimarketingweb.blob.core.windows.net/static/images/hp-promo/2014-470X217-HP-Promo-Web-Demo.jpg"" alt=""UltiPro HR Payroll Solutions"" width=""470px"" height=""217px""><p><strong>UltiPro HR Payroll Solutions</strong></p><p class=""desc"">Streamline your payroll process for simplicity, accuracy, and speed. Process payroll on time, every time, with UltiPro.</p><a title=""Learn More"" href=""/UltiPro-Solution-Features-Payroll-Administration-Tax-Management"">Learn More</a></div>
-->


<div class=""owl-controls clickable"" style=""display: none;""><div class=""owl-buttons""><div class=""owl-prev"">prev</div><div class=""owl-next"">next</div></div></div></div>
</section>



<!-- mp_trans_remove_start -->
<section class=""feeds"">
<section class=""feed--hcm"">
<h2><strong>Newest</strong> HCM Whitepapers
<button class=""plus open""><span></span></button>
</h2>
<div class=""feed__contents"" style=""display: block;"">
<ol style=""height: 537px;"">

<li class=""feed__item"">
<h4><a href=""/Contact/7-tips-handbook-employees-will-want-to-read-whitepaper"" title=""7 Tips For A Handbook Your Employees Will (Actually) Want to Read"">7 Tips For A Handbook Your Employees Will (Actually) Want to Read</a></h4>
<p>Explore 7 simple HR practices you can implement to get your handbook out and in front of the eyes of your employees to create a truly readable employee handbook.</p>

</li>

<li class=""feed__item"">
<h4><a href=""/Contact/CA-canadian-HR-law-essential-reference-guide"" title=""Canadian HR Law: The Essential Reference Guide"">Canadian HR Law: The Essential Reference Guide</a></h4>
<p></p>

</li>

<li class=""feed__item"">
<h4><a href=""/Contact/hcm-solutions-for-retail-organizations"" title=""Cloud HCM for Retail"">Cloud HCM for Retail</a></h4>
<p>Building the right workforce in the most cost-effective manner is complicated. Retail organizations must contend with high turnover, continual training, and shifting employee schedules which inflate employee costs and reduce already-slim profits.</p>

</li>

<li class=""feed__item"">
<h4><a href=""/Contact/hcm-solution-for-financial-services-organizations-whitepaper"" title=""Cloud HCM for Financial Services"">Cloud HCM for Financial Services</a></h4>
<p>Ultimate Software delivers insights and tools for financial services HR and business leaders to not only solve their compliance challenges but also build a build a high-performing and ethically grounded workforce and leadership team.</p>

</li>

<li class=""feed__item"">
<h4><a href=""/Contact/virtual-employees-hcm-case-study"" title=""Virtual Employees: An Employee Experience Case Study"">Virtual Employees: An Employee Experience Case Study</a></h4>
<p>While the number of people working remotely is on the rise, the concept is still fairly new. Establish best practices on how to do it right evidenced by the current state of virtual employee engagement.</p>

</li>

</ol>
<h3><a title=""View all HCM whitepapers"" href=""/HCM-Whitepaper-Library-Human-Capital-Management-Topics"">View all HCM whitepapers</a></h3>
</div>
</section>
<section class=""feed--events"">
<h2><strong>Upcoming</strong> Ultimate events
<button class=""plus open""><span></span></button>
</h2>
<div class=""feed__contents"" style=""display: block;"">
<ol style=""height: 537px;"">

<li class=""feed__item--seminar"">
<h4><a title=""Human Capital Management Seminar"" href=""/ContactForm/7010d000001BRth/20154"">Human Capital Management Seminar - , </a></h4>

<time datetime=""yyyy-mm-dd"">9/6/2017</time>
</li>

<li class=""feed__item--seminar"">
<h4><a title=""Human Capital Management Seminar"" href=""/ContactForm/7010d000001BRnY/20154"">Human Capital Management Seminar - Atlanta, GA</a></h4>

<time datetime=""yyyy-mm-dd"">9/7/2017</time>
</li>

<li class=""feed__item--seminar"">
<h4><a title=""Human Capital Management Seminar"" href=""/ContactForm/70132000001FS2B/20154"">Human Capital Management Seminar - New York, NY</a></h4>

<time datetime=""yyyy-mm-dd"">9/7/2017</time>
</li>

<li class=""feed__item--webcast"">
<h4><a title=""HR/Payroll Webcast"" href=""/Contact/hrms-hr-payroll-demo-webcast"">HR/Payroll Webcast - Live UltiPro Software Web Demo</a></h4>

<time datetime=""yyyy-mm-dd"">9/7/2017</time>
</li>

<li class=""feed__item--seminar"">
<h4><a title=""Human Capital Management Seminar"" href=""/ContactForm/70132000001FKIf/20154"">Human Capital Management Seminar - , </a></h4>

<time datetime=""yyyy-mm-dd"">9/8/2017</time>
</li>

<li class=""feed__item--seminar"">
<h4><a title=""Human Capital Management Seminar"" href=""/ContactForm/70132000001BOJq/20154"">Human Capital Management Seminar - Woodinville, WA</a></h4>

<time datetime=""yyyy-mm-dd"">9/8/2017</time>
</li>

<li class=""feed__item--workshop"">
<h4><a title=""HR Workshop"" href=""/HR-Workshop-Overview/70132000001BPDH/205"">HR Workshop - Montreal, QC</a></h4>

<time datetime=""yyyy-mm-dd"">9/12/2017</time>
</li>

<li class=""feed__item--seminar"">
<h4><a title=""Human Capital Management Seminar"" href=""/ContactForm/70132000001BMr4/20154"">Human Capital Management Seminar - Tampa, FL</a></h4>

<time datetime=""yyyy-mm-dd"">9/13/2017</time>
</li>

</ol>
<h3><a title=""View all events"" href=""/Events"">View all events</a></h3>
</div>
</section>
<section class=""feed--blog"">
<h2><strong>Latest</strong> News
<button class=""plus open""><span></span></button>
</h2>
<div class=""feed__contents"" style=""display: block;"">
<ol style=""height: 537px;"">

<li class=""feed__item"">
<h4><a href=""/PR/Press-Release/Ultimate-Announces-Schedule-of-Investor-Conferences-for-September-2017"" title=""Ultimate Announces Schedule of Investor Conferences for September 2017"">Ultimate Announces Schedule of Investor Conferences for September 2017</a></h4>
<p>Ultimate Software announced today its scheduled participation in two investor conferences in September 2017.</p>

</li>

<li class=""feed__item"">
<h4><a href=""/PR/Press-Release/Independent-Research-Report-Recognizes-Ultimate-Software-as-a-Leader-in-SaaS-HR-Management-Systems"" title=""Independent Research Report Recognizes Ultimate Software as a Leader in SaaS HR Management Systems"">Independent Research Report Recognizes Ultimate Software as a Leader in SaaS HR Management Systems</a></h4>
<p>Ultimate Software announced today that it was named a Leader in The Forrester Wave™: SaaS Human Resource Management Systems, Q3 2017.</p>

</li>

<li class=""feed__item"">
<h4><a href=""/PR/Press-Release/Gartner-Positions-Ultimate-Software-in-the-Leaders-Quadrant-of-the-Magic-Quadrant-for-Cloud-HCM-Suites-for-Midmarket-and-Large-Enterprises"" title=""Gartner Positions Ultimate Software in the “Leaders” Quadrant of the Magic Quadrant for Cloud HCM Suites for Midmarket and Large Enterprises"">Gartner Positions Ultimate Software in the “Leaders” Quadrant of the Magic Quadrant for Cloud HCM Suites for Midmarket and Large Enterprises</a></h4>
<p>Ultimate Software announced today that it has been positioned by Gartner, Inc. as a Leader in the Magic Quadrant for Cloud HCM Suites for Midmarket and Large Enterprises.</p>

</li>

<li class=""feed__item"">
<h4><a href=""/PR/Press-Release/US-Olympic-Committee-Uses-UltiPro-to-Elevate-Employee-Experience"" title=""U.S. Olympic Committee Uses UltiPro to Elevate Employee Experience"">U.S. Olympic Committee Uses UltiPro to Elevate Employee Experience</a></h4>
<p>Ultimate Software celebrated more than a year of the United States Olympic Committee utilizing UltiPro to help increase employee engagement and organizational support.</p>

</li>

</ol>
<h3><a title=""Newsroom"" href=""/PR/Newsroom"">View all news</a></h3>
</div>
</section>
<!-- mp_trans_remove_end -->
</section>

<!-- mp_trans_remove_start -->
<section class=""twitter"" style=""display: none;"">
<img src=""/images/twitter_logo_blue.png"" alt=""Recent Tweets"" style=""width: 72px; height: auto;"">
<div id=""twitter-feed"" class=""twitter__feed""></div>

</section>
<!-- mp_trans_remove_end -->
</main>

<div id=""content"" style=""height: auto; min-height: 0"">



</div>

<div style=""clear: both;""></div>
<footer class=""footer"">



<nav class=""site-map"">
<ul class=""site-map__nav"">


<li>
<dl class=""site-map__section"">
<dt class=""site-map__heading""><a title=""Cloud based HRIS, UltiPro, to make your payroll software and HR software more efficient."" href=""/HCM-Solutions"">HCM Solutions</a></dt>


<dd data-website-menu-id=""11"" title=""The most flexible, functional payroll software engine on the market, UltiPro does it all"" class=""site-map__sub-item""><a title=""The most flexible, functional payroll software engine on the market, UltiPro does it all"" href=""/UltiPro-Solution-Features"" target=""_top"">UltiPro HCM Features</a></dd>



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""1"" title=""Video tours to help you learn about human resources management, payroll software, talent management and more
"" class=""site-map__sub-item""><a title=""Video tours to help you learn about human resources management, payroll software, talent management and more
"" href=""/UltiPro-Solution-Tours"" target=""_top"">UltiPro HCM Tours</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""125"" title=""UltiPro Services include managed human resource functions, payment services, and printing services 
"" class=""site-map__sub-item""><a title=""UltiPro Services include managed human resource functions, payment services, and printing services 
"" href=""/UltiPro-Services"" target=""_top"">UltiPro Services</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""522"" title=""UltiPro Customer Reviews"" class=""site-map__sub-item""><a title=""UltiPro Customer Reviews"" href=""/hcm-software-customer-reviews"" target=""_top"">UltiPro Customer Reviews</a></dd>

<!-- mp_trans_remove_end -->


</dl>
</li>



<li>
<dl class=""site-map__section"">
<dt class=""site-map__heading""><a title=""UltiPro human capital management (HCM) customers tell their triumphant tales of overcoming HR payroll solution challenges."" href=""/Customer-Stories"">Customer Stories</a></dt>


<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""24"" title=""See the outstanding HCM accomplishments of those utilizing UltiPro's HR, payroll, and talent management solution
"" class=""site-map__sub-item""><a title=""See the outstanding HCM accomplishments of those utilizing UltiPro's HR, payroll, and talent management solution
"" href=""/Customer-Stories-HR-Heroes"" target=""_top"">HR Heroes</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""23"" title=""Discover those who have utilized UltiPro's HCM software to better manage their business
"" class=""site-map__sub-item""><a title=""Discover those who have utilized UltiPro's HCM software to better manage their business
"" href=""/Workforce-Management-Innovation-Awards"" target=""_top"">Innovation Awards</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""439"" title=""Customer Reviews"" class=""site-map__sub-item""><a title=""Customer Reviews"" href=""/hcm-software-customer-reviews"" target=""_top"">Customer Reviews</a></dd>

<!-- mp_trans_remove_end -->


</dl>
</li>



<li>
<dl class=""site-map__section"">
<dt class=""site-map__heading""><a title=""HCM and HR talent management whitepapers, videos, webcasts, infographics, and more, to aid your continuing HCM education."" href=""/Resources"">Resources</a></dt>


<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""525"" title=""Service Matters"" class=""site-map__sub-item""><a title=""Service Matters"" href=""/servicematters"" target=""_top"">Service Matters</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""28"" title=""Explore the depth of knowledge, from talent management to HRIS, available in a leading HCM provider's whitepaper library
"" class=""site-map__sub-item""><a title=""Explore the depth of knowledge, from talent management to HRIS, available in a leading HCM provider's whitepaper library
"" href=""/HCM-Whitepaper-Library-Human-Capital-Management-Topics"" target=""_top"">Whitepapers</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""96"" title=""From HR and payroll to Global HCM, Ultimate Software's webcasts keep you informed
"" class=""site-map__sub-item""><a title=""From HR and payroll to Global HCM, Ultimate Software's webcasts keep you informed
"" href=""/Events-Webcasts"" target=""_top"">HR/Payroll Webcasts</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""38"" title=""Earn HR credits and gain detailed knowledge of the most important HCM topics through this distance learning community
"" class=""site-map__sub-item""><a title=""Earn HR credits and gain detailed knowledge of the most important HCM topics through this distance learning community
"" href=""/Resources-HCMAcademy"" target=""_top"">HCM Academy</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""87"" title=""See the HR, payroll, and talent management knowledge Ultimate Software provides in its video room
"" class=""site-map__sub-item""><a title=""See the HR, payroll, and talent management knowledge Ultimate Software provides in its video room
"" href=""/Video-Room"" target=""_top"">Video Room</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""92"" title=""Find the tools necessary to deal with all things healthcare and discover how an HCM Solution can help
"" class=""site-map__sub-item""><a title=""Find the tools necessary to deal with all things healthcare and discover how an HCM Solution can help
"" href=""/canada-hr-and-payroll-software-resource-center"" target=""_top"">Canadian Resource Center</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""526"" title=""HCM Interactive Content"" class=""site-map__sub-item""><a title=""HCM Interactive Content"" href=""/human-capital-management-interactive-content-center"" target=""_top"">HCM Interactive Content</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""88"" title=""Visual HCM guides to understand trends of the HR software and payroll software industries
"" class=""site-map__sub-item""><a title=""Visual HCM guides to understand trends of the HR software and payroll software industries
"" href=""/resources-infographics"" target=""_top"">Infographics</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""520"" title=""Case Studies"" class=""site-map__sub-item""><a title=""Case Studies"" href=""/Customer-Stories"" target=""_top"">Case Studies</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""436"" title=""Millennial Research"" class=""site-map__sub-item""><a title=""Millennial Research"" href=""/MillennialResearch"" target=""_top"">Millennial Research</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""521"" title=""HCM Buyer's Kit"" class=""site-map__sub-item""><a title=""HCM Buyer's Kit"" href=""/hcm-buyers-kit"" target=""_top"">HCM Buyer's Kit</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""523"" title=""Hot HCM Topics"" class=""site-map__sub-item""><a title=""Hot HCM Topics"" href=""/hot-hcm-topics"" target=""_top"">Hot HCM Topics</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""97"" title=""HCM Podcasts"" class=""site-map__sub-item""><a title=""HCM Podcasts"" href=""/Human-capital-management-podcasts"" target=""_top"">HCM Podcasts</a></dd>

<!-- mp_trans_remove_end -->


</dl>
</li>



<li>
<dl class=""site-map__section"">
<dt class=""site-map__heading""><a title=""HR, payroll, and talent management-focused events by HCM professionals, sponsored and produced by Ultimate Software."" href=""/Events"">Events</a></dt>


<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""34"" title=""From HR and payroll to Global HCM, Ultimate Software's webcasts keep you informed
"" class=""site-map__sub-item""><a title=""From HR and payroll to Global HCM, Ultimate Software's webcasts keep you informed
"" href=""/Events-Webcasts"" target=""_top"">HR/Payroll Webcasts</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""33"" title=""Gain essential strategies from industry leaders and find out how to increase HR and payroll efficiency
"" class=""site-map__sub-item""><a title=""Gain essential strategies from industry leaders and find out how to increase HR and payroll efficiency
"" href=""/Events-HR-Workshops"" target=""_top"">HR Workshops</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""35"" title=""Find a seminar near you to discover more about the most comprehensive HR, payroll, and talent management solution
"" class=""site-map__sub-item""><a title=""Find a seminar near you to discover more about the most comprehensive HR, payroll, and talent management solution
"" href=""/Events-Seminars"" target=""_top"">Seminars</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""36"" title=""Stop by our booth at a local tradeshow to experience Ultimate Software's award-winning, comprehensive HCM solution
"" class=""site-map__sub-item""><a title=""Stop by our booth at a local tradeshow to experience Ultimate Software's award-winning, comprehensive HCM solution
"" href=""/Events-Trade-Shows"" target=""_top"">Trade Shows</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""29"" title=""Earn HR credits and gain detailed knowledge of the most important HCM topics through this distance learning community
"" class=""site-map__sub-item""><a title=""Earn HR credits and gain detailed knowledge of the most important HCM topics through this distance learning community
"" href=""/Events-HCMAcademy"" target=""_top"">HCM Academy</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""86"" title=""Join us for the Connections Conference to keep up to date on the most comprehensive HCM solution, UltiPro
"" class=""site-map__sub-item""><a title=""Join us for the Connections Conference to keep up to date on the most comprehensive HCM solution, UltiPro
"" href=""/Events-Connections-Conference"" target=""_blank"">Connections Conference</a></dd>

<!-- mp_trans_remove_end -->


</dl>
</li>



<li>
<dl class=""site-map__section"">
<dt class=""site-map__heading""><a title=""Award-winning HRIS / HRMS provider of human capital management solutions in the cloud."" href=""/About-Us"">About Us</a></dt>


<dd data-website-menu-id=""43"" title=""Learn about the unique culture of Ultimate Software that helps create HR and payroll software that puts people first
"" class=""site-map__sub-item""><a title=""Learn about the unique culture of Ultimate Software that helps create HR and payroll software that puts people first
"" href=""/Ultimate-Company-Culture"" target=""_top"">Company Culture</a></dd>



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""437"" title=""Our Mission"" class=""site-map__sub-item""><a title=""Our Mission"" href=""/Ultimate-Our-Mission"" target=""_top"">Our Mission</a></dd>

<!-- mp_trans_remove_end -->



<dd data-website-menu-id=""42"" title=""Experience how putting people first made Ultimate Software leaders in HR, payroll, and talent management software
"" class=""site-map__sub-item""><a title=""Experience how putting people first made Ultimate Software leaders in HR, payroll, and talent management software
"" href=""/Ultimate-Awards-Recognition"" target=""_top"">Awards &amp; Recognition</a></dd>



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""40"" title=""Stay up to date on all things Ultimate Software to discover the added benefits a HRMS can bring to your company
"" class=""site-map__sub-item""><a title=""Stay up to date on all things Ultimate Software to discover the added benefits a HRMS can bring to your company
"" href=""/PR/Newsroom"" target=""_top"">Newsroom</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""39"" title=""Stay current on this human resource management software providers financial history and continued growth
"" class=""site-map__sub-item""><a title=""Stay current on this human resource management software providers financial history and continued growth
"" href=""/Ultimate-Investor-Relations"" target=""_top"">Investor Relations</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""524"" title=""G2 Crowd Reports"" class=""site-map__sub-item""><a title=""G2 Crowd Reports"" href=""/g2-crowd-compares-the-best-hcm-solutions"" target=""_top"">G2 Crowd Reports</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""434"" title=""HCM Analyst Reports"" class=""site-map__sub-item""><a title=""HCM Analyst Reports"" href=""/ultimate-analyst-relations"" target=""_top"">HCM Analyst Reports</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""438"" title=""Ultimate Software's Blog"" class=""site-map__sub-item""><a title=""Ultimate Software's Blog"" href=""http://www.ultimatesoftware.com/blog?m=438"" target=""_blank"">Blog</a></dd>

<!-- mp_trans_remove_end -->



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""45"" title=""Explore social media with Ultimate Software to stay up to date on the HR software and payroll software provider
"" class=""site-map__sub-item""><a title=""Explore social media with Ultimate Software to stay up to date on the HR software and payroll software provider
"" href=""/Ultimate-Connect-With-Us"" target=""_top"">Social Media</a></dd>

<!-- mp_trans_remove_end -->



<dd data-website-menu-id=""44"" title=""Committed to sustainable strategies that produce ROI in your HR and payroll 
"" class=""site-map__sub-item""><a title=""Committed to sustainable strategies that produce ROI in your HR and payroll 
"" href=""/Ultimate-Paperless-HR-Payroll"" target=""_top"">Paperless HR &amp; Payroll</a></dd>



<dd data-website-menu-id=""17"" title=""UltiPro's HCM Software protects your HR and payroll data with industry best-practices"" class=""site-map__sub-item""><a title=""UltiPro's HCM Software protects your HR and payroll data with industry best-practices"" href=""/Data-Security"" target=""_top"">Data Security</a></dd>



<!-- mp_trans_remove_start -->

<dd data-website-menu-id=""41"" title=""Explore the possibility of working for the leading HCM software provider
"" class=""site-map__sub-item""><a title=""Explore the possibility of working for the leading HCM software provider
"" href=""/careers-at-ultimate"" target=""_top"">Careers</a></dd>

<!-- mp_trans_remove_end -->



<dd data-website-menu-id=""83"" title=""Customers choose Ultimate for our sophisticated people management technology delivered in the cloud"" class=""site-map__sub-item""><a title=""Customers choose Ultimate for our sophisticated people management technology delivered in the cloud"" href=""/Partners"" target=""_top"">Partners</a></dd>


</dl>
</li>


</ul>
</nav>



<nav class=""social-links"">
<ul class=""social-links__nav"">
<li class=""social-links__item"">
<a href=""https://www.facebook.com/UltimateSoftware"" target=""_blank"" title=""Ultimate Software on Facebook"">
<!--[if lt IE 9]><img src=""/images/social/facebook.png"" width=""17"" height=""32"" alt=""Facebook""/><![endif]-->
<!--[if gte IE 9]><!-->
<img src=""/images/social/facebook.svg"" width=""17"" height=""32"" alt=""Facebook""><!-- <![endif]--></a>
</li>
<li class=""social-links__item"">
<a href=""http://www.twitter.com/UltimateHCM"" target=""_blank"" title=""Ultimate Software on Twitter"">
<!--[if lt IE 9]><img src=""/images/social/twitter.png"" width=""32"" height=""26"" alt=""Twitter""/><![endif]-->
<!--[if gte IE 9]><!-->
<img src=""/images/social/twitter.svg"" width=""32"" height=""26"" alt=""Twitter""><!-- <![endif]--></a>
</li>
<li class=""social-links__item"">
<a href=""https://www.linkedin.com/company/ultimate-software"" target=""_blank"" title=""Ultimate Software on LinkedIn"">
<!--[if lt IE 9]><img src=""/images/social/linkedin.png"" width=""32"" height=""29"" alt=""LinkedInt""/><![endif]-->
<!--[if gte IE 9]><!-->
<img src=""/images/social/linkedin.svg"" width=""32"" height=""29"" alt=""LinkedInt""><!-- <![endif]--></a>
</li>
<li class=""social-links__item"">
<a href=""https://plus.google.com/110663172528105323134/posts"" target=""_blank"" title=""Ultimate Software on Google+"">
<!--[if lt IE 9]><img src=""/images/social/gplus.png"" width=""32"" height=""27"" alt=""Google Plus""/><![endif]-->
<!--[if gte IE 9]><!-->
<img src=""/images/social/gplus.svg"" width=""32"" height=""27"" alt=""Google Plus""><!-- <![endif]--></a>
</li>
<li class=""social-links__item"">
<a href=""https://www.youtube.com/user/ultimatesoftware"" target=""_blank"" title=""Ultimate Software on YouTube"">
<!--[if lt IE 9]><img src=""/images/social/youtube.png"" width=""32"" height=""32"" alt=""YouTube""/><![endif]-->
<!--[if gte IE 9]><!-->
<img src=""/images/social/youtube.svg"" width=""32"" height=""32"" alt=""YouTube""><!-- <![endif]--></a>
</li>
<li class=""social-links__item"">
<a href=""http://www.pinterest.com/ultimatehcm/"" target=""_blank"" title=""Ultimate Software on Pinterest"">
<!--[if lt IE 9]><img src=""/images/social/pinterest.png"" width=""32"" height=""32"" alt=""Pinterest""/><![endif]-->
<!--[if gte IE 9]><!-->
<img src=""/images/social/pinterest.svg"" width=""32"" height=""32"" alt=""Pinterest""><!-- <![endif]--></a>
</li>
</ul>

</nav>

<section class=""footer-cap"">
<div class=""footer-cap__wrapper"">
<p>©&nbsp;2017 Ultimate Software</p>
<nav class=""footer-cap__links"">
<ul class=""footer-cap__links-nav"">
<li class=""footer-cap__link""><a href=""/UltiPro-Solution-Tours"">UltiPro®</a></li>
<li class=""footer-cap__link""><a href=""/Privacy-Policy"">Privacy Policy</a></li>
<li class=""footer-cap__link""><a href=""/Legal-Statement"">Legal Statement</a></li>
<li class=""footer-cap__link""><a href=""/ContactUs"">Contact Us</a></li>
<li class=""footer-cap__link""><a href=""http://go.ultimatesoftware.com/preference-center-entry"" target=""_blank"">Email Preferences</a></li>
<li class=""footer-cap__link""><a href=""/Site-Map"">Site Map</a></li>
</ul>
</nav>
</div>
</section>



<div class=""special-footer"">
FORTUNE is a registered trademark of Time Inc. and is used under license. From FORTUNE.com ©2017 Time Inc. FORTUNE and Time Inc. are not affiliated with, and do not endorse products or services of, Licensee.
</div>

</footer>





<div id=""dialog-modal"" title="""" style=""z-index: 3001;"" class=""noindex"">
<p id=""pVideoEmbed"" style=""z-index: 3001;""></p>
<div id=""divVideoEmbed"" style=""z-index: 3001;"">
</div>
<p id=""imageHtml"" style=""z-index: 3001;""></p>
</div>


<!-- Google Code for Visits To LP Remarketing List -->


<script type=""text/javascript"" language=""JavaScript"" src=""/Scripts/elqNow/elqCfg.js""></script>
<script type=""text/javascript"" language=""JavaScript"" src=""/Scripts/elqNow/elqImg.js""></script><layer hidden=""true""><img src=""http://now.eloqua.com/visitor/v200/svrGP.aspx?pps=3&amp;siteid=1426&amp;ref2=elqNone&amp;tzo=300&amp;ms=335"" border=""0"" width=""1"" height=""1""></layer>

<!-- mp_trans_remove_start -->
<!-- Quantcast Tag -->
<script>
qcdata = {} || qcdata;
(function () {
var elem = document.createElement('script');
elem.src = (document.location.protocol == ""https:"" ? ""https://secure"" : ""http://pixel"") + "".quantserve.com/aquant.js?a=p-87LMPPVKzr-KV"";
elem.async = true;
elem.type = ""text/javascript"";
var scpt = document.getElementsByTagName('script')[0];
scpt.parentNode.insertBefore(elem, scpt);
}());


var qcdata = {
qacct: 'p-87LMPPVKzr-KV',
orderid: '',
revenue: ''
};
</script>
<noscript>
&lt;img src=""//pixel.quantserve.com/pixel/p-87LMPPVKzr-KV.gif?labels=_fp.event.Default;"" style=""display: none;"" border=""0"" height=""1"" width=""1"" alt=""Quantcast"" /&gt;
</noscript>
<!-- End Quantcast Tag -->
<!-- mp_trans_remove_end -->


<script src=""/js/base.min.js""></script>
<script src=""/js/home.js""></script>
<!--[if gte IE 9]><!-->
<script src=""/js/clamp.js""></script>
<!-- <![endif]-->
<script src=""/js/main.min.js""></script>



<!-- Start of ReTargeter Tag -->
<script type=""text/javascript"" src=""https://s3.amazonaws.com/V3-Assets/prod/client_super_tag/json3.js""></script>
<script type=""text/javascript"">
if (typeof _rt_cgi == ""undefined"") {
var _rt_cgi = 1985;
var _rt_base_url = ""https://lt.retargeter.com/"";
var _rt_js_base_url = ""https://s3.amazonaws.com/V3-Assets/prod/client_super_tag/"";
var _rt_init_src = _rt_js_base_url + ""init_super_tag.js"";
var _rt_refresh_st = false;
var _rt_record = function (params) { if (typeof document.getElementsByTagName(""_rt_data"")[0] == ""undefined"") { setTimeout(function () { _rt_record(params); }, 25); } };
(function () { var scr = document.createElement(""script""); scr.src = _rt_init_src; document.getElementsByTagName(""head"")[0].appendChild(scr); })();
}
</script>
<!-- End of ReTargeter Tag -->


<!--mp_easylink_begins-->
<script type=""text/javascript"" id=""mpelid"" src=""//ultimatesoftwarecom.mpeasylink.com/mpel/mpel.js"" async=""""></script>
<!--mp_easylink_ends-->



<script type=""text/javascript"" id="""">qcdata={};(function(){var a=document.createElement(""script"");a.src=(""https:""==document.location.protocol?""https://secure"":""http://pixel"")+"".quantserve.com/aquant.js?a\x3dp-87LMPPVKzr-KV"";a.async=!0;a.type=""text/javascript"";var b=document.getElementsByTagName(""script"")[0];b.parentNode.insertBefore(a,b)})();var qcdata={qacct:""p-87LMPPVKzr-KV"",orderid:"""",revenue:""""};</script>
<noscript>
&lt;img src=""//pixel.quantserve.com/pixel/p-87LMPPVKzr-KV.gif?labels=_fp.event.Default;"" style=""display: none;"" border=""0"" height=""1"" width=""1"" alt=""Quantcast""&gt;
</noscript>
<script type=""text/javascript"" id="""">(function(a,b,c,d,e){a=b.createElement(c);b=b.getElementsByTagName(c)[0];a.async=1;a.id=e;a.src=d;b.parentNode.insertBefore(a,b)})(window,document,""script"",""https://scripts.demandbase.com/5c6f14ad.min.js"",""demandbase_js_lib"");</script> <iframe name=""_hjRemoteVarsFrame"" title=""_hjRemoteVarsFrame"" id=""_hjRemoteVarsFrame"" src=""https://vars.hotjar.com/rcj-99d43ead6bdf30da8ed5ffcb4f17100c.html"" style=""display: none !important; width: 1px !important; height: 1px !important; opacity: 0 !important; pointer-events: none !important;""></iframe><img style=""display:none"" alt=""Demandbase pixel"" id=""db_pixel_ad"" src=""http://d.company-target.com/pixel?type=js&amp;id=1490991151&amp;page=http%3A%2F%2Fwww.ultimatesoftware.com%2F""><img style=""display:none"" alt=""Demandbase pixel"" id=""db_pixel_rt"" src=""http://d.company-target.com/pixel?type=js&amp;id=1490991167&amp;page=http%3A%2F%2Fwww.ultimatesoftware.com%2F""><iframe src=""http://b.company-target.com/ect.html"" id=""db_ect"" height=""0"" width=""0"" style=""display: none;""></iframe><div id=""ads""></div><script src=""https://dc.ads.linkedin.com/collect/?time=1504143704150&amp;pid=39678&amp;url=http%3A%2F%2Fwww.ultimatesoftware.com%2F&amp;pageUrl=http%3A%2F%2Fwww.ultimatesoftware.com%2F&amp;ref=&amp;fmt=js&amp;s=1"" type=""text/javascript""></script><img src=""https://secure.adnxs.com/seg?t=2&amp;add=7326041,7326077,7326080,7326450,6991860,6991871,7324346,7324349,6992024,7326878,7324058,7324183,7326818,7323981,7326065&amp;redir=https%3A%2F%2Fsecure.adnxs.com%2Fseg%3Fadd%3D%26add_code%3Dwww_ultimatesoftware_com%2Cultimatesoftware_com%26member%3D232%26redir%3Dhttps%253A%252F%252Fimp2.ads.linkedin.com%252Fl"" width=""1"" height=""1"" border=""0"" alt="""" style=""display: none;""><img src=""https://cm.g.doubleclick.net/pixel?google_nid=bizo_bk_cm&amp;google_cm"" width=""1"" height=""1"" border=""0"" alt="""" style=""display: none;""></body></html>";
    }
}