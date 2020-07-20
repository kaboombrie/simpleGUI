/* Brie Prater
 * CIS353
 * 07/16/2020
 * Professor Cain
 * Assignment 7.2 A */

using System;
using System.Windows.Forms;
using System.Drawing;

namespace CIS353
{
    public partial class assignment7 : Form // inherited class from System.Windows.Forms
    {
        private Button btnClickMe; // declaring buttons
        private Button btnExit;

        [STAThread]
        static void Main() // Main method
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new assignment7()); // instantiates the form
        }

        public assignment7() // assignment7 method
        {
            InitializeComponent(); // calls InitializeComponent method
        }

        private void InitializeComponent() // InitializeComponent method
        {
            this.btnExit = new Button(); // instantiates btnExit button
            this.btnClickMe = new Button(); // instantiates btnClickMe button
         
            this.btnExit.Location = new Point(15, 60); // sets coordinates to 15 and 60
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(75, 23); // sets button size
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit"; // sets button text to Exit
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new EventHandler(btnExit_Click); // call EventHandler method btnExit_Click on button click
           
            this.btnClickMe.Location = new Point(15, 20); // sets coordinates to 15 and 20
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new Size(75, 23); // sets button size
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Press Me"; // sets button text to Press Me
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new EventHandler(btnClickMe_Click); // calls EventHandler method btnClickMe_Click on button click

            this.ClientSize = new Size(300, 150); // sets form size to 300 x 150
            this.Controls.Add(this.btnClickMe); // adds button to form
            this.Controls.Add(this.btnExit); // adds button to form
            this.Text = "Assignment 8"; // sets title of form 
            this.ResumeLayout(false);
        }

        private void btnClickMe_Click(object sender, EventArgs e) // EventHandler method
        {
            MessageBox.Show("The Button Has Been Clicked!", "Click Me!"); 
            // creates a message box titled Click Me! and displays a message
        }
        private void btnExit_Click(object sender, EventArgs e) // EventHandler method
        {
            Application.Exit(); // exits form
        }
    }
}
