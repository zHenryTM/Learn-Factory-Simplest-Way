# Learn Factory - Simplest Way


### What is Factory?
Factory is a design pattern in which a class (called a factory class) creates instances of different classes.
     
### But how does the factory class know which class it should instantiate?
Through parameters that the client provides to the factory class.
       
### What is the advantage of creating a class that instantiates other classes in a "customized" way? 
- The Factory helps instantiate objects without exposing the logic.
- It centralizes the responsibility of deciding which object to instantiate.
- It makes it easier to add new types of objects to the system without modifying the client code.

  
## Basic Structure of Implementing Factory in Practice:
We will create an interface called **IMessage** and three classes: **SMSMessage**, **EmailMessage**, and **PushNotificationMessage** (I’m creating three classes as examples, but you can create as many as you want).

Now, we’ll have the classes implement the **IMessage** interface, ensuring that the classes have the same methods.

So far, we have the following structure:

![image](https://github.com/user-attachments/assets/cf39ad7d-2a07-4d6e-9e2a-83ef473c5912)


Practical example in C# of the interface and the classes:

![image](https://github.com/user-attachments/assets/42cf1970-5d08-4c81-9fe9-954dac59010c)


The classes that implement IMessage will send messages according to their type: SMS, Email or Notification.

Now, let’s create a class that will be responsible for instantiating the SMSMessage, EmailMessage, and PushNotificationMessage classes.

We will call this class **MessageFactory**.

![image](https://github.com/user-attachments/assets/636befc3-c59d-4fba-851b-98bec30995e1)

The factory class MessageFactory has the method *getFactory()*, which takes a string as a parameter.
Depending on the value of this string, the MessageFactory will instantiate SMSMessage, EmailMessage, or PushNotificationMessage.

![image](https://github.com/user-attachments/assets/a1e5c692-2bc3-40ba-bedc-9dd69c040b56)

I used if-statements to determine which class will be instantiated, but you can (and should, in some situations) use switch.
