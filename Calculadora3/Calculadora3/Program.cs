using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormMain main = new FormMain();

            List<Persona> _personas1 = new List<Persona>();

            Persona JP = new Persona("Juan", "Perez");
            Persona JPV = new Persona("Juan Pablo", "Varsky");
            Persona JRR = new Persona("Juan Román", "Riquelme");

            _personas1.Add(JP);
            _personas1.Add(JPV);
            _personas1.Add(JRR);

            Application.Run(main);
        }
    }
}
