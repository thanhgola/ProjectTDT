﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XTDT.API.Requests
{
    public class SemesterRequest : BasicRequestObject
    {
        public override string act => "tkb";
        public string option => "ln";
        public int id { get; set; }
    }
}
