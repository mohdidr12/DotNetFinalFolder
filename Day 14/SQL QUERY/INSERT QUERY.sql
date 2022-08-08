Create table AEmployee
(
  Emp_No int not null,
  EName varchar(50)  null,
  Job varchar(50)  null,
  MGR int null,
  HireDate  DateTime null,
  SAL int null,
  COMM int null,
  Dept_no int null)

  --CREATE VIEW hello as
  --Select Emp_No, ENAme 
 -- from  SEmployee


  Insert into AEmployee values(01,'Sam','Software_Developer',NULL ,'2022-07-07',20000,23,20)
  Insert into AEmployee values(02,'Tim','Software_Developer',003,'2022-07-07',20000,23,31)
  Insert into AEmployee values(03,'Vaibhav','Software_Developer',001,'2022-07-07',20000,23,41)
  Insert into AEmployee values(04,'Nikki','Software_Developer',004,'2022-07-07',20000,23,35)
  Insert into AEmployee values(05,'Aditya','Software_Developer',002,'2022-07-07',20000,23,15)
  Insert into AEmployee values(06,'Aryan','Software_Developer',003,'2022-07-07',25000,23,12)
  Insert into AEmployee values(07,'Alam','Software_Developer',004,'2022-07-07',20000,23,11)
  Insert into AEmployee values(08,'Shardha','Software_Developer',002,'2022-07-07',100000,23,17)
  Insert into AEmployee values(09,'Ayushman','Software_Developer',003,'2022-07-07',20000,23,23)
  Insert into AEmployee values(10,'Vivek','Software_Developer',005,'2022-07-07',20000,23,20)
  Insert into AEmployee values(11,'Sumit','Software_Developer',005,'2022-07-07',20000,23,20)

  select *from AEmployee where EName like 'A%'