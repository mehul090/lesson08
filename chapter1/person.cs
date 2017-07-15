using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    /// <summary>
    /// this is the person class
    /// </summary>
    class person
    {
        //private instance variables(fields)

        private string _name;
        private int _age;

        //public properties----------------
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age =value;
            }
        }
        // constructo---------------

            /// <summary>
            /// this is the constructor for person class
            /// it takes two argument - name(string)and age
            /// </summary>
            /// <param name="name"></param>
            /// <param name="age"></param>
        public person(string name, int age)
        {
            this.Name = _name;
            Age = _age;
        }
       //public methid--------
       public void talks()
        {
            Console.WriteLine(Name + "is talking");
        }
        
    }
}
