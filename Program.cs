using System.ComponentModel;
using DesafioPOO.Models;



Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "11111", modelo: "Modelo 2", imei: "33333", memoria: 44);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "55555", modelo: "Modelo 6", imei: "77777", memoria: 88);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");