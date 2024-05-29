using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "98765-4321", modelo: "Md55555DS", imei: "A0001b2222", memoria: 254);
Console.WriteLine($"Smartphone Nokia:\n Número: {nokia.Numero}.");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "87654-3210", modelo: "MI202020CX", imei: "C4455W6666", memoria: 128);
Console.WriteLine($"Smartphone iPhone:\n Número: {iphone.Numero}.");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
