using _1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Models
{
    public class User
    {
        public Gender gender { get; set; }
        /// <summary>
        /// ID
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// نام و نام خانوادگی
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// تلفن همراه
        /// </summary>
        public string CellPhone { get; set; }
        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// کارت های بانکی
        /// </summary>
        public List<CartInfo> Cartinfo { get; set; }
        /// <summary>
        /// شماره ثابت
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// کد تایید
        /// </summary>
        public string VerifyCode { get; set; }

        public List<Finance> finances { get; set; }

        public List<FinancialTransaction> financialTransactions { get; set; }

        public string NationalCode { get; set; }

        public string GenerateVerifyCode()
        {
            var randomNumber = new Random().Next(1000, 9999).ToString();
            return randomNumber;

        }
        private User()
        {
        }

        public User(string address, DateTime birthDate, string cellPhone, Gender gender, string phone, string nationalCode , List<CartInfo> cartInfos )
        {
            Address = address;
            BirthDate = birthDate;
            CellPhone = cellPhone;
            this.gender = gender;
            Phone = phone;
            NationalCode = nationalCode;
            Cartinfo = cartInfos;
            VerifyCode = GenerateVerifyCode();

        }
    }
}
