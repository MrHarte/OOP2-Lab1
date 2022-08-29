namespace OOP2_Lab1
{
    public partial class Form1 : Form
    {
        private Person? _person;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadExampleButton_Click(object sender, EventArgs e)
        {
            this._person = new Person();
            this._person.Name = "John Doe";
            this._person.PhoneNumber = "(819) 555-0123";
            this._person.EmailAdress = "john@gmail.com";
            this.displayPerson(this._person);
        }

        private void displayPerson(Person person)
        {
            nameTextBox.Text = person.Name;
            phoneNumberTextBox.Text = person.PhoneNumber;
            emailAddressTextBox.Text = person.EmailAdress;
            if (person.ParkingPassPurchased)
            {
                parkingPassLabel.Text = "This person has a parking pass!";
                parkingPassLabel.ForeColor = Color.Green;
            }
            else
            {
                parkingPassLabel.Text = "This person does not have a parking pass!";
                parkingPassLabel.ForeColor = Color.Red;
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this._person == null)
            {
                this._person = new Person();
            }
            this._person.Name = nameTextBox.Text;
            this._person.EmailAdress = emailAddressTextBox.Text;
            this._person.PhoneNumber = phoneNumberTextBox.Text;
            this.displayPerson(this._person);
            MessageBox.Show("Entered data saved successfully!");
        }

        private void buyPassButton_Click(object sender, EventArgs e)
        {
            if (this._person == null)
            {
                this._person = new Person();
            }

            bool purchaseResult = this._person.PurchaseParkingPass();
            this.displayPerson(this._person);
            if (!purchaseResult)
            {
                MessageBox.Show("This person already had a parking pass! Don't waste my money!");
            }

        }
    }
}