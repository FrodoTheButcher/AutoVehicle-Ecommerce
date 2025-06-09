using AutoEcommerce.Domain.Users;

namespace AutoEcommerce.Database
{
  public class Database
  {
    const string CommandToCreateDatabase = @"Create Database if not exists";
    const string CommandToCreateUserTable = @"Create table User if not exists with values ";
    const string CommandToCreateProductsTable = @"Create table products if not exists with values";
    const string CommandToCreateFinalBasketTable = @"";
    const string CommandToCreateBasketItemTable = @"";
    public Database()
    {
      InitDatabase();
      InitTables();
    }
    public void InitTables()
    {
    }
    public void InitDatabase()
    {
    }
  }

}
