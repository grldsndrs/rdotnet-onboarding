using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using RDotNet;

namespace WebApplicationRdn
{
    public class validate
    {
        /// <summary>
        /// If an invalid _state value is passed to best, the function should throw an error via the stop function with the exact message “invalid _state”
        /// </summary>
        private CharacterVector state;
        /// <summary>
        /// If an invalid _outcome value is passed to best, the function should throw an error via the stop function with the exact message “invalid _outcome”
        /// </summary>
        private CharacterVector outcome;
        /// <summary>
        /// The setter method that called validate
        /// </summary>
        /// <remarks>it is the output from this.ToSting</remarks>
        private CharacterVector caller;

        /// <param name="caller">the setter that called</param>
        /// <param name="textToValidate">state or outcome to check</param>
        public Boolean validate(CharacterVector caller, CharacterVector textToValidate)
        {
            //code to validate ToDo
            return true;
            throw new System.NotImplementedException();
        }


        /// <summary>
        /// checks the validity of the _state string
        /// </summary>
        private LogicalVector validateState(CharacterVector _state)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// checks the validity of the _outcome
        /// </summary>
        private LogicalVector validateOutcome(CharacterVector _outcome)
        {
            throw new System.NotImplementedException();
        }
    }
}
