namespace Encryption
{
    using ResultDetails;
    using System;
    using System.Text;

    public class Base64Decoder
    {
        public Result Decode(string encodedText)
        {
            Result resultObject = new Result();

            if (!string.IsNullOrEmpty(encodedText))
            {
                try
                {
                    var encodedTextBytes = Convert.FromBase64String(encodedText);
                    resultObject.Data = Encoding.UTF8.GetString(encodedTextBytes);
                    resultObject.Status = true;
                }
                catch
                {
                    resultObject.Data = "The input is not a valid Base-64 string. Please enter a valid Base-64 string.";
                    resultObject.Status = false;
                }
            }
            else
            {
                resultObject.Data = "Enter the text to be decoded!";
                resultObject.Status = false;
            }
            return resultObject;
        }
    }
}