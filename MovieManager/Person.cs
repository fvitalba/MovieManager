using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager {
    class Person {
        //Attributes
        private String name;
        private String surname;
        
        //Constructors
        public Person(String name, String surname) {
            this.setName(name);
            this.setSurname(surname);
        }

        //Getter and Setter
        public void setName(String name)    {
            if (name == null)   {
                return;
            }
            this.name = name;
        }

        public String getName() {
            return this.name;
        }

        public void setSurname(String surname) {
            if (surname == null)   {
                return;
            }
            this.surname = surname;
        }

        public String getSurname() {
            return this.surname;
        }

        //Methods
        public String toString() {
            return "[" + this.getName() + " " + this.getSurname() + "]";
        }

        public Boolean equals(Person p) {
            if (p == null)   {
                return false;
            }

            return (p.getName().Equals(this.getName())) && (p.getSurname().Equals(this.getSurname()));
        }
    }
}
