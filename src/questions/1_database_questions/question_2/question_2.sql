-- 1) Drop and re-create the "Employee" table
DROP TABLE IF EXISTS Employee;

CREATE TABLE IF NOT EXISTS Employee (
    employeeId UUID NOT NULL,
    firstName VARCHAR(255),
    lastName VARCHAR(255),
    gender VARCHAR(50),
    email VARCHAR(255),
    age INT,
    birthday DATE,
    active BOOLEAN,
    street VARCHAR(255),
    postalCode VARCHAR(20),
    province VARCHAR(50),
    city VARCHAR(255),
    longitude NUMERIC,
    latitude NUMERIC,
    package VARCHAR(255),
    vendor VARCHAR(255),
    phone VARCHAR(50),
    packageCost VARCHAR(50),
    contractStart DATE,
    contractEnd DATE
);

-- Step 2: Load data from CSV
COPY Employee(employeeId, firstName, lastName, gender, email, age, birthday, active,
             street, postalCode, province, city, longitude, latitude, 
             package, vendor, phone, packageCost, contractStart, contractEnd)
FROM '/tmp/Employee_File.csv'
DELIMITER ',' CSV HEADER;


-- 3) Update statement to replace the email host with "company"
-- Begin transaction for safety
BEGIN;

-- ROLLBACK -- Uncomment this line to roll back changes if needed

-- Update all employee email addresses to use "company" as the host
-- while preserving the username and domain extension
UPDATE Employee
SET email = 
    -- Extract username (part before @)
    SPLIT_PART(email, '@', 1) || '@' ||
    -- Add new company domain
    'company.' ||
    -- Extract domain extension (part after the last dot)
    SUBSTRING(
        email 
        FROM POSITION('.' IN SUBSTRING(email FROM POSITION('@' IN email))) + POSITION('@' IN email)
        FOR LENGTH(email)
    )
WHERE 
    -- Only process rows with valid email addresses
    email IS NOT NULL 
    AND POSITION('@' IN email) > 0
    AND POSITION('.' IN SUBSTRING(email FROM POSITION('@' IN email))) > 0;

-- Verify changes before committing
-- SELECT email FROM Employee LIMIT 10;
-------------------------
-- mome@company.na
-- le@company.fo
-- curgosac@company.im
-- zewicibe@company.vg
-- mekisu@company.ws
-- cokafeil@company.as
-- pim@company.tp
-- zo@company.dj
-- piric@company.zm
-- zogrefgig@company.co.za

COMMIT;