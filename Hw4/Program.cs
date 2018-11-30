using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Hollywood.MovieInfoServiceSoapClient HWclient;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HWclient = new Hollywood.MovieInfoServiceSoapClient("MovieInfoServiceSoap");
            Application.Run(new FormMovieSearch());
        }
    }
}
