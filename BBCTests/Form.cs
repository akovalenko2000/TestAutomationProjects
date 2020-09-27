using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCTests
{
    class Form
    {
        Dictionary<string, string> FormDataV = new Dictionary<string, string>
        {
            { "Text","blah-blah-blah"},
            {"Name","NAME" },
            {"Accept","Accepted" },
            {"Age","Accepted" },
            {"Submit","Click" }
        };
        Dictionary<string, string> FormDataI = new Dictionary<string, string>
        {
            { "Text","blah-blah-blah"},
            {"Name","NAME" },
            {"Accept","Denied" },
            {"Age","Denied" },
            {"Submit","Click" }
        };
        public void FillForm(Dictionary<string, string> values)
        {
            foreach(string key in values.Keys)
            {
                switch (key)
                {
                    case "Text":
                        GetNewsPage().GetCovidPage().GetHaveYourSayPage().EnterText(values[key]);
                        break;
                    case "Name":
                        GetNewsPage().GetCovidPage().GetHaveYourSayPage().EnterName(values[key]);
                        break;
                    case "Accept":
                        if(values[key] == "Accepted")
                        {
                            GetNewsPage().GetCovidPage().GetHaveYourSayPage().ClickAccept();
                        }
                        break;
                    case "Age":
                        if (values[key] == "Accepted")
                        {
                            GetNewsPage().GetCovidPage().GetHaveYourSayPage().ClickAge();
                        }
                        break;
                    case "Submit":
                        GetNewsPage().GetCovidPage().GetHaveYourSayPage().ClickSubmit();
                        break;

                }
            }
        }

    }
}
