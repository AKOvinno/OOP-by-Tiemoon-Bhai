// ------------------ LIST --------------------
Console.WriteLine("---- List Example ----\n\n");
List<string> nameList = new List<string>();
nameList.Add("Hasan");
nameList.Add("Kayes");
nameList.Add("Ovinno");
nameList.Add("Alif");

foreach (string aName in nameList)
{
    Console.WriteLine(aName);
}

string name = nameList[2];
nameList.Remove("Alif");
nameList[0] = "Mahmudul";

Console.WriteLine("\nAccessed Name: " + name);
Console.WriteLine("\nAfter Modification:");
foreach (string aName in nameList)
{
    Console.WriteLine(aName);
}

// ------------------ HashSet -----------------
Console.WriteLine("\n\n---- HashSet Example ----\n\n");
HashSet<string> allRegistrationNo = new HashSet<string>();
allRegistrationNo.Add("11-00-001");
allRegistrationNo.Add("11-00-005");
allRegistrationNo.Add("22-00-001");
allRegistrationNo.Add("11-11-001");
allRegistrationNo.Add("11-00-001"); // Duplicate, will be ignored

foreach (string aRegiNo in allRegistrationNo)
{
       Console.WriteLine(aRegiNo);
}

// ------------------ Dictionary -----------------
Console.WriteLine("\n\n---- Dictionary Example ----\n\n");

Dictionary<string, double> salary = new Dictionary<string, double>();
salary.Add("emp-098", 25000);
salary.Add("emp-012", 34000);
salary.Add("emp-342", 11000);
salary.Add("emp-111", 25000);
Console.WriteLine("Employee Code || Salary Amount");
foreach (KeyValuePair<string, double> codeSalary in salary)
{
    Console.WriteLine(codeSalary.Key + " || " + codeSalary.Value);
}