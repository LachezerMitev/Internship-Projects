
INSERT INTO VehicleStatuses ([Code], [Name], [Description], [Active]) VALUES (N'WAITDIAG', N'Waiting diagnostic', N'Vehicle is currently waiting diagnostick', 1)
INSERT INTO VehicleStatuses ([Code], [Name], [Description], [Active]) VALUES (N'WAITCHECK', N'Waiting Check-Up', N'Vehicle is currently waiting for the check up to start', 1)
INSERT INTO VehicleStatuses ([Code], [Name], [Description], [Active]) VALUES (N'FNSHD', N'Finished', N'Vehicle Service has finished an is waiting for pick-up', 1)

INSERT INTO AccountStatuses ([Code], [Name], [Description], [Active]) VALUES (N'ACTV', N'Active', N'Account is active', 1)
INSERT INTO AccountStatuses ([Code], [Name], [Description], [Active]) VALUES (N'NACTV', N'Not Active', N'Account is not active', 1)

INSERT INTO AccountTypes([Code], [Name], [Description], [Active]) VALUES (N'ADMN', N'Admin', N'Account is admin', 1)
INSERT INTO AccountTypes ([Code], [Name], [Description], [Active]) VALUES (N'USER', N'User', N'Account is User', 1)

INSERT INTO AutoPartStatuses ([Code], [Name], [Description], [Active]) VALUES (N'INSTK', N'In Stock', N'item is in stock', 1)
INSERT INTO AutoPartStatuses ([Code], [Name], [Description], [Active]) VALUES (N'NINSTK', N'Not In Stock', N'item is not in stock', 1)

INSERT INTO CheckUpStatuses ([Code], [Name], [Description], [Active]) VALUES (N'INPRGS', N'In Progress', N'Check up is being worked on right now', 1)
INSERT INTO CheckUpStatuses ([Code], [Name], [Description], [Active]) VALUES (N'ONHLD', N'On Hold', N'Check up is on hold', 1)
INSERT INTO CheckUpStatuses ([Code], [Name], [Description], [Active]) VALUES (N'FNSHD', N'Finished', N'Check up has been Finished', 1)

INSERT INTO ContractStatuses ([Code], [Name], [Description], [Active]) VALUES (N'ACTV', N'Active', N'Contract is active', 1)
INSERT INTO ContractStatuses ([Code], [Name], [Description], [Active]) VALUES (N'NACTV', N'Not Active', N'Contract is not active', 1)

INSERT INTO ContractTypes ([Code], [Name], [Description], [Active]) VALUES (N'FTime', N'Full Time', N'Full time', 1)
INSERT INTO ContractTypes ([Code], [Name], [Description], [Active]) VALUES (N'PTime', N'Part Time', N'Part time', 1)

INSERT INTO Makes ([Code], [Name], [Description], [Active]) VALUES (N'HONDA', N'HONDA', N'HONDA', 1)
INSERT INTO Makes([Code], [Name], [Description], [Active]) VALUES (N'MRCBENZ', N'Mercedes - Benz', N'Mercedes - Benz', 1)

INSERT INTO Models ([Code], [Name], [Description], [Active]) VALUES (N'CIVIC1.6V', N'Civic 1.6 VTEC', N'Honda Civic 1.6VTEC', 1)
INSERT INTO Models ([Code], [Name], [Description], [Active]) VALUES (N'C220W203', N'C220 W203', N'Mercedes - Benz C220 w203', 1)

INSERT INTO Users ([Username], [Password], [Active]) VALUES (N'Admin', N'PA62a9DGKrc1l1mkwklkIp0awYB7wX34850Tml2VoFU=', 1)
INSERT INTO Users ([Username], [Password], [Active]) VALUES (N'User1', N'2BT5vg2hdYnBDDIl1vdkEuH5yxdhiJNRPY2IydHqTTs=', 1)

INSERT INTO UserGroupStatuses ([Code], [Name], [Description], [Active]) VALUES (N'ACTV', N'Active', N'User group is active', 1)
INSERT INTO UserGroupStatuses ([Code], [Name], [Description], [Active]) VALUES (N'NACTV', N'Not Active', N'User group is not active', 1)

INSERT INTO Accounts ([Code], [Name], [Description], [FirstName], [Surname], [LastName], [UserId], [AccountStatusId], [AccountTypeId], [Active]) VALUES (N'ADMIN', N'Admin', N'Account is an Admin', N'Admin', N'Admin', N'Admin', 1, 1, 1, 1)
INSERT INTO Accounts ([Code], [Name], [Description], [FirstName], [Surname], [LastName], [UserId], [AccountStatusId], [AccountTypeId], [Active]) VALUES (N'USER', N'user', N'Account is an user', N'User', N'User', N'User', 2, 2, 2, 1)

INSERT INTO Vehicles ([Code], [Name], [Description], [VehicleStatusId], [DateOfProduction], [Mileage], [Active]) VALUES (N'HDNACVC', N'Honda Civic', N'Honda Civic 1.6 VTEC', 1, N'2020-01-28 12:18:21', 125621, 1)
INSERT INTO Vehicles ([Code], [Name], [Description], [VehicleStatusId], [DateOfProduction], [Mileage], [Active]) VALUES (N'MRCBNZC', N'Mercedes Benz C220', N'Mercedes Benz C220 W203 2006', 2, N'2020-01-28 12:18:21', 235621, 1)

INSERT INTO CheckUps ([Code], [Name], [Description], [CheckUpStatusId], [Price], [CheckUpStart], [CheckUpEnd], [VehicleId], [CustomerId], [Active]) VALUES (N'ADMIN', N'Admin', N'Check-Up for a Honda Civic 1.6 vtec', 1, CAST(3500.00 AS Decimal(18, 2)), N'2020-01-28 12:18:21', N'2020-01-28 12:18:21', 1, 1, 1)
INSERT INTO CheckUps ([Code], [Name], [Description], [CheckUpStatusId], [Price], [CheckUpStart], [CheckUpEnd], [VehicleId], [CustomerId], [Active]) VALUES (N'User', N'user', N'Check-Up for a Mercedes Benz C220 W203 2006', 2, CAST(5500.00 AS Decimal(18, 2)), N'2020-01-28 12:18:21', N'2020-01-28 12:18:21', 2, 2, 1)

INSERT INTO AutoParts ([Code], [Name], [Description], [AutoPartStatusId], [CheckUpId], [Price], [Quantity], [Active]) VALUES (N'WTRPC:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataSeeding\MP', N'Water Pump', N'Water Pump', 1, 1, CAST(2000.00 AS Decimal(18, 2)), 20, 1)
INSERT INTO AutoParts ([Code], [Name], [Description], [AutoPartStatusId], [CheckUpId], [Price], [Quantity], [Active]) VALUES (N'TRBCHR', N'Turbo Charger', N'Turbo Charger', 2, 2, CAST(32510.00 AS Decimal(18, 2)), 0, 1)

INSERT INTO Contracts ([Code], [Name], [Description], [WorkDayStart], [WorkDayEnd], [Salary], [ContractStatusId], [ContractTypeId], [Active]) VALUES (N'FULLTIME', N'Full Time', N'Full time Work Contract', N'2020-01-28 12:18:21', N'2020-01-28 12:18:21', CAST(800.00 AS Decimal(18, 2)), 1, 1, 1)
INSERT INTO Contracts ([Code], [Name], [Description], [WorkDayStart], [WorkDayEnd], [Salary], [ContractStatusId], [ContractTypeId], [Active]) VALUES (N'PARTTIME', N'PArt Time', N'Part time Work Contract', N'2020-01-28 12:18:21', N'2020-01-28 12:18:21', CAST(400.00 AS Decimal(18, 2)), 1, 1, 1)

INSERT INTO UserGroups ([Code], [Name], [Description], [UserGroupStatusId], [Active]) VALUES (N'ADMN', N'Admin', N'Admin', 1, 1)
INSERT INTO UserGroups ([Code], [Name], [Description], [UserGroupStatusId], [Active]) VALUES (N'USRS', N'User', N'User', 1, 1)
INSERT INTO UserGroups ([Code], [Name], [Description], [UserGroupStatusId], [Active]) VALUES (N'WRKR', N'Worker', N'Worker', 1, 1)
INSERT INTO UserGroups ([Code], [Name], [Description], [UserGroupStatusId], [Active]) VALUES (N'CLNT', N'Client', N'Client', 1, 1)
INSERT INTO UserGroups ([Code], [Name], [Description], [UserGroupStatusId], [Active]) VALUES (N'MNGR', N'Manager', N'Manager', 1, 1)

INSERT INTO Issues ([Code], [Name], [Description], [CheckUpId], [Active]) VALUES (N'GSERVICE', N'General Service', N'General Service', 1, 1)
INSERT INTO Issues ([Code], [Name], [Description], [CheckUpId], [Active]) VALUES (N'BRKWPMP', N'Water Pump Issue', N'Water Pump Issue', 2, 1)

INSERT INTO UserUserGroups ([UserGroupId], [UserId], [Active]) VALUES (1, 1, 1)
INSERT INTO UserUserGroups ([UserGroupId], [UserId], [Active]) VALUES (2, 2, 1)
INSERT INTO UserUserGroups ([UserGroupId], [UserId], [Active]) VALUES (4, 2, 1)

INSERT INTO VehicleMakeModels ([VehicleId], [MakeId], [ModelId], [Active]) VALUES (1, 1, 1, 1)
INSERT INTO VehicleMakeModels ([VehicleId], [MakeId], [ModelId], [Active]) VALUES (2, 2, 2, 1)

