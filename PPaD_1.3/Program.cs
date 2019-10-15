using GammaChiperLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPaD_1._3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var chiper = new GammaChiper();
            var enc = chiper.Encrypt("ВДОВИЧЕНКО", "ПРОГРАМНЫЙ");
            var dec = chiper.Decrypt(enc, "ПРОГРАМНЫЙ");
            File.WriteAllText("test.txt", $"{enc}|{dec}");
            MessageBox.Show($"{chiper.Test(206,201)}");
            Application.Run(new Form1());
            
        }
    }
}
