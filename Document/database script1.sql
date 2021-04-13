create table Users(
	userId int identity(1,1) primary key,
	email varchar(255),
	username varchar(255) not null,
	mobile varchar(255),
	avater varchar(max),
	gender varchar(10),
	DOB date,
	password varchar(255) not null
);

create table [Delivery Details](
	userId int not null foreign key references Users(userId),
	recipientFullName varchar(255) not null,
	recipientPhoneNumber varchar(255) not null,
	postalCode varchar(255),
	building_street_desc varchar(255) not null,
	unitNo varchar(255) not null,
	isDefaultAddress int not null
);

create table Categories(
	categoryId int identity(1,1) primary key,
	categoryName varchar(255) not null,
	catgoryIcon varchar(max) not null 
);

create table Products(
	productId int not null primary key,
	productName varchar(max) not null,
	productImages varchar(max),
	categoryId int not null foreign key references Categories(categoryId),	
	expiredDate date,
	stock int not null,
	brand varchar(max),
	volume varchar(10),
	productDesc varchar(max)
);

create table Orders(
	orderId int primary key,
	userId int foreign key references Users(userId),	
	productId int not null foreign key references Products(productId),
	qty int not null,
	unitPrice float not null,
	orderStatus int not null,     	/* 1-delivered, 0-not delivered */
	orderDate datetime not null,
	remarksText varchar(max),
	remarksImage varchar(max),
	remarksDate datetime
);




