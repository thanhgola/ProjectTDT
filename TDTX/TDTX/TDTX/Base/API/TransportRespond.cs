﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TDTX.Base.API
{
    public class TransportRespond
    {
        public ApiObject Content { get; set; }
        public TransportStatusCode Status { get; set; }
    }

    public enum TransportStatusCode
    {
        Awaiting,
        NotAuthorized,
        Offline,
        OK,
        UnknownError
    }

}