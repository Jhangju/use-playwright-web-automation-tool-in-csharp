using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaywrightSharp;

namespace playwright
{
    class Program
    {
        static async Task Main(string[] args)
        {
                 var playwright = await Playwright.CreateAsync();
                 var browser = await playwright.Chromium.LaunchAsync(headless: false);

                
                var page = await browser.NewPageAsync();
                await page.GoToAsync("https://google.com/");
                Console.ReadLine();
        }
    }
}
