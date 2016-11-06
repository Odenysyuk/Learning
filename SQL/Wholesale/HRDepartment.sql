 --1
 SELECT
	worker.FullName,
	worker.Age,
	worker.stat as sex,
	worker.AddressWorker,
	worker.Phone,
	worker.Passport,
	position.name as Position,
	position.Salary as Salary,
	position.Obligation as Obligation,
	position.Requirements as Requirements
INTO #HRDepartment
FROM
 Worker as worker
 INNER JOIN Position as position
 ON worker.ID_Position = position.ID_Position

 Select
 *
 FROM #HRDepartment


 DECLARE @Position AS varchar(100)
SET @Position = 'Seller'


 Select
 *
 FROM #HRDepartment
 WHERE 
 Position = @Position 

 GO

CREATE FUNCTION FilterOfDepartament(@Position CHAR(50))
RETURNS @result TABLE(FullName VARCHAR(150),Age INT,stat Sex,AddressWorker VARCHAR(100),Ph VARCHAR(10),P VARCHAR(50),N VARCHAR(100),Sal smallmoney,Obl VARCHAR(100), Req VARCHAR(100))
BEGIN
 INSERT @result 
 Select
 *
 FROM #HRDepartment
 WHERE 
 Position = @Position 
END
RETURN

 GO

 
