using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Creator
{
    public partial class Form1 : Form
    {
        List<Resume> listres = new List<Resume>();

        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            Resume res1 = new Resume()
            {
                lastname = txtbxLName.Text,
                firstname = txtbxFName1.Text,
                job = txtbxApplying.Text,
                email = txtbxEmail.Text,
                contact = txtbxContact.Text,
                address = txtbxAddress.Text,
                aboutme = txtbxAMe.Text,
                WorkExp = txtbxWExp.Text,
                skills = txtbxSkills.Text,
                interests = txtbxInterest.Text

            };

            Resume res2 = new Resume()
            {
                lastname = txtbxLName.Text,
                firstname = txtbxFName1.Text,
                job = txtbxApplying.Text,
                email = txtbxEmail.Text,
                contact = txtbxContact.Text,
                address = txtbxAddress.Text,
                aboutme = txtbxAMe.Text,
                WorkExp = txtbxWExp.Text,
                skills = txtbxSkills.Text,
                interests = txtbxInterest.Text

            };
            listres.Add(res1);
            listres.Add(res2);

            string jsonText = JsonConvert.SerializeObject(listres, Formatting.Indented);
            File.WriteAllText(@"C:\Users\Joyce Calangian\Documents\MJ\PUP\SUBJECTS\OBJECT ORIENTED PROGRAMMING\PDF Creator\Resume.json", jsonText);

            MessageBox.Show("Your data has been saved!");
        }
        class Resume
        {
            public string lastname;
            public string firstname;
            public string job;
            public string email;
            public string contact;
            public string address;
            public string aboutme;
            public string WorkExp;
            public string skills;
            public string interests;
        }
    }
}
