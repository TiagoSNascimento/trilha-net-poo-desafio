using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "351912578176", modelo: "Modelo I1", imei: "2222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "351912581544", modelo: "Modelo N1", imei: "3333333", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
