using System;

namespace Isp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        /*

        The Interface Segregation Principle states that no client should be forced to 
        depend on methods it does not use. So, this is the basic definition which we 
        can read in many different articles, but what does this really mean?

        Let’s imagine that we are starting a new feature on our project. 
        We start with some code and from that code, an interface emerges with the 
        required declarations. Soon after, the customer decides that they want another feature which is similar to the previous one and we decide to implement the same interface in another class. But now, as a consequence, we don’t need all the methods from that interface, just some of them. Of course, we have to implement all the methods, which we shouldn’t have to, and that ’s the problem and where the ISP helps us a lot.

        Basically, the ISP states that we should reduce code objects down to the 
        smallest required implementation thus creating interfaces with only required 
        declarations. As a result, an interface that has a lot of different 
        declarations should be split up into smaller interfaces.

        */






        /*

        What are the Benefits of the Interface Segregation Principle
        We can see from the example above, that smaller interface is a lot easier
        to implement due to not having to implement methods that our class doesn’t need.

        Of course, due to the simplicity of our example, we can make a single 
        interface with a single method inside it. But in real-world projects, we often come up with an interface with multiple methods, which is perfectly normal as long as those methods are highly related to each other. Therefore, we make sure that our class needs all these actions to complete its task.

        Another benefit is that the Interface Segregation Principle increases the readability 
        and maintainability of our code. We are reducing our class implementation only to 
        required actions without any additional or unnecessary code.

        */
    }
}
