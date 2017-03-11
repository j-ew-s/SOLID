# SOLID
This repository is my study about SOLID principles.

---

*S.O.L.I.D* is a achronomus for the five princles of Object-oriented Programing (O.O.P.) first identified by **Robert C. Martin** (**Uncle Bob**) and named by **Michael Feathers**.

Well, the achronomous stands for: 
+ **_S_** - (SRP) - Single Responsability Princile
+ **_O_** - (OCP) - Open Closed Principle
+ **_L_** - (LSP) - Liskov Substitution Principle
+ **_I_** - (ISP) - Interface Segregation Principle
+ **_D_** - (DIP) - Dependency Inversion Principle.


Let's see what each one of the principles means. 

##S 
###Single Responsability Principle (SRP)

"_A class should have only one, and only one, reason to change._"

This one is the most importante. If you do not follow this first principle you can not apply the others principles properly. 

Well, it is simple, every class you create at yur project must have just one job. 
When you design a class, this class should solve a specific think at your applilcation. I mean, it just know how to do one thing, and be specialised on it. 

Let's see some code.

At SOLID solution, open the SOLID.SRP Console Application project. You can notice that there is a Entity folder and a Person class.

This class (Person) knows how to create it's self and verify if it's valid. Looking deep at IsValid method, you can see that Person class do not know how to validate a email, so it calls a EmailService class, that can handle it!

EmailService class knows how to validate an email and also knows how to send too! Well, it's all about email.

Going back to Person class, the same thing will happen to Phone, Person can not tell to the application if a phone number is valid, so it calls PhoneService class, that should know how to handle it(I know, its not implemented). 

The rest of this SRP example have classes and methods that just do one thing, you can see by yourself. 

The gains with maintance is pretty clear, do not you think ?

Use this principle to methods too, not just classes. 
Do not worry about having too much classes or methods, it's really important to give to they just one action, so you can make things more clearly.

##O 
###Open-Closed Principle (OCP)

"_Software entities should be open for extensions but closed for modifications._"

This means, when you face a necessity to add adaptiations or new treatments to a method for example, you will not alter this code adding new stuffs, you will extend this and customizing with new stuffs.


