// int employeeLevel = 400;
// string employeeName = "Andrew Carroll";

// string title = "";

// switch (employeeLevel)
// {
//   case 100:
//   case 200:
//     title = "Senior Associate";
//     break;
//   case 300:
//     title = "Manager";
//     break;
//   case 400:
//     title = "Senior Manager";
//     break;
//   default:
//     title = "Associate";
//     break;
// }

// Console.WriteLine($"{employeeName} is a {title}.");

// SKU = Stock Keeping Unit.
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

// creates product array ["01", "MN", "L"]
string[] product = sku.Split('-');
string type = "";
string color = "";
string size = "";

Console.WriteLine($"Initial Values: {product[0]}, {product[1]}, {product[2]}");

switch (product[0])
{
  case "01":
    type = "Sweat shirt";
    break;
  case "02":
    type = "T-Shirt";
    break;
  case "03":
    type = "Sweat pants";
    break;
  default:
    type = "Other";
    break;
}

switch (product[1])
{
  case "BL":
    color = "Black";
    break;
  case "MN":
    color = "Maroon";
    break;
  case "WH":
    color = "White";
    break;
  default:
    color = "Other";
    break;
}

switch (product[2])
{
  case "S":
    size = "Small";
    break;
  case "M":
    size = "Medium";
    break;
  case "L":
    size = "Large";
    break;
  default: 
    size = "One size fits all";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");