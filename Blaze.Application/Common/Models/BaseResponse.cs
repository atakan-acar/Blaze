﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Application.Common.Models
{
    public class BaseResponse
    {
        public string Message { get; set; }

        public bool IsSuccess { get; set; }
    }
}
