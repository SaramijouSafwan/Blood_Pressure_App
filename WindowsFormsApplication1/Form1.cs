using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void signup_Click(object sender, EventArgs e)
        {
            ServiceReference1.USERClient obj = new ServiceReference1.USERClient();
            obj.signUp(ssnText.Text, nameText.Text, passwordText.Text, ageText.Text, genderText.Text, weightText.Text);

        }

        private void update_Click(object sender, EventArgs e)
        {
            ServiceReference1.USERClient obj = new ServiceReference1.USERClient();
            obj.updateUser(ssnText.Text, nameText.Text, passwordText.Text, ageText.Text, genderText.Text, weightText.Text);
        }

        private void find_Click(object sender, EventArgs e)
        {
            ServiceReference1.USERClient obj = new ServiceReference1.USERClient();
            string[] userInfo = obj.findUser(ssnText.Text);
            nameText.Text = userInfo[1];
            passwordText.Text = userInfo[2];
            ageText.Text = userInfo[3];
            genderText.Text = userInfo[4];
            weightText.Text = userInfo[5];
        }

        private void signin_Click(object sender, EventArgs e)
        {
            ServiceReference1.USERClient obj = new ServiceReference1.USERClient();
            ssnText.Text = obj.signIn(nameText.Text, passwordText.Text);
        }

        private void measure_Click(object sender, EventArgs e)
        {
            ServiceReference2.BLOOD_PRESSUREClient obj = new ServiceReference2.BLOOD_PRESSUREClient();
            status.Text = "Status : "  + obj.measureBloodPressure(ssnText.Text, float.Parse(upperText.Text), float.Parse(lowerText.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.BLOOD_PRESSUREClient obj = new ServiceReference2.BLOOD_PRESSUREClient();
            string pressure = obj.measureBloodPressure(ssnText.Text, float.Parse(upperText.Text), float.Parse(lowerText.Text));
            string[] result = obj.getDietPlan(pressure.Split('-')[0]);
            dietPlan.Items.Clear();
            dietPlan.Items.AddRange(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference2.BLOOD_PRESSUREClient obj = new ServiceReference2.BLOOD_PRESSUREClient();
            string[] result = obj.trackBloodPressure(ssnText.Text);
            bloodPressure.Items.Clear();
            bloodPressure.Items.AddRange(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference2.BLOOD_PRESSUREClient obj = new ServiceReference2.BLOOD_PRESSUREClient();
            obj.notifyUser(true, 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference2.BLOOD_PRESSUREClient obj = new ServiceReference2.BLOOD_PRESSUREClient();
            MessageBox.Show(obj.cheakMail());
        }
    }
}
