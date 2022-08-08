using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagementApp
{
    class Patient
    {
        string id, name, address, disease;
        byte age;
        double doctor_charge;
        int room_No;

        public Patient(string id, string name,string address,string disease,byte age,double doctor_charge,int room_No)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.disease = disease;
            this.age = age;
            this.doctor_charge = doctor_charge;
            this.room_No = room_No;
        }
        public string ID   // property
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public string Address  // property
        {
            get { return address; }   // get method
            set { address = value; }  // set method
        }
        public string Disease   // property
        {
            get { return disease; }   // get method
            set { disease = value; }  // set method
        }
        public byte Age  // property
        {
            get { return age; }   // get method
            set { age = value; }  // set method
        }
        public double Doctor_Charge   // property
        {
            get { return doctor_charge; }   // get method
            set { doctor_charge = value; }  // set method
        }
        public int Room_No  // property
        {
            get { return room_No; }   // get method
            set { room_No = value; }  // set method
        }

    }
}

