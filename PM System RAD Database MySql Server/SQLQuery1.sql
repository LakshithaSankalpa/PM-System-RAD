CREATE TABLE CompanyTB(
	CompID varchar(50) not null Primary key,
	CompName varchar(50),
	CompPhone varchar(50),
	CompAddress varchar(max)
)

select * from CompanyTB

insert into CompanyTB values('CC1001', 'AllerinePVT(Ltd)','+94113568649','No.25,Galle Rd, Colombo02')

CREATE TABLE MedicineTB(
	MediName varchar(50) not null Primary key,
	BPrice float,
	SPrice float,
	MedQty int,
	ExpDate varchar(50),
	Company varchar(50)
)

select * from MedicineTB

CREATE TABLE EmployeeTB(
	EmpID varchar(50) not null Primary key, 
	EmpName varchar(50),
	EmpSal float,
	EmpAge float,
	EmpPhone varchar(50),
	EmpPassword varchar(50)
)

select * from EmployeeTB

CREATE TABLE BillsTB(
	BillID int not null Primary key,
	SellarName varchar(50),
	TotalAmount int
)

select * from BillsTB