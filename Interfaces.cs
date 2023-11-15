using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Pitagoras
{
    partial class Sender
    {
        private IMessagesSender _sender;
        public Sender(IMessagesSender sender)
        {
            _sender = sender;
        }

        public void SendMessage(string message)
        {
            _sender.SendMessage(message);
        }
    } 
    partial class SMS : IMessagesSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Enviando SMS: " + message);
        }
    }
    partial class Email : IMessagesSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Enviando correo: " + message);
        }
    }

    partial class MessegesSenderFactoryError : IMessagesSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Ingresó un tipo de interfaz no valida...");
        }
    }
    partial interface IMessagesSender
    {
        // interface are templates for classes
        // it means a class has to implement all the methods included in the interface
        // methods in classes using interfaces must be public
        void SendMessage(string message);
    }

    static partial class MessagesSenderFactory
    {
        public static IMessagesSender GetMessagesSender(string type)
        {
            // Returns an instance of the class that implements the interface
            // from the type of the interface
            switch (type.ToLower())
            {
                case "sms":
                    return new SMS();
                case "email":
                    return new Email();
                default:
                    return new MessegesSenderFactoryError();
            }
        }
    }

    static class GenericMethods
    {
        public static string Serializer<T>(T dato)
        {
            // <T> is a generic type, it means it can be any type
            // This is named as generic method
            var serliazer = new XmlSerializer(typeof(T));

            using (var stringWriter = new StringWriter())
            {
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    serliazer.Serialize(writer, dato);
                    return stringWriter.ToString();
                }
            }
        }
    }
}
