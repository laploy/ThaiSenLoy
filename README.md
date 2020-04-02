# Thai Sentiment Analytic by Loy [ThaiSenLoy]
 [![nuget](https://img.shields.io/nuget/v/TW.Resfit.Core.svg)](https://www.nuget.org/packages/ThaiSenLoy/)  [![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/) [![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.3731677.svg)](https://doi.org/10.5281/zenodo.3731677)

Library tool ช่วยตรวจข้อความไทยว่าเป็น ด่า ติหนิ หรือมีคำหยาบคายหรือไม่

เป็นไลบรารีพัฒนาด้วย C# .NET Core 3.1 ทำงานได้ใน Windows, macOS และ Linux ใช้ทำแอพได้ทุกชนิด ไม่ต้องเรียกเว็บเซอร์วิส เป็น Nuget package ฝังในแอพของท่านเรียกใช้งานได้แบบ off-line ใช้งานง่ายโค้ดบรรทัดเดียวทำงานได้กับภาษา C#, F#, VB.NET และภาษา .NET ทั้งหมดที่สนับสนุน ML.NET ไลบรารี (.NET Standard 2.0) มีความแม่นยำ 90% เพราะ train model Machine learning ด้วย dataset ภาษาไทย เป็นข้อความคละกันระหว่างคำชมและคำด่ามากกว่าหมื่นข้อความ มีทั้งประโยคสั้นและยาวหลากหลาย รวบรวมจากหลายแหล่ง

## ก่อนใช้งาน
1. ดาวน์โหลดไฟล์ MLModel.zip จาก https://github.com/laploy/ThaiSenLoy/tree/master/ThaiSenLoy%20source%201.0/ThaiSenLoy/Model
2. สร้าง folder ชื่อ Model ใน root folder ของ Application เช่น ขณะกำลังดีบักใน Visual Studio ให้ใส่ใน bin\Debug\netcoreapp3.1>
2. นำไฟล์ MLModel.zipไปใส่ใน folder Model เช่น ขณะกำลังดีบักใน Visual Studio ให้ใส่ใน bin\Debug\netcoreapp3.1>\Model

## Prediction 

*ถ้าผลลัพธ์ของการ predict เป็น true แสดงว่าเป็นอย่างใดอย่างหนึ่งต่อไปนี้*
- ข้อความมีความรู้สึกในทางลบ
- ข้อความมีคำไม่สุภาพ
- ข้อความมีคำหยาบคาย

*ถ้าผลลัพธ์ของการ predict เป็น false แสดงว่าเป็นอย่างใดอย่างหนึ่งต่อไปนี้*
- ข้อความแสดงความรู้สึกในทางบวก
- ข้อความไม่แสดงความรู้สึกใด ๆ เช่นประโยคบอกเล่า
- เป็นประโยคคำถาม

## Traning Data Set

Data Set ที่ใช้ train มีข้อความที่เป็นประโยคภาษาภาษาไทยทั้งสิ้น 24,561 ข้อความ 3,934,610 ตัวอักษร แบ่งเป็นประโยคให้ความรู้สึกกลาง ๆ  ประโยคคำถาม ข้อความเชิงตำหนิ และข้อความด่า

*ตัวอย่างคำที่มีความหมายกลาง ๆ*
- จัน จ้า จูน เจ้ ใช่ ดูๆ โด่ ตัง ตัว เตง เตร ถูก โถ่ เทส เทอ นะๆ นี้ บ่ๆ บาย ปี๊ ฝาก มาๆ มึง แม่ ยัง ยี๋ เย้ แยก ลดๆ ลอง

*ตัวอย่างคำให้ความรู้สึกทางลบ*
- ไม่กินจบ ไม่รู้คะ สาขาน้อย เสียใตไง เสียเวลา หยุดก่อน อีใจร้าย เออแพง55 กุแพ้โซฟี จะอ้วก!!! ดีแม๊กอืด ตอแหลป่าว ตะเตือนไต โนวมันนี่ บ่กินลีโอ เพลียยยยย

*ตัวอย่างคำหยาบคาย*
- ระยำ ทมิฬ ลูกโสเภณี ควย หี เจี๊ยว แดก ขี้ นรกแดกกบาล เศษนรก กวนส้นตีน ล่อกัน เอากัน เยี่ยว ขึ้แตก เย็ด

*ตัวอย่างประโยคที่มีความหมายกลาง ๆ*
- อาทิตย์หน้าไปโดนกัน
- อาทิตย์หน้าหยุดนะ55
- อ้าวเครๆเเพรวเลี้ยง
- มันเป็นญาติกับไอ้ฤทธิ์กินเเบล็คใช่มั้ย
- มาร่วมกันร่วมเล่นสนุก ขับนิสสันกันเถอะ
- มาแล้ววววว แต่รอบนี้มีสตรอเบอร์รี่ด้วย
- มีแต่ของแดกลดเว้ยตูนเว้ย อัญชลี วงษ์ดี
- มียารักษาริดสีดวงและมะเร็งลำไส้มั๊ยค่ะ

*ตัวอย่างประโยคที่ให้ความรู้สึกทางลบ*
- ต้องดักตีแม่มไอพวกนี้
- ต่างจังหวัดไม่มีเซงไป
- ติดบุหรี่ไฟฟ้าว่ะแม่ง
- แต่ปวดหัวเพราะแดกช้าง
- ทำไมฮอทพอทไม่มีกุ้งคะ
- แท็กอีกล้าวอิเหี้ยยยย

*ตัวอย่างประโยคคำถาม*
- อ้าวไม่ไปเรียนละหรอ
- อิดอก เช้านี้เลยแมะ
- อิ่มกับการเที่ยวยัง
- ทำไมที่เรากินไม่มีใส้
- มีของเชฟเทรลเบลเซอร์หรือเปล่าครับเทอิน
- เมื่อถามจีน่าว่าบิวตี้บุฟเฟ่มีโปรไหม??



## Package ID
ThaiSenLoy

## Version
1.0.0

## Owner
laploy


## Language
C# 8.0

## Compatible Frameworks

ThaiSenLoy สามารถทำงานได้กับ project ที่ใช้ framework ต่าง ๆ ตามรายการข้างล่าง ตัวเลขทางขวาคือหมายเลข version ขั้นต่ำสุดที่จะสามารถใช้ได้
- .NET Standard	2.0	
- .NET Core	2.0	
- .NET Framework 1	4.6.1 2	
- Mono	5.4	
- Xamarin.iOS	10.14	
- Xamarin.Mac	3.8	
- Xamarin.Android	8.0	
- Universal Windows Platform	10.0.16299	
- Unity	2018.1	



## Dependencies
- .NETStandard 2.0
- Microsoft.ML (>= 1.4.0)
- Microsoft.ML.FastTree (>= 1.4.0)

## Description
C# ฟรี tool ตรวจข้อความไทยว่าเป็น ด่า ติหนิ หรือมีคำหยาบคายหรือไม่

Thai sentiment text analytic by Loy (ThaiSenLoy) เป็นไลบรารีพัฒนาด้วย C# .NET Core 3.1 ทำงานได้ใน Windows, macOS และ Linux ใช้ทำแอพได้ทุกชนิด ไม่ต้องเรียกเว็บเซอร์วิส เป็น Nuget package ฝังในแอพของเท่านเรียกใช้งานได้แบบ off-line เรียกใช้งานง่าย ใช้โค้ดบรรทัดเดียวทำงานได้กับภาษา C#, F#, VB.NET และภาษา .NET ทั้งหมดที่สนับสนุน ML.NET ไลบรารี มีความแม่นยำ 90% เพราะ train model Machine learning ด้วย dataset ภาษาไทย เป็นข้อความคละกันระหว่างคำชมและคำด่ามากกว่าหมื่นข้อความ มีทั้งประโยคสั้นและยาวหลากหลาย รวบรวมจากหลายแหล่ง

## Release Notes (for this version)
This is first release

## Project URL
https://github.com/laploy/ThaiSenLoy

## Repository Type
GitHub package

## Repository URL
https://github.com/laploy/ThaiSenLoy

Icon Preview

## Authors
Laploy V. Angkul

## Copyright
Creative Commons Attribution 4.0 International Public License

## Tags
C# .NET Standard ML Machine Learning Thai Sentiment analysis Loy Laploy


## Corpus file structure

*ThaiSenLoy example 1.0* source code ตัวอย่างวิธีใช้ ThaiSenLoy
- Example
- - Example.csproj
- - Program.cs 
- ThaiSenLoy.sln

*ThaiSenLoy source 1.0* source code ThaiSenLoy
- ThaiSenLoy.sln
- - ThaiSenLoy
- - Model
- - - MLModel.zip *** Machine Learning Model 
- - ThaiSen.cs
- ThaiSenLoy.csproj


## การติดตั้ง ThaiSenLoy
การติดตั้งทำได้สองแบบ คือผ่าน NuGet หรือ download ที่ GitHub
1.	NuGet: แนะนำให้ใช้วิธีนี้เพราะสะดวก ทำได้โดยติดตั้งผ่าน NuGet Package Manager ใน Microsoft Visual Studio หรือใช้ CLI หากทำงานใน Microsoft Visual Studio Code
2.	GitHub: หากต้องการ source code มาใส่ใน project อาจ clone ได้จาก GitHub https://github.com/laploy/ThaiSenLoy

## การติดตั้ง Dependency
ThaiSenLoy มี dependency ต่าง ๆ ตามรายการที่เห็นข้างล่าง หากท่านติดตั้ง ThaiSenLoy ผ่าน NuGet Package Manager ใน Microsoft Visual Studio ท่านไม่จำเป็นติดตั้ง file ต่าง ๆ เหล่านี้เองเพราะ Microsoft Visual Studio จะติดตั้งให้โดยอัตโนมัต

*Microsoft.ML 1.4.0*
- Microsoft.ML.CpuMath (>= 1.4.0)
- Microsoft.ML.DataView (>= 1.4.0)
- Newtonsoft.Json (>= 10.0.3)
- System.CodeDom (>= 4.4.0)
- System.Collections.Immutable (>= 1.5.0)
- System.Memory (>= 4.5.1)
- System.Reflection.Emit.Lightweight (>= 4.3.0)
- System.Threading.Tasks.Dataflow (>= 4.8.0)

*Microsoft.ML.FastTree 1.4.0*
- .NETStandard 2.0
- Microsoft.ML (>= 1.4.0)

*NETStandard.Library 2.0.3*


*.NETCoreApp 2.0*
- Microsoft.NETCore.Platforms (>= 1.1.0)

*.NETFramework 4.5*
- Microsoft.NETCore.Platforms (>= 1.1.0)
- System.Runtime.InteropServices.RuntimeInformation (>= 4.3.0)

*.NETFramework 4.6*
- Microsoft.NETCore.Platforms (>= 1.1.0)
- Microsoft.Win32.Primitives (>= 4.3.0)
- System.AppContext (>= 4.3.0)
- System.Console (>= 4.3.0)
- System.Globalization.Calendars (>= 4.3.0)
- System.IO.Compression (>= 4.3.0)
- System.IO.Compression.ZipFile (>= 4.3.0)
- System.IO.FileSystem (>= 4.3.0)
- System.IO.FileSystem.Primitives (>= 4.3.0)
- System.Net.Http (>= 4.3.2)
- System.Net.Sockets (>= 4.3.0)
- System.Runtime.InteropServices.RuntimeInformation (>= 4.3.0)
- System.Security.Cryptography.Algorithms (>= 4.3.0)
- System.Security.Cryptography.Encoding (>= 4.3.0)
- System.Security.Cryptography.Primitives (>= 4.3.0)
- System.Security.Cryptography.X509Certificates (>= 4.3.0)
- System.Xml.ReaderWriter (>= 4.3.0)

*.NETFramework 4.6.1*
- Microsoft.NETCore.Platforms (>= 1.1.0)

*.NETStandard 2.0*
- Microsoft.NETCore.Platforms (>= 1.1.0)
- Portable Class Library (.NETFramework 4.5, Windows 8.0)
- Microsoft.NETCore.Platforms (>= 1.1.0)
- System.Runtime.InteropServices.RuntimeInformation (>= 4.3.0)

*Portable Class Library (.NETFramework 4.5, Windows 8.0, WindowsPhone 8.0, WindowsPhoneApp 8.1)*
- Microsoft.NETCore.Platforms (>= 1.1.0)

*Portable Class Library (.NETFramework 4.5, Windows 8.0, WindowsPhoneApp 8.1)*
- Microsoft.NETCore.Platforms (>= 1.1.0)
- System.Runtime.InteropServices.RuntimeInformation (>= 4.3.0)

*UAP 10.0*

*UAP 10.0.15138*
- Microsoft.NETCore.Platforms (>= 1.1.0)

*Windows 8.0*
- Microsoft.NETCore.Platforms (>= 1.1.0)

*System.Runtime.InteropServices.RuntimeInformation (>= 4.3.0)*

*WindowsPhone 8.0*
- Microsoft.NETCore.Platforms (>= 1.1.0)

*WindowsPhoneApp 8.1*
- Microsoft.NETCore.Platforms (>= 1.1.0)
- System.Runtime.InteropServices.RuntimeInformation (>= 4.3.0)


## การติดตั้ง Machine Learning Model file (MLModel.zip)

ไม่ว่าจะติดตั้งโดยใช้ NuGet หรือ GitHub ท่านจะต้องติดตั้ง MLModel.zip ก่อนจะสามารถใช้งานได้ วิธีติดตั้งคือให้สร้างโฟลเดอร์ชื่อ Model ใน root ของ Application แล้วนำไฟล์ MLModel.zip ไปใส่ไว้ในนั้นโดยไม่ต้อง unzip มันก่อน 

ดาวน์โหลดไฟล์ MLModel.zip จาก https://github.com/laploy/ThaiSenLoy/tree/master/ThaiSenLoy%20source%201.0/ThaiSenLoy/Model

ยกตัวอย่างเช่นหากท่านกำลังพัฒนา Application .NET Core 3.1 ด้วยภาษา C# ในโหมด debug ในโปรแกรม Microsoft Visual Studio จะมี folder ที่เป็น root ของ Application เป็น ..\bin\Debug\netcoreapp3.1\

ในกรณีที่ท่าน download source จาก GitHub และเปิด solution ด้วยโปรแกรม Microsoft Visual Studio โปรแกรม Microsoft Visual Studio จะสร้าง folder นี้ในที่ ๆ เหมาะสมและนำไฟล์ MLModel.zip ไปใส่ไว้ให้อย่างอัตโนมัต





Creative Commons Attribution 4.0 International Public License

Nuget : https://www.nuget.org/packages/ThaiSenLoy/
