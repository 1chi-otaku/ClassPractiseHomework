using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractiseHomework
{
    internal class WebSite
    {
        private string site_name;
        private string url;
        private string description;

        public WebSite()
        {
           site_name= string.Empty;
           url= string.Empty;
           description= string.Empty;
        }
        public WebSite(string site_name, string url, string description)
        {
           this.site_name= site_name;
           this.url= url;
           this.description = description;
        }

        public void Print() => Console.WriteLine("Site name - " + site_name + "\nURL - " + url + "\nDescription - " + description);
        public void Input()
        {
            Console.Write("Enter Site name: ");
            site_name = Console.ReadLine();
            Console.Write("Enter URL: ");
            url = Console.ReadLine();
            Console.Write("Enter Description: ");
            description = Console.ReadLine();
        }
        public string Site_Name
        {
            get { return site_name; }
            set
            {
                site_name = value;
            }
        }
        public string Url
        {
            get { return url; }
            set
            {
                url = value;
            }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public override string ToString()
        {
            return "Site name - " + site_name + "\nURL - " + url + "\nDescription - " + description;
        }
    }
}
