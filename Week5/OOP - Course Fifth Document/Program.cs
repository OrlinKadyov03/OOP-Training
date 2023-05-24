using System.Net;
using System.Threading.Tasks;
using System;

namespace OOP___Course_Fifth_Document
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Person class. Each Person has a Name, Age and Address.
            //Address is also a class that contains
            //a city name, a country name, and a street name.
            //After you create the Person class,
            //you need to create a second Child class.
            //Each child of Person has the same properties as the parent,
            //but also has a Play method.
            //When the Play method is executed, the console displays I am a child.
            //In this task, you will need to create a structure that allows the following:
            //Address address = new Address(“Plovdiv”,”Bulgaria”,”Bul.Bulgaria 236”);
            //Person person = new Person(“Georgi”, 25, address);
            //Child child = new Child(“Toshko”, 5, address);
            //child.Play();

            Address address = new Address("Plovdiv","Bulgaria","Bul.Bulgaria 236");
            Person person = new Person("Georgi",25,"address");
            Child child = new Child("Toshko",5,"address");
            child.Play();



        }
    }
}