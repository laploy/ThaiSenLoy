// Thai Sentiment Analytic by Loy [ThaiSenLoy]
// https://github.com/laploy/ThaiSenLoy
// Laploy 2020

using System;
using Laploy.ThaiSen.ML;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string testText1 = "ร้านนี้ไม่ดี ส่งของช้า นานเลยกว่าจะได้แถุมสินค้าก็มีตำหนิ";
            string testText2 = "บริการลูกค้าติดต่อได้ง่าย ให้ความช่วยเหลือดี ถือว่าใช้ได้เลยครับ";
            
            // ถ้า Prediction = True แปลว่าเป็นข้อความที่มีความหมายเชิงลบ เป็นการตำหนิ
            var predictResult = ThaiSen.Predict(testText1);  
            Console.WriteLine($"Prediction Result (True = negative): " +
                $"{predictResult.Result}");
            Console.WriteLine($"Predicted score : {predictResult.Score}");
            Console.WriteLine("-----------------------------------");

            // ถ้า Prediction = False แปลว่าเป็นข้อความที่มีความหมายในทางดี
            // เป็นประโยคคำถาม หรือเป็นประโยคบอกเล่าที่ไม่ส่อความรู้สิ่กใด ๆ
            predictResult = ThaiSen.Predict(testText2);
            Console.WriteLine($"Prediction Result (True = negative): " +
                $"{predictResult.Result}");
            Console.WriteLine($"Predicted score : {predictResult.Score}");
            Console.WriteLine("End program");
        }
    }
}



