--List the departments names that are having atleast 1 employee in it-------
select departmentName from tb1Department where ID in (Select ID from tblEmployee group by ID having Count(*)>0)

---list the department names that are having atleast 4 employee in it-------

select departmentName from tb1Department where ID in (Select ID from tblEmployee group by ID having Count(*)>=4)

---list the department names which are having atleast 2 clerks  in it----
select departmentName from tb1Department where ID in (Select ID from tblEmployee group by ID having Count('Clerk')=2)

---Display the 2nd Maximum Salary-------------
Select max(salary) from tblEmployee where salary<(Select max(Salary)  from tblEmployee)

--Display the 3rd Maximum Salary-------------
Select max(salary) from tblEmployee where salary<(Select max(Salary)  from tblEmployee where salary<(Select max(Salary) from tblEmployee))
----------Display the 4th Maximum Salary-------------

Select min(salary) from tblEmployee where salary>(Select max(Salary)  from tblEmployee where salary>(Select max(Salary) from tblEmployee where Salary > (Select min(salary) from tblEmployee)))

---list the department names that are having no Employees in it----
Select * from tb1Department where ID Not in(Select ID from tblEmployee)
/*
------Create functions in SQL Server-----------
CREATE FUNCTION [schema_name.]function_name (parameter_list)
RETURNS data_type AS
BEGIN
    statements
    RETURN value
END
*/
----Demo of function-----------------------
create function fnGetEmpFullName
(
@firstName varchar(20),
@lastName varchar(20)
)
returns varchar(41)
As
Begin return (Select @firstName +' '+@lastName);
end

Select * from Emp_fnTable

insert into Emp_fnTable Values(1,'mohd','idris')

insert into Emp_fnTable Values(2,'rizu','baba')

insert into Emp_fnTable Values(3,'mis','shren')


---------calling the above created function----
Select dbo.fnGetEmpFullName(firstName,lastName) as Name from Emp_fnTable





