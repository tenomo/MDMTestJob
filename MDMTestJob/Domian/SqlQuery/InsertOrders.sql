
INSERT INTO Orders
					(
					    CustomerId, 
					    Number,
						Amount,
					    DueTime,
						ProcessedTime,
						Description 
					)
VALUES
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Matthew Kramer'),
			'2j-3g-4',
			100,
			2007-05-08, 
			2012-05-08,
			'testing description for entry  name "Matthew Kramer"'
		),	
	 
		(		
			(SELECT CustomerId FROM Customers WHERE Name = 'Sid Harup'),
			'2j-3g-4',
			100,
			2014-06-25, 
			2014-06-25,
			'testing description for entry  name "Sid Harup"'
		),
 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Matthew Kramer'),
			'2j-3g-4',
			100,
			2007-05-08, 
			2007-05-08,
			'testing description for entry  name "Matthew Kramer"'
		),
	 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Sid Harup'),
			'2j-3g-4',
			100,
			2007-05-08, 
			2007-05-08,
			'testing description for entry  name "Sid Harup"'
		),
		 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Pete Ramirez'),
			'2j-3g-4',
			100,
		2007-05-08, 
			2007-05-08,
			'testing description for entry  name "Pete Ramirez"'
		),
	 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Matthew Kramer'),
			'2j-3g-4',
			100,
			2007-05-08, 
			2007-05-08,
			'testing description for entry  name "Matthew Kramer"'
		),
	 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Carl Borden'),
			'2j-3g-4',
			100,
			2007-05-08, 
			2007-05-08,
			'testing description for entry  name "Carl Borden"'
		),
	 
	 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Matthew Kramer'),
			'2j-3g-4',
			100,
			2007-05-08, 
			2007-05-08,
			'testing description for entry  name "Matthew Kramer"'
		),
 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Erik Wongvorakul'),
			'2j-3g-4',
			100,
			2007-05-08, 
			2007-05-08,
			'testing description for entry  name "Erik Wongvorakul"'
		),
 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Matthew Kramer'),
			'2j-3g-4',
			100,
			2007-05-08, 
			2007-05-08,
			'testing description for entry  name "Matthew Kramer"'
		)

 