using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using InstaTest;

namespace Demo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        static string email;
        static string pass;
        static string proxy;
        static string port;
        static string proxyLogin;
        static string proxyPass;
        static string name;
        string midCoockie = "Vtmq0AAEAAHzRAsP6Tmc1C5AnjI8";
        Random random = new Random();

        public static void ParsingProxy()
        {
            var xx = new StreamReader("proxy.txt");
            string input = xx.ReadLine();
            //string input = "ywSICy:PgZuYf@185.147.128.14:8000";
            string pattern = @"(.*):(.*)@(.*):(.*)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            string proxyName = match.Groups[1].Value;
            string proxyPass = match.Groups[2].Value;
            proxy = match.Groups[3].Value;
            string port = match.Groups[4].Value;
            //xx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int count = File.ReadAllLines("proxy.txt").Length; // number of line in file

            for (int i = 0; i < count; i++)
            {


                ParsingProxy();
                //m.Close();
                /*OperationsWithFile.DeleteFirstLineFromFile("proxy.txt");*/ // delete first line from file



                //System.Diagnostics.Process.Start("www.instagram.com");
                //System.Threading.Thread.Sleep(5000);
                //Cursor.Position = new Point(1325, 95); //"свойства:интернет"
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(320, 510); //"настройка сети"
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //Cursor.Position = new Point(150, 355); //"адрес"
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.DoubleLeftClick();
                //System.Threading.Thread.Sleep(2000);
                Clipboard.SetText(proxy);
                //SendKeys.Send("^{v}");
                //System.Threading.Thread.Sleep(2000); //"порт"
                //Cursor.Position = new Point(240, 355);
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.DoubleLeftClick();
                //System.Threading.Thread.Sleep(2000);
                Clipboard.SetText(port);
                //SendKeys.Send("^{v}");
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(240, 427);
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(75, 45); //refersh
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(2000);
                Clipboard.SetText(proxyLogin); //insert proxyName
                //SendKeys.Send("^{v}");
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(660, 245); //insert proxyPass
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(2000);
                Clipboard.SetText(proxyPass);
                //SendKeys.Send("^{v}");
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(680, 320);
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick(); //click

                //Cursor.Position = new Point(1250, 45); //coockie
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(2000); //delete coockie
                //Cursor.Position = new Point(750, 75);
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(75, 45); //refersh
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(1250, 45); //coockie
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //Cursor.Position = new Point(850, 250);
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.DoubleLeftClick(); //doubleclick in "Значение"
                //System.Threading.Thread.Sleep(2000);
                Clipboard.SetText(midCoockie); //insert into buffer midCoockie value
                //SendKeys.Send("^{v}"); //ctrl+v into "Значение" in plaggin
                //Cursor.Position = new Point(980, 505); //save midCoockie
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(75, 45); //refersh
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(850, 435); //name field
                //System.Threading.Thread.Sleep(2000);
                //VirtualMouse.LeftClick();
                Clipboard.SetText(name);
                //SendKeys.Send("^{v}");
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(850, 400); //email field
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(2000);
                Clipboard.SetText(email);
                //SendKeys.Send("^{v}");
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(850, 510); //pass field
                //VirtualMouse.LeftClick();
                Clipboard.SetText(pass);
                //SendKeys.Send("^{v}");
                //System.Threading.Thread.Sleep(2000);
                //Cursor.Position = new Point(850, 555); //registration click
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(3000);
                //VirtualMouse.LeftClick();
            }



        }
    }
}
