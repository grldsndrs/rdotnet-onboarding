using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using RDotNet;

namespace WebApplicationRdn
{
    public class rankhospital:best
    {
        private CharacterVector state;
        private CharacterVector outcome;
        private CharacterVector num;
        /// <summary>
        /// a character vector with the name of the hospital that has the ranking specified by the num argument
        /// </summary>
        private CharacterVector hospitalWithRank;
        /// <summary>
        /// get the num-th hospital
        /// </summary>
        /// <param name="state">the 2-character abbreviated name of a state (state)</param>
        /// <param name="outcome">an outcome (outcome)</param>
        /// <param name="num">the ranking of a hospital in that state for that outcome (num).</param>
        public  CharacterVector getRankedX(CharacterVector state, CharacterVector outcome, CharacterVector num)
        {
            CharacterVector answer = num;
            return  answer;
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// use R function to  find and return  worst hospital
        /// </summary>
        public CharacterVector getWorst(CharacterVector state, CharacterVector outcome)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// read.csv
        /// </summary>
        /// <param name="fileName">csv file</param>
        /// <param name="parameter">parameters for read.csv</param>
        public DataFrame getData(CharacterVector fileName, string parameter)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// reads the outcome-of-care-measures.csv file
        /// </summary>
        private DataFrame outcomeOfCareMeasuresCsv
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal CharacterVector _state
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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
            }
        }

        internal RDotNet.CharacterVector _num
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
