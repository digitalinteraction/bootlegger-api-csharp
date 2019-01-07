﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Bootleg.API.Model
{
    public class Topic
    {
        public string id { get; set; }
        public string color { get; set; }
        public bool burn { get; set; }
        public Dictionary<string, string> values { get; set; }

        public string GetLocalisedTagName(string locale)
        {
            return values[locale] ?? values[values.Keys.First()];
        }

        public Topic()
        {
            
        }
    }
}
