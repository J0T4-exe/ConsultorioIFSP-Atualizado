using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSPContext;
using IFSPStore.Repository.Repository;
using System.Text.Json;

namespace ConsultorioIFSP.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        // Os testes TestCategory e TestProduct foram removidos ou comentados para focar
        // apenas nas entidades do Consultório Médico, conforme solicitado.

        // --- Testes para as entidades do Consultório Médico ---

        [TestMethod]
        public void TestMedico()
        {
            // Construtor: (int id, string nome, string login, string password, string especialidade, string crm, string telefone)
            var medico = new Medico(0, "Dr. João Silva", "jsilva", "12345", "Cardiologia", "CRM/SP 123456", "11987654321");

            using (var context = new MySqlContext())
            {
                var repository = new BaseRepository<Medico>(context);
                repository.Insert(medico);
                Console.WriteLine("Medico Insert Done!");

                var retrievedMedico = repository.Select(medico.Id);
                Console.WriteLine("Medico Retrieved:");
                Console.WriteLine(JsonSerializer.Serialize(retrievedMedico));
                Assert.IsNotNull(retrievedMedico);
                Assert.AreEqual("Dr. João Silva", retrievedMedico.Nome);
            }
        }

        [TestMethod]
        public void TestPaciente()
        {
            // Construtor: (int id, string nome, string email, DateTime dataNascimento, string sexo, string telefone)
            var paciente = new Paciente(0, "Maria Souza", "maria@email.com", new DateTime(1985, 10, 20), "Feminino", "11998877665");

            using (var context = new MySqlContext())
            {
                var repository = new BaseRepository<Paciente>(context);
                repository.Insert(paciente);
                Console.WriteLine("Paciente Insert Done!");

                var retrievedPaciente = repository.Select(paciente.Id);
                Console.WriteLine("Paciente Retrieved:");
                Console.WriteLine(JsonSerializer.Serialize(retrievedPaciente));
                Assert.IsNotNull(retrievedPaciente);
                Assert.AreEqual("Maria Souza", retrievedPaciente.Nome);
            }
        }

        [TestMethod]
        public void TestMedicamento()
        {
            // Construtor: (int id, String nome, String nome_Generico)
            var medicamento = new Medicamento(0, "Paracetamol", "Acetaminofeno");

            using (var context = new MySqlContext())
            {
                var repository = new BaseRepository<Medicamento>(context);
                repository.Insert(medicamento);
                Console.WriteLine("Medicamento Insert Done!");

                var retrievedMedicamento = repository.Select(medicamento.Id);
                Console.WriteLine("Medicamento Retrieved:");
                Console.WriteLine(JsonSerializer.Serialize(retrievedMedicamento));
                Assert.IsNotNull(retrievedMedicamento);
                Assert.AreEqual("Paracetamol", retrievedMedicamento.Nome);
            }
        }

        [TestMethod]
        public void TestReceita()
        {
            // Construtor: (int id, DateTime periodo, int quantidade)
            var receita = new Receita(0, DateTime.Now.Date.AddDays(7), 1);

            using (var context = new MySqlContext())
            {
                var repository = new BaseRepository<Receita>(context);
                repository.Insert(receita);
                Console.WriteLine("Receita Insert Done!");

                var retrievedReceita = repository.Select(receita.Id);
                Console.WriteLine("Receita Retrieved:");
                Console.WriteLine(JsonSerializer.Serialize(retrievedReceita));
                Assert.IsNotNull(retrievedReceita);
                Assert.AreEqual(1, retrievedReceita.Quantidade);
            }
        }

        [TestMethod]
        public void TestConsulta()
        {
            // Construtor: (int id, DateTime dataConsulta, TimeOnly horario)
            // Nota: Os campos Paciente e MedicoId foram adicionados para simular a
            // necessidade de chaves estrangeiras, mas seus valores são apenas placeholders (1).
            var consulta = new Consulta(0, DateTime.Now.Date, new TimeOnly(14, 30))
            {
                Paciente = 1, // Placeholder
                MedicoId = 1  // Placeholder
            };

            using (var context = new MySqlContext())
            {
                var repository = new BaseRepository<Consulta>(context);
                repository.Insert(consulta);
                Console.WriteLine("Consulta Insert Done!");

                var retrievedConsulta = repository.Select(consulta.Id);
                Console.WriteLine("Consulta Retrieved:");
                Console.WriteLine(JsonSerializer.Serialize(retrievedConsulta));
                Assert.IsNotNull(retrievedConsulta);
                Assert.AreEqual(consulta.Horario, retrievedConsulta.Horario);
            }
        }
    }
}