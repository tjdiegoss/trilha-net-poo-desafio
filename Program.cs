using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n = new Nokia("1234", "LumiaX19", "lkmcmsd8937", 64);
n.InstalarAplicativo("Instagram");
n.ReceberLigacao();

Console.WriteLine("\n");

Iphone ap = new Iphone("14587", "Iphone13 ProMax", "dsfs5454sdf", 120);
ap.InstalarAplicativo("Whatsapp");
ap.Ligar();