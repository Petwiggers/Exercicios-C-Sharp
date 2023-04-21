using Exercicios_03_ao_10;

Proprietario proprietario1 = new Proprietario();
proprietario1.Nome = "Joana";
proprietario1.Cpf = "01523177709";
proprietario1.Telefone = "478767425";
Proprietario proprietario2 = new Proprietario("Peterson", "01523178809", "498785225");
Proprietario proprietario3 = new Proprietario("Ricardo", "01323177809", "478785225");

Carro carro1 = new Carro("Seat", "Cordoba SXE 1.8 / GLX 1.8 4p", "1995", "KIA8858", "Prata", proprietario1);
Carro carro2 = new Carro("Daihatsu", "Applause 1.6 16V", "1994", "DCD6815", "Amarelo", proprietario2);
Carro carro3 = new Carro("BMW", "428i Cabriolet Sport 2.0 TB 245cv 2p", "2015", "MYG2480", "Dourado", proprietario3);
