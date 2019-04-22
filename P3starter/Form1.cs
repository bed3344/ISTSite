using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Brooke Daniels
// Project 3

namespace P3starter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string getRESTData(string url)
        {
            const string baseUri = "http://ist.rit.edu/api";

            // connect to the API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUri + url);

            try
            {
                // Waits and gets the response from the REST reqeust
                WebResponse response = request.GetResponse();

                // Using the response stream from the web request
                using(Stream responseStream = response.GetResponseStream())
                {
                    // read the response from the api
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch(WebException we)
            {
                // get the response
                Console.WriteLine("Error ");
                throw;
            }
        }

        private void aboutTab_Enter(object sender, EventArgs e)
        {
            // Get About from the API
            string jsonAbout = getRESTData("/about/");

            // Convert the JSON to a C# object
            About about = JToken.Parse(jsonAbout).ToObject<About>();

            // title
            titleLbl.Text = about.title;

            // Description
            tb_aboutDesc.Text = about.description;

            // Quote
            tb_aboutQuote.Text = about.quote;

            // Quote Author
            lbl_quoteAuthor.Text = about.quoteAuthor;
        }

        // Populates the resources tab upon entering
        private void resourceTab_Enter(object sender, EventArgs e)
        {
            // Get resources from the API
            string jsonRes = getRESTData("/resources/");
            Resources resources = JToken.Parse(jsonRes).ToObject<Resources>();

            // Set the Title and Sub-title to the corresponding data from the API
            resTitle.Text = resources.title;
            resSubTitle.Text = resources.subTitle;

            // Sets the name using the data from the API, except for Forms because it does not have a title attribute
            resource1.Text = resources.studyAbroad.title;
            resource2.Text = resources.studentServices.title;
            resource3.Text = resources.tutorsAndLabInformation.title;
            resource4.Text = resources.studentAmbassadors.title;
            resource5.Text = "Forms";
            resource6.Text = resources.coopEnrollment.title;
        }

        // Populates the undergraduate degrees tab upon entering
        private void degreesTab_Enter(object sender, EventArgs e)
        {
            // Get the data about a major from the API
            string jsonWMC = getRESTData("/degrees/undergraduate/degreeName=wmc");
            Undergraduate degWMC = JToken.Parse(jsonWMC).ToObject<Undergraduate>();

            // Place the major's description in the text box
            tb_wmc.Text = degWMC.description;

            // Add the course list to the list box
            wmcList.Items.Clear();
            for (int i = 0; i < degWMC.concentrations.Length; i++)
            {
                wmcList.Items.Add(" - " + degWMC.concentrations[i]);
            }

            // Get the data about the major from the API
            string jsonHCC = getRESTData("/degrees/undergraduate/degreeName=hcc");
            Undergraduate degHCC = JToken.Parse(jsonHCC).ToObject<Undergraduate>();

            // Place the major's description in the text box
            tb_hcc.Text = degHCC.description;

            // Add the course list to the list box
            hccList.Items.Clear();
            for (int i = 0; i < degHCC.concentrations.Length; i++)
            {
                hccList.Items.Add(" - " + degHCC.concentrations[i]);
            }

            // Get the data about the major from the API
            string jsonCIT = getRESTData("/degrees/undergraduate/degreeName=cit");
            Undergraduate degCIT = JToken.Parse(jsonCIT).ToObject<Undergraduate>();

            // Place the major's description in the text box
            tb_cit.Text = degCIT.description;

            // Add the course list to the list box
            citList.Items.Clear();
            for (int i = 0; i < degCIT.concentrations.Length; i++)
            {
                citList.Items.Add(" - " + degCIT.concentrations[i]);
            }
        }

        // Populates the graduate degrees tab upon entering
        private void gradTab_Enter(object sender, EventArgs e)
        {
            // Get the data about a major from the API
            string jsonIST = getRESTData("/degrees/graduate/degreeName=ist");
            Graduate degIST = JToken.Parse(jsonIST).ToObject<Graduate>();

            // Place the major's description in the text box
            tb_ist.Text = degIST.description;

            // Add the course list to the list box
            istList.Items.Clear();
            for (int i = 0; i < degIST.concentrations.Length; i++)
            {
                istList.Items.Add(" - " + degIST.concentrations[i]);
            }

            // Get the data about a major from the API
            string jsonHCI = getRESTData("/degrees/graduate/degreeName=hci");
            Graduate degHCI = JToken.Parse(jsonHCI).ToObject<Graduate>();

            // Place the major's description in the text box
            tb_hci.Text = degHCI.description;

            // Add the course list to the list box
            hciList.Items.Clear();
            for (int i = 0; i < degHCI.concentrations.Length; i++)
            {
                hciList.Items.Add(" - " + degHCI.concentrations[i]);
            }

            // Get the data about a major from the API
            string jsonNSA = getRESTData("/degrees/graduate/degreeName=nsa");
            Graduate degNSA = JToken.Parse(jsonNSA).ToObject<Graduate>();

            // Place the major's description in the text box
            tb_nsa.Text = degNSA.description;

            // Add the course list to the list box
            nsaList.Items.Clear();
            for (int i = 0; i < degNSA.concentrations.Length; i++)
            {
                nsaList.Items.Add(" - " + degNSA.concentrations[i]);
            }

            string jsonCert = getRESTData("/degrees/graduate/degreeName=graduate advanced certificates");

            // Get the data about the certificates from the API
            Graduate certificates = JToken.Parse(jsonCert).ToObject<Graduate>();

            // Add the course list to the list box
            certList.Items.Clear();
            for (int i = 0; i < certificates.availableCertificates.Length; i++)
            {
                certList.Items.Add(" - " + certificates.availableCertificates[i]);
            }
        }

        // Once the button is clicked it calls the Show() method to make an instance of 
        // the MinorDialog class with the information loaded in from the API
        private void dbBtn_Click(object sender, EventArgs e)
        {
            string jsonDB = getRESTData("/minors/UgMinors/name=DBDDI-MN");

            Minor db = JToken.Parse(jsonDB).ToObject<Minor>();

            MinorDialog popup = new MinorDialog();
            popup.Show(db.title, db.title, db.description, db.courses);
        }

        // Once the button is clicked it calls the Show() method to make an instance of 
        // the MinorDialog class with the information loaded in from the API
        private void gisBtn_Click(object sender, EventArgs e)
        {
            string jsonGIS = getRESTData("/minors/UgMinors/name=GIS-MN");

            Minor gis = JToken.Parse(jsonGIS).ToObject<Minor>();

            MinorDialog popup = new MinorDialog();
            popup.Show(gis.title, gis.title, gis.description, gis.courses);
        }

        // Upon entering the minors tab the buttons names are populated by the API
        // Note: The & character does not display in the window when loaded in, so I typed in the names that have that manually
        private void minorsTab_Enter(object sender, EventArgs e)
        {
            string jsonDB = getRESTData("/minors/UgMinors/name=DBDDI-MN");

            Minor db = JToken.Parse(jsonDB).ToObject<Minor>();

            dbBtn.Text = db.title;

            string jsonGIS = getRESTData("/minors/UgMinors/name=GIS-MN");

            Minor gis = JToken.Parse(jsonGIS).ToObject<Minor>();

            gisBtn.Text = gis.title;

            string jsonMED = getRESTData("/minors/UgMinors/name=MEDINFO-MN");

            Minor med = JToken.Parse(jsonMED).ToObject<Minor>();

            medBtn.Text = med.title;

            string jsonMDEV = getRESTData("/minors/UgMinors/name=MDEV-MN");

            Minor mdev = JToken.Parse(jsonMDEV).ToObject<Minor>();

            mdevBtn.Text = mdev.title;

            string jsonNET = getRESTData("/minors/UgMinors/name=NETSYS-MN");

            Minor net = JToken.Parse(jsonNET).ToObject<Minor>();

            netsysBtn.Text = net.title;

            string jsonWEBD = getRESTData("/minors/UgMinors/name=MDEV-MN");

            Minor webd = JToken.Parse(jsonWEBD).ToObject<Minor>();

            webdBtn.Text = webd.title;
        }

        // Once the button is clicked it calls the Show() method to make an instance of 
        // the MinorDialog class with the information loaded in from the API
        private void medBtn_Click(object sender, EventArgs e)
        {
            string jsonMED = getRESTData("/minors/UgMinors/name=MEDINFO-MN");

            Minor med = JToken.Parse(jsonMED).ToObject<Minor>();

            MinorDialog popup = new MinorDialog();
            popup.Show(med.title, med.title, med.description, med.courses);
        }

        // Once the button is clicked it calls the Show() method to make an instance of 
        // the MinorDialog class with the information loaded in from the API
        private void mddevBtn_Click(object sender, EventArgs e)
        {
            string jsonMDDEV = getRESTData("/minors/UgMinors/name=MDDEV-MN");

            Minor mddev = JToken.Parse(jsonMDDEV).ToObject<Minor>();

            MinorDialog popup = new MinorDialog();
            popup.Show(mddev.title, mddev.title, mddev.description, mddev.courses);
        }

        // Once the button is clicked it calls the Show() method to make an instance of 
        // the MinorDialog class with the information loaded in from the API
        private void mdevBtn_Click(object sender, EventArgs e)
        {
            string jsonMDEV = getRESTData("/minors/UgMinors/name=MDEV-MN");

            Minor mdev = JToken.Parse(jsonMDEV).ToObject<Minor>();

            MinorDialog popup = new MinorDialog();
            popup.Show(mdev.title, mdev.title, mdev.description, mdev.courses);
        }

        // Once the button is clicked it calls the Show() method to make an instance of 
        // the MinorDialog class with the information loaded in from the API
        private void netsysBtn_Click(object sender, EventArgs e)
        {
            string jsonNET = getRESTData("/minors/UgMinors/name=NETSYS-MN");

            Minor net = JToken.Parse(jsonNET).ToObject<Minor>();

            MinorDialog popup = new MinorDialog();
            popup.Show(net.title, net.title, net.description, net.courses);
        }

        // Once the button is clicked it calls the Show() method to make an instance of 
        // the MinorDialog class with the information loaded in from the API
        private void webdBtn_Click(object sender, EventArgs e)
        {
            string jsonWEBD = getRESTData("/minors/UgMinors/name=WEBD-MN");

            Minor webd = JToken.Parse(jsonWEBD).ToObject<Minor>();

            MinorDialog popup = new MinorDialog();
            popup.Show(webd.title, webd.title, webd.description, webd.courses);
        }

        // Once the button is clicked it calls the Show() method to make an instance of 
        // the MinorDialog class with the information loaded in from the API
        private void webddBtn_Click(object sender, EventArgs e)
        {
            string jsonWEBDD = getRESTData("/minors/UgMinors/name=WEBDD-MN");

            Minor webdd = JToken.Parse(jsonWEBDD).ToObject<Minor>();

            MinorDialog popup = new MinorDialog();
            popup.Show(webdd.title, webdd.title, webdd.description, webdd.courses);
        }

        // Goes the Map in the user's web browser once the link is clicked
        private void mapLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://ist.rit.edu/api/map.php");
        }

        // Upon entering the employment tab the data is requested from the API and loaded into the text boxes and headers
        private void employTab_Enter(object sender, EventArgs e)
        {
            string jsonEmp = getRESTData("/employment/");

            Employment employ = JToken.Parse(jsonEmp).ToObject<Employment>();

            empTitle.Text = employ.introduction.title;

            empLbl.Text = employ.introduction.content[0].title;
            empDesc.Text = employ.introduction.content[0].description + "\n" + employ.degreeStatistics.title + ":" + "\n";

            for (int i = 0; i < employ.degreeStatistics.statistics.Count; i++)
            {
                empDesc.Text += "   " + employ.degreeStatistics.statistics[i].value + "\n" + "   - " + employ.degreeStatistics.statistics[i].description + "\n";
            }

            coopLbl.Text = employ.introduction.content[1].title;
            coopDesc.Text = employ.introduction.content[1].description + "\n" + employ.employers.title + ":" + "\n";
            for (int i = 0; i < employ.employers.employerNames.Length; i++)
            {
                coopDesc.Text += "   - " + employ.employers.employerNames[i]  + "\n";
            }

            coopDesc.Text += employ.careers.title + ":" + "\n";
            for (int i = 0; i < employ.careers.careerNames.Length; i++)
            {
                coopDesc.Text += "   - " + employ.careers.careerNames[i] + "\n";
            }
        }

        // Makes an Employment object to be used by the methods that populate the tables with data upon request
        Employment emp = null;
        private void loadEmploymentData()
        {
            if (emp == null)
            {
                string jsonEmp = getRESTData("/employment/");

                emp = JToken.Parse(jsonEmp).ToObject<Employment>();
            }
        }

        // When the button is clicked load in the employment table's data
        private void empBtn_Click(object sender, EventArgs e)
        {
            // Load in info from API
            loadEmploymentData();

            // Clear the table in case it already has data
            empTable.Clear();
            empTable.View = View.Details;

            // Set the width of the table and set the names and widths of the columns 
            empTable.Width = 490;
            empTable.Columns.Add("Employer", 130);
            empTable.Columns.Add("Degree", 80);
            empTable.Columns.Add("City", 100);
            empTable.Columns.Add("Title", 80);
            empTable.Columns.Add("Date", 80);

            // Add information from the Employment class
            ListViewItem item;
            for (var i = 0; i < emp.employmentTable.professionalEmploymentInformation.Count; i++)
            {
                item = new ListViewItem(new string[] {
                    emp.employmentTable.professionalEmploymentInformation[i].employer,
                    emp.employmentTable.professionalEmploymentInformation[i].degree,
                    emp.employmentTable.professionalEmploymentInformation[i].city,
                    emp.employmentTable.professionalEmploymentInformation[i].title,
                    emp.employmentTable.professionalEmploymentInformation[i].startDate
                });

                empTable.Items.Add(item);

            } // end for
        }

        // When the button is clicked load in the co-op table's data
        private void coopBtn_Click(object sender, EventArgs e)
        {
            // Load in info from API
            loadEmploymentData();

            // Clear the table in case it already has data
            coopTable.Clear();
            coopTable.View = View.Details;

            // Set the width of the table and set the names and widths of the columns
            coopTable.Width = 380;
            coopTable.Columns.Add("Employer", 130);
            coopTable.Columns.Add("Degree", 80);
            coopTable.Columns.Add("City", 100);
            coopTable.Columns.Add("Term", 80);

            // Add information from the Employment class
            ListViewItem item;
            for (var i = 0; i < emp.coopTable.coopInformation.Count; i++)
            {
                item = new ListViewItem(new string[] {
                    emp.coopTable.coopInformation[i].employer,
                    emp.coopTable.coopInformation[i].degree,
                    emp.coopTable.coopInformation[i].city,
                    emp.coopTable.coopInformation[i].term
                });

                coopTable.Items.Add(item);

            } // end for
        }

        // Makes a People object to be used by the methods that populate the text box, picture box and label with the appropriate data upon request
        People ppl = null;

        // Populates the people tab with info from the API upon entering
        private void pplTab_Enter(object sender, EventArgs e)
        {
            string jsonPpl = getRESTData("/people/");
            ppl = JToken.Parse(jsonPpl).ToObject<People>();

            // Set the header to match the data from the API
            pplTitle.Text = ppl.title;

            // Clear the combo box
            facultyCb.Items.Clear();

            // Add each name from the list of faculty members to the combo box
            for (int i = 0; i < ppl.faculty.Count; i++)
            {
                facultyCb.Items.Add(ppl.faculty[i].name);
            }

            // Clear the combo box
            staffCb.Items.Clear();

            // Add each name from the list of staff members to the combo box
            for (int i = 0; i < ppl.staff.Count; i++)
            {
                staffCb.Items.Add(ppl.staff[i].name);
            }
        }

        // When the index of the faculty combo box is changed, retrieve the corresponding data and populate the text box, picture box, and label
        private void facultyCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the number for the current index and save it as an int
            int current = facultyCb.SelectedIndex;

            // Get the name and title of the faculty member and set the pplName label to reflect this data
            pplName.Text = ppl.faculty[current].name + ", " + ppl.faculty[current].title;

            // Load in the faculty member's picture
            pplPic.Load(ppl.faculty[current].imagePath);

            // Reset the description so it can append all the new info
            pplDesc.Text = "";

            // These if statements check to make sure that a faculty member has data for each attribute, if the data exists it is added to the text box
            // and if they don't have any info, that attribute will not be appended to the text box
            if (ppl.faculty[current].office != "" && ppl.faculty[current].office != null)
            {
                pplDesc.Text += "Office: " + ppl.faculty[current].office + "\n";
            }

            if (ppl.faculty[current].phone != "" && ppl.faculty[current].phone != null)
            {
                pplDesc.Text += "Phone: " + ppl.faculty[current].phone + "\n";
            }

            if (ppl.faculty[current].email != "" && ppl.faculty[current].email != null)
            {
                pplDesc.Text += "Email: " + ppl.faculty[current].email + "\n";
            }

            if (ppl.faculty[current].website != "" && ppl.faculty[current].website != null)
            {
                pplDesc.Text += "Website: " + ppl.faculty[current].website + "\n";
            }

            if (ppl.faculty[current].twitter != "" && ppl.faculty[current].twitter != null)
            {
                pplDesc.Text += "Twitter: " + ppl.faculty[current].twitter + "\n";
            }

            if (ppl.faculty[current].facebook != "" && ppl.faculty[current].facebook != null)
            {
                pplDesc.Text += "Facebook: " + ppl.faculty[current].facebook + "\n";
            }
        }

        // When the index of the staff combo box is changed, retrieve the corresponding data and populate the text box, picture box, and label
        private void staffCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the number for the current index and save it as an int
            int current = staffCb.SelectedIndex;

            // Get the name and title of the staff member and set the pplName label to reflect this data
            pplName.Text = ppl.staff[current].name + ", " + ppl.staff[current].title;

            // Load in the staff member's picture
            pplPic.Load(ppl.staff[current].imagePath);

            // Reset the description so it can append all the new info
            pplDesc.Text = "";

            // These if statements check to make sure that a faculty member has data for each attribute, if the data exists it is added to the text box
            // and if they don't have any info, that attribute will not be appended to the text box
            if (ppl.staff[current].office != "" && ppl.staff[current].office != null)
            {
                pplDesc.Text += "Office: " + ppl.staff[current].office + "\n";
            }

            if (ppl.staff[current].phone != "" && ppl.staff[current].phone != null)
            {
                pplDesc.Text += "Phone: " + ppl.staff[current].phone + "\n";
            }

            if (ppl.staff[current].email != "" && ppl.staff[current].email != null)
            {
                pplDesc.Text += "Email: " + ppl.staff[current].email + "\n";
            }

            if (ppl.staff[current].website != "" && ppl.staff[current].website != null)
            {
                pplDesc.Text += "Website: " + ppl.staff[current].website + "\n";
            }

            if (ppl.staff[current].twitter != "" && ppl.staff[current].twitter != null)
            {
                pplDesc.Text += "Twitter: " + ppl.staff[current].twitter + "\n";
            }

            if (ppl.staff[current].facebook != "" && ppl.staff[current].facebook != null)
            {
                pplDesc.Text += "Facebook: " + ppl.staff[current].facebook + "\n";
            }
        }

        // Makes a Research object to be used by the methods that populate the text box and label with the appropriate data upon request
        Research research = null;
        private void researchTab_Enter(object sender, EventArgs e)
        {
            // Get the info from the API
            string jsonRes = getRESTData("/research/");
            research = JToken.Parse(jsonRes).ToObject<Research>();

            // Clear the combo box
            facultyResearch.Items.Clear();

            // Add each name from the list of faculty members to the combo box
            for (int i = 0; i < research.byFaculty.Count; i++)
            {
                facultyResearch.Items.Add(research.byFaculty[i].facultyName);
            }

            // Clear the combo box
            interestCb.Items.Clear();

            // Add each interest area to the combo box
            for (int i = 0; i < research.byInterestArea.Count; i++)
            {
                interestCb.Items.Add(research.byInterestArea[i].areaName);
            }
        }

        // When the index of the faculty research combo box is changed, retrieve the corresponding data and populate the text box and label
        private void facultyResearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the number for the current index and save it as an int
            int current = facultyResearch.SelectedIndex;

            // Get the name and title of the staff member and set the pplName label to reflect this data
            reasearchLbl.Text = "Research: " + research.byFaculty[current].facultyName;

            // Clear the text box
            researchText.Text = "";

            // Load the research data into the text box
            for (int i = 0; i < research.byFaculty[current].citations.Length; i++)
            {
                researchText.Text += " - " +research.byFaculty[current].citations[i] + "\n" + "\n";
            }
        }

        // When the index of the intereste area research combo box is changed, retrieve the corresponding data and populate the text box and label
        private void interestCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the number for the current index and save it as an int
            int current = interestCb.SelectedIndex;

            // Get the name and title of the staff member and set the pplName label to reflect this data
            reasearchLbl.Text = "Research: " + research.byInterestArea[current].areaName;

            // Clear the text box
            researchText.Text = "";

            // Load the research data into the text box
            for (int i = 0; i < research.byInterestArea[current].citations.Length; i++)
            {
                researchText.Text += " - " + research.byInterestArea[current].citations[i] + "\n" + "\n";
            }
        }

        // Upon clicking the button the data is loaded into a ResourceDialog and shown to the user and shown to the user and shown to the user
        private void resource1_Click(object sender, EventArgs e)
        {
            string jsonRes = getRESTData("/resources/studyAbroad");
            Resources res = JToken.Parse(jsonRes).ToObject<Resources>();

            string allText = res.studyAbroad.description + "\n" + "\n";

            for (int i = 0; i < res.studyAbroad.places.Count; i++)
            {
                allText += res.studyAbroad.places[i].nameOfPlace + ":" + "\n" + " - " + res.studyAbroad.places[i].description + "\n" + "\n";
            }

            ResourceDialog popup = new ResourceDialog();
            popup.Show(res.studyAbroad.title, res.studyAbroad.description, allText);
        }

        // Upon clicking the button the data is loaded into a ResourceDialog and shown to the user
        private void resource2_Click(object sender, EventArgs e)
        {
            string jsonRes = getRESTData("/resources/studentServices");
            Resources res = JToken.Parse(jsonRes).ToObject<Resources>();

            string parOne = res.studentServices.academicAdvisors.title + "\n" + res.studentServices.academicAdvisors.description + "\n" + res.studentServices.academicAdvisors.faq + "\n" + "\n";
            parOne += res.studentServices.facultyAdvisors.title + "\n" + res.studentServices.facultyAdvisors.description;

            string parTwo = res.studentServices.istMinorAdvising.title + "\n";

            for (int i = 0; i < res.studentServices.istMinorAdvising.minorAdvisorInformation.Count; i++)
            {
                parTwo += "     " + res.studentServices.istMinorAdvising.minorAdvisorInformation[i].title + "\n" + "     " + res.studentServices.istMinorAdvising.minorAdvisorInformation[i].advisor + "\n" + "     " + res.studentServices.istMinorAdvising.minorAdvisorInformation[i].email + "\n" + "\n";
            }

            parTwo += "\n" + res.studentServices.professonalAdvisors.title + "\n";

            for (int i = 0; i < res.studentServices.professonalAdvisors.advisorInformation.Count; i++)
            {
                parTwo += "     " + res.studentServices.professonalAdvisors.advisorInformation[i].name + "\n" + "     " + res.studentServices.professonalAdvisors.advisorInformation[i].department + "\n" + "     " + res.studentServices.professonalAdvisors.advisorInformation[i].email + "\n" + "\n";
            }


            ResourceDialog popup = new ResourceDialog();
            popup.Show(res.studentServices.title, parOne, parTwo);
        }

        // Upon clicking the button the data is loaded into a ResourceDialog and shown to the user
        private void resource3_Click(object sender, EventArgs e)
        {
            string jsonRes = getRESTData("/resources/tutorsAndLabInformation");
            Resources res = JToken.Parse(jsonRes).ToObject<Resources>();

            ResourceDialog popup = new ResourceDialog();
            popup.ShowTutor(res.tutorsAndLabInformation.title, res.tutorsAndLabInformation.description, res.tutorsAndLabInformation.tutoringLabHoursLink);
        }

        // Upon clicking the button the data is loaded into a ResourceDialog and shown to the user
        private void resource4_Click(object sender, EventArgs e)
        {
            string jsonRes = getRESTData("/resources/studentAmbassadors");
            Resources res = JToken.Parse(jsonRes).ToObject<Resources>();

            string allText = "";

            for (int i = 0; i < res.studentAmbassadors.subSectionContent.Count; i++)
            {
                allText += res.studentAmbassadors.subSectionContent[i].title + "\n" + res.studentAmbassadors.subSectionContent[i].description + "\n" + "\n";
            }

            allText += res.studentAmbassadors.note;

            ResourceDialog popup = new ResourceDialog();
            popup.Show(res.studentAmbassadors.title, res.studentAmbassadors.ambassadorsImageSource, allText, res.studentAmbassadors.applicationFormLink);
        }

        // Upon clicking the button the data is loaded into a ResourceDialog and shown to the user
        private void resource5_Click(object sender, EventArgs e)
        {
            string jsonRes = getRESTData("/resources/forms");
            Resources res = JToken.Parse(jsonRes).ToObject<Resources>();

            string allText = "";
            string uLinks = "";
            for (int i = 0; i < res.forms.undergraduateForms.Count; i++)
            {
                allText += res.forms.undergraduateForms[i].formName;
                uLinks = res.forms.undergraduateForms[i].href;
            }

            string[] gradNames = new string[res.forms.graduateForms.Count];
            string[] gLinks = new string[res.forms.graduateForms.Count];
            for (int i = 0; i < res.forms.graduateForms.Count; i++)
            {
                gradNames[i] = res.forms.graduateForms[i].formName;
                gLinks[i] = res.forms.graduateForms[i].href;
            }

            ResFormDialog popup = new ResFormDialog();
            popup.Show( allText, uLinks, gradNames, gLinks);
        }

        // Upon clicking the button the data is loaded into a ResourceDialog and shown to the user
        private void resource6_Click(object sender, EventArgs e)
        {
            string jsonRes = getRESTData("/resources/coopEnrollment");
            Resources res = JToken.Parse(jsonRes).ToObject<Resources>();

            string desc1 = res.coopEnrollment.enrollmentInformationContent[0].title + "\n" + res.coopEnrollment.enrollmentInformationContent[0].description + "\n" + "\n";
            desc1 += res.coopEnrollment.enrollmentInformationContent[1].title + "\n" + res.coopEnrollment.enrollmentInformationContent[1].description + "\n" + "\n";

            string desc2 = res.coopEnrollment.enrollmentInformationContent[2].title + "\n" + res.coopEnrollment.enrollmentInformationContent[2].description + "\n" + "\n";
            desc2 += res.coopEnrollment.enrollmentInformationContent[3].title + "\n" + res.coopEnrollment.enrollmentInformationContent[3].description + "\n" + "\n";
          
            ResourceDialog popup = new ResourceDialog();
            popup.ShowCoop(res.coopEnrollment.title, desc1, desc2, res.coopEnrollment.RITJobZoneGuidelink);
        }

        // Create a news object to be used by the newsCb_SelectedIndexChanged method
        News news = null;

        // Upon entering the news tab some initial data is loaded in
        private void newsTab_Enter(object sender, EventArgs e)
        {
            string jsonNews = getRESTData("/news/");
            news = JToken.Parse(jsonNews).ToObject<News>();

            string split = "";

            // Splits the date up so it's just the date and doesn't contain "00:00:00" and then adds the new string to the combo box
            for (int i = 0; i < news.older.Count; i++)
            {
                split = news.older[i].date.Substring(0,10);
                newsCb.Items.Add(split);
            }

            // Puts the most recent news item as a defualt into the label and text box
            newsTitle.Text = news.older[0].title;
            newsTb.Text = news.older[0].description;
        }

        // When the news combo box has it's selected index changed and the corresponding news from that date is loaded into the label and text box
        private void newsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            newsTitle.Text = news.older[newsCb.SelectedIndex].title;
            newsTb.Text = news.older[newsCb.SelectedIndex].description;
        }
    }
}
