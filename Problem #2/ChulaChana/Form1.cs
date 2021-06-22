using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChulaChana
{
    public partial class Form1 : Form
    {
        private Database locAndPopData = new Database();
        private string mode = "checkin";
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            label4.Visible = false;
            phoneNum.Visible = false;
            chooseLoc.Visible = false;
            buttonContinue.Visible = false;
            ok.Visible = false;
            label5.Visible = false;
            logDetails.Visible = false;
            allLocationPop.Visible = false;
        }

        private void showPhoneAndLoc()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label3.Visible = true;
            phoneNum.Visible = true;
            buttonContinue.Visible = true;
            if (mode == "checkin")
            {
                label4.Visible = true;
                chooseLoc.Visible = true;
            }
        }

        private void showMainMenu()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            phoneNum.Visible = false;
            chooseLoc.Visible = false;
            buttonContinue.Visible = false;
            label3.Text = "Enter your phone number :";
        }

        private void disablePhoneAndLoc()
        {
            label3.Visible = false;
            label4.Visible = false;
            phoneNum.Visible = false;
            chooseLoc.Visible = false;
            buttonContinue.Visible = false;
        }

        private void nowCheckIn()
        {
            if (locAndPopData.locationPop.ContainsKey(chooseLoc.Text))
            {
                locAndPopData.locationPop[chooseLoc.Text].Add(phoneNum.Text);
            }
            else
            {
                locAndPopData.locationPop.Add(chooseLoc.Text, new List<string>() { phoneNum.Text });
            }
            locAndPopData.phoneAndLocation[phoneNum.Text] = chooseLoc.Text;
            label5.Text = "Successfully logged in";
            logDetails.Text = phoneNum.Text + " at " + chooseLoc.Text;
            label5.Visible = true;
            logDetails.Visible = true;
            ok.Visible = true;
        }

        private bool findCheckOut()
        {
            bool foundPhoneNum = false;
            if (locAndPopData.phoneAndLocation.ContainsKey(phoneNum.Text))
            {
                string currentLocation = locAndPopData.phoneAndLocation[phoneNum.Text];
                locAndPopData.locationPop[currentLocation].Remove(phoneNum.Text);
                locAndPopData.phoneAndLocation.Remove(phoneNum.Text);
                label5.Text = "Successfully logged out";
                foundPhoneNum = true;
                logDetails.Text = phoneNum.Text + " at " + currentLocation;
                logDetails.Visible = true;
                label5.Visible = true;
                ok.Visible = true;
            }
            return foundPhoneNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = "checkin";
            showPhoneAndLoc();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mode = "checkout";
            showPhoneAndLoc();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (mode == "checkin")
            {
                if (phoneNum.Text == "" || chooseLoc.Text == "")
                {
                    label5.Text = "Please enter phone number and/or location!";
                    label5.Visible = true;
                    ok.Visible = true;
                    disablePhoneAndLoc();
                    return;
                }
                findCheckOut();
                nowCheckIn();
            } else //mode == "checkout"
            {
                if (phoneNum.Text == "")
                {
                    label5.Text = "Please enter phone number!";
                    label5.Visible = true;
                    ok.Visible = true;
                    disablePhoneAndLoc();
                    return;
                }
                if (!findCheckOut())
                {
                    logDetails.Visible = true;
                    logDetails.Text = "Phone number not found";
                    ok.Visible = true;
                }
            }
            disablePhoneAndLoc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] listLoc = locAndPopData.locationPop.Keys.ToArray();
            chooseLoc.Items.AddRange(listLoc);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            showMainMenu();
            phoneNum.Text = "";
            chooseLoc.Text = "";
            allLocationPop.Text = "";
            ok.Visible = false;
            label5.Visible = false;
            logDetails.Visible = false;
            allLocationPop.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            foreach (string loc in locAndPopData.locationPop.Keys)
            {
                allLocationPop.Text += loc + " : "+ locAndPopData.locationPop[loc].Count + "\r\n";
            }
            allLocationPop.Visible = true;
            ok.Visible = true;
        }
    }

    class Database
    {
        public Dictionary<string, string> phoneAndLocation = new Dictionary<string, string>();

        public Dictionary<string, List<string>> locationPop = new Dictionary<string, List<string>>() {
                {"Mahamakut Building", new List<string>() },
                {"Sara Phra Kaew", new List<string>() },
                {"CU Sport Complex", new List<string>() },
                {"Sanum Juub", new List<string>() },
                {"Samyan Mitr Town", new List<string>() }
            };
    }
}
