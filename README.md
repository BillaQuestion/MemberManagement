# MemberManagement
## What is this?
Well, it's a long story. Briefly, I'm currently in a group to develop a management system for a paint workshorp. <br><br>
This workshorp offers painting environment with medium like paper. In exchange, the shopkeeper is pleasant to get some money. 
Customers always pay in these three ways: by lecture, by membership card or by cash.<br><br>
"By lecture": There are tutors hired by this gallery and customers can pay for teaching.
No other fees would be generated through teaching process.<br>
"By membership card": The membership card is a product with certain number of certain medium under certain customer's name. 
The shopkeeper is pleasant to sale membership card in a reasonable lower price and record customer's information so that members could pay by membership card.
## Constraint
* The shopkeeper would like to have ability as much as possible to change settings.
* After finishing every lecture, tutors should add description to specific lecture of specific customer.
* Data would be stored into database.

## Pertential Risks
* Product Guid may not be matched when Product definition deleted from database. A possible approach would be set Product definition to be unvisible so that user could not add this kind of product anymore. Hopefully, database would delete that definition when there is no member has any balance on.
