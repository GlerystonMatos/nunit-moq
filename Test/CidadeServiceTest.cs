using Aplicacao;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class CidadeServiceTest
    {
        private CidadeService _cidadeService;
        private Mock<CidadeRepository> _mockCidadeRepository;

        [SetUp]
        public void SetUp()
        {
            _mockCidadeRepository = new Mock<CidadeRepository>();
            _cidadeService = new CidadeService(_mockCidadeRepository.Object);
        }

        [Test]
        public void CreateTest()
        {
            Cidade cidade = new Cidade("Fortaleza");
            _mockCidadeRepository.Setup(r => r.Create(cidade)).Returns(true);
            Assert.IsTrue(_cidadeService.Create(cidade));
        }

        [Test]
        public void UpdateTest()
        {
            Cidade cidade = new Cidade("Fortaleza");
            _mockCidadeRepository.Setup(r => r.Update(cidade)).Returns(true);
            Assert.IsTrue(_cidadeService.Update(cidade));
        }

        [Test]
        public void RemoveTest()
        {
            Cidade cidade = new Cidade("Fortaleza");
            _mockCidadeRepository.Setup(r => r.Remove(cidade)).Returns(true);
            Assert.IsTrue(_cidadeService.Remove(cidade));
        }

        [Test]
        public void GetAllTest()
        {
            IList<Cidade> cidades = new List<Cidade>();
            cidades.Add(new Cidade("Fortaleza"));

            _mockCidadeRepository.Setup(r => r.GetAll()).Returns(cidades.AsQueryable());
            Assert.IsNotNull(_cidadeService.GetAll());
            Assert.AreEqual(cidades.Count, _cidadeService.GetAll().ToList().Count);
        }

        [Test]
        public void FindByIdTest()
        {
            Cidade cidade = new Cidade("Fortaleza");
            _mockCidadeRepository.Setup(r => r.FindById(cidade.Id)).Returns(cidade);
            Assert.IsNotNull(_cidadeService.FindById(cidade.Id));
            Assert.AreEqual(cidade.Id, _cidadeService.FindById(cidade.Id).Id);
        }
    }
}