// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using EnterpriseArchitecture;

int dbType = 1; // 1 SQL, 2 Oracle düşün

//if(dbType == 1)
//{
//    MsSqlOperations sqlServer  = new MsSqlOperations();
//    sqlServer.Insert();
//    sqlServer.Delete();
//    sqlServer.Update();
//    sqlServer.Read();
//}
//else if (dbType == 2)
//{
//    OracleOperations oracleServer = new OracleOperations();
//    oracleServer.Insert();
//    oracleServer.Delete();
//    oracleServer.Update();
//    oracleServer.Read();
//}

// Bunu abstract etmeliyim. Bir ara class hangi server'da çalışacağıma karar vermeli.
DbOperationsManager dbOpSql = new DbOperationsManager(new MsSqlOperations());
dbOpSql.Insert();
dbOpSql.Delete();
dbOpSql.Read();
dbOpSql.Update();

Console.WriteLine(new string('*', 50));

DbOperationsManager dbOpOracle = new DbOperationsManager(new OracleOperations());
dbOpOracle.Insert();
dbOpOracle.Delete();
dbOpOracle.Read();
dbOpOracle.Update();
