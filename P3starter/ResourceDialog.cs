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
    public partial class ResourceDialog : Form
    {
        public ResourceDialog()
        {
            InitializeComponent();
        }


        // Overloaded Show method
        // Populates the first and second rich text boxes in the dialog as well as the header
        public DialogResult Show(string name, string desc1, string desc2)
        {
            resourcePopupLbl.Text = name;
            resourcePopupDesc.Text = desc1;
            resDesc2.Text = desc2;

            return (ShowDialog());
        }

        // String to hold the link's url
        String linkString = null;

        // Overloaded Show method
        // Populates header, picture box, and the second text box
        // Used for Student Ambassadors resource
        public DialogResult Show(string name, string imagePath, string desc, string link)
        {
            resourcePopupLbl.Text = name;
            resourcePic.ImageLocation = imagePath;
            resourcePic.BringToFront();
            resourcePopupDesc.Text = "";
            resDesc2.Text = desc + "\n" + link;

            linkString = link;

            return (ShowDialog());
        }

        // Overloaded Show method
        // Populates header, the two text boxes and link
        // Used for the Coop Enrollment resource
        public DialogResult ShowCoop(string name, string desc1, string desc2, string link)
        {
            resourcePopupLbl.Text = name;
            resourcePopupDesc.Text = desc1;
            resDesc2.Text = desc2 + "\n" + link;

            linkString = link;

            return (ShowDialog());
        }

        // Overloaded Show method
        // Populates header and text boxes
        // Used for Tutors and Lab Info resource
        public DialogResult ShowTutor(string name, string desc, string link)
        {
            resourcePopupLbl.Text = name;
            resourcePopupDesc.Text = desc;
            resourcePopupDesc.Size = new Size(650, 250);
            resDesc2.Text = link;
            Size = new Size(700, 500);

            linkString = link;

            return (ShowDialog());
        }

        // If there is a link that is clicked inside of the second text box it will go to that link
        private void resDesc2_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkString);
        }
    }
}
