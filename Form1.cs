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
                string jsonFromFile;
                string openfile = File.ReadAllText(_path);
                jsonFromFile = File.ReadAllText(_path);
                Resume myResume = JsonConvert.DeserializeObject<Resume>(jsonFromFile);
                FileStream destination = new FileStream(@"C:\Users\Joyce Calangian\Documents\MJ\PUP\SUBJECTS\OBJECT ORIENTED PROGRAMMING\PDF Creator\CALANGIAN_MARYJOYCE.pdf", FileMode.Create);

                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font biggest = new iTextSharp.text.Font(bfTimes, 34, iTextSharp.text.Font.BOLD); //name
                iTextSharp.text.Font big = new iTextSharp.text.Font(bfTimes, 22, iTextSharp.text.Font.BOLD); //section title
                iTextSharp.text.Font normal = new iTextSharp.text.Font(bfTimes, 16, iTextSharp.text.Font.NORMAL); //title
                iTextSharp.text.Font small = new iTextSharp.text.Font(bfTimes, 14, iTextSharp.text.Font.NORMAL); // details

                Document doc = new Document(PageSize.A4, 60, 75, 60, 75);
                PdfWriter writer = PdfWriter.GetInstance(doc, destination);

                doc.Open();

                Paragraph paragraph = new Paragraph();

                paragraph.Add(new Phrase(name + "\n" + "\n", biggest));
                paragraph.Add(new Phrase(position, big));
                //line 
                paragraph.Add(new Phrase(objective + "\n" + "\n", big));

                //Personal Information
                paragraph.Add(new Phrase(objective + "\n" + "\n", small));
                paragraph.Add(new Phrase(email + "\n" + "\n", small));
                paragraph.Add(new Phrase(contactno + "\n" + "\n", small));
                paragraph.Add(new Phrase(address + "\n" + "\n", small));
                paragraph.Add(new Phrase(age + "\n" + "\n", small));

                //Education

                paragraph.Add(new Phrase(educational  +"\n" + "\n", big));
                paragraph.Add(new Phrase(college + "\n" + "\n", small));
                paragraph.Add(new Phrase(graduated + "\n" + "\n", small));

                //Work Experience

                paragraph.Add(new Phrase(work1 + "\n" + "\n", big));
                paragraph.Add(new Phrase("• " + company1 + "\n" + "\n", small));
                paragraph.Add(new Phrase("• " +yearwork1 + "\n" + "\n", small));
                paragraph.Add(new Phrase(work2 + "\n" + "\n", big));
                paragraph.Add(new Phrase("• " + company2 + "\n" + "\n", small));
                paragraph.Add(new Phrase("• " + yearwork2 + "\n" + "\n", small));

                //Skills
                paragraph.Add(new Phrase("• " + skill1 + "\n" + "\n", small));
                paragraph.Add(new Phrase("• " + skill2 + "\n" + "\n", small));
                paragraph.Add(new Phrase("• " + skill3 + "\n" + "\n", small));


                doc.Add(paragraph);
                doc.Close();
                writer.Close();
                destination.Close();
                readjson = false;

                MessageBox.Show("Your PDF file has been saved!");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        class Resume
        {
            public string name { get; set; }
            public string position { get; set; }
            public string objective { get; set; }
            public string email { get; set; }
            public string contactno { get; set; }
            public string address { get; set; }
            public string age { get; set; }
            public string educational { get; set; }
            public string college { get; set; }
            public string graduated { get; set; }
            public string work1 { get; set; }
            public string company1 { get; set; }
            public string yearwork1 { get; set; }
            public string company2 { get; set; }
            public string yearwork2{ get; set; }
            public string skill1 { get; set; }
            public string skill2 { get; set; }
            public string skill3 { get; set; }




        }
    }
}
