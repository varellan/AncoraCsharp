using IdentityServer3.Core.Resources;
using System;
using System.Collections.Generic;

namespace Lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        class DatingProfile
        {
            public string firstName;
            private string lastName;
            public int age;
            public string gender;
            public string bio;
            private List<Messages> myMessages;

            public DatingProfile(string firstName, string lastName, int age, string gender)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.gender = gender;
                myMessages = new List<Messages>();
            }

            public void WriteBio(string text)
            {
                bio = text;
            }

            public void AddToInbox(Messages message)
            {
                myMessages.Add(message);

            }

            public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
            {
                Messages message = new Messages(this, messageTitle, messageData);
                sentTo.AddToInbox(message);
            }

            public void ReadMessage()
            {
                foreach (Messages message in myMessages)
                {
                    if (message.isRead
                        == false)
                    {
                        Console.WriteLine(message.messageTitle);
                        Console.WriteLine(message.messageData);
                        message.isRead = true;
                    }

                }
            }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            DatingProfile Ted = new DatingProfile("Ted", "Dancing", 42, "Male");
            Ted.WriteBio("Loves the OutDoors");

            DatingProfile Babes = new DatingProfile("Babes", "Bunny", 39, "Female");
            Babes.WriteBio("Loves To Hike and Bike Ride");

            Ted.SendMessage("Hello Babes", "Wanna Take a Walk With Me", Babes);
            Babes.ReadMessage();
        }
        class Messages
        {
            public DatingProfile sender;
            public string messageTitle;
            public string messageData;
            public bool isRead;

            public Messages(DatingProfile sender, string messageTitle, string messageData)
            {
                this.sender = sender;
                this.messageTitle = messageTitle;
                this.messageData = messageData;
                isRead = false;
            }

        }
    }
}

