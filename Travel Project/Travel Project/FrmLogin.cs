using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Project
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text.Trim();
            string surname = TxtSurname.Text.Trim(); 
            string age = TxtAge.Text.Trim(); 
            string identityNumber = TxtIdentityNumber.Text.Trim(); 
            string phoneNumber = TxtPhoneNumber.Text.Trim(); 
            string email = TxtEmail.Text.Trim(); 
            string address = richTxtAddress.Text.Trim();
            bool isValid = name != "" && surname != "" && age != "" && identityNumber != "" && phoneNumber != "" && email != "" && address != "";


            if (isValid)
            {
                Person person = new Person(name,surname,age, identityNumber, phoneNumber,email,address); ;
                FrmHome form2 = new FrmHome(person);
                form2.Show();
                this.Hide();
            }

        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
