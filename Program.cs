using DesafioPOO.Models;

Iphone iphone = new("(83) 3121-4746","IPhone 11","356656422302496", 64);
Nokia nokia = new("(65) 3299-9284","Nokia C01 Plus","466657422302099", 35);

iphone.Ligar();
nokia.Ligar();

iphone.ReceberLigacao();
nokia.ReceberLigacao();

iphone.InstalarAplicativo("Angry Birds 2");
nokia.InstalarAplicativo("Nubank");