using scafold1.Models;
using System.Diagnostics;
namespace scafold1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Scafold1Context context)
        {
            // Look for any Aeronaves.
            if (context.Aeronaves.Any())
            {
                Debug.WriteLine("Database already seeded");
                return;   // DB has been seeded
            }
            var aeronaves = new Aeronave[]
            {
                new Aeronave{IdEmpresa=1, ModeloAeronave="Boeing 737", DataFabricacao=new DateOnly(2015,5,20), NumeroPoltronas=180, NumeroMaximoTripulantes=6, CapacidadeMaximaCombustivel=26000, CapacidadeMaximaVoo=5600},
                new Aeronave{IdEmpresa=2, ModeloAeronave="Airbus A320", DataFabricacao=new DateOnly(2018,3,15), NumeroPoltronas=150, NumeroMaximoTripulantes=5, CapacidadeMaximaCombustivel=24000, CapacidadeMaximaVoo=6100},
                new Aeronave{IdEmpresa=1, ModeloAeronave="Boeing 777", DataFabricacao=new DateOnly(2012,11,10), NumeroPoltronas=396, NumeroMaximoTripulantes=10, CapacidadeMaximaCombustivel=181000, CapacidadeMaximaVoo=9700}
            };
            foreach (Aeronave a in aeronaves)
            {
                context.Aeronaves.Add(a);
            }

            if (!context.Aeroportos.Any())
            {
                var aeroportos = new Aeroporto[]
                {
                    new Aeroporto { Nome = "Aeroporto Internacional de São Paulo", Cidade = "São Paulo", Estado = "SP"},
                    new Aeroporto { Nome = "Aeroporto Internacional do Rio de Janeiro", Cidade = "Rio de Janeiro", Estado = "RJ"},
                    new Aeroporto { Nome = "Aeroporto Internacional de Brasília", Cidade = "Brasília", Estado = "DF"}
                };
                foreach (Aeroporto ap in aeroportos)
                {
                    context.Aeroportos.Add(ap);
                }
            }

            if (!context.EmpresaAereas.Any())
            {
                var empresas = new EmpresaAerea[]
                {
                    new EmpresaAerea { Nome = "Azul Linhas Aéreas", Telefone = "0800-123-456", Cnpj = "12.345.678/0001-90" },
                    new EmpresaAerea { Nome = "Latam Airlines", Telefone = "0800-987-654", Cnpj = "98.765.432/0001-12" },
                    new EmpresaAerea { Nome = "Gol Linhas Aéreas", Telefone = "0800-555-333", Cnpj = "11.222.333/0001-44" }
                };
                foreach (EmpresaAerea e in empresas)
                {
                    context.EmpresaAereas.Add(e);
                }
            }

            if (!context.Escalas.Any())
            {
                var escalas = new Escala[]
                {
                    new Escala { IdEscala = 1, IdAeroportoEscala = 2, ChegadaEscala = new DateTime(2024, 7, 1, 11, 0, 0), SaidaEscala = new DateTime(2024, 7, 1, 15, 0, 0)},
                    new Escala { IdEscala = 2, IdAeroportoEscala = 3, ChegadaEscala = new DateTime(2024, 7, 2, 17, 0, 0), SaidaEscala = new DateTime(2024, 7, 2, 18, 30, 0)},
                    new Escala { IdEscala = 3, IdAeroportoEscala = 1, ChegadaEscala = new DateTime(2024, 7, 3, 10, 0, 0), SaidaEscala = new DateTime(2024, 7, 3, 12, 0, 0)}
                };
                foreach (Escala es in escalas)
                {
                    context.Escalas.Add(es);
                }
            }

            if (!context.Passageiros.Any())
            {
                var passageiros = new Passageiro[]
                {
                    new Passageiro { Nome = "João Silva", DataNascimento = new DateOnly(1990, 5, 15), Sexo = "Masculino", Cpf = "123.456.789-00", EstadoCivil = "Solteiro", Nacionalidade = "Brasileiro", Preferencial = false, Email = "josesilva@email.com", Telefone = "(00) 99999-9999" },
                    new Passageiro { Nome = "Maria Oliveira", DataNascimento = new DateOnly(1985, 8, 22), Sexo = "Feminino", Cpf = "987.654.321-00", EstadoCivil = "Casada", Nacionalidade = "Brasileira", Preferencial = false, Email = "mariaoliveira@email.com", Telefone = "(00) 98888-8888" },
                    new Passageiro { Nome = "Carlos Souza", DataNascimento = new DateOnly(1958, 3, 10), Sexo = "Masculino", Cpf = "456.789.123-00", EstadoCivil = "Divorciado", Nacionalidade = "Brasileiro", Preferencial = true, Email = "carlosouza@email.com", Telefone = "(00) 97777-7777" }
                };

                foreach (Passageiro p in passageiros)
                {
                    context.Passageiros.Add(p);
                }
            }

            if (!context.Passagens.Any())
            {
                var passagens = new Passagem[]
                {
                    new Passagem {IdPassageiro = 1, IdVoo = 1, NumeroPoltrona = "1", CheckinRealizado = true},
                    new Passagem {IdPassageiro = 2, IdVoo = 2, NumeroPoltrona = "2", CheckinRealizado = false},
                    new Passagem {IdPassageiro = 3, IdVoo = 3, NumeroPoltrona = "3", CheckinRealizado = true}
                };
                foreach (Passagem ps in passagens)
                {
                    context.Passagens.Add(ps);
                }
            }

            if (!context.Poltronas.Any())
            {
                var poltronas = new Poltrona[]
                {
                    new Poltrona { IdVoo = 1, NumeroPoltrona = "1A", TipoPoltrona = "Poltrona Simples", Lado = "direito", Ocupada = true},
                    new Poltrona { IdVoo = 1, NumeroPoltrona = "1B", TipoPoltrona = "Poltrona Simples", Lado = "esquerdo", Ocupada = false},
                    new Poltrona { IdVoo = 2, NumeroPoltrona = "2A", TipoPoltrona = "Poltrona Executiva", Lado = "direito", Ocupada = true}
                };
                foreach (Poltrona pl in poltronas)
                {
                    context.Poltronas.Add(pl);
                }
            }

            if (!context.Voos.Any())
            {
                var voos = new Voo[]
                {
                    new Voo { IdAeronave = 1, IdAeroportoOrigem = 1, IdAeroportoDestino = 2, Partida = new DateTime(2024, 7, 1, 10, 0, 0), Chegada = new DateTime(2024, 7, 1, 12, 0, 0) },
                    new Voo { IdAeronave = 2, IdAeroportoOrigem = 2, IdAeroportoDestino = 3, Partida = new DateTime(2024, 7, 2, 14, 0, 0), Chegada = new DateTime(2024, 7, 2, 16, 30, 0) },
                    new Voo { IdAeronave = 3, IdAeroportoOrigem = 3, IdAeroportoDestino = 1, Partida = new DateTime(2024, 7, 3, 9, 0, 0), Chegada = new DateTime(2024, 7, 3, 11, 45, 0) }
                };
                foreach (Voo v in voos)
                {
                    context.Voos.Add(v);
                }
            }



                context.SaveChanges();
            Debug.WriteLine("Database seeded successfully");
        }


    }
}
