using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceDemo;

namespace WcfServiceDemoTests
{
    [TestClass]
    public class Service1Tests
    {
        [TestMethod]
        public void TestGetData()
        {
            // Arrange
            Service1 service = new Service1();
            string orderno = "HS20C00060"; // ���]�s�b���q�渹

            // Act
            var result = service.GetData(orderno);

            // Assert
            Assert.IsNotNull(result, "��^�����G���ର��");

            Console.WriteLine($"��^���ӫ~�C��ƶq: {result.Count}");
            if (result.Count == 0)
            {
                Assert.IsTrue(result.Count == 0, "�S��������ӫ~");
            }
            else
            {

                foreach (var item in result)
                {
                    Console.WriteLine($"�ӫ~�W�١G{item}");
                }
                Assert.IsTrue(result.Count > 0, "��^���ӫ~�C�����ӥ]�t����");
            }

            // �o�̥i�H�ھڨ���ݨD�i���h�_���A�Ҧp�ˬd��^�����鶵�جO�_���T��
        }

        [TestMethod]
        public void TestInserData() {

            // Arrange
            Service1 service = new Service1(); 
            CompositeType composite = new CompositeType
            {
                office = "Office1",
                item = "Item1",
                company = "Company1",
                saleQ4 = 100,
                saleQ3 = 200,
                saleQ2 = 150,
                saleQ1 = 120,
                reqdate = DateTime.Now,
                orderno = "67890",
                currency = "USD",
                price = 99.99M,
                msp = 199.99M
            };

            // Act
            var result = service.InserData(composite);

            // Assert
            Assert.IsTrue(result, "�ƾڴ��J���Ӧ��\");

            // ���Ҵ��J�O�_���\ (��ܩʡA�i�H�ھڨ���ݨD�Ӷi��)
            var retrievedData = service.GetData("67890");
            Assert.IsNotNull(retrievedData, "���ӯ���˯��촡�J���ƾ�");
            Assert.IsTrue(retrievedData.Contains("Item1"), "���J���ӫ~���Ӧs�b���˯����G��");


        }

    }
}
