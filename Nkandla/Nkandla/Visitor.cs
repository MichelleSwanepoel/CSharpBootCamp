﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public interface Visitor
    {
        string visit(HomeStead homeStead);
    }
}