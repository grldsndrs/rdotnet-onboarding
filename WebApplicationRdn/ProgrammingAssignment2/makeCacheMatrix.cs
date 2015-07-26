using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using RDotNet;

namespace WebApplicationRdn
{
    public class makeCacheMatrix
    {
        private NumericMatrix  _matrix;
        private NumericMatrix _inverse;

        public makeCacheMatrix(NumericMatrix Martix)
        {
           _matrix = Matrix;
        }

        public NumericMatrix Matrix
        {
            get
            {
                return Matrix = _matrix;
            }
            set
            {
                _matrix = Matrix;
            }
        }

        public NumericMatrix Inverse
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
