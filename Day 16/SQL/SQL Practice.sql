---LEN() string functions as shown below.--
Select SUBSTRING('John@bbb.com',
(
CHARINDEX('@','John@bbb.com')+1),
(LEN ('John@bbb.com') -  CHARINDEX('@','John@bbb.com')))
----Output : bbb.com--

Select SUBSTRING('John@bbb.com',6,7)
----Output : bbb.com--

Select ABS(-101.5)-----REMOVES - SIGN--

Select CEILING(15.2)-------Returns 16-----
Select CEILING(-15.2)------Returns -15----

Select FLOOR(15.2)--------Returns 15--
Select FLOOR(-15.2)--------Returns -16--

-------Power(expression,power)---------
--------Returns the power value of the number--
Select POWER(2,3)---------Returns 8---

------RAND([Seed_Value])
---Returns a random float number between 0 and 1.
---Rand() function takes an optional seed parameter.when value is supplied the

--Rand() function always return the same value
Select RAND(1)------ Always return the Same VALUE---
---eVERY time you execute this query , you get a random number between 1 and 100

Select FLOOR(RAND()*100)---VARIABLE VALUE
--The following query prints 10 random numbers between 1 and 100.
Declare @Counter INT
Set @Counter =1 
While(@Counter<=10)
Begin
Print FLOOR(RAND()*100)
Set @Counter=@Counter+1
End

Select SQUARE(9)---------Returns 81-

Select SQRT(81)---------Returns 9--


---ROUND(numeric_expresssion)-

Select ROUND(850.556,2)---Returns 850.550--

-----Truncate anything after 2 places , after(to the right) the decimal-
Select ROUND(850.556,2,1)----Returns 850.550

Select ROUND(850.556,1)----returns 850.600---

Select ROUND(850.556,1,1)


Select ROUND(850.556,2)----Returns 850.560


Select EmployeeId,LastName,BirthDate,Convert(nvarchar,BirthDate) as ConvertedDOB from Employees

Select EmployeeId,LastName,BirthDate,Convert(nvarchar,BirthDate,105) as ConvertedDOB from Employees

CREATE FUNCTION Age(@DOB Date)
RETURNS INT
AS 
BEGIN
 DECLARE @Age INT
 SET @Age = DATEDIFF(YEAR,@DOB,GETDATE())
 - CASE WHEN (MONTH(@DOB)>MONTH(GETDATE())) OR (MONTH(@DOB)=MONTH(GETDATE())
 AND DAY(@DOB) > DAY(GETDATE()))
 THEN 1
 ELSE 0
 END
 RETURN @Age
 END
 Select AllSampleCode.dbo.Age('10/08/1982')
 Select dbo.Age('10/08/1972')
