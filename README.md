# Week4-OOP-Practice
Patika+ Fullstack Bootcamp Week4 OOP Practice


We get Phone and Computer records at a technology store.

Phone -> Production Date, Serial Number, Name, Description, Operating System, TR Licensed or not.

Computer -> Production Date, Serial Number, Name, Description, Operating System, Number of USB Ports, Bluetooth availability

Inherit the Phone and Computer classes from a BaseClass named BaseMachine. (Inheritance)

The number of USB ports for the computer can be assigned to 2 or 4, otherwise a warning message will be given and the value should be assigned to -1. (Encapsulation)

Automatically assign the Production Date value as soon as an object is created. It is valid for both phone and computer.

Let's define a PrintInformation() method within the Base Class (BaseMachine) that prints common information such as Production Date, Serial Number, Name, Description, Operating System. In derived classes (Phone, Computer), this method should be crushed and the function of printing their own properties should be added on top of the Base function.   (Polymorphism)

By defining an abstract method called ProductNameGet() and crushing it separately for Phone and Computer

"Your phone name ---> ......"

"Your computer name ---> ......"

Console messages like this can be printed.  (abstraction)

Program flow:

1- From the console screen, tell the user to press 1 to produce a phone and 2 to produce a computer.

2- Create an object of the relevant class according to the user's choice and get its properties from the console screen, that is, from the user.

3- When all the information is entered, inform him with a message that the product has been produced successfully and ask him if he wants to produce another product.

4- If the user answers yes, go back to step 1. If the user answers no, end the application by wishing you a good day.
