
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class UserForm : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        private bool createeNew = true;

        #region Properties

        public List<string> UserRewardList = new List<string>();
        public List<string> AllRewards;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birthdate { get; private set; }
        
        #endregion

        public UserForm(List<Reward> rewards)
        {
            InitializeComponent();
            AllRewards = rewards.Select(x => x.Title).ToList();

            createeNew = false;
        }

        public UserForm(User user, List<Reward> rewards) 
        {
            InitializeComponent();

            AllRewards = rewards.Select(x => x.Title).ToList();

            FirstName = user.FirstName;
            LastName = user.LastName;
            Birthdate = user.Birthday;
            UserRewardList = user.UserRewarList.Select(x => x.Title).ToList();

            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            dateBirthday.Value = Birthdate;

            createeNew = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text.Trim();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            string fname = txtFirstName.Text.Trim();
            bool valid = string.IsNullOrWhiteSpace(fname);

            if (valid)
            {
                errorProvider.SetError(txtFirstName, "Incorrect value");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFirstName, string.Empty);
                e.Cancel = false;
            }
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            LastName = txtLastName.Text.Trim();
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            string lname = txtLastName.Text.Trim();
            bool valid = string.IsNullOrWhiteSpace(lname);

            if (valid)
            {
                errorProvider.SetError(txtLastName, "Incorrect value");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLastName, string.Empty);
                e.Cancel = false;
            }
        }

        private void ctlRewardOfUser_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
            if (e.NewValue == CheckState.Checked)
            {
                UserRewardList.Add(ctlRewardOfUser.Items[e.Index].ToString());
            }
            UserRewardList.Remove(ctlRewardOfUser.Items[e.Index].ToString());
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            foreach ( var item in AllRewards)
            {
                ctlRewardOfUser.Items.Add(item);
            }
        }
    }
}
