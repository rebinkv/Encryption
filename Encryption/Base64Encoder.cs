namespace Encryption
{
    using ResultDetails;
    using System;
    using System.Text;

    public class Base64Encoder
    {
        Result resultObject = new Result();

        public Result Encode(string plainText)
        {
            if (!string.IsNullOrEmpty(plainText))
            {
                var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                resultObject.Data = Convert.ToBase64String(plainTextBytes);
                resultObject.Status = true;
            }
            else
            {
                resultObject.Data = "Enter the text to be encoded!";
                resultObject.Status = false;
            }
            return resultObject;
        }
    }
}
