using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Project.Data_Access_Layer;
using PRG282_Project.Presentation_Layer;

namespace PRG282_Project.BusinessLogic_layer
{
    class Student  
    {
        private int studentnum;
        private string name;
        private string surname;
        private object studentimage;
        private DateTime dob;
        private bool gender;
        private int phonenumber;
        private string address;
        private string modulecode;

       
        public int Studentnum { get => studentnum; set => studentnum = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public object Studentimage { get => studentimage; set => studentimage = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public bool Gender { get => gender; set => gender = value; }
        public int Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Address { get => address; set => address = value; }
        public string Modulecode { get => modulecode; set => modulecode = value; }

        public Student(int studentnum, string name, string surname, object studentimage, DateTime dob, bool gender, int phonenumber, string address, string modulecode)
        {
            this.studentnum = studentnum;
            this.name = name;
            this.surname = surname;
            this.studentimage = studentimage;
            this.dob = dob;
            this.gender = gender;
            this.phonenumber = phonenumber;
            this.address = address;
            this.modulecode = modulecode;
        }
    }
}
