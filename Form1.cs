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

        private string _path;         //path of json file
        private string filename;       //for the pdf and json file name

        private string name, position, objective, email, contactno, address, age, educational,
            college, graduated, work1, company1, yearwork1, work2, company2, yearwork2, skill1, skill2, skill3;



        private bool generate = false;
        private bool readjson = false;
        public Form1()
        {

            InitializeComponent();

            btnGenerate.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            string jsonFromFile;
            btnGenerate.Enabled = true;
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); 



            if (result == DialogResult.OK)
            {

                _path = openFileDialog.FileName;


                try
                {
                    jsonFromFile = File.ReadAllText(_path);
                    Resume myResume = JsonConvert.DeserializeObject<Resume>(jsonFromFile);
                    rchtxtbxUpload.Text = _path;

                    readjson = true;
                }

                catch (Exception)
                {
                    //nothing
                }
            }

        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (readjson)
            {
                FileStream destination = new FileStream(@"C:\Users\Joyce Calangian\Documents\MJ\PUP\SUBJECTS\OBJECT ORIENTED PROGRAMMING\PDF Creator" + name + ".pdf", FileMode.Create);

                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font biggest = new iTextSharp.text.Font(bfTimes, 34, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font big = new iTextSharp.text.Font(bfTimes, 22, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font normal = new iTextSharp.text.Font(bfTimes, 16, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font small = new iTextSharp.text.Font(bfTimes, 14, iTextSharp.text.Font.NORMAL);

                Document doc = new Document(PageSize.A4, 60, 75, 60, 75);
                PdfWriter writer = PdfWriter.GetInstance(doc, destination);
               

            }
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





        }
    }
}
