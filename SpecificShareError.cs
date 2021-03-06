﻿using System;
using System.Linq;
using System.Text;

namespace ShareClientDotNet
{
    internal class SpecificShareError : Exception
    {
        public string code { get; set; }

        public SpecificShareError(string message, string code) : base(message)
        {
            this.code = code;
        }

        public override string ToString()
        {
            return this.code + ":" + this.Message;
        }
    }
}