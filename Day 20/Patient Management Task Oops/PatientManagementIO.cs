using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagementApp
{
    class CheckCustomException : Exception
    {
        public CheckCustomException(string str) : base(str)
        {

        }
    }
    class PatientManagementIO
    {
        PatientService patientservice = new PatientService();
        public byte Menu()
        {
            Console.WriteLine("Press 1 to Admit the Patient ");
            Console.WriteLine("Press 2 to View All Patients");
            Console.WriteLine("Press 3 to Update/Edit Patient Details");
            Console.WriteLine("Press 4 to Discharge the patient");
            Console.WriteLine("Press 5 to Exit");
            Console.WriteLine("Enter Your choice:");
            try
            {
                byte option = Convert.ToByte(Console.ReadLine());
                return option;
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a Valid Input\n");
                return Menu();
            }
        }
        public void Add()
        {
            try
            {
                Console.WriteLine("Enter Patient ID:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Patient Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Patient  Age:");
                byte age = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter Patient Address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter Disease Name:");
                string disease = Console.ReadLine();
                Console.WriteLine("Enter Doctor Charges:");
                double doctor_charge = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Patient Room No:");
                int room_No = int.Parse(Console.ReadLine());
                Patient p = patientservice.Add(id, name, address, disease, age, doctor_charge, room_No);
                Display(p);
                Console.WriteLine("".PadLeft(15, '-'));
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a Valid Input\n");
                Add();
            }

        }
        private void Display(Patient patient)
        {
            if (patient == null)
            {
                throw new CheckCustomException("patient  Not Found");
            }
            else
            {
                Console.WriteLine("".PadLeft(15, '-'));
                Console.WriteLine("ID: " + patient.ID);
                Console.WriteLine("Name: " + patient.Name);
                Console.WriteLine("Age: " + patient.Age);
                Console.WriteLine("Address : " + patient.Address);
                Console.WriteLine("Disease: " + patient.Disease);
                Console.WriteLine("Doctor Charge: " + patient.Doctor_Charge);
                Console.WriteLine("Room No: " + patient.Room_No);
            }
        }
        public void DisplayAll()
        {
            Console.WriteLine();
            patientservice.DisplayAll();
            Console.WriteLine();
        }
        public void DeletePatient()
        {
            try
            {
                Console.WriteLine("Enter Id:");
                string id = Console.ReadLine();
                if (patientservice.DeletePatient(id))
                {
                    Console.WriteLine("Patient discharged  successfully");
                }
                else
                {
                    Console.WriteLine("Patient  Not Found!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a Valid Input\n");
                DeletePatient();
            }
        }
        public void UpdatePatient()
        {
            Console.WriteLine("Press 1 to update Address");
            Console.WriteLine("Press 2 to update Disease");
            Console.WriteLine("Press 3 to update Room No");
            Console.WriteLine("Enter Your Choice");
            try
            {

                switch (Convert.ToByte(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter Id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        string address = Console.ReadLine();
                        Display(patientservice.UpdateAddress(id, address));
                        break;

                    case 2:
                        Console.WriteLine("Enter Id:");
                        string Id = Console.ReadLine();
                        Console.WriteLine("Enter Disease:");
                        string disease = Console.ReadLine();
                        Display(patientservice.UpdateDisease(Id, disease));
                        break;

                    case 3:
                        Console.WriteLine("Enter Id:");
                        string ID = Console.ReadLine();
                        Console.WriteLine("Enter Room No:");
                        int room_No = int.Parse(Console.ReadLine());
                        Display(patientservice.UpdateRoomNo(ID, room_No));
                        break;

                    default:
                        Console.WriteLine("Enter a Valid Option");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a Valid Input\n");
                UpdatePatient();
            }
        }

    }
}
