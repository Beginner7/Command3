﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ChessService
{
    [DataContract]
    public class ChessPlayer
    {
        [DataMember]
        public string Name {get; set;}
    }
}