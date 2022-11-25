using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmFileName ffn = new FrmFileName();
            ffn.ShowDialog();

            String StudentNo = txtStudentNo.Text;
            String FirstName = txtFirstName.Text;
            String MiddleInitial = txtMiddleInitial.Text;
            String LastName = txtLastName.Text;
            String Program = cbPrograms.Text;
            String Age = txtAge.Text;
            String Gender = cbGender.Text;
            String Birthday = datePickerBirthday.Text;
            String ContactNo = txtContactNo.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No. : " + StudentNo);
                Console.WriteLine("Student No. : " + StudentNo);

                outputFile.WriteLine("Full Name : " + FirstName + ", " + MiddleInitial + ", " + LastName );
                Console.WriteLine("Full Name : " + FirstName + ", " + MiddleInitial + ", " + LastName);

                outputFile.WriteLine("Program : " + Program);
                Console.WriteLine("Program : " + Program);

                outputFile.WriteLine("Gender : " + Gender);
                Console.WriteLine("Gender : " + Gender);

                outputFile.WriteLine("Age : " + Age);
                Console.WriteLine("Age : " + Age);

                outputFile.WriteLine("Birthday : " + Birthday);
                Console.WriteLine("Birthday : " + Birthday);

                outputFile.WriteLine("Contact No. : " + ContactNo);
                Console.WriteLine("Contact No. : " + ContactNo);

            }
        }
    }
}
