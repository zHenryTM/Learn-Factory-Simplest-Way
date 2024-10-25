#pragma warning disable CS8602

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


public interface IMessage
{
    public abstract void Send(string message);
}


public class SMSMessage : IMessage
{
    // Interface Abstract Method
    public void Send(string message)
    {
        message = (message == null) ? "" : message;        
        Console.WriteLine("Message sent by SMS: " + message);
    }
}


public class EmailMessage : IMessage
{
    // Interface Abstract Method
    public void Send(string message)
    {
        message = (message == null) ? "" : message; 
        Console.WriteLine("Message sent by Email: " + message);
    }
}


public class PushNotificationMessage : IMessage
{
    // Interface Abstract Method
    public void Send(string message)
    {
        message = (message == null) ? "" : message; 
        Console.WriteLine("Message sent by Notification Push: " + message);
    }
}


public class MessageFactory
{
    public IMessage? GetMessage(string messageType)
    {    
        if (messageType.Equals("SMS", StringComparison.CurrentCultureIgnoreCase))
        {
            return new SMSMessage();
        }
        else if (messageType.Equals("Email", StringComparison.CurrentCultureIgnoreCase))
        {
            return new EmailMessage();
        }
        else if (messageType.Equals("PushNotification", StringComparison.CurrentCultureIgnoreCase))
        {
            return new PushNotificationMessage();
        }
        else
        {
            return null;
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        MessageFactory messageFactory = new MessageFactory();
        IMessage? message = messageFactory.GetMessage("SMS");
        message.Send("[...] Eu quero você como eu quero.");
    }
}
