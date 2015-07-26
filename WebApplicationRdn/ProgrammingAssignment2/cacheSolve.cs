using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using RDotNet;

namespace WebApplicationRdn
{
    public class cacheSolve
    {
        private NumericMatrix inverse;
        /// <summary>
        /// stoe gotten data from repositiry
        /// </summary>
        /// <remarks>scxczv</remarks>
        private NumericMatrix data;
        /// <summary>
        /// accesses the CacheMatrix object created elsewhere
        /// </summary>
        /// <remarks>
        /// In R on the command line the makeCacheMatrix function is sourced before it can be used.
        /// In .NET representation the makeCacheMatrix class is instantiated in the cacheSolve contructor
        /// </remarks>
        private makeCacheMatrix specialObject;

        public cacheSolve(NumericMatrix matrix)
        {
            data = matrix;
        }

        /// <summary>
        /// get cacheMatrix and set data value
        /// </summary>
        internal makeCacheMatrix _specialObject
        {
            get
            {
                return _specialObject = new makeCacheMatrix(data);
            }
            set
            {
            }
        }
    }
}
