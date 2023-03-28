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

CREATE PROCEDURE SpGetAllData
As BEGIN

SELECT * FROM Employees_Table

END

CREATE TABLE [dbo].[Employees_Table] (
    [Name]        VARCHAR (20)  NULL,
    [BasicPay]    FLOAT        NULL,
    [StartDate]   DATETIME      NULL,
    [Gender]      VARCHAR (1)   NULL,
    [Address]     VARCHAR (100) NULL,
    [PhoneNumber] BIGINT        NULL,
    [Department]  VARCHAR (25)  NULL,
    [Deduction]	   FLOAT      NULL,
    [TaxablePay]  FLOAT       NULL,
    [IncomeTax]   FLOAT        NULL,
    [NetPay]      FLOAT        NULL
);