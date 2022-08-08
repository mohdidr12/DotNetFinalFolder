using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEvent
{
    public class Button
    {
        public delegate void EventHandler();
        public event EventHandler OnClick; //event name
        //Method
        public void Click()
        {
            OnClick();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.OnClick += new Button.EventHandler(Button_Click);
        }
        public static void Button_Click()
        {
            Console.WriteLine("Button Clicked");
            
        }
    }
}
