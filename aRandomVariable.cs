using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// aRandomVariable object holds a static random object to be used by classes that inherit it.
    /// As discussed in class, it makes more sense to implement our program this way as having a static Random object means
    /// both die have access to a single random object. This also makes our program more flexible for the future, if we needed to implement any
    /// other kind of class that would need to have access to a Random object.
    /// </summary>
    public class aRandomVariable
    {
        public static Random random;
    }
}
