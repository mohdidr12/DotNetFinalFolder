create table Student_2(Id int ,Name varchar(20),Address varchar(50),phone varchar(10))

insert into Student_2 values(1,'fardeen','Amer jaipur','5678997867')
insert into Student_2 values(1,'fardeen','Amer jaipur','9998988988')
insert into Student_2 values(2,'Mannu','Bhakrota jaipur','8989900008')
insert into Student_2 values(2,'Mannu','Bhakrota jaipur','9098989799')

Select * from Student_2
---------------------------breaks the table to achive 3 NF--------------------------
create table Student_3(Id int primary key, Name varchar(10),Address varchar(50))
create table Student_4(Id int , phone varchar(10))

insert into Student_3 values(1,'fardeen','Amer jaipur')
insert into Student_3 values(2,'Mannu','Bhakrota jaipur')

Insert into Student_4 values(1,'5678997867')
Insert into Student_4 values(1,'9998988988')
Insert into Student_4 values(2,'8989900008')
Insert into Student_4 values(2,'9098989799')

Select * from Student_3

Select * from Student_4





