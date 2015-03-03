using System.Windows.Forms;

namespace OneTwoThree.AddUserToGoServer
{
	public partial class AddUserForm : Form
	{
		public AddUserForm()
		{
			InitializeComponent();
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void butAddUser_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Not Yet Implemented", "TEST", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
