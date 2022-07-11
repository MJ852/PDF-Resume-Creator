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
using iTextSharp.text.pdf.draw;

namespace PDF_Creator
{
    public partial class Form1 : Form
    {

        private string _path;         //path of json file
        private string filename;       //for the pdf and json file name

        private string name, position, objective, email, contactno, address, age, educational,
            college, graduated, work1, company1, yearwork1, work2, company2, yearwork2, skill1, skill2, skill3;

        private void btnpnl_Click(object sender, EventArgs e)
        {
            pnlLearnMore.Visible = false;
        }

        private bool panel = false;

        private bool readjson = false;
        public Form1()
        {

            InitializeComponent();

            btnGenerate.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lnkLearnmore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                pnlLearnMore.Visible = true;
           
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            panel = false;
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
            panel = false;
            if (readjson)
            {
                string jsonFromFile;
                string openfile = File.ReadAllText(_path);
                jsonFromFile = File.ReadAllText(_path);
                Resume myResume = JsonConvert.DeserializeObject<Resume>(jsonFromFile);
                FileStream fs = new FileStream(@"C:\Users\Joyce Calangian\Documents\MJ\PUP\SUBJECTS\OBJECT ORIENTED PROGRAMMING\PDF Creator\CALANGIAN_MARYJOYCE.pdf", FileMode.Create);
                
                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font name = new iTextSharp.text.Font(bfTimes, 34, iTextSharp.text.Font.BOLD); //name
                iTextSharp.text.Font big = new iTextSharp.text.Font(bfTimes, 20, iTextSharp.text.Font.BOLD); //section title
                iTextSharp.text.Font normal = new iTextSharp.text.Font(bfTimes, 16, iTextSharp.text.Font.NORMAL); //title
                iTextSharp.text.Font small = new iTextSharp.text.Font(bfTimes, 14, iTextSharp.text.Font.NORMAL); // details

                Document doc = new Document(PageSize.A4, 60, 75, 60, 75);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
 
                doc.Open();

               // firstname = myResume.firstname;
                //MI = myResume.MI;
               // lastname = myResume.lastname;
                position = myResume.position;
                objective = myResume.objective;
                email = myResume.email;
                contactno = myResume.contactno;
                address = myResume.address;
                age = myResume.age;
                educational = myResume.educationalattainment;
                college = myResume.college;
                graduated = myResume.yeargraduated;
                work1 = myResume.work1;
                company1 = myResume.company1;
                yearwork1 = myResume.yearwork1;
                work2 = myResume.work2;
                company2 = myResume.company2; 
                yearwork2 = myResume.yearwork2;
                skill1 = myResume.skill1;
                skill2 = myResume.skill2;
                skill3 = myResume.skill3;

                Paragraph paragraph = new Paragraph();

                //Name
                paragraph.Add(new Phrase( myResume.firstname + myResume.MI + "\n" + "\n", name ));
                paragraph.Add(new Phrase( myResume.lastname + "\n" + "\n", name));
                paragraph.Add(new Phrase( position + "\n" , big ));
                paragraph.Add(new Phrase("\n"));

                LineSeparator line1 = new LineSeparator(3f, 100f, BaseColor.GRAY, Element.ALIGN_CENTER, 3 );
                paragraph.Add(line1);
                paragraph.Add(new Phrase("\n" + "\n"));

                //Objective
                paragraph.Add(new Phrase("Objective: " + "\n", big));
                paragraph.Add(new Phrase( objective + "\n" + "\n", normal));

                paragraph.Add(line1);
                paragraph.Add(new Phrase("\n" + "\n"));

                //Personal Information
                paragraph.Add(new Phrase("Personal Information" + "\n" , big));
                paragraph.Add(new Phrase("Email: " + email + "\n" ,  small));
                paragraph.Add(new Phrase("Contact Number: " + contactno + "\n" , small));
                paragraph.Add(new Phrase("Address: " + address +"\n" , small));
                paragraph.Add(new Phrase("Age: " + age + "\n" + "\n" + "\n" , small));

                //Education
                paragraph.Add(new Phrase("Educational Background" + "\n" , big));
                paragraph.Add(new Phrase("Course: " + educational  +"\n", normal));
                paragraph.Add(new Phrase("University: " + college + "\n", small));
                paragraph.Add(new Phrase("Year Graduated: " + myResume.yeargraduated + "\n" + "\n" + "\n", small));

                //Work Experience
                paragraph.Add(new Phrase("Work Experience: " + "\n" , big));
                paragraph.Add(new Phrase( work1 + "\n", normal));
                paragraph.Add(new Phrase("• "+ "Company: " + company1 + "\n" , small));
                paragraph.Add(new Phrase("• " + "Year: " + yearwork1 + "\n" + "\n", small));
                paragraph.Add(new Phrase(work2 + "\n", normal)) ;
                paragraph.Add(new Phrase("• " + "Company: " + company2 + "\n" , small));
                paragraph.Add(new Phrase("• " + "Year: " + yearwork2 + "\n" + "\n" + "\n", small));

                //Skills
                paragraph.Add(new Phrase("Skills" +"\n",  big));
                paragraph.Add(new Phrase("• " + skill1 + "\n" , small));
                paragraph.Add(new Phrase("• " + skill2 + "\n" , small));
                paragraph.Add(new Phrase("• " + skill3 + "\n" + "\n", small));

                paragraph.Add(line1);

                doc.Add(paragraph);
                doc.Close();
                writer.Close();
                fs.Close();
                readjson = false;

                

                MessageBox.Show("Your PDF file has been saved!", "Pdf Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error");
            }

            btnGenerate.Enabled = false;
            rchtxtbxUpload.Clear();
            
        }

        class Resume
        {
            public string firstname { get; set; }
            public string MI { get; set; }
            public string lastname { get; set; }
            public string position { get; set; }
            public string objective { get; set; }
            public string email { get; set; }
            public string contactno { get; set; }
            public string address { get; set; }
            public string age { get; set; }
            public string educationalattainment { get; set; }
            public string college { get; set; }
            public string yeargraduated { get; set; }
            public string work1 { get; set; }
            public string company1 { get; set; }
            public string yearwork1 { get; set; }
            public string work2 { get; set; }
            public string company2 { get; set; }
            public string yearwork2{ get; set; }
            public string skill1 { get; set; }
            public string skill2 { get; set; }
            public string skill3 { get; set; }




        }
    }
}
