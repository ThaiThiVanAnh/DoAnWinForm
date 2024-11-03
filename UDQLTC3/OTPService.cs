using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UDQLTC.BUS
{
    public class OTPService
    {
        public string GenerateOTP()
        {
            // Sinh mã OTP ngẫu nhiên với 6 chữ số
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        public void SendOTPEmail(string recipientEmail, string otpCode)
        {
            // Cấu hình thông tin gửi email
            string senderEmail = "vant26803@gmail.com"; // Thay bằng email của bạn
            string senderPassword = "jsrs tlcg phmy sbic"; // App password nếu dùng Gmail
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;

            // Thiết lập nội dung email
            var mailMessage = new MailMessage(senderEmail, recipientEmail)
            {
                Subject = "Mã xác thực của bạn",
                Body = $"Your OTP code is: {otpCode}",
                IsBodyHtml = false
            };

            using (var smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.EnableSsl = true;

                try
                {
                    smtpClient.Send(mailMessage);
                    Console.WriteLine("OTP email sent successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to send OTP email: {ex.Message}");
                }
            }
        }
    }
}
