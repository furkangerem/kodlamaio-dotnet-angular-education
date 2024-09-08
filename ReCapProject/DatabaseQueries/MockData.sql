INSERT INTO Brand (BrandName)
VALUES 
('Toyota'),
('BMW'),
('Mercedes'),
('Ford'),
('Honda');

INSERT INTO Color (ColorName)
VALUES 
('Red'),
('Blue'),
('Black'),
('White'),
('Silver');

INSERT INTO Car (BrandId, ColorId, ModelYear, DailyPrice, Description)
VALUES 
(1, 1, 2021, 120.50, 'Compact car, fuel efficient'),
(2, 3, 2020, 150.75, 'Luxury sedan, premium features'),
(3, 2, 2019, 180.00, 'SUV with great off-road capability'),
(4, 4, 2022, 100.00, 'Reliable and affordable hatchback'),
(5, 5, 2018, 90.50, 'Older model but still performs well'),
(1, 2, 2023, 200.00, 'Brand new electric model'),
(2, 1, 2020, 140.00, 'Sporty coupe, fast acceleration'),
(3, 5, 2017, 160.00, 'Well-maintained older SUV'),
(4, 3, 2021, 110.75, 'Family sedan, spacious interior'),
(5, 4, 2022, 130.50, 'New compact car, easy to park');
