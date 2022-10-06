using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P229desktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Test()
        {
            MessageBox.Show("P229 First desktop App");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            long result = await Loop();

            //Task task = Task.Run(() =>
            //{
            //    for (long i = 0; i < 999999999999; i++)
            //    {
            //        result += i;
            //    }
            //});

            //await task;

            //for (long i = 0; i < 999999999999; i++)
            //{
            //    result += i;
            //}

            label1.Text = result.ToString();
        }

        public async Task<long> Loop()
        {
            long result = 0;

            Task task = Task.Run(() =>
            {
                for (long i = 0; i < 999999999999; i++)
                {
                    result += i;
                }
            });

            await task;

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World P229 Last CSharp Lesson");
        }
    }
}
