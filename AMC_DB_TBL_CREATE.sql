CREATE TABLE city_mstr
(
	[city_Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [city_name] VARCHAR(MAX) NULL, 
    [status] NVARCHAR(MAX) NULL, 
    [entry_time] TIMESTAMP NULL
);

CREATE TABLE [dbo].[Table]
(
	[pincode_id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [city_id] INT NOT NULL, 
    [pincode_name] NVARCHAR(7) NULL, 
    [status] NVARCHAR(MAX) NULL, 
    [entry_date] DATETIME NULL DEFAULT getdate()
);


CREATE TABLE [dbo].[emp_mstr]
(
	[emp_id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [emp_name] NVARCHAR(MAX) NULL, 
    [address] NVARCHAR(50) NULL, 
    [phone] NCHAR(12) NULL, 
    [email] NCHAR(25) NULL, 
    [status] NVARCHAR(10) NULL, 
    [entry_date] DATETIME NULL DEFAULT getdate()
);

CREATE TABLE [dbo].[category_mstr]
(
	[category_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [category_name] NVARCHAR(MAX) NULL, 
    [status] NVARCHAR(10) NULL, 
    [entry_date] DATETIME NULL DEFAULT getdate()
);

CREATE TABLE [dbo].[product_mstr]
(
	[product_id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [category_id] INT NULL, 
    [product_name] NVARCHAR(MAX) NULL, 
    [status] NCHAR(10) NULL, 
    [entry_date] DATETIME NULL DEFAULT getdate()
);


CREATE TABLE [dbo].[complain_tbl]
(
	[complain_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [customer_id] INT NULL, 
    [comp_date] DATE NULL, 
    [comp_time] VARCHAR(MAX) NULL, 
    [comp_info] VARCHAR(100) NULL, 
    [received_by] INT NULL, 
    [allocate_to] INT NULL, 
    [comp_status] VARCHAR(MAX) NULL, 
    [remark] VARCHAR(MAX) NULL, 
    [status] NVARCHAR(10) NULL, 
    [entry_date] DATETIME NULL DEFAULT getdate()
);
