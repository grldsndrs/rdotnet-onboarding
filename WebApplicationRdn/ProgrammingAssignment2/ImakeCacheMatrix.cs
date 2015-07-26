using System;
namespace WebApplicationRdn.ProgrammingAssignment2
{
    interface ImakeCacheMatrix
    {
        global::RDotNet.NumericMatrix Inverse { get; set; }
        global::RDotNet.NumericMatrix Matrix { get; set; }
    }
}
