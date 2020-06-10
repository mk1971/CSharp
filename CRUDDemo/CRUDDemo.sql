--For GetAllEmployee
create procedure SP_GetAllEmployee
as 
BEGIN
	Select * From Employee
END

--For Insert
Create Procedure SP_InsertEmployee
(
	@Name varchar(150)='',
	@Gender varchar(50)='',
	@Company varchar(150)='',
	@Department varchar(150)=''
)
as
BEGIN
	Insert into Employee (Name,Gender,Company,Department)
	Values (@Name,@Gender,@Company,@Department)
END


--For Update
Create Procedure SP_UpdateEmployee
(
	@EmpId int=0,
	@Name varchar(150)='',
	@Gender varchar(50)='',
	@Company varchar(150)='',
	@Department varchar(150)=''
)
as 
BEGIN
	Update Employee Set	Name=@Name, Gender=@Gender, Company=@Company, Department=@Department Where ID=@EmpId
END

--For Delete
create procedure SP_DeleteEmployee
(
	@EmpId int
)
as
BEGIN
	Delete From Employee Where ID=@EmpId
END


--Get By EmpId
create procedure SP_GetEmployeeById
(
	@EmpId int
)
as
BEGIN
	Select * From Employee Where ID=@EmpId
END