namespace CSharpSyntax;

public class CreatingAndInitializingTypes
{
    [Fact]
    public void UsingLiteralsToCreateInstanceOfTyoes()
    {
        //Ctrl K and Ctrl D formats code
        //Ctrl K and Ctrl C to comment out lines
        //Ctrl L to delete line
        //Hold Alt and use arrow keys to move line(s) of code
        //local variables -- variables that are declared inside a method, or property

        string myName = "Jeff";
        char mi = 'M';
        bool isVendor = true;

        int myAge = 53;
        bool isLegalAgeToDrink = myAge >= 21;

        Taco food = new Taco();
        Assert.Equal("Jeff", myName);
        Assert.Equal(53, myAge); 

    }

    [Fact]
    public void ImplicitlyTypedLocalVariables()
    {
        //Var can be used for local variables, and you must initialize the variable.
        var myAge = 21;

        var myName = "Jeff";

        var favoriteFood = new Taco();

        var myPay = 25.34M;

        //option in c# 6, we don't use this much except in special circumstances I'll show later
        Taco lunch = new();


    }
}


public class Taco
{

}
