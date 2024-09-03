SELECT 
	PRD.ProductName,  
	SUM(ORDD.Quantity * ORDD.UnitPrice) TotalAmount 
FROM 
	Products PRD 
INNER JOIN 
	[Order Details] ORDD ON PRD.ProductID = ORDD.ProductID
INNER JOIN 
	Orders ORD ON ORD.OrderID = ORDD.OrderID
GROUP BY 
	PRD.ProductName