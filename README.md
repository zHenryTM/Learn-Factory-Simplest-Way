# Learn Factory - Simplest Way

### What is Factory?

Factory is a design pattern in which a class (called a factory class) creates instances of different classes.

‎ 
### But how does the factory class know which class it should instantiate?

Through parameters that the client provides to the factory class.

‎ 
### What is the advantage of creating a class that instantiates other classes in a "customized" way? 

- The Factory helps instantiate objects without exposing the logic.
- It centralizes the responsibility of deciding which object to instantiate.
- It makes it easier to add new types of objects to the system without modifying the client code.

‎ 
## Basic Structure of Implementing Factory in Practice:

We will create an interface called **IMessage** and three classes: **SMSMessage**, **EmailMessage**, and **PushNotificationMessage** (I’m creating three classes as examples, but you can create as many as you want).

Now, we’ll have the classes implement the **IMessage** interface, ensuring that the classes have the same methods.

So far, we have the following structure:‎

![image](https://github.com/user-attachments/assets/cf39ad7d-2a07-4d6e-9e2a-83ef473c5912)
‎ 
‎
#### Practical example in C# of the interface and the classes:

![image](https://github.com/user-attachments/assets/4e29ade9-f42e-4671-a4aa-0bb7431f78f1)



The classes that implement IMessage will send messages according to their type: SMS, Email or Notification.

Now, let’s create a class that will be responsible for instantiating the SMSMessage, EmailMessage, and PushNotificationMessage classes.

We will call this class **MessageFactory**.
‎ 
![image](https://github.com/user-attachments/assets/636befc3-c59d-4fba-851b-98bec30995e1)


‎The factory class MessageFactory has the method *getMessage()*, which takes a string as a parameter.
Depending on the value of this string, the MessageFactory will instantiate SMSMessage, EmailMessage, or PushNotificationMessage.
‎ ‎
#### Practical example in C# of the MessageFactory:

![image](https://github.com/user-attachments/assets/a1e5c692-2bc3-40ba-bedc-9dd69c040b56)


_**For those who don't know C#:**_
_In `public IMessage? GetMessage(string messageType)`, the question mark (?) after `IMessage` means that the method can return an instance of a class that implements the `IMessage` interface or it can return null._

`StringComparison.CurrentCultureIgnoreCase` _is a parameter that makes Equals() not consider different uppercase and lowercase characters._
‎ 
## Using Factory

It's done! Now we can create an instance of the factory class and let it be responsible for creating instances of the other classes.

Now everything will be easier; the code below is sufficient for you to understand how to implement the Factory pattern in your code.

![image](https://github.com/user-attachments/assets/5e17fe1d-c4e1-40c8-9be8-6b67a371d419)

‎ 
### Thank you!
