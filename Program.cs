using DesafioPOONet.Models;

Console.WriteLine("testando Nokia:");
Smartphone nokia = new Nokia("9999-9999", "Nokia X", "11111111111", 64);
nokia.Ligar();
nokia.ReceberLigação();
nokia.InstalarAplicativo("Spotfy");

Console.WriteLine("\nTestando o iPhone:");
Smartphone iphone = new Iphone("987654321", "iPhone 12", "222222222222222", 128);
iphone.Ligar();
iphone.ReceberLigação();
iphone.InstalarAplicativo("Instagram");