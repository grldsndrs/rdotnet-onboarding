using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using RDotNet;

namespace WebApplicationRdn.ProgrammingAssignment2
{
    public class cacheSolve
    {
        private NumericMatrix inverse;
        /// <summary>
        /// stoe gotten data from repositiry
        /// </summary>
        /// <remarks>scxczv</remarks>
        private NumericMatrix inputData;

        /// <summary>
        /// get/set input martrix
        /// </summary>
        public NumericMatrix _inputData
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                inputData = _inputData;
            }
        }

        /// <summary>
        /// accesses the CacheMatrix object created elsewhere
        /// </summary>
        /// <remarks>
        /// In R on the command line the makeCacheMatrix function is sourced before it can be used.
        /// In .NET representation the makeCacheMatrix class is instantiated in the cacheSolve contructor
        /// </remarks>
        private ImakeCacheMatrix specialObject;

        /// get cacheMatrix and set data value
        /// <summary>
        /// </summary>
        public NumericMatrix cacheSolve(ImakeCacheMatrix specialObject)
        {
            this.specialObject = specialObject;
            return inverse;
        }

        /// <summary>
        /// get inverse
        /// </summary>
        public NumericMatrix _inverse
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

    }
}
