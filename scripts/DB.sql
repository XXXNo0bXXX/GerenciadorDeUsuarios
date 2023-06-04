CREATE TABLE users(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL UNIQUE,
	email VARCHAR(50) NOT NULL,
	telephone VARCHAR(19),
	age SMALLINT CHECK(age>=12 AND age<=75),
	date_of_birth DATE
);