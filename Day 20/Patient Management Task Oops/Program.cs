using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PatientManagementIO patient = new PatientManagementIO();
            bool flag = true;
            while (flag)
            {
                switch (patient.Menu())
                {
                    case 1:
                        patient.Add();
                        break;

                    case 2:
                        patient.DisplayAll();
                        break;

                    case 3:
                        patient.UpdatePatient();
                        break;

                    case 4:
                        patient.DeletePatient();
                        break;

                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
