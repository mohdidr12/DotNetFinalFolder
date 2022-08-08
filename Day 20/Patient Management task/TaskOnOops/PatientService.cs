using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagementApp
{
    class PatientService:IPatient
    {
        List<Patient> lList = new List<Patient>();
        public Patient Add(string id,string name,string address,string disease,byte age,double doctor_charge,int room_No)
        {
            Patient p = new Patient(id, name, address, disease, age, doctor_charge, room_No);
            lList.Add(p);
            return p;
        }
        public Patient getPatientById(string id)
        {
            if (lList.Count != 0)
            {
                foreach (Patient p in lList)
                {
                    if (p.ID == id)
                    {
                        return p;
                    }

                }
                return null;
            }
            else
            {
                return null;
            }
        }
        public Patient UpdateAddress(string id,string address)
        {
            if(lList.Count!=0)
            {
                foreach(Patient p in lList)
                {
                    if(p.ID==id)
                    {
                        p.Address = address;
                        return p;
                    }
                }
                return null;
            }
            return null;
        }
        public Patient UpdateDisease(string id, string disease)
        {
            if (lList.Count != 0)
            {
                foreach (Patient p in lList)
                {
                    if (p.ID == id)
                    {
                        p.Disease = disease;
                        return p;
                    }
                }
                return null;
            }
            return null;
        }
        public Patient UpdateRoomNo(string id, int room_No)
        {
            if (lList.Count != 0)
            {
                foreach (Patient p in lList)
                {
                    if (p.ID == id)
                    {
                        p.Room_No = room_No;
                        return p;
                    }
                }
                return null;
            }
            return null;
        }
       public  void DisplayAll()
        {
            if(lList.Count==0)
            {
                throw new CheckCustomException("No pateints are there to Display");
            }
            else
            {
                Console.WriteLine("All Patients Details are ");
                foreach (Patient p in lList)
                {
                    
                    Console.WriteLine("Patient ID is " + p.ID);
                    Console.WriteLine("Patient Name is " + p.Name);
                    Console.WriteLine("Patient Address is " + p.Address);
                    Console.WriteLine("Patient Disease is " + p.Disease);
                    Console.WriteLine("Patient Age is " + p.Age);
                    Console.WriteLine("Doctor Charges is " + p.Doctor_Charge);
                    Console.WriteLine("Patient Room No is " + p.Room_No);
                }
            }
        }
       public  bool DeletePatient(string id)
        {
            if(lList.Count!=0)
            {
                Patient p = getPatientById(id);
                if(p!=null)
                {
                    lList.Remove(p);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
