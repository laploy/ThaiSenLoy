# Thai Sentiment Analytic by Loy [ThaiSenLoy]
[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.3731677.svg)](https://doi.org/10.5281/zenodo.3731677)

C# ฟรี tool ตรวจข้อความไทยว่าเป็น ด่า ติหนิ หรือมีคำหยาบคายหรือไม่

Thai sentiment text analytic by Loy (ThaiSenLoy) เป็นไลบรารีพัฒนาด้วย C# .NET Core 3.1 ทำงานได้ใน Windows, macOS และ Linux ใช้ทำแอพได้ทุกชนิด ไม่ต้องเรียกเว็บเซอร์วิส เป็น Nuget package ฝังในแอพของเท่านเรียกใช้งานได้แบบ off-line เรียกใช้งานง่าย ใช้โค้ดบรรทัดเดียวทำงานได้กับภาษา C#, F#, VB.NET และภาษา .NET ทั้งหมดที่สนับสนุน ML.NET ไลบรารี มีความแม่นยำ 90% เพราะ train model Machine learning ด้วย dataset ภาษาไทย เป็นข้อความคละกันระหว่างคำชมและคำด่ามากกว่าหมื่นข้อความ มีทั้งประโยคสั้นและยาวหลากหลาย รวบรวมจากหลายแหล่ง

## ก่อนใช้งาน
1. ดาวน์โหลดไฟล์ MLModel.zip จาก https://github.com/laploy/ThaiSenLoy/tree/master/ThaiSenLoy%20source%201.0/ThaiSenLoy/Model
2. สร้าง folder ชื่อ Model ใน root folder ของ Application เช่น ขณะกำลังดีบักใน Visual Studio ให้ใส่ใน bin\Debug\netcoreapp3.1>
2. นำไฟล์ MLModel.zipไปใส่ใน folder Model เช่น ขณะกำลังดีบักใน Visual Studio ให้ใส่ใน bin\Debug\netcoreapp3.1>\Model

## Package ID
ThaiSenLoy

## Version
1.0.0

## Owner
laploy


## Language
C# 8.0


## Dependencies
.NETStandard 2.0
Microsoft.ML (>= 1.4.0)
Microsoft.ML.FastTree (>= 1.4.0)

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
test


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

Nuget : https://www.nuget.org/packages/AppLogger_Loy/
