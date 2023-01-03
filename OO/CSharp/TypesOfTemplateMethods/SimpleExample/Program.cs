using SimpleExample.Classes;

var jsonParser = new CustomerDataJsonParser("./Files/customer_data.json");
var txtParser = new CustomDataTxtParser("./Files/customer_data.txt");

Console.WriteLine("JSON Parser: " + string.Join(" ", jsonParser.customerDataList.Select(x => "\n" + x.name + " " + x.address + " " + x.age)));
Console.WriteLine("========================================");
Console.WriteLine("TXT Parser: " + string.Join(" ", txtParser.customerDataList.Select(x => "\n" + x.name + " " + x.address + " " + x.age)));