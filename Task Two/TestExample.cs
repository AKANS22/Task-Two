using System;
namespace Task_Two
{
    public class TestExample :  IEmptyInterface
    {
        public IExample example1;
        public TestExample(IExample example)
        {
            example1 = example;
        }

        public int GetNumber()
        {
            throw new NotImplementedException();
        }
    }
}



// actual class or object, u should implement the abstraction (Interfece and abstract class )

/* Dependency Injection 
    - constructor injection
    - method
    - properties

 DI Container -- microsoft dependency injection, Autofac simple injection lamar -- resolve register and dispose
 lifetime -- Singleton Transcient and Scope


  option
  Login
  Signup
    -- email
    -- password          list<User> 
    -- first name
    -- lastname           List<Account> List<transaxtio>
Acc No 0795985894 NUBAN
  Logout

  Create Account
  Print Account Details
  Print Account Statement 
  Account
    -- deposit
    -- withdraw
    -- check balance
    -- transfer money to another account
   print transaction 
    
  
 */