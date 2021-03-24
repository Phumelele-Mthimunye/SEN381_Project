using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PremierServiceSolutions_V1._0._0.CallAgent
{
    public partial class PhoneCall : Form
    {
        public CallController CallManager { get; set; }
        private int conversationIndex = 0;
        private ComboBox selectionInput = new ComboBox();
        private TextBox textInput= new TextBox();
        private Label lblCallerName = new Label();
        private Label lblCallerDisplay = new Label();
        private Label lblRecieverName = new Label();
        private Label lblRecieverDisplay = new Label();
        public PhoneCall()
        {
            InitializeComponent();
        }

        private void PhoneCall_Load(object sender, EventArgs e)
        {
            lblCallerName.AutoSize = true;
            lblCallerDisplay.AutoSize = true;


            lblRecieverName.AutoSize = true;
            lblRecieverDisplay.AutoSize = true;


            CallManager = new CallController(new Call(new Client(), new Employee()));
            lblRecieverName.Text = CallManager.Call.Reciever.DisplayName;
            lblCallerName.Text = "Unknown Caller";



            lblRecieverDisplay.Text = String.Format("Hello  \nplease select option\n1 - log service request \n2 - enquire service request");

            fpnlChatContent.Controls.Add(new Label() { Text = lblRecieverName.Text, AutoSize = true });
            fpnlChatContent.Controls.Add(new Label() { Text = lblRecieverDisplay.Text, AutoSize = true });
            fpnlChatContent.Controls[fpnlChatContent.Controls.Count - 1].Dock = DockStyle.Left;
            fpnlChatContent.Controls[fpnlChatContent.Controls.Count - 2].Dock = DockStyle.Left;

            selectionInput.Items.AddRange(new string[] { "1", "2" });
            pnlCallInput.Controls.Add(selectionInput);
            pnlCallInput.Controls[pnlCallInput.Controls.Count - 1].Dock = DockStyle.Fill;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (conversationIndex == 0)
            {
                lblCallerDisplay.Text = selectionInput.SelectedItem.ToString();
                
                fpnlChatContent.Controls.Add(new Label() { Text = lblCallerName.Text, AutoSize = true });
                fpnlChatContent.Controls.Add(new Label() { Text = lblCallerDisplay.Text, AutoSize = true });

                fpnlChatContent.Controls[fpnlChatContent.Controls.Count - 1].Anchor = AnchorStyles.Right;
                fpnlChatContent.Controls[fpnlChatContent.Controls.Count - 2].Anchor = AnchorStyles.Right;


                lblRecieverDisplay.Text = "Please enter your ID";

                fpnlChatContent.Controls.Add(new Label() { Text = lblRecieverName.Text, AutoSize = true });
                fpnlChatContent.Controls.Add(new Label() { Text = lblRecieverDisplay.Text, AutoSize = true });
                fpnlChatContent.Controls[fpnlChatContent.Controls.Count - 1].Dock = DockStyle.Left;
                fpnlChatContent.Controls[fpnlChatContent.Controls.Count - 2].Dock = DockStyle.Left;

                pnlCallInput.Controls.Clear();
                pnlCallInput.Controls.Add(textInput);
                pnlCallInput.Controls[pnlCallInput.Controls.Count - 1].Dock = DockStyle.Fill;

                selectionInput.Items.Clear();
                conversationIndex++;
                return;

            }
            if (conversationIndex == 1)
            {

                lblCallerDisplay.Text = textInput.Text;


                fpnlChatContent.Controls.Add(new Label() { Text = lblCallerName.Text, AutoSize = true });
                fpnlChatContent.Controls.Add(new Label() { Text = lblCallerDisplay.Text, AutoSize = true });

                fpnlChatContent.Controls[fpnlChatContent.Controls.Count - 1].Anchor = AnchorStyles.Right;
                fpnlChatContent.Controls[fpnlChatContent.Controls.Count - 2].Anchor = AnchorStyles.Right;


                lblRecieverDisplay.Text = "Thank you \n, please select device with problem";

                fpnlChatContent.Controls.Add(lblRecieverName);
                fpnlChatContent.Controls.Add(lblRecieverDisplay);
                fpnlChatContent.Controls[fpnlChatContent.Controls.Count - 1].Dock = DockStyle.Left;
                fpnlChatContent.Controls[fpnlChatContent.Controls.Count - 2].Dock = DockStyle.Left;
                conversationIndex++;
                return;
            }
            if (conversationIndex++ == 1)
            {

            }
        }
    }
}
