using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Global_System.Forms
{
    public partial class FrmRequestInfoUpdates : Form
    {
        public FrmRequestInfoUpdates()
        {
            InitializeComponent();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            DateTime submissionDate= DateTime.Now;
            DateTime submissionDateFormatted = submissionDate.Date;
            UpdateRequest newUpdateRequest = new UpdateRequest(SessionManager.Instance._IDOfUser,submissionDateFormatted,txtRequestTitle.Text,rtxtRequestDetails.Text,"Submitted",SessionManager.Instance._countryOfUser);
            newUpdateRequest.SendUpdateRequestToDB(newUpdateRequest);
            this.Close();
        }
    }
}
