using ChinaAPICommon.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Enum;

namespace ChinaAPICommon.CustomAttribute
{
    public static class ValidateData<T>
    {
        public static ServicesResult ValidateRequiredData(T record)
        {
            //var className = typeof(T).Name;

            // Lấy toàn bộ property của TResult 
            var properties = typeof(T).GetProperties();

            // tạo một mảng để lưu các giá trị lỗi
            var validateFail = new List<string>();
            var result = new ServicesResult
            {
                IsSuccess = true,
            };

            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(record);

                // validate các trường Maxlength
                var maxLengthAttribute = (MyMaxLengthAttribute?)property.GetCustomAttributes(typeof(MyMaxLengthAttribute), false).FirstOrDefault();
                if (maxLengthAttribute != null && propertyValue != null)
                {
                    var length = ((string)propertyValue).Length;
                    if (length > maxLengthAttribute.MaxLength)
                    {
                        result.IsSuccess = false;
                        result.ErrorCode = maxLengthAttribute.ErrorCode;
                        return result;
                    }
                }

                // Validate trường băt buộc
                var requiredAttribute = (RequiredAttribute?)property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault();

                // Nếu property có attribute là required thì kiểm tra xem giá trị truyền lên có null không 
                if (requiredAttribute != null && (string.IsNullOrEmpty(propertyValue?.ToString()) || propertyValue.ToString() == "00000000-0000-0000-0000-000000000000"))
                {
                    validateFail.Add(propertyName);
                }
                if (validateFail.Count > 0)
                {
                    result.IsSuccess = false;
                    result.ErrorCode = MyErrorCode.RequiredValueIsEmpty;
                    result.Error = validateFail;
                }

                var emailAttribute =
                    (EmailAttribute?)property.GetCustomAttributes(typeof(EmailAttribute), false).FirstOrDefault();
                if (emailAttribute != null && !string.IsNullOrEmpty(propertyValue?.ToString()))
                {
                    var isValidEmail = IsValidEmail((string)propertyValue);
                    if (!isValidEmail)
                    {
                        result.IsSuccess = false;
                        result.ErrorCode = MyErrorCode.EmailInvalid;
                    }
                }
            }


            return new ServicesResult
            {
                IsSuccess = true,
            };

        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
