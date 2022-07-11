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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text.Json;

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

        }
        class Resume
        {
            public string lastname { get; set; }
            public string firstname { get; set; }
            public string job { get; set; }
            public string email { get; set; }
            public string contact { get; set; }
            public string address { get; set; }
            public string aboutme { get; set; }
            public string WorkExp { get; set; }
            public string skills { get; set; }
            public string interests { get; set; }






            private void lblSkills_Click(object sender, EventArgs e)
            {

            }
        }

        private void lblSkills_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
