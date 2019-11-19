AcuCafe has an ordering system which is poorly designed and sometime fails to deliver the right orders. 
For example, some of the clients complaint that their ice tea had milk in it.
Also, the system turned out to be a maintenance nightmare as it is difficult to add new drinks.

AcuCafe has selected you to update their ordering system to be able to:
-	Stop the preparation of an ice tea with milk and inform the barista
-	Add a new chocolate topping to the expresso
Can you think of any new requirements that can impact your design?
If we would need to know if a drink should be prepared cold or hot we could store this data in the topping class but the name of the class wouldn't really make sense anymore.
As a solution, we could rename the class and the interface 
OR we could wrap the topping interface in another one which would let us the possibility to add extra interfaces
OR we could just pass it as an argument to the factory class but it wouldn't make any extra extension easy (not recommended).


Ensure you commit the completed code into GitHub and send us a link to a public repository. Please register a GitHub account if you don't already have one.
Hints:
We are looking for a solution that shows a good understanding of the SOLID principles, object oriented programming and that displays a working knowledge of TDD.
Please add some commentary to justify the decisions you've taken, if possible by quoting books, blog posts or talks that have influenced you.
