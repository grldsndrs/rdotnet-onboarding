using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using RDotNet;

namespace WebApplicationRdn
{
    public class rankall:rankhospital
    {
        /// <param name="outcome">one of “heart attack”, “heart failure”, or “pneumonia”</param>
        /// <param name="num">requested rank</param>
        public DataFrame rankall(CharacterVector outcome, CharacterVector num)
        {
           
            throw new System.NotImplementedException();
        }
    }
}
