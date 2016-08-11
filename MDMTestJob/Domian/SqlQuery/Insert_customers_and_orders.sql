INSERT INTO Customers 
					(
					    Name, 
					    Address,
					    PhoneNum 
					)
					 
VALUES
	(
		'Matthew Kramer',
		'1486 West Street Terr Yonkers',
		'(615)123-4568' 
	),

	(
		'Sid Harup',
		' 1159 Willow st Palm Desert',
		'(615)123-3405' 
	),
	(
		'Carl Borden',
		'1923 Pleasant View Dr Kelseyville',
		'(615)771-3435' 
	),
	(
		'Carl Thumer',
		'1474 Midland St Alton',
		'(615)151-3805' 
	),
	(
		'Erik Wongvorakul',
		' 272 Buncaneer Dr Orlando',
		'(615)151-3805' 
	),
	(
		'Elvin Hall',
		' 1661 Carriage Ln. Emporia',
		'(615)151-3805' 
	),
	(
		'Gabriel Carr ',
		'1071 Veslo st Antelope',
		'(615)151-3805' 
	),
	(
		'Pete Ramirez',
		'1253 Stillwell Rd Milwaukee',
		'(615)151-3805' 
	)



INSERT INTO Orders
					(
					    CustomerId, 
					    Number,
						Amount,
					    DueTime,
						Description 
					)
VALUES
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Matthew Kramer'),
			'2j-3g-4',
			100,
			'2012-06-18T10:34:09', 
			'testing description for entry  name "Matthew Kramer"'
		),	
	 
		(		
			(SELECT CustomerId FROM Customers WHERE Name = 'Sid Harup'),
			'2j-3g-4',
			100,
			'2012-06-18T10:34:09', 
			'testing description for entry  name "Sid Harup"'
		),
 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Matthew Kramer'),
			'2j-3g-4',
			100,
			'2012-06-18T10:34:09', 
			'testing description for entry  name "Matthew Kramer"'
		),
	 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Sid Harup'),
			'2j-3g-4',
			100,
			'2012-06-18T10:34:09', 
			'testing description for entry  name "Sid Harup"'
		),
		 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Pete Ramirez'),
			'2j-3g-4',
			100,
			'2012-06-18T10:34:09', 
			'testing description for entry  name "Pete Ramirez"'
		),
	 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Matthew Kramer'),
			'2j-3g-4',
			100,
			'2012-06-18T10:34:09', 
			'testing description for entry  name "Matthew Kramer"'
		),
	 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Carl Borden'),
			'2j-3g-4',
			100,
			'2012-06-18T10:34:09', 
			'testing description for entry  name "Carl Borden"'
		),
	 
	 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Matthew Kramer'),
			'2j-3g-4',
			100,
			'2012-06-18T10:34:09', 
			'testing description for entry  name "Matthew Kramer"'
		),
 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Erik Wongvorakul'),
			'2j-3g-4',
			100,
			'2012-06-18T10:34:09', 
			'testing description for entry  name "Erik Wongvorakul"'
		),
 
		(
			(SELECT CustomerId FROM Customers WHERE Name = 'Matthew Kramer'),
			'2j-3g-4',
			100,
			'2012-06-18T10:34:09', 
			'testing description for entry  name "Matthew Kramer"'
		)

 