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
using VersionControl.Entities;

namespace VersionControl
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource.FullName; // label1
            btnAdd.Text = Resource.Add; // button1

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtLastName.Text,

            };
            users.Add(u);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         //   SaveFileDialog sfd = new SaveFileDialog();

           // using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            //{
              //  foreach (var s in users)
                //{
                  //  sw.Write(s.ID);
                    //sw.Write(s.FullName);

                //}
            
        }
    }
}
