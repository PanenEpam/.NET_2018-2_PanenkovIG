using Department.BL;
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
    public partial class MainForm : Form
    {
        private enum UserSortMode { Asceding, Desceding };
        private enum RewardSortMode { Asceding, Desceding };

        private UserSortMode userSortMode = UserSortMode.Asceding;
        private RewardSortMode rewardSortMode = RewardSortMode.Asceding;

        private readonly Logic logic;


        public MainForm()
        {
            InitializeComponent();

            CreateUserGrid();
            CreateRewardGrid();

            logic = new Logic();

            Visible = false;
        }

        void DisplayUsers()
        {
            ctlUsersGridViwe.DataSource = null;
            ctlUsersGridViwe.DataSource = logic.GetUsers().ToList();

        }

        void DisplayRewards(List<Reward> rewards)
        {
            ctlRewardsGridView.DataSource = null;
            ctlRewardsGridView.DataSource = rewards;
        }

        void DisplayRewards()
        {
            ctlRewardsGridView.DataSource = null;
            ctlRewardsGridView.DataSource = logic.GetRewards();
        }

        private void CreateUserGrid()
        {
            ctlUsersGridViwe.AutoGenerateColumns = false;

            ctlUsersGridViwe.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "UserID",
                Visible = false

            });
            ctlUsersGridViwe.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "FirstName",
                HeaderText = "First Name",
                Width = 100

            });
            ctlUsersGridViwe.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "LastName",
                HeaderText = "Last Name",
                Width = 100

            });
            ctlUsersGridViwe.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Birthdate",
                HeaderText = "Birthdate",
                Width = 100

            });
            ctlUsersGridViwe.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "RewardsOfUser",
                HeaderText = "Rewards",
                Width = 200

            });
        }

        private void CreateRewardGrid()
        {
            ctlRewardsGridView.AutoGenerateColumns = false;

            ctlRewardsGridView.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "RewardID",
                Visible = false

            });
            ctlRewardsGridView.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Title",
                HeaderText = "Title",
                Width = 100,

            });
            ctlRewardsGridView.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Description",
                HeaderText = "Description",
                Width = 200

            });
        }

        private void AddUser()
        {
            UserForm userForm = new UserForm(logic.GetRewards().ToList());
      
            if (userForm.ShowDialog(this) == DialogResult.OK)
            {
                logic.AddUser(userForm.FirstName, userForm.LastName, userForm.Birthdate.Date, logic.GetRewards().
                    Where(x => userForm.UserRewardList.Contains(x.Title)).ToList());
                DisplayUsers();
            }
        }

        private void ChangeUser()
        {
            if (ctlUsersGridViwe.SelectedCells.Count > 0)
            {
                UserGridView userGridView = new UserGridView((User)ctlUsersGridViwe.SelectedCells[0].OwningRow.DataBoundItem);
                User user = logic.GetUserById(userGridView.UserId);
                UserForm userForm = new UserForm(user, logic.GetRewards().ToList());

                if (userForm.ShowDialog(this) == DialogResult.OK)
                {
                    user.FirstName = userForm.FirstName;
                    user.LastName = userForm.LastName;
                    user.Birthday = userForm.Birthdate;
                    user.UserRewarList = logic.GetRewards().Where(x => userForm.UserRewardList.Contains(x.Title)).ToList();

                    logic.ChangeUser(user);

                    DisplayUsers();
                }
            }
        }

        private void RemoveUser()
        {
            if (ctlUsersGridViwe.SelectedCells.Count > 0)
            {
                User user = (User)ctlUsersGridViwe.SelectedCells[0].OwningRow.DataBoundItem;

                logic.RemoveUser(user);
                DisplayUsers();
            }
        }

        private void AddReward()
        {
            RewardForm form = new RewardForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                logic.AddReward(form.Title, form.Description);
                DisplayRewards();
            }
        }

        private void ChangeReward()
        {
            if (ctlRewardsGridView.SelectedCells.Count > 0)
            {
                Reward reward = (Reward)ctlRewardsGridView.SelectedCells[0].OwningRow.DataBoundItem;
                RewardForm rewardForm = new RewardForm(reward);
               

                if (rewardForm.ShowDialog(this) == DialogResult.OK)
                {
                    reward.Title = rewardForm.Title;
                    reward.Description = rewardForm.Description;

                    logic.ChangeReward(reward);

                    DisplayRewards();
                    DisplayUsers();
                }
            }
        }

        private void RemoveReward()
        {
            if (ctlRewardsGridView.SelectedCells.Count > 0)
            {
                Reward reward = (Reward)ctlRewardsGridView.SelectedCells[0].OwningRow.DataBoundItem;

                logic.RemoveReward(reward);
                DisplayRewards();
            }
        }

        #region Event handlers

        private void ctrAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void ctlEditUser_Click(object sender, EventArgs e)
        {
            ChangeUser();
        }

        private void ctlRemoveUser_Click(object sender, EventArgs e)
        {
            RemoveUser();
        }

        private void ctlAddReward_Click(object sender, EventArgs e)
        {
            AddReward();
        }

        private void ctlEditReward_Click(object sender, EventArgs e)
        {
            ChangeReward();
        }

        private void ctlRemoveReward_Click(object sender, EventArgs e)
        {
            RemoveReward();
        }

        private void ctlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ctlUsersGridViwe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (userSortMode == UserSortMode.Asceding)
                {
                    logic.SortUserByFirstNameDes();
                    userSortMode = UserSortMode.Desceding;
                }
                else
                {
                    logic.SortUserByFirstNameAsc();
                    userSortMode = UserSortMode.Asceding;
                }
            }

            if (e.ColumnIndex == 2)
            {
                if (userSortMode == UserSortMode.Asceding)
                {
                    logic.SortUserByLastNameDes();
                    userSortMode = UserSortMode.Desceding;
                }
                else
                {
                    logic.SortUserByLastNameAsc();
                    userSortMode = UserSortMode.Asceding;
                }
            }

            if (e.ColumnIndex == 3)
            {
                if (userSortMode == UserSortMode.Asceding)
                {
                    logic.SortUserByBirthdayDes();
                    userSortMode = UserSortMode.Desceding;
                }
                else
                {
                    logic.SortUserByBirthdayAsc();
                    userSortMode = UserSortMode.Asceding;
                }

                DisplayUsers();
            }
        }

        private void ctlRewardsGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var sorderRewards = new List<Reward>();
            if (e.ColumnIndex == 1)
            {
                if (rewardSortMode == RewardSortMode.Asceding)
                {
                    sorderRewards = logic.SortRewardByTitleDes();
                    rewardSortMode = RewardSortMode.Desceding;
                }
                else
                {
                    sorderRewards = logic.SortRewardByTitleAsc();
                    rewardSortMode = RewardSortMode.Asceding;
                }
            }

            if (e.ColumnIndex == 2)
            {
                if (rewardSortMode == RewardSortMode.Asceding)
                {
                    logic.SortRewardByDescriptionDes();
                    rewardSortMode = RewardSortMode.Desceding;
                }
                else
                {
                    logic.SortRewardByDescriptionAsc();
                    rewardSortMode = RewardSortMode.Asceding;
                }
            }

            DisplayRewards(sorderRewards);
        }

        #endregion
    }
}
