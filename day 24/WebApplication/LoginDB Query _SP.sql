Create table Emp_Login(id int IDENTITY (1,1) NOT NULL , userName varchar(50),Password varchar(50))

Insert into Emp_Login (userName,Password) values ('Admin','Admin123')

 select * from Emp_Login
Create  procedure Emplogin
(
@Usename Varchar (20),
@Password varchar (10)
)
as
Begin
Select COUNT(*)from Emp_Login where username=@Usename and Password=@Password
End