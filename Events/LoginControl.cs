using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;

namespace Events
{
    public partial class LoginControl : System.Windows.Forms.UserControl
    {

        protected System.Windows.Forms.Label serverTypeLabel;
        protected System.Windows.Forms.Label serverInstanceLabel;
        protected System.Windows.Forms.Label authenticationLabel;
        protected System.Windows.Forms.Label userNameLabel;
        protected System.Windows.Forms.Label passwordLabel;
        protected System.Windows.Forms.ComboBox comboBoxServerType;
        protected System.Windows.Forms.ComboBox serverInstance;
        protected System.Windows.Forms.ComboBox comboBoxAuthentication;
        protected System.Windows.Forms.ComboBox userName;
        protected System.Windows.Forms.TextBox password;

        public EventHandler PWDTextChanged;
       
        public LoginControl()
        {
            InitializeComponent();
        }

        private void OnPWDTextChanged(object sender, EventArgs e)
        {
           
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
           
        }

        public void Initialize()
        {
            InitializeHandlers();
            RegisterHandlers();
        }

        public void InitializeHandlers()
        {
            PWDTextChanged = new EventHandler(OnPWDTextChanged); 
        }

        public void RegisterHandlers()
        {
            this.textBox2.TextChanged += PWDTextChanged;
        }
    }
}
