using Microsoft.Win32;
using System.Security.AccessControl;
namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string source = @"HKEY_LOCAL_MACHINE\SOFTWARE\Humeniuk";
            Registry.SetValue(source, "P6", new string[] { "Я - студент/студентка кафедрі", "комп’ютерноїінженерії!" }, RegistryValueKind.MultiString);
            MessageBox.Show("Дані успішно внесено в реєстр");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey regLM = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Humeniuk");

            string[] value;
            value = (string[])regLM.GetValue("P5");
            string allS = "";

            foreach(string i in value){
                allS += (" " + i);
            }
            MessageBox.Show(allS);
            regLM.Close();
        }
    }
}