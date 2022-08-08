
  Create Table dept1(
  deptNo int not null,
  Dname varchar(20) Null,
  Loc varchar(10) Null)

  
  Select * from dept1
  Select * from AEmployee where Dept_no=(Select Dept_no from dept1 where Dname='ABC')
  Select * from AEmployee dept1 where Dept_no in (Select Dept_no from AEmployee where job='Analyst')
  Select * from AEmployee where Dept_no in ( select Dept_no from dept1 where Dname in ('ABC','XYZ')) order by Dept_no
  Select * from dept1 where deptNo in (select deptno from AEmployee where job='Salesman')
  Select *from AEmployee
  where Dept_no in (select deptno from dept1 where loc like '%0%')