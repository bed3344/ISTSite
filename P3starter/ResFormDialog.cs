using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Brooke Daniels
// Project 3

namespace P3starter
{
    public partial class ResFormDialog : Form
    {
        public ResFormDialog()
        {
            InitializeComponent();
        }

        // String to hold link href
        string uLinkText = "";
        private string[] gradLink = new string[7];

        public DialogResult Show(string uGradName, string uLink, string[] gradName, string[] gLink)
        {
            uGradLink.Text = uGradName;
            uLinkText = uLink;

            gradLink1.Text = gradName[0];
            gradLink[0] = gLink[0];

            gradLink2.Text = gradName[1];
            gradLink[1] = gLink[1];

            gradLink3.Text = gradName[2];
            gradLink[2] = gLink[2];

            gradLink4.Text = gradName[3];
            gradLink[3] = gLink[3];

            gradLink5.Text = gradName[4];
            gradLink[4] = gLink[4];

            gradLink6.Text = gradName[5];
            gradLink[5] = gLink[5];

            gradLink7.Text = gradName[6];
            gradLink[6] = gLink[6];

            return (ShowDialog());
        }
    }
}
