------------Inline function-----------
Create function fnGetInlineEmployee()
returns Table
As
 return (Select * from Emp_fnTable)

 Select * from fnGetInlineEmployee()

 Create function fnGetMultiEmployee()
 returns @Emp Table
 (
 EMP_id int,
 LastName varchar(50),
 SAL int
 )
 As
 begin
 Insert into @Emp Select e.Emp_id,e.LastName,e.SAL from Emp_fnTable e;
 ---Now updae salary of first employee-----
 update @Emp set SAL=25000 where EMP_ID=1;
 --it will update only in @Emp table not in Original Employee table
 return
 end

 Select * from fnGetMultiEmployee()

 ----Tasks create an inline function for Customers ----------------
 Create function fnGetInlineCustomers()
returns Table
As
 return (Select * from Customers)

 Select * from fnGetInlineCustomers()

 ----Create multiAttribute Function--------
 --------Company Name,City,Postal Code-----------
 Create function fnGetMultiCustomers()
 returns @Cust Table
 (
 CompanyName varchar(40),
 City varchar(15),
 PostalCode nvarchar(10)
 )
 As
 begin
 Insert into @Cust Select e.CompanyName,e.City,e.PostalCode from Customers e;
 ---Now updae salary of first employee-----
 update @Cust set PostalCode=302004 where CompanyName='Around the Horn';
  return
 end

 Select * from fnGetMultiCustomers()

 CREATE TABLE [dbo].[tb2Employees]
 (
 [Id][int] Primary Key,
 [Name] [varchar](50) NULL,
 [DateOfBirth][datetime] NULL,
 [DepartmentId] [int] NULL
 )

 Insert into tb2Employees values(1,'Sam','1980-12-30 00:00:00.000','Male',1)
 Insert into tb2Employees values(2,'Pam','1982-09-01 12:02:36.260','Female',2)

 Select Name,DateOfBirth , dbo.Age(DateOfBirth) as Age
 from tb2Employees
 where dbo.Age(DateOfBirth) > 40


 -------Exceptions in SQL----------

 BEGIN TRY
 DECLARE @num INT
 -----Divide by zero to generate error
 SET @num=5/0
 PRINT 'This will not execute'
 END TRY
 BEGIN CATCH
 SELECT ERROR_NUMBER() As ErrorNumber , Error_SEVERITY() as ErrorSeverity,
        ERROR_STATE() AS ErrorState,ERROR_PROCEDURE() As ErrorProcedure,
		ERROR_LINE() As ErroeLine , ERROR_MESSAGE() As ErrorMessage;
 END CATCH;

 GO
 select * from master.dbo.sysmessages
  select * from master.dbo.sysmessages
  where severity=16 and error=8134

  -----------Stored Procedures in sql server-------

  Create Procedure spGetEmployees
  As
  Begin
  Select Name,Gender from tb1Employee
  End

  spGetEmployees

  -----with parameters-----------
  Create Proc spGetEmployeesByGenderAdDepartment
  @Gender nvarchar(20),
  @DepartmentId int
  As
  Begin
  Select Name,Gender,@DepartmentId from tb1Employee
              where Gender=@Gender and @DepartmentId=@DepartmentId
 End
 spGetEmployeesByGenderAdDepartment @Gender='male',@DepartmentId=1
 exec spGetEmployeesByGenderAdDepartment @Gender='Female',@DepartmentId=3
 sp_helptext spGetEmployeesByGenderAdDepartment

 ---------------------------------------------------------------------------------------
 create proc spGetEmployeeCountByGender
 @gender nvarchar(20),
 @EmployeeCount int output
 As
 Begin
 Select @EmployeeCount = Count(Id) from tb1Employee where Gender = @Gender
 End
 spGetEmployeeCountByGender

 --Excecute output stoed procedure
 Declare @EmployeeTotal int
 execute spGetEmployeeCountByGender 'Female',@EmployeeTotal output
 Print @EmployeeTotal
