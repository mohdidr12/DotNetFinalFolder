using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagementApp
{
    interface IPatient
    {
        Patient  Add(string id,string name, string address, string disease, byte age, double doctor_charge, int room_No);
        Patient UpdateAddress(string id, string address);
        Patient UpdateDisease(string id, string disease);
        Patient UpdateRoomNo(string id, int room_No);
        void DisplayAll();
        bool DeletePatient(string id);
    }
}
