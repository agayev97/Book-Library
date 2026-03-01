using BookLibrary.WinForms.Helpers;
using BookLibrary.WinForms.Models;
using BookLibrary.WinForms.Services;
using BookLibrary.WinForms.Session;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookLibrary.WinForms.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthApiService _authService;
        private readonly MainForm _mainForm;

        public LoginForm(AuthApiService authApiService, MainForm mainForm)
        {
            InitializeComponent();
            _authService = authApiService;
            _mainForm = mainForm;

            // Set the default button for the form
            this.AcceptButton = loginButton;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            // Clear any previous error messages
            lblError.Text = string.Empty;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                DisplayError("Zəhmət olmasa bütün sahələri doldurun");
                return;
            }

            try
            {
                // Create login request
                var loginRequest = new LoginRequestDto
                {
                    UserName = txtUsername.Text.Trim(),
                    Password = txtPassword.Text
                };

                // Attempt login
                var loginResponse = await _authService.LoginAsync(loginRequest);

                if (loginResponse == null)
                {
                    DisplayError("İstifadəçi adı və ya şifrə yanlışdır");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                // Save session details
                AppSession.Token = loginResponse.Token;
                AppSession.UserName = loginResponse.UserName;
                AppSession.Role = loginResponse.Role;

                // Open main form
                _mainForm.Show();
                //this.Hide();
            }
            catch (HttpRequestException)
            {
                DisplayError("Serverə qoşulmaq mümkün olmadı. İnternet bağlantınızı yoxlayın.");
            }
            catch (Exception ex)
            {
                DisplayError($"Gözlənilməz xəta baş verdi: {ex.Message}");
            }
        }

        private void IconEye_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Center the login panel
            CenterPanel();

            // Set placeholder text and password character
            txtUsername.PlaceholderText = "Username";
            txtPassword.PlaceholderText = "Password";
            txtPassword.UseSystemPasswordChar = true;
        }

        private void CenterPanel()
        {
            // Center the panel within the form
            panelCard.Left = (this.ClientSize.Width - panelCard.Width) / 2;
            panelCard.Top = (this.ClientSize.Height - panelCard.Height) / 2;
        }

        private void DisplayError(string message)
        {
            lblError.Text = message;
        }
    }
}
