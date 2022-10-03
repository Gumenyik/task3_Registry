using Microsoft.Win32;

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
            RegistryKey regLM = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Humeniuk");

            regLM.SetValue("P")
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
        }
    }
}