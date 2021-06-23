﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEssentials
{
    class Student
    {
        #region State/Fields

        private string id; //camel Case ex; excelSoft , helloWorld ,thinkPad,
        private string name;
        #endregion
        #region Propoerties

        public string Id
        {
            //mutators
            // public string get_Id()
            get {

                //Get Mutator Body
                return this.id;
            }
            //public void set_id(string value)
            set {
                //Set Mutator Method Body
                this.id = value;
            }
        }

        public string Name
        {
            get { return this.name; }
        }

        //Auto Properties
        //Private Backing Field is Generated By Compiler
        public int Age { get; set; }
        #endregion
        #region Initializers / Constructors
        public Student()
        {
            

            //Initialize Data Members

        }
        //Static Initalizer
        static Student()
        {
            
        }

        #endregion




    }
}