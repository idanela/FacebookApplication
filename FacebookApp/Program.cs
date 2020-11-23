using System;

namespace FacebookAppUI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}

