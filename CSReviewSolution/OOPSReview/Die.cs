using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    public class Die
    {
        //Class lever variable ehich will be an instance of the System namespace math class Random. 
        //create a static instance which will be used for ALL Die instances created by the programmer/ developer
        //this instance of Random will be generated once on the first Die instance that is created.
        private static Random _rnd = new Random();

        //Data Members
        //Usually private  
        private int _Sides;
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
        public int Sides
        {
            get
            {
                //returns data of a specified DataType. 
                return _Sides;
                 
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
                    _Sides = value;
                    Roll(); 
                }
                else
                {
                    //this is an unacceptable value
                    //issue a user friendly error message
                    throw new Exception("Die cannot be a " + value.ToString() + " sided. Die must be between 6 and 20 sided.");
                }
                _Sides = value;
            }
        }

        
        public string Color
        {
            get
            {
                //return Data Member
                return _Color;
            }
            set
            {
                //value.Trim() == ""
                //value == null
                if (string.IsNullOrEmpty(value)) // IsNullOrEmpty or NullOrWhiteSpace 
                {
                    throw new Exception("You must supply a color string for the die.");
                }
                else
                {

                }
            }
        }
        // or you can right it as a auto implemented property public string Color { get; private set; } 

        //Auto Implemented Property 
        //NO Data Member definition 
        // the Data Member is internally created for you. 
        // the Data Memeber datatype is taken from your data type specified on the property header. 
        //auto implemted properties are usually used when there is no need to internal validation. 
        //access to a value managed by an auto implemented property MUST be done via property. 
        //If your auto implemented property to have validatin then a good practice is to use a private set and have the validation done somewhere/somehow elsewhere in the class
        public int FaceValue { get; private set; }

        //Constructor 
        //Optional 
        //Purpose of a construtor is to insure that when an instance of a class is created, it will be created within a stable state; ALWAYS. 
        // You do NOT call the constructor directly. It is called for you when you create an instance of a class. 
        //if you do not code the construct then the operating system will assign, a default value memeber/auto implemented property internally member matching the data type of that item.
        //if you DO code a construtor thne you are responsible for ALL the constructors for the class

        //syntax public classname([list of parameter]) { coding block }

        //Default Constructor
        //Is similar to the system default constructor 
        public Die()
        {
            //if you leave this coding block empty, it would be the same as using a default constructor

            //optionally you can set your own default values. 
            _Sides = 6;      //via data member
            Color = "White"; //via property 
            Roll();
        }


        //Greety COnstrutor
        //this constructor will allow the user of the class to pass in a set of values which will be used at the time of instance creation to set the value of the internal data member/auto properties. 

        public Die(int sides, string color)
        {
            Sides = sides;
            Color = color;
            Roll(); //is an internal method of this Die class
        }
        
        //Behaviours (Methods) 
        //Are methods that can be used by the outside user to: 
        // a) use instance data to generate and return information 
        // b) use instance data to generate and return information. 
        public void Roll()//dont need to pass anythig in the parameter cause the class already has the sides
        {
            //Random can  take a set of values and produce a integer value between the two values, where the minimum value is inclusive and the maximium value is exclusive. 
            FaceValue = _rnd.Next(1, _Sides + 1);
        }

    }
}
