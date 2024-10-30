string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);

 Console.WriteLine(formattedLine);