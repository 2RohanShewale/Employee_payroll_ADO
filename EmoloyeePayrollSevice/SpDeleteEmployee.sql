CREATE PROCEDURE SpDeleteEmployee
(
	@Name VARCHAR(25)
)
AS BEGIN
DELETE FROM Employees_Table WHERE Name = @Name;
end