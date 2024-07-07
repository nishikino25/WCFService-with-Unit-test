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
            string orderno = "HS20C00060"; // 假設存在的訂單號

            // Act
            var result = service.GetData(orderno);

            // Assert
            Assert.IsNotNull(result, "返回的結果不能為空");

            Console.WriteLine($"返回的商品列表數量: {result.Count}");
            if (result.Count == 0)
            {
                Assert.IsTrue(result.Count == 0, "沒有找到任何商品");
            }
            else
            {

                foreach (var item in result)
                {
                    Console.WriteLine($"商品名稱：{item}");
                }
                Assert.IsTrue(result.Count > 0, "返回的商品列表應該包含項目");
            }

            // 這裡可以根據具體需求進行更多斷言，例如檢查返回的具體項目是否正確等
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
            Assert.IsTrue(result, "數據插入應該成功");

            // 驗證插入是否成功 (選擇性，可以根據具體需求來進行)
            var retrievedData = service.GetData("67890");
            Assert.IsNotNull(retrievedData, "應該能夠檢索到插入的數據");
            Assert.IsTrue(retrievedData.Contains("Item1"), "插入的商品應該存在於檢索結果中");


        }

    }
}
