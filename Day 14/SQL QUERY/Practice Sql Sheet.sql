create table Student1(Id int PRIMARY KEY
                     ,Name varchar(10) not null,
					  salary DECIMAL(6,2));

INSERT into Student1 values(1,'idris',4000.89);
INSERT into Student1 values(2,'imran',4000.89);
INSERT into Student1 values(3,'iris',4000.89);
INSERT into Student1 values(4,'ilkris',4000.89);
INSERT into Student1 values(5,'dhjis',4000.89);
INSERT into Student1 values(6,'uijdris',4000.89);
INSERT into Student1 values(7,'ikkris',4000.89);

Select * from Student1 where Name like 'i%'

  -----------------------------------------------------------------------------

Select distinct Name from Student1 ORDER BY Name DESC

UPDATE Student1 Set Name='Ayan',salary=789.90 where Id=2

Delete Student1 

Insert into Student1 values(1,'Ireuy',899.90)

Select * from Student1

--------------------------------------------------------------------------------------
-------------Joins practice----------

Insert into Student_Demo values(3,'Mohd shan','Ang')
Insert into Student_Demo values(4,'Mohd rizw','React')
Insert into Student_Demo values(5,'Mohd rais','Expre')
Insert into Student_Demo values(6,'Mohd faiz','Node')


Select * from Student_Demo

Insert into Course_Demo values(3,'Angular',6,01)
Insert into Course_Demo values(2,'java',8,02)
Insert into Course_Demo values(1,'Dot Net',9,03)
Insert into Course_Demo values(4,'React',12,04)
Insert into Course_Demo values(5,'Express',4,05)

Select * from Student_Demo right Join Course_Demo ON Student_Demo.S_id = Course_Demo.S_id


