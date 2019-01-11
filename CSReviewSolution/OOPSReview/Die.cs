using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    public class Die
    {
        //Data Members
        //Usually private 
        private int _Side;
        private string _Color;
        private int _FaceValue;
        
        //Properties
        //are responsible for assigning and retrieving data to/from their associated data member.
        //retrieving a data from a Data Member a get{}
        //assigning data from a Data Member uses a set{}
        //properties need to be exposed to outside users.
        //properties will have a return data type BUT no perameter list. 

        //Fully Implemented Property 
        //has a defined Data Memeber that the developer can directly access. 
        public int Side
        {
            get
            {
                //returns data of a specified DataType. 
                return _Side;
            }
            set
            {
                //assigns a supplied value to the Data Member.
                //the supplied value is located in the key word: value
                //_Side need to equal the value not the other way around. Not the Value need to equal _Side
                //optionally include data value validation to insure an appropriate value has been supplied
                if (value >= 6 && value <= 20)
                {
                    //this is a acceptable value to keep 
                    _Side = value;
                }
                else
                {
                    //this is an unacceptable value
                    //issue a user friendly error message
                    throw new Exception("Die cannot be a " + value.ToString() + " sided. Die must be between 6 and 20 sided.");
                }
                _Side = value;
            }
        }

        //Auto Implemented Property 
        //NO Data Member definition 
        // the Data Member is internally created for you. 
        // the Data Memeber datatype is taken from your data type specified on the property header. 
        //auto implemted properties are usually used when there is no need to internal validation. 
        //access to a value managed by an auto implemented property MUST be done via property. 
        public int FaceValue { get; set;  }
    }
}
