Create table dept
( ID int Primary Key identity(1,1),
DepartMentName nvarchar(50) not null
)
Alter table temployee add Constraint emp_Depart_FK
Foreign Key (emp_no) references dept(ID)[salary]
