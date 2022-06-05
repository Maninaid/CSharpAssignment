create database EmployeeManagementDB

use EmployeeManagementDB

create table Code_Employee (empno int primary key,
empname varchar(50) not null,
empsal numeric(10,2) check(empsal >= 25000),
emptype varchar(1) check(emptype in('C','P')))

insert into Code_Employee values
(1001,'Manikanta',30000,'C'),
(1002,'Vinodh', 32000,'P'),
(1003,'Bangaram',40000,'C')

select * from Code_Employee

create or alter procedure empinsert ( @empname varchar(50), @empsal numeric(10,2), @emptype varchar(1))
as
 begin 
  declare @eid int = (select max(empno) from Code_Employee)
  if(@eid is null)
  begin
    set @eid = 0;
    declare @empid int = @eid + 1;
    insert into Code_Employee values(@empid, @empname, @empsal, @emptype)
  end
  else
  begin
   declare @empid1 int = @eid + 1;
   insert into Code_Employee values(@empid1, @empname, @empsal, @emptype)
  end
end

