using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "kelly", sobrenome: "Rejane");
Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Joaquina");
//Pessoa p3 = new Pessoa(nome: "Maria", sobrenome: "Joaquina");

hospedes.Add(p1);
hospedes.Add(p2);
//hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 250);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Hospede: {p1.NomeCompleto}, Hospede: {p2.NomeCompleto}");
Console.WriteLine($"Quantidade de dias hospedados: {reserva.DiasReservados}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");