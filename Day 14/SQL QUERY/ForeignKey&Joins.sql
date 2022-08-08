Create table tbDepartment
  (
    ID int primary key,
	DepartmentName nvarchar(50),
	Location nvarchar(50),
	DepartmentHead nvarchar(50)
	)

	Go
	Insert into tbDepartment values(1,'IT','London','Ram')
	Insert into tbDepartment values(2,'Finance','US','Pam')
	Insert into tbDepartment values(3,'HR','New York','Christio')
    Insert into tbDepartment values(4,'Other','London','Sydnay')
	Go
Create table tblEmployee
	(
	 ID int primary key,
	 Name nvarchar (50),
	 Gender Nvarchar(50),
	 salary int,
	 DepartmentID int foreign key references tbDepartment(ID)
	 )
	 GO
	 Insert into tblEmployee values(1, 'Terry','Male',4000,1)
	 Insert into tblEmployee values(2,'Pam','Female',3000,1)
	 Insert into tblEmployee values(3,'Johnny','Male',3500,1)
	 Insert into tblEmployee values(4,'Sammy','male',4500,3)
	 Insert into tblEmployee values(5,'Toddy','male',2800,1)
	 Insert into tblEmployee values(6,'Beny','male',7000,2)
	 Insert into tblEmployee values(7,'Sara','Female',3000,1)
	 Insert into tblEmployee values(8,'Vikas','Female',5500,3)
	 Insert into tblEmployee values(9,'Jakie','male',3000,NULL)
	 Insert into tblEmployee values(10,'Rohan','male',8800,NULL)
	 GO

	 Select * from tbDepartment ;
     Select * from tblEmployee;

	  ---Right join
  Select Name, Gender,salary,DepartmentName from tblEmployee
  right join tbDepartment
  ON tblEmployee.ID=tbDepartment.ID

 -- How to retrieve only the non matching rows from the left table.
  Select Name, Gender, salary, DepartmentName from tblEmployee E
  left Join tbDepartment D
  ON E.ID=D.ID 
  Where D.ID is NULL
  ----How to reterieve only the non matching rows from the right table
  Select Name, Gender,Salary,DepartmentName
  From tblEmployee E
  Right Join tbDepartment D
  ON E.DepartmentID=D.ID
  Where E.DepartmentID=NULL

  SELECT Name, Gender, Salary, DepartmentName
  From tblEmployee E
  Left Join tbDepartment D
  ON E.DepartmentID=D.ID
  where D.ID is NULL