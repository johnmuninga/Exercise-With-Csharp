# Exercise-With-Csharp

You are required to develop a C# application that processes transaction for a supermarket. The supermarket sales a variety of products such as bread, milk, etc. A purchase involves ensuring the product to be bought exists, the amount provided by customer is greater or equals to the price of the item, and subtracting the quantity by one. A customer can only buy on item per given transaction. 

The application must consist of the following methods:
•	populate (string [], int [], double []): The method accepts three parallel (same sized arrays) which must be populated. The first array of type string must be populated with product names via user input. Second array of type int must have the quantity for each product. This is done via random number between 5 – 60. The last array of type double must store the price per product. This is done via user input.
•	searchProduct (string []): The method accepts an array of type string which contain product names. The method must prompt user for a product name to search for. The method searches the array and return the index of where the product is found. If product is not found an index of -1 must be return.

•	Buy (string [], int [], double []): The method accepts three arrays of type string, int and double containing the product names, product quantity and the product prices, respectively. The method’s role is to process a purchase. The method must first search for the product if it exists as shown in Figure 4, then prompt user for the amount to be paid. Ensure that the money provide is greater or equals to the purchase price of the item. The transaction is done by subtracting 1 to quantity and computing the difference between the price of the product and the amount tendered. If purchase is successful, display the change as shown in Figure 3.

•	Display (string [], int [], double []): The method accepts three arrays of type string, int and double. The methods must display the data in all three arrays as shown in Figure 2.  
•	menu (): This method must create a menu or a list of option to select from as shown in Figure 1. The method must return the user selected option.

•	Main (): In this main method, declare three arrays of type string, int, and double which will be used throughout this method. Invoke the menu and based on the user selected option do the following
