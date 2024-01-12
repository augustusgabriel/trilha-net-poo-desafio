using DesafioPOO.Models;

// TODO: Realizando os testes com as classes Nokia e Iphone
    Console.WriteLine("Smartphone Nokia:");
    Nokia nokia = new("0000-0000", "tijolao", "111111111", "64");

    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("Whatsapp");

    Console.WriteLine("\n");

    Console.WriteLine("Smartphone Iphone:");
    Iphone iphone = new("1111-1111", "13 pro", "222222222", "128");

    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Instagram");