using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp1_ADDREFERENCE
{
    public delegate void DelEventHandler();
    //public delegate void Eventhandler (object sende , EventArgs e);
    class Program:Form
    {
        public event DelEventHandler add;
        public Program()
        {
            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "Hit Me";
            btn.Location = new Point(100, 100);

            //Event handler is assigned to 
            //the button click event
            btn.Click += new EventHandler(onClick);
            add += new DelEventHandler(Initiate);
            //invoke the event
            add();
        }
        public void Initiate()
        {
            Console.WriteLine("Event Initiated");
        }
        //Call when button clicked
        public void onClick(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked now");

        }
        static void Main(string[] args)
        {
            Application.Run(new Program());
            Console.ReadLine();
        }
    }
}
