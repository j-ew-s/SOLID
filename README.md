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

Isso significa que quando você enfrenta a necessidade de adicionar adaptações ou novos tratamentos a um método, por exemplo, você não alterará este código adicionando novos materiais, você deve estendê-lo e personalizar com seu novo código.

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
