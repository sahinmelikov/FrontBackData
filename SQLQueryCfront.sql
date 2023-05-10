create database StudentInformation
use StudentInformation

Create Table StudentEduAzINform(
ID INT Primary key identity,
FULLName NVarChar(50),
EmailAdress VarChar(100),
IdentNO Nvarchar(20),
BirthDay Date,

)
ALTER TABLE StudentEduAzINform
ADD  BirthDay nvarchar

INSERT INTO StudentEduAzINform values('Sahin','sdf','qwerty','2000-2-3')