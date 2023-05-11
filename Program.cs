using AbstracaoCelular.Models;

Nokia nokia = new Nokia("965144897", "Lumia 630", "000000-00-000000-0", "64");

Iphone iphone = new Iphone("947689514", "14 Pro Max", "111111-11-111111-1", "128");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

