Create procedure SpStoreData 
(
	@Name VARCHAR(20),
	@BasicPay MONEY,
	@StartDate DATETIME,
	@Gender VARCHAR(1),
	@Address VARCHAR(100),
	@PhoneNumber BIGINT,
	@Department VARCHAR(25),
	@Deduction MONEY,
	@TaxablePay MONEY,
	@IncomeTax MONEY,
	@NetPay MONEY
)
AS BEGIN

INSERT INTO Employees_Table(Name,BasicPay,StartDate,Gender,Address,PhoneNumber,Department,Deduction,TaxablePay,IncomeTax,NetPay)
VALUES (@Name,@BasicPay,@StartDate,@Gender,@Address,@PhoneNumber,@Department,@Deduction,@TaxablePay,@IncomeTax,@NetPay)

END