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
    public partial class RewardForm : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        private bool createNew = true;

        #region Properties

        public string Title { get; private set; }
        public string Description { get; private set; }

        #endregion

        public RewardForm()
        {
            InitializeComponent();
        }

        public RewardForm(Reward reward )
        {
            InitializeComponent();

            Title = reward.Title;
            Description = reward.Description;
            txtTitle.Text = Title;
            txtDescription.Text = Description;

            createNew = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Title = txtTitle.Text;
            Description = txtDescription.Text;

            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }

        private void txtTitle_Validated(object sender, EventArgs e)
        {
            Title = txtTitle.Text.Trim();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            string title = txtTitle.Text.Trim();
            bool valid = string.IsNullOrWhiteSpace(title);

            if (valid)
            {
                errorProvider.SetError(txtTitle, "Incorrect value");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTitle, string.Empty);
                e.Cancel = false;
            }
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            Description = txtDescription.Text.Trim();
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            string description = txtDescription.Text.Trim();
            bool valid = string.IsNullOrWhiteSpace(description);

            if (valid)
            {
                errorProvider.SetError(txtDescription, "Incorrect value");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDescription, string.Empty);
                e.Cancel = false;
            }
        }
    }
}
