using System;

//ref link:https://www.youtube.com/watch?v=VzISkVTLfSg&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=29
// upcast, downcast, safety
// inheritance, polymorphism required knowledge

// Casting -- temporary changing types
// Type Conversions -- changing types explicitly(safetyoff) which can lead to data loss


class Base                // recommended
//class Base : System.Object         // explicit compiler inheritance -- not optional
{
    int baseInt;
    
    
    //public int baseValue;
    //public void BaseMethod()
    //{
    //    Console.WriteLine("BaseMethod()");
    //}
}

class Derived : Base
{
    float deriveFloat;


    //public float derivedValue;
    //public void DerivedMethod()
    //{
    //    Console.WriteLine("DerivedMethod()");
    //}
}

class MainClass
{
    static void Main()
    {
        int i = 5;
        float f = i;    // implicit convertion allowed
        i = (int)f;     // safety off(loss of datawork) explicit casting


        Derived d = new Derived();      // Compile Type(Derived d) = Runtime Type(new Derived();)
        Base b = d;
        d = (Derived)b; // safety off explicit casting -- RUNTIME ERROR --

        //Base b = new Base();
        //Derived d = new Derived();
        ////b = d;  // implicit reference convertion
        ////d = b;  // error: need  explicit casting not recommended 
        //d = (Derived)b; // safety off explicit casting -- RUNTIME ERROR --
    }
}