using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99999-9999", modelo: "Modelo Nokia", imei: "teste", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "11111-1111", modelo: "Modelo Iphone", imei: "testando", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");