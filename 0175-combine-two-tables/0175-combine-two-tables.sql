/* Write your T-SQL query statement below */
select 
person.firstName, person.LastName,
Address.city, Address.state
from Person
left join Address
 on person.PersonId = Address.personId