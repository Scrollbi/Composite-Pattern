﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Paragraph : DocumentComponent
    {
        private string _text;

        public Paragraph(string text)
        {
            _text = text;
        }

        public void Add(DocumentComponent component)
        {   
        }

        public void Remove(DocumentComponent component)
        { 
        }

        public void Display(int value)
        {
            Console.WriteLine(new string(' ', value * 2) + _text);
        }
    }
}
