using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace MobileAppAutomation.AllPages
{
    public class Pages
    {
        public LocatorHelper locatorHelper { get; private set; }

        private  T getPages<T>() where T : new()
        {
            var page = new T();
            locatorHelper = new LocatorHelper(BaseTest.getDriver, "android");
            PageFactory.InitElements(BaseTest.getDriver, page);
            return page;
        }
        public FirstPage fPage
        {
            get { return getPages<FirstPage>(); }
        }
    }
}
