-------------------Inserting values in Project_table--------------------
Insert into Project_Table values(1,'Apple Sum','technical','Amit Goyal')
Insert into Project_Table values(2,'TATA Motor','Automotive','Riya Ahuja')
Insert into Project_Table values(3,'Ambuja','Construction','Ayush')
Insert into Project_Table values(4,'Jet Airways','Aerospace','Varsha')
Insert into Project_Table values(5,'Mahindra Clothes','manufacturing','Shahid')

Select * from Project_Table

Select * from Emp1_Table

----------------Insering values in Emp1 Table----------------------

Insert into Emp1_Table values(05,1,'kishan','.net',4)
Insert into Emp1_Table values(02,1,'Aditya','java',5)
Insert into Emp1_Table values(03,1,'fardeen','sql',6)
Insert into Emp1_Table values(04,1,'idris','JS',3)

Insert into Emp1_Table values(06,2,'tushar','Azure',2)
Insert into Emp1_Table values(07,2,'makki','Salesforce',4)
Insert into Emp1_Table values(08,2,'Amir','Apache',4)

Insert into Emp1_Table values(09,4,'bilal','Python',2)
Insert into Emp1_Table values(10,4,'Ayesha','React',4)

Insert into Emp1_Table values(11,5,'punit','JS',2)
Insert into Emp1_Table values(12,5,'arjit','Salesforce',4)
Insert into Emp1_Table values(13,5,'Aman','Node',4)
Insert into Emp1_Table values(14,5,'Akhtar','React',2)
Insert into Emp1_Table values(15,5,'Arzuu','MongoDB',4)

Insert into Emp1_Table values(16,3,'yukta','AutoCad',6)

-------------Group By----------------------------

Select Count(*) from Emp1_Table Group By P_id 

Select * from Emp1_Table

Select Count(Emp_id) from Emp1_Table Group By P_id

-----------------------having group by----------------

Select Count(Emp_id),P_id from Emp1_Table Group by P_id having Count(Emp_id)>2

--------------------iNNER Joins-------------------------

Select * from Project_Table join Emp1_Table  ON  Project_Table.P_id=Emp1_Table.P_id

-------------------Left Join------------------------------

Select * from Project_Table left join Emp1_Table  ON  Project_Table.P_id=Emp1_Table.P_id

---------------------Right Join----------------------------

Select * from Project_Table right join Emp1_Table  ON  Project_Table.P_id=Emp1_Table.P_id

