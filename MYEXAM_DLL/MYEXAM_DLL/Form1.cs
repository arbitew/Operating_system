using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace MYEXAM_DLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(System.IO.File.Exists("EXAM_DLL.dll").ToString());
            Assembly a = Assembly.Load("EXAM_DLL");
            Object o = a.CreateInstance("EXAM_DLL.calci");
            Type t = a.GetType("EXAM_DLL.calci");
            Object[] numbers = new Object[2];
            numbers[0] = 2;
            numbers[1] = 3;
            MethodInfo mi = t.GetMethod("add");
            MessageBox.Show(Convert.ToString(mi.Invoke(o, numbers)));
        }
    }
}
