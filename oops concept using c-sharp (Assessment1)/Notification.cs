using System;
using System.Collections.Generic;


public interface INotificationObserver
{
    void Update(string message);
}


public class EmailNotifier : INotificationObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Email Notification: {message}");
    }
}


public class SMSNotifier : INotificationObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"SMS Notification: {message}");
    }
}

public class NotificationService
{
    private readonly List<INotificationObserver> _observers = new List<INotificationObserver>();

    public void AddObserver(INotificationObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(INotificationObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}