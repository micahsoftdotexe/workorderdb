delete from PhoneNumber;
delete from PhoneType;
delete from Address;
delete from AddressType;
delete from Labor;
delete from Part;
delete from WorkOrder;
delete from Automobile;
delete from customer;
delete from Owns;

SET IDENTITY_INSERT Customer OFF;
SET IDENTITY_INSERT Automobile OFF;
SET IDENTITY_INSERT WorkOrder OFF;

insert into PhoneType values (1, 'Work');
insert into PhoneType values (2, 'Cell');
insert into PhoneType values (3, 'Home');

insert into AddressType values (1, 'Mailing');
insert into AddressType values (2, 'Billing');
insert into AddressType values (3, 'Shipping');


SET IDENTITY_INSERT Automobile ON;
insert into Automobile(AutomobileID, Vin, Make, Model, Year) values (1, '5UMDU935261K2JXA4', 'BMW', 'Series 3', 2018);
insert into Automobile(AutomobileID, Vin, Make, Model, Year) values (2, 'JAEDJ58V9VWDED5SX', 'Tesla', 'Model 3', 2019);
insert into Automobile(AutomobileID, Vin, Make, Model, Year) values (3, '1GNEK13Z16J160267', 'Toyota', 'Camry', 2007);
insert into Automobile(AutomobileID, Vin, Make, Model, Year) values (4, '1G1PG5SB7D7118056', 'Mazda', 'Mazda3', 2014);
SET IDENTITY_INSERT Automobile OFF;

SET IDENTITY_INSERT Customer ON;
insert into Customer(CustomerID, FirstName, LastName) values (1, 'Matthew', 'Jensen');
insert into Customer(CustomerID, FirstName, LastName) values (2, 'Micah', 'Tanner');
insert into Customer(CustomerID, FirstName, LastName) values (3, 'Logan', 'Bateman');
insert into Customer(CustomerID, FirstName, LastName) values (4, 'Miro', 'Manestar');
insert into Customer(CustomerID, FirstName, LastName) values (5, 'Michael', 'Jensen');
insert into Customer(CustomerID, FirstName, LastName) values (6, 'Joseph', 'Dietel');
SET IDENTITY_INSERT Customer OFF;

insert into PhoneNumber values (1, 1, '8634461056');
insert into PhoneNumber values (1, 2, '8638000511');
insert into Address values (1, 2, '900 County Rd 950', null, 'Calhoun', '37309', 'TN');
insert into Address values (1, 1, '870 County Rd 950', null, 'Calhoun', '37309', 'TN');
insert into Owns values (1, 4);


insert into PhoneNumber values (2, 2, '2573564291');
insert into Address values (2, 1, '470 Blairsville Dr', null, 'Calhoun', '39405', 'GA');
insert into Owns values (2, 1);


insert into PhoneNumber values (3, 1, '9876543211');
insert into Address values (3, 1, '37 Random Rd', null, 'Boseman', '97350', 'MT');
insert into Owns values (3, 2);


insert into PhoneNumber values (4, 2, '9093726482');
insert into Address values (4, 2, '2581 Lakeview Dr', null, 'Sebring', '33880', 'Fl');
insert into Owns values (4, 3);


insert into PhoneNumber values (5, 3, '8638000311');
insert into Address values (5, 2, '900 County Rd 950', null, 'Calhoun', '37309', 'TN');
insert into Owns values (5, 4);


insert into PhoneNumber values (6, 2, '4567894231');
insert into Address values (6, 2, '76 Continnental Ave', null, 'Saint Paul', '55111', 'MN');


SET IDENTITY_INSERT WorkOrder ON;
insert into WorkOrder(WorkOrderID, CustomerID, AutomobileID, Date, Subtotal, Tax, WorkOrderNotes, AmountPaid, PaidInFull) values (1,1,4,'20210318 10:34:09 AM', 25.00, 3.42, 'Be sure to come back in 6 months for another oil change', 28.42, 1);
insert into WorkOrder(WorkOrderID, CustomerID, AutomobileID, Date, Subtotal, Tax, WorkOrderNotes, AmountPaid, PaidInFull) values (2,2,1,'20201218 3:30:09 PM', 100.00, 10.17, 'You should be set for a few years with that refrigerant recharge', 100.00, 0);
SET IDENTITY_INSERT WorkOrder OFF;


insert into Labor values (1, 'Oil Change', 'Took a bit longer because of rust', 25.00);
insert into Part values (1, 10.00, 25.00, '1 Quart 10W40', null);
insert into Part values (1, 1.00, 0.00, 'Paper Towls', null);

insert into Labor values (2, 'Refrigerant Refill', 'Nothing in particular', 45.00);
insert into Part values (2, 50.00, 10.00, '2 Liters Refrigerant', null);

