create table Employee_Test
(
 Emp_ID int identity,
 Emp_Name varchar(55),
 Emp_Technology varchar(55),
 Emp_Sal decimal (10,2),
 Emp_Designation varchar(20)
 )
 --To view detailed information of the columns of table Employee_test
 Select * from INFORMATION_SCHEMA.COLUMNS
 where TABLE_NAME='Employee_Test'

 Select * from sys.tables
 --To see all SQL Server connections
 SELECT connection_id,session_id,client_net,address,auth_scheme
 FROM sys.dm_exec_connections

 --Now Insert data to table Employee_Test
 Insert into Employee_Test values('Amit','PHP',12000,'SE');
 Insert into Employee_Test values('Mohan','ASP.NET',15000,'TL');
  Insert into Employee_Test values('Rohan','JAVA',14000,'SSE');
   Insert into Employee_Test values('Umar','C#',22000,'SE');
    Insert into Employee_Test values('Riyaz','VB',18000,'TH');

------------nOW CREATE view on single tble Employee_test
create VIEW vw_Employee_Test
AS
Select Emp_ID , Emp_Name,Emp_Designation from Employee_Test

----Query view like as table
Select * from vw_Employee_Test

---In the simple view we can insert , update ,delete data.
--We can only insert data in a simple view
---If we have a primary key and all not null fields in the view.
---Insert data to view vw_Employee_Test
insert into vw_Employee_Test(Emp_Name,Emp_Designation) values('Shailu','SSE')
--nOW SEE THE AFFECTED VIEW
Select * from vw_Employee_Test
Select * from Employee_Test
------Update data to view vw_Employee_Test
Update vw_Employee_Test set Emp_Name='Pawan' where Emp_ID=6
----Now see the affected view
Select * from vw_Employee_Test

---Delete data from view vw_Employeee_Test
delete from vw_Employee_Test where Emp_ID=6
-----Now see the affected view
Select * from vw_Employee_Test

-------------------------------------------------------------------------------------

CREATE TABLE Department3
(
 DeptID int PRIMARY KEY, 
 DeptName varchar(50) NULL,
 Location varchar(100) NULL,
 )
GO
 CREATE TABLE Employees
(
 EmpID int PRIMARY KEY, 
 Name varchar(50) NULL,
 Salary int NULL, 
 Address varchar(100) NULL,
 DeptID int foreign Key references Department3(DeptID)
) 
--Now Insert data
INSERT INTO Department3(DeptID,DeptName,Location)VALUES(3,'IT','Kolkata')
GO
INSERT INTO Employees(EmpID,Name,Salary,Address,DeptID)VALUES(3,'rajesh',15000,'Mumbai',3)

 IF @@TRANCOUNT > 0
 BEGIN COMMIT TRANSACTION trans
 END
END TRY
BEGIN CATCH
 print 'Error Occured'
 IF @@TRANCOUNT > 0
 BEGIN ROLLBACK TRANSACTION trans
 END
END CATCH

---Now Select data to see transaction effects
SELECT * from Employees
Select * from Department3

--Transaction with Save Point BEGIN TRANSACTION trans
BEGIN TRY
 INSERT INTO Department3(DeptID,DeptName,Location)Values(2,'HR','Delhi')
 IF @@TRANCOUNT>0
  BEGIN SAVE TRANSACTION trans;
   END
   INSERT INTO Department3(DeptID,DeptName,Location)VALUES(3,'Admin','Delhi')
   INSERT INTO Employees(EmpID,Name,Salary,Address,DeptID)VALUES(1,'Mohan',18000,'Delhi',2)
   IF @@TRANCOUNT>0
    BEGIN COMMIT TRANSACTION trans
	 END
	END TRY
	BEGIN CATCH
	 print 'Error Occured'
	IF @@TRANCOUNT>0
	 BEGIN ROLLBACK TRANSACTION trans
	 END