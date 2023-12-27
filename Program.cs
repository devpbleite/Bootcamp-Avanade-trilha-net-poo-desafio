using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(
  numero: "97653424", 
  modelo: "Nokia 3310", 
  imei: "11111111", 
  memoria: 64
);

Console.WriteLine(nokia.Numero);
Console.WriteLine(nokia.Modelo);
Console.WriteLine(nokia.IMEI);
Console.WriteLine(nokia.Memoria);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(
  numero: "978654567", 
  modelo: "Iphone 15", 
  imei: "22222222", 
  memoria: 256
);

Console.WriteLine(iphone.Numero);
Console.WriteLine(iphone.Modelo);
Console.WriteLine(iphone.IMEI);
Console.WriteLine(iphone.Memoria);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

