﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebsitePinger
{
    public class Bootstrapper
    {
        static int Main(string[] args)
        {
            // TODO: use IOC

            new SitemapPinger();

            //return 1; // return code != 0 to re-execute

            //Console.ReadKey();
            return 1;


        }
    }
}
