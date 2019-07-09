// "vehicles": [
//     {
//         "vehicle": {
//             "year": "2008",
//             "model": "Damfresh",
//             "make": "Biotraxquote",
//             "color": "sky magenta"
//         },
//         "sales_agent": {
//             "mobile": "(896) 478-6975",
//             "last_name": "Botsford",
//             "first_name": "Shaina"
//         },
//         "credit": {
//             "credit_provider": "J.P.Morgan Chase & Co",
//             "account": "601109582720302"
//         }
//     },
//     {
//         "vehicle": {
//             "year": "2010",
//             "model": "Hotquadtrax",
//             "make": "Transtintechno",
//             "color": "robin egg blue"
//         },
//         "sales_agent": {
//             "mobile": "562.300.2912",
//             "last_name": "Davis",
//             "first_name": "Gerardo"
//         },
//         "credit": {
//             "credit_provider": "PNC Financial Services",
//             "account": "34578280562836"
//         }
//     }
// ]

// List<Dictionary<string, string>> vehicle1 = new List<Dictionary<string, string>>();

// Dictionary<string, string> vehicleInfo1 = new Dictionary<string, string>() {
//     {"year", "2008"},
//     {"model", "Damfresh"},
//     {"make", "Biotraxquote"},
//     {"color", "sky magenta"}
// };

// Dictionary<string, string> salesAgent1 = new Dictionary<string, string>() {
//     {"mobile", "(896) 478-6975"},
//     {"last_name", "Botsford"},
//     {"first_name", "Shaina"}
// };

// Dictionary<string, string> credit1 = new Dictionary<string, string>() {
//     {"credit_provider", "J.P.Morgan Chase & Co"},
//     {"account", "601109582720302"}
// };

// List<Dictionary<string, string>> vehicle2 = new List<Dictionary<string, string>>();

// Dictionary<string, string> vehicleInfo2 = new Dictionary<string, string>() {
//     {"year", "2010"},
//     {"model", "Hotquadtrax"},
//     {"make", "Transtintechno"},
//     {"color", "robin egg blue"}
// };

// Dictionary<string, string> salesAgent2 = new Dictionary<string, string>() {
//     {"mobile", "562.300.2912"},
//     {"last_name", "Davis"},
//     {"first_name", "Gerardo"}
// };

// Dictionary<string, string> credit2 = new Dictionary<string, string>() {
//     {"credit_provider", "PNC Financial Services"},
//     {"account", "34578280562836"}
// };


// // Adam's demo *******************************************************

// var ford = new Dictionary<string, string>
// {
//     {"Year", "1914"},
//     {"Make", "Ford"},
//     {"Model", "T"},
//     {"Price", "300"}
// };

// var tesla = new Dictionary<string, string>
// {
//     {"Year", "2017"},
//     {"Make", "Tesla"},
//     {"Model", "X"},
//     {"Price", "80100.45"}
// };

// var garage = new List<Dictionary<string, string>>();

// garage.Add(ford);
// garage.Add(tesla);

// var ford2 = new Car();
// ford2.Year = 2017;
// ford2.Make = "Ford"
// ford2.Model = "Fiesta"
// ford2.Price = 32500.65

// var tesla = new Car()
// {
//     Year = 2017,
//     Model = "X",
//     Make = "Tesla",
//     Price = 80000.42
// };

// var garage2 = new List<Car>()
// {
//     ford2, tesla2
// }

// class Car
// {
//     public int Year { get; set; }

//     public string Model { get; set; }

//     public string Make { get; set; }

//     public double Price
//     {
//         get; set: }
//     }
