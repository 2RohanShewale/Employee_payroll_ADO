CREATE PROCEDURE SpDeleteEmployee
(
	@Name VARCHAR(25)
)
AS BEGIN
DELETE FROM Employees_Table WHERE Name = @Name;
end

CREATE PROCEDURE SpUpdateEmployee
(
	@Name VARCHAR(25),
	@Address VARCHAR(50)
)
AS BEGIN
UPDATE Employees_Table SET Address = @Address WHERE Name = @Name;
END