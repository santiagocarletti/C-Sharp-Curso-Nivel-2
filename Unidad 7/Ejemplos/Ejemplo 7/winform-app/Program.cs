﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    //TEMATICA EJEMPLO 7: DATAGRIDVIEW: PROPIEDADES VARIAS - ANNOTATIONS
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
            Application.Run(new frmPokemons());
        }
    }
}
