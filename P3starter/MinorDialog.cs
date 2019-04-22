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
    public partial class MinorDialog : Form
    {
        public MinorDialog()
        {
            InitializeComponent();
        }

        // Overloaded Show method
        // Populates the header, text box and list with the chosen minor's information
        public DialogResult Show(string title, string name, string desc,  string[] courses)
        {
            Text = title;
            minorLbl.Text = name;
            minorDesc.Text = desc;
            coursesList.Items.Clear();
            for (int i = 0; i < courses.Length; i++)
            {
                coursesList.Items.Add(" - " + courses[i]);
            }

            return (ShowDialog());
        }
    }
}
