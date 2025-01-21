using Shuler_MasterPol.Models;
using Shuler_MasterPol.Shuler_MasterPolDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shuler_MasterPol.Exceptions;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using Shuler_MasterPol.Models.Services;

namespace Shuler_MasterPol.AppForms
{
    public partial class CreateUpdatePartnerForm : ParentForm
    {
        Partner _partners;
        public CreateUpdatePartnerForm()
        {
            InitializeComponent();
            _partners = new Partner();
            UserExperienceManager.SetTitle(this, "Новый партнер");
        }

        public CreateUpdatePartnerForm(Partner partner)
        {
            InitializeComponent();
            _partners = partner;
            UserExperienceManager.SetTitle(this, $"Изменить партнера: \"{_partners.PartnerName}\"");
        }


        private void CreateUpdatePartnerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shuler_MasterPolDataSet.ProductType". При необходимости она может быть перемещена или удалена.
            this.productTypeTableAdapter.Fill(this.shuler_MasterPolDataSet.ProductType);
            this.partnerTypeTableAdapter1.Fill(this.shuler_MasterPolDataSet.PartnerType);

            if (!_partners.isNew())
            {
                partnerBindingSource.DataSource = _partners;
            }

            UserExperienceManager.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceManager.CustomizeControls(splitContainer.Panel2.Controls);


        }

        private string GetSanitizedPhone()
        {
            // PKGH            
            // Подготовка введенной пользователем информации
            // о телефоне для сохранения в БД.

            string trimmedPhone = PhoneMaskedTextBox.Text.Replace("+", "");
            trimmedPhone = trimmedPhone.Replace(" ", "");
            return trimmedPhone;
        }
        public static MasterPolDb context = new MasterPolDb();

        private void FillModelFields()
        {
            _partners.PartnerName = partnerNameTextBox.Text.Trim();
            _partners.PartnerTypeId = (int)this.partnerTypeIdComboBox.SelectedValue;
            _partners.Rating = int.Parse(this.ratingTextBox.Text);
            _partners.Address = this.addressTextBox.Text.Trim();
            _partners.Ceo = this.ceoTextBox.Text.Trim();
            _partners.Phone = Int64.Parse(GetSanitizedPhone());
            _partners.Email = this.emailTextBox.Text.Trim();
        }

        /// <summary>
        /// PKGH
        /// Проверка введенной пользователем информации. Если допущена ошибка,
        /// сообщить, в каком поле это случилось, и что можно вводить.
        /// </summary>
        /// <param name="pattern">Паттерн</param>
        /// <param name="userInputText">Текст, введенный пользователем в поле на форме.</param>
        /// <param name="field">Поле, в котором пользователь допустил ошибку.</param>
        /// <param name="messageAboutAllowedSymbols">Какие символы разрешено вводить в это поле.</param>
        /// <exception cref="ValidationException"></exception>
        private void ValidateGeneral(string userInputText, string field, string messageAboutAllowedSymbols = "поле не должно быть пустым.", string pattern = @"^.+$")
        {
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            bool isValid = regex.IsMatch(userInputText.Trim());
            if (!isValid)
            {
                throw new ValidationException($"{field}: {messageAboutAllowedSymbols}");
            }
        }

        private void ValidatePartnerName()
        {
            ValidateGeneral(partnerNameTextBox.Text, "Наименование");
        }

        private void ValidateRating()
        {
            ValidateGeneral(ratingTextBox.Text, "Рейтинг", "допустимо только целое неотрицательное число.", @"^\d+$");
        }
        private void ValidateAddress()
        {
            ValidateGeneral(addressTextBox.Text, "Адрес");
        }

        private void ValidateCeo()
        {
            ValidateGeneral(ceoTextBox.Text, "Директор");
        }

        private void ValidatePhone()
        {
            ValidateGeneral(GetSanitizedPhone(), "Телефон", "должно быть 11 цифр.", @"^\d{11}$");
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void ValidateEmail()
        {
            if (!IsValidEmail(emailTextBox.Text.Trim()))
            {
                throw new ValidationException("Неверный формат электронной почты");
            }
        }



        private void Validate()
        {
            ValidatePartnerName();
            ValidateRating();
            ValidateAddress();
            ValidateCeo();
            ValidatePhone();
            ValidateEmail();
        }

        private void SaveAttentionBackground_Click(object sender, EventArgs e)
        {

            try
            {
                Validate();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillModelFields();

            if (_partners.isNew())
            {
                Program.context.Partner.Add(_partners);
            }

            DialogResult toBeSaved = MessageBox.Show("Сохранить?", "Запрос подтверждения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (toBeSaved == DialogResult.No)
            {
                return;
            }

            try
            {
                Program.context.SaveChanges();
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void partnerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partnerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shuler_MasterPolDataSet);

        }
    }
}
