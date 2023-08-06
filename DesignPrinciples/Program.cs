using EncapsulateWhatVaries;
using System.Diagnostics.Metrics;
using SingleResponsibility;
using DependencyInversion.After;
using Loose_Vs._Tight_Coupling.Before;
using Loose_Vs._Tight_Coupling.After;

/////////////////////////////////////////////////
///
//Encapsulate What Varies Principle
/*
Pizza pizza = Pizza.Order(PizzaConstants.CheesePizza);
Console.WriteLine(pizza);
*/
////////////////////////////////////////////////
////
//Single Responsibility
/*
//TestWithoutSRP(); 
TestWithSRP();

static void TestWithoutSRP()
{
    var account =
        new SingleResponsibility.Before.Account("Reem", "reem@example.com", 10000m);
    account.MakeTransaction(500);
    account.MakeTransaction(-11000);
}

 static void TestWithSRP()
{
    var account =
        new SingleResponsibility.After.Account("Reem", "reem@example.com", 10000m);

    var accountService = new SingleResponsibility.After.AccountService();
    accountService.Deposit(account, 500);
    accountService.WithDraw(account, 11000);
}
*/
////////////////////////////////////////////////
////
// Open Closed
/*
var quiz = new OpenClosed.Before.Quiz(OpenClosed.Before.QuestionBank.Generate());

quiz.Print();
*/
/*
var quiz = new OpenClosed.After.Quiz(OpenClosed.After.QuestionBank.Generate());

quiz.Print();
*/
////////////////////////////////////////////////
////
//Liskov Substitution
/*
var account = new LiskovSubstitution.Before.FixedDepositAccount("Issam", 10_000);
account.Withdraw(1000);
*/
/*
var account = new LiskovSubstitution.After.CheckingAccount("Issam", 10_000);
account.Withdraw(1000);

//var account = new LiskovSubstitution.After.FixedDepositAccount("Issam", 10_000);
//account.Withdraw(1000); // won't work
*/
////////////////////////////////////////////////
////
// Interface Segregation
/*
var employees = InterfaceSegregation.Before.Repository.LoadEmployees();
foreach (var e in employees)
{
    Console.WriteLine(e.PrintSalarySlip());
    Console.WriteLine();
}
*/
/*
var employees = InterfaceSegregation.After.Repository.LoadEmployees();
foreach (var e in employees)
{
    Console.WriteLine(e.PrintSalarySlip());
    Console.WriteLine();
}
*/
////////////////////////////////////////////////
////
// Dependency Inversion
/*
var customers = DependencyInversion.Before.Repository.Customers;

foreach (var customer in customers)
{
    var notificationService = new DependencyInversion.Before.NotificationService(customer);
    notificationService.Notify();
}
*/
/////////////After/////////
//var customers = DependencyInversion.After.Repository.Customers;
//foreach(var customer in customers)
//{
//    var messageService = new List<DependencyInversion.After.IMessageService>
//    {
//        new DependencyInversion.After.EmailService { EmailAddress =  customer.EmailAddress },
//        new DependencyInversion.After.SMSService { MobileNo =  customer.MobileNo },
//        new DependencyInversion.After.MailService { Address =  customer.Address }
//    };

//    // constructor injection
//    /*
//    var notificationService = new DependencyInversion.After.NotificationService(messageService);
//    notificationService.Notify();
//    */

//    // property injection
//    /*
//    var notificationService1 = new DependencyInversion.After.NotificationService1();
//    notificationService1.SetServices(messageService);
//    notificationService1.Notify();
//    */

//    // Method injection
//    /*
//    var notificationService2 = new DependencyInversion.After.NotificationService2();
//    notificationService2.Notify(messageService);
//    */
//}
////////////////////////////////////////////////
////
// Loosly VS Tight coupling
////////
// Tighly Coupled
/*
Loose_Vs._Tight_Coupling.Before.NotificationService notificationService = new Loose_Vs._Tight_Coupling.Before.NotificationService(new Loose_Vs._Tight_Coupling.Before.EmailService(),new SmsService());
notificationService.Notify();
*/
// Loosly Coupled


var serviceMode = Loose_Vs._Tight_Coupling.After.NotificationModeFactory.Create(NotificationMode.EMAIL);
Loose_Vs._Tight_Coupling.After.NotificationService notificationService = new Loose_Vs._Tight_Coupling.After.NotificationService(serviceMode);
notificationService.Notify();


