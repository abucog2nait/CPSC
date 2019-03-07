using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        //this static variable is being used in this demo example
        //   to hang unto the dummy data.
        public static List<DDLClass> DataCollection;

        protected void Page_Load(object sender, EventArgs e)
        {
            //this event method is executed EACH and EVERY time
            // this page is processed
            //this event method is executed BEFORE ANY EVENT method is processed

            //Clear out all old messages 
            OutputMessage.Text = "";


            //this page is an excellent place to do page initialization
            //  of your controls.
            //there is a property to test for post back of your
            //  page called Page.IsPostBack (Razor: IsPost)
            if (!Page.IsPostBack)
            {
                //do 1st page initialization processing

                //create an instance of the data collection list
                DataCollection = new List<DDLClass>();

                //load the data collection with dummy data
                //normally this data would come from your database
                DataCollection.Add(new DDLClass(1, "COMP1008"));
                DataCollection.Add(new DDLClass(2, "CPSC1517"));
                DataCollection.Add(new DDLClass(3, "DMIT2018"));
                DataCollection.Add(new DDLClass(4, "DMIT1508"));

                //to sort a List<T> use the method .Sort()
                //(x,y) x and y represent any two instances in your list at any time
                //x.field compared to y.field : ascending
                //y.field compared to x.field : descending
                DataCollection.Sort((x,y) => x.DisplayField.CompareTo(y.DisplayField));

                //setup the dropdownlist (radiobuttonlist, checkboxlist)
                //a) assign your data to the control
                CollectionList.DataSource = DataCollection;

                //b) assign the data list field names to
                //      the appropriate control properties
                //  i) .DataValueField this is the value of the select option
                // ii) .DataTextField this is the display of the select option
                CollectionList.DataValueField = "ValueField";
                CollectionList.DataTextField = nameof(DDLClass.DisplayField);

                //c) phyiscally bind the data to the control for show
                CollectionList.DataBind();

                //what about a prompt?
                //one can add a prompt to the start of the BOUND control list
                //one will use the index 0 to position the prompt
                CollectionList.Items.Insert(0, "select ....");

            }
        }

        protected void SubMitButton_Click(object sender, EventArgs e)
        {
            //This method is executed when the submit button is submit is pressed 
            //This method is concered with the actions needed for the dubmit button 


            //To access the data of a control, you use the appropriate control (object) property (get. set) and access technique

            //For Textbox, Label, Literal use .Text
            //for a list (DropDownList, RadioButtonList) use one of
            //  .SelectedIndex  the physical location of the item in the list 
            //  .SelectedItem   the associated data display text of the item in the list
            //for the boolean controls (RadioButton, Checkbox ) use .Checked
            //Most controls will use strings except for boolean controls


            string submitchoice = TextBoxNumericChoice.Text;

            //Sample validation 
            if(string.IsNullOrEmpty(submitchoice))
            {
                OutputMessage.Text = "Enter a course choice of 1-4";
            }
            else
            {
                //Set the RadioButtonList using the entered data value
                //property: .SelectedValue 
                RadioButtonListChoice.SelectedValue = submitchoice;

                //Set the checkbox to on if the choice was a programming language
                if(submitchoice.Equals("2") || submitchoice.Equals("3"))
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }
                //position in the dropdownlist
                //use the entered data value to position
                //property: .SelectedValue
                CollectionList.SelectedValue = submitchoice;

                //demonstate the 3 different access technique for a list 
                //output will be to a label (appearance will be read only)
                DisplayReadOnly.Text = CollectionList.SelectedItem.Text
                    + " at index " + CollectionList.SelectedIndex
                    + " has a value of " + CollectionList.SelectedValue;
            }//end of if
        }//end of method submit choice
    }//end of class form class
}