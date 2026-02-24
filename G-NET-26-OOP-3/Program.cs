namespace G_NET_26_OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Q1
            //Q1 : Identify the type of relationship in each scenario below (Inheritance, Association, Aggregation, Composition, or Dependency):
            //a) A University has Departments. If the university is closed, the departments no longer exist.
            //a) => Composition
            //b) A Driver uses a Car. The driver does not own the car.
            //b) => Dependency
            //c) A Dog is an Animal.
            //c) => Inheritance
            //d) A Team has Players. If the team is deleted, the players still exist.
            //d) => Aggregation
            //e) A method receives a Logger as a parameter and calls it inside the method only.
            //e) => Dependency
            #endregion

            #region Q2
            //Q2 : Answer the following questions about access modifiers and sealed:
            //a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?
            //a) => Yes, a child class in a different assembly can access a protected field,but accessing it through an object instance from outside is not allowed . 
            //b) What is the difference between protected internal and private protected?
            //b) => - protected internal : a member is accessible to any code in the same assembly, OR to any derived class even in a different assembly. 
            //      - private protected : a member is only accessible to a derived class that is also in the same assembly. 
            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            //c) => - On a class: It prevents the class from being inherited at all. No other class can derive from it.
            //      - On a method: sealed can only be applied to a method that is overriding a virtual method from a base class. It stops the override chain at that point.
            //d) Can you create an object from a sealed class using new? Why or why not?
            //d) => Yes, absolutely. sealed has no effect on instantiation, it only restricts inheritance.
            #endregion
            #endregion
        }
    }
}
