using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo N1", imei: "111222333", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "321", modelo: "Modelo Iphone14", imei: "111222555", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
