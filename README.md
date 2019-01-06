# SOLID
This repository is my study about SOLID principles.

---

This five princles of Object-oriented Programing (O.O.P.) first identified by **Robert C. Martin** (**Uncle Bob**) and named as *S.O.L.I.D* by **Michael Feathers**.

Well, the SOLID achronomous stands for: 
+ **_S_** - Single Responsability Princile (SRP)
+ **_O_** - Open Closed Principle (OCP)
+ **_L_** - Liskov Substitution Principle (LSP)
+ **_I_** - Interface Segregation Principle (ISP)
+ **_D_** - Dependency Inversion Principle (DIP)


Let's see what each one of the principles means. 

## S 

### Single Responsability Principle (SRP)

"_A class should have one, and only one, reason to change._"

This one is the most importante. If you do not follow this first principle you can not apply the others principles properly. 

Well, it is simple, every class you create at your project must have just one job. 
When you design a class, this class should solve a specific think at your applilcation. I mean, it just know how to do one thing, and be specialised on it. 

Let's see some code.

At SOLID solution, open the SOLID.SRP Console Application project. You can notice that there is a Entity folder and a Person class.

This class (Person) knows how to create it's self and verify if it's valid. Looking deep at IsValid method, you can see that Person class do not know how to validate a email, so it calls a Email class, that can handle it!

EmailService class knows how to validate an email and also knows how to send too! Well, it's all about email.

Going back to Person class, the same thing will happen to Phone, Person can not tell to the application if a phone number is valid, so it calls PhoneService class, that should know how to handle it(I know, its not implemented). 

The rest of this SRP example have classes and methods that just do one thing, you can see by yourself. 

The gains with maintance is pretty clear, do not you think ?

Use this principle to methods too, not just classes. 
Do not worry about having too much classes or methods, it's really important to give to they just one action, so you can make things more clearly.

## O 
### Open-Closed Principle (OCP)

"_Software entities should be open for extensions but closed for modifications._"

When you face the necessity of adding a new feature to a method, for example, you shlould not have to alter it, just extend a new class to implement this. 

Well, to be more clear, take a look at SOLID.OCP Console Application. You will find a Service folder wich contains FileService class.
This class has the Generate method, and this method just do one thing: Calls the CreateArchive for any file extension you pass to it.

So, to came to this aproach, we must use Abstractions.
Abstract classes means that this class can not be Instantiated, but Inherited and it can contains properties and methods, wich could/should be abstractions too.

Looking back to our definition, the File class is closed to modifications and open to extensions.

Following the example, we have the  WordFile and PDFFile class that inheritage from the Abstract Class File and override the CreateArchive method. WordFile and PDFFile have they own idea of how to generate a file, so, let they do the job.

What is common in this case, let's call it as _violation_ is, at FileService class our Generate method will have a lot of _if_ or _switch_ that select the properly block of code wich will treat the CreateArchive. So, this Method and Class by consequence will have more than one reason to change, violatin the SRP. 

Another problems that it create is : errors that can rise. If your new _if_ that treat a new file implementation have some bug all the class will broke the build, even for the ones that were not even modified; and if you have tests, every time you put a treatment, you must change your test; and also if you increase the quantity of _if_ you will increase your software cyclomatic complexity. Think about it.

Ok, it's the hard one, in my opinion. It does not mean that when we write a class this class will never ever be modified again, because, changes may occurr: this is software development. But we must be attentive  about how handle extensions, trying to prevent failures to classes that already implement our dll's. 

* In most cases, we use to use Abstract classes instead of Interfaces because you can have properties.

## L
### Liskov Substitution Principle (LSP)

"_Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it_".

Every subclasse should be substitutable by it's base class without a warning.

A method M that treat a behavor of a subclass B using its Base class A as parameter, must know every sobclasses of A so it can treat properly. When a new A subclass is added, you shoul alter M to the new treatment, violating OCP. Cool.

You can look at SOLID.LSP Console Application project. Open the Service folder, and in IdentityService at method ValidateIDTags you can see that Person is a parameter and it calls IdentificationIsValid mehtod. Go to Program.cs and you will see that what is pasted to ValidateIDTags is a Customer and Employee. 

Both Customer and Employee are subclass of Person. Because of abstraction the ValidateIDTags method can recieve a People class and do not knowing who truly is. Beautful, don't you think?

Note that, we have not a lot of _IF_ we have no treatment to know who's the parameter, we just call the method we want.

## I
### Interface Segregation Principle (ISP)

"_Make fine grained interfaces that are client specific_".

A class should not have to implement a method that will never use. Well, we use interfaces to create contracts and some times more than one class uses this interface, so this classes must use all of interfaces contracts, just one contrat this classes do not uses it is already a reason to do not use this interfece.

Take a look at SOLID.ISP Console Application. You can see that we have Car, Airplane and Boat classes. They all are vehicles, but have different behavors so I isolted they interfaces. Put all this contracts in just one interface called IVehicles would be a violation. Boa class will never use the Taxiing method or Car will never have to Row(I hope. if it does, I am so sorry for you).

It's simple, so much like SRP.

## D
### Dependency Inversion Principle (DIP)

"_1. High level modules should not depend upo low level modules. Both should depend on abstractions. 2. Abstractions should not depend upon details. Detains should depend upon abstractions_. 

Depends on abstractions not on concretions, this is the idea.
Its not good when we depends on a concretions, if an change is done to the low level module, your high level may be affected.

Go to SOLID.DIP Console Application project. In the Program.cs depends on a IEngine interface. Program.cs does not know how to create they implementation, but know it's should use the Start method.
At concrete folder we have Car.cs and it implements the IEngine interface. So, Program.cs could use Cars class without knowing how to creat it. Any change on Car class will not affect the Program.cs.




---


This is my conclusion about S.O.L.I.D. 

If you have any consideration, let me know! 
gabriel.scavassa@outlook.com.

