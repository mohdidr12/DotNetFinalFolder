
----------Create table Emp_Ass--------------
----------Make Emp_id As Primary Key----------
Create table Emp_Ass(Emp_id int Primary key,FullName varchar(20),Manager_id varchar(20),DateOfJoining date,City varchar(10))

----------Create table Emp_Sal------------------------
----Make Emp_id as Foreign Key refernce from Emp_Ass--------------
Create table Emp_Sal(Emp_id int , Project varchar(10),Salary int , variable int ,CONSTRAINT FK_Emp FOREIGN KEY (Emp_id) REFERENCES Emp_Ass(Emp_id)




----------Insert values in Emp_Ass---------
Insert into Emp_Ass values(121,'Laskshmi Kumar',321,'01/31/2001','Hyderabad')
Insert into Emp_Ass values(321,'Damodaran',986,'01/30/2002','Chennai')
Insert into Emp_Ass values(421,'Priyadarshini',876,'2003/11/27','Bangalore')
Insert into Emp_Ass values(521,'Mahesh',768,'2004/09/08','Mumbai')
Insert into Emp_Ass values(621,'Mrinalini',456,'2005/10/09','Thrivanthapuram')
Insert into Emp_Ass values(721,'Yuvraj',654,'2006/08/06','Bhopal')
Insert into Emp_Ass values(821,'Shruthi',546,'2007/05/05','Chandigarh')
Insert into Emp_Ass values(921,'Nandini',256,'2008/06/09','Shimla')
Insert into Emp_Ass values(221,'Santhya',345,'2009/11/07','Shillong')
Insert into Emp_Ass values(121,'Laskshmi Kumar',321,'01/31/2001','Hyderabad')

Select * from Emp_Ass

-------Insert Values in Emp_Sal-----------------
Insert into Emp_Sal values(121,'P1',15000,500)
Insert into Emp_Sal values(321,'P2',10000,1000)
Insert into Emp_Sal values(421,'P1',12000,0)
Insert into Emp_Sal values(521,'P2',9000,600)
Insert into Emp_Sal values(621,'Null',11000,0)
Insert into Emp_Sal values(721,'P1',9000,850)
Insert into Emp_Sal values(821,'P2',14000,478)
Insert into Emp_Sal values(921,'P1',13000,0)
Insert into Emp_Sal values(221,'P2',9000,586)
Insert into Emp_Sal values(122,'Null',7000,750)

Select * from Emp_Sal

---------Query 1----------------------

select * from(
select Emp_id,Salary, dense_rank() 
over(order by sal desc)r from Emp_Sal) 
where r=&n;

----To find to the 2nd highest sal we  = 2--
----------To find 3rd highest sal set n = 3 and so on.
---check for n=2---
select * from(
select Emp_id,Salary, dense_rank() 
over(order by sal desc)r from Emp_Sal) 
where r=&2;

--------------------------------------------------------------------------------------------------------

-------------Query 2 PROJECT Available for Employees------------------------------

Select  Emp_Ass.Emp_id ,Emp_Ass.FullName,Project from Emp_Ass JOIN Emp_Sal ON Emp_Ass.Emp_id=Emp_Sal.Emp_id

---------------Query 3----------------------

Select  Emp_id ,Salary from Emp_Sal where Salary BETWEEN 9000 and 15000

------------Query 4-----------------------------------

Select Count(*) from Emp_Sal where Project='P1'

-------Output = 4--

---------Query 5----------------
Select Max(Salary)AS MAX,Min(Salary) As MIN ,AVG(Salary) As AVG from Emp_Sal 

----------Query 6------------------

Select Emp_id,FullName,City,Manager_id from Emp_Ass where City='Hyderabad' AND Manager_id=321

-------------Query 7-------------------

Select Concat(Emp_id,'---',Manager_id) As EmpId_Manager_Id from Emp_Ass

------------Query 8---------------------

Select Emp_id,Project from Emp_Sal where Project='Null'

----------Query 9-----------------------
Select Emp_Ass.Emp_Id,Emp_Ass.FullName,Emp_Ass.Manager_id,Emp_Ass.DateOfJoining,Emp_Ass.City from Emp_Ass LEFT JOIN Emp_Sal ON Emp_Ass.Emp_id=Emp_Sal.Emp_id AND Salary!=0

---------Query 10-----------------------
Select  Emp_Sal.Emp_id ,Manager_Id from Emp_Ass JOIN Emp_Sal ON Emp_Ass.Emp_id=Emp_Sal.Emp_id
