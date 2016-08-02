using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
 
namespace log_file
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            
        }
         
        private void press_log_button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = File.AppendText("log/log.txt"))
            {
                Log("This is the log of my application here you can wether it is running correctly, please be reminded the this is great application!", w); 
            }

            using (StreamReader r = File.OpenText("log/log.txt"))
            {
                DumpLog(r);
            }
        } 
         
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString()); 
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("----------------------------------------------------------------------------------");
        } 

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
