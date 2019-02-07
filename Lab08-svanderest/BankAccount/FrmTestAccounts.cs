using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Sebastian van der Est
namespace BankAccount
{
    public partial class FrmTestAccounts : Form
    {
        public FrmTestAccounts()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // create a display string variable and initialize to an empty string
            string display = "";
            // create two bank account objects using both constructors - with valid data
            BankAccount myAccount = new BankAccount(123, 100m);
            BankAccount doeAccount = new BankAccount(234, 200m, "J Doe");
            // test one of the objects - get accessors --> add output to display string
            display += myAccount.ClientName + "\n" 
                    + myAccount.DateOpen + "\n" 
                    + myAccount.Balance + "\n" 
                    + myAccount.AccountNumber + "\n\n";
            // test one of the objects - set accessors  --> add output to display string
            doeAccount.ClientName = "John Doe";
            display += doeAccount.ClientName + "\n"
                    + doeAccount.DateOpen + "\n"
                    + doeAccount.Balance + "\n"
                    + doeAccount.AccountNumber + "\n\n";
            // test one of the objects - methods  --> add output to display string
            doeAccount.Withdrawal(100m);
            display += doeAccount.Balance + "\n\n";
            // show display string to user - use bank name in caption of message box
            MessageBox.Show(display, BankAccount.BankName);
            /*****************************Next Test*********************************/
            // reset display string to empty string
            display = "";
            // create one account using the 3 parameter constructor - invalid name
            BankAccount testAccount = new BankAccount(555, 27m, "");
            // use get accessor to check name  --> add output to display string
            display += testAccount.ClientName + "\n";
            // use set accessor to set invalid name  --> add output to display string
            testAccount.ClientName = "";
            display += testAccount.ClientName + "\n";
            // use set accessor to set valid name  --> add output to display string
            testAccount.ClientName = "John Doe";
            display += testAccount.ClientName + "\n";
            // show display sgtring to user - use bank name in caption of message box
            MessageBox.Show(display, BankAccount.BankName);
        }
    }
}
