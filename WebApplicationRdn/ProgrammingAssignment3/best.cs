using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using RDotNet;

namespace WebApplicationRdn
{
    public class best
    {
        /// <summary>
        /// 2-character abbreviated name of a _state
        /// </summary>
        private CharacterVector State;
        /// <summary>
        /// one of “heart attack”, “heart failure”, or “pneumonia”
        /// </summary>
        private CharacterVector Outcome;
        /// <summary>
        /// _outcome-of-care-measures.csv:
        /// </summary>
        /// <remarks>Contains information about 30-day mortality and readmission rates for heart attacks, heart failure, and pneumonia for over 4,000 hospitals.</remarks>
        private DataFrame outcomeOfCareMeasures;
        /// <summary>
        /// use this object to validate a given field based on its  setter object
        /// </summary>
        private validate v;

        /// <summary>
        /// a character vector with the name of the hospital that has the best (i.e. lowest) 30-day mortality for the specified _outcome in that _state
        /// </summary>
        public String best(CharacterVector state, CharacterVector outcome)
        {
            validate v = new validate();
            _state = state;
            _outcome = outcome;
            return getBest(State, Outcome);
        }
        /// <summary>
        /// _outcome enumeration
        /// </summary>
        private enum outcomeEnum
        {
            heartattack, heartfailure, pneumonia
        };

        internal CharacterVector _state
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                if (v.validate(this.ToString(), _state))
                {
                    State = _state;
                }
                else
                {
                    throw new System.Exception("invalid state");
                }
            }
        }

        internal CharacterVector _outcome
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set

            {
                if (v.validate(this.ToString(), _outcome))
                {
                    Outcome = _outcome;
                }
                else
                {
                    throw new System.Exception("invalid outcome");
                }
            }
        }

        /// <remarks>
        /// Hospitals that do not have data on a particular _outcome should be excluded from the set of hospitals when deciding the rankings.
        /// Handling ties. If there is a tie for the best hospital for a given _outcome, then the hospital names should be sorted in alphabetical order and the first hospital in that set should be chosen (i.e. if hospitals “b”, “c”, and “f” are tied for best, then hospital “b” should be returned).
        /// </remarks>
        public CharacterVector _best
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// use R function to  find and return  best hospital
        /// </summary>
        internal CharacterVector getBest(CharacterVector state, string outcome)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// case statement to set enum
        /// </summary>
        internal Factor enumOutcome(CharacterVector outcome)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Code book
        /// </summary>
        private DataFrame outcomeCodes;

        /// <summary>
        /// Code book
        /// </summary>
        public DataFrame _outcomeCodes
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
