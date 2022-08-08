Select SUBSTRING('mohdidris@gmail.com',10,4)

Select SUBSTRING('mohdidris@gl.com',CharIndex('@','mohdidris@gl.com')+1,3)

Select SUBSTRING('mohdidris@gl.com',CharIndex('@','mohdidris@gl.com')+1,LEN('mohdidris@gl.com') - CharIndex('@','mohdidris@gl.com'))

Select Replicate('Idris ',3)

Select * from tblEmployee

Select Name, Replace(Name,'Terry','hungry') As ConvertedName from tblEmployee

Select Id,Name,STUFF(Name,2,3,'*******') as StuffName from tblEmployee