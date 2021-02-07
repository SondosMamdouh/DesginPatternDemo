using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views
{
    public interface ICalulatior
    {
        string TxtNumberOne { set; get; }
        string TxtNumberTwo { set; get; }
        string TxtResult { set; get; }
    }
}
