--Bad Update
update dbo.[User] set PhoneNumber = '09129564201' where FirstName = 'reza' and LastName = 'neyestani'


select * from dbo.[User]

--good Update
update dbo.[User] set PhoneNumber = '09129564201',FirstName = '',LastName = '',NationalCode = '' where Id = 5

delete dbo.[User] where Id = 5