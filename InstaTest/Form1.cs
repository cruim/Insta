using System;
using System.Drawing;
using System.IO;
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


        private static string fullProxy;
        static string email;
        static string pass;
        static string proxy;
        static string port;
        static string proxyLogin;
        static string proxyPass;
        static string name;
        static string nickname;

        string midCoockie = "Vtmq0AAEAAHzRAsP6Tmc1C5AnjI8";

        public static void ParsingProxy()
        {
            var xx = new StreamReader("proxy.txt");
            string input = xx.ReadLine();
            string pattern = @"(.*):(.*)@(.*):(.*)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            fullProxy = match.Groups[0].Value;
            proxyLogin = match.Groups[1].Value;
            proxyPass = match.Groups[2].Value;
            proxy = match.Groups[3].Value;
            port = match.Groups[4].Value;
            xx.Close();
            OperationsWithFile.DeleteFirstLineFromFile("proxy.txt");
            xx.Close();
        }

        public static void GetNameFromFile()
        {
            var xx = new StreamReader("name.txt");
            string input = xx.ReadLine();
            name = input;
            xx.Close();
            OperationsWithFile.DeleteFirstLineFromFile("name.txt");
        }

        public static void GetEmailFromFile()
        {
            var xx = new StreamReader("email.txt");
            string input = xx.ReadLine();
            email = input;
            xx.Close();
            OperationsWithFile.DeleteFirstLineFromFile("email.txt");
        }

        public static void GetPassFromFile()
        {
            var xx = new StreamReader("pass.txt");
            string input = xx.ReadLine();
            pass = input;
            xx.Close();
            OperationsWithFile.DeleteFirstLineFromFile("pass.txt");
        }

        public static void WriteFinalInfoInFile()
        {
            string finalInfo = nickname + ":" + pass + ";" + fullProxy + "\n";
            File.AppendAllText("finalResult.txt", finalInfo); //write in file
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2999);

            int count = File.ReadAllLines("proxy.txt").Length; // number of line in file

            //System.Diagnostics.Process.Start("www.instagram.com");

            for (int i = 0; i < 2; i++)
            {


                ParsingProxy();
                //m.Close();
                /*OperationsWithFile.DeleteFirstLineFromFile("proxy.txt");*/ // delete first line from file



                System.Diagnostics.Process.Start("www.instagram.com");
                System.Threading.Thread.Sleep(5000);
                Cursor.Position = new Point(1325, 95); //"свойства:интернет"
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(320, 510); //"настройка сети"
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                Cursor.Position = new Point(150, 355); //input proxy
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                SendKeys.Send("^{a}");
                //VirtualMouse.DoubleLeftClick();
                System.Threading.Thread.Sleep(2999);
                Clipboard.SetText(proxy);
                SendKeys.Send("^{v}");
                System.Threading.Thread.Sleep(2999); //input port
                Cursor.Position = new Point(240, 355);
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                SendKeys.Send("^{a}");
                System.Threading.Thread.Sleep(2999);
                Clipboard.SetText(port);
                SendKeys.Send("^{v}");
                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(240, 427);
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(75, 45); //refersh
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                Clipboard.SetText(proxyLogin); //insert proxyName
                SendKeys.Send("^{v}");
                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(660, 245); //insert proxyPass
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                Clipboard.SetText(proxyPass);
                SendKeys.Send("^{v}");
                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(680, 320);
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick(); //click


                Cursor.Position = new Point(1250, 45); //coockie
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999); //delete coockie
                Cursor.Position = new Point(750, 75);
                System.Threading.Thread.Sleep(4000);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(75, 45); //refersh
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(1250, 45); //coockie
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                Cursor.Position = new Point(850, 250);
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick(); //doubleclick in "Значение"
                SendKeys.Send("^{a}");
                System.Threading.Thread.Sleep(2999);
                Clipboard.SetText(midCoockie); //insert into buffer midCoockie value
                SendKeys.Send("^{v}"); //ctrl+v into "Значение" in plaggin
                Cursor.Position = new Point(980, 505); //save midCoockie
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(75, 45); //refersh
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);


                Cursor.Position = new Point(850, 435); //name field
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                GetNameFromFile();
                Clipboard.SetText(name);
                SendKeys.Send("^{v}");

                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(850, 400); //email field
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                GetEmailFromFile();
                Clipboard.SetText(email);
                SendKeys.Send("^{v}");

                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(850, 510);
                System.Threading.Thread.Sleep(2999); //pass field
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                GetPassFromFile();
                Clipboard.SetText(pass);
                System.Threading.Thread.Sleep(2999);
                SendKeys.Send("^{v}");


                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(850, 470); //copy nickname in file
                VirtualMouse.LeftClick();
                SendKeys.Send("^{a}");
                System.Threading.Thread.Sleep(2999);
                SendKeys.Send("^{c}");
                nickname = Clipboard.GetText(TextDataFormat.Text);
                WriteFinalInfoInFile();



                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(850, 555); //registration click
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(3000);
                VirtualMouse.LeftClick();

                Cursor.Position = new Point(1250, 45); //coockie
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999); //delete coockie
                Cursor.Position = new Point(750, 75);
                System.Threading.Thread.Sleep(4000);
                VirtualMouse.LeftClick();
                System.Threading.Thread.Sleep(2999);
                Cursor.Position = new Point(200, 200);
                System.Threading.Thread.Sleep(2999);
                VirtualMouse.LeftClick();
                SendKeys.Send("^{w}");

            }
        }
    }
}

