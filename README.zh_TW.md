# WCFService-with-Unit-test

- en [English]([README.md](https://github.com/nishikino25/WCFService-with-Unit-test/blob/main/README.md))
- zh_TW [繁体中文](https://github.com/nishikino25/WCFService-with-Unit-test/blob/main/README.zh_TW.md)

在此 Repo 中，您將看到兩個C#專案，wcfservicedemo 是一個基本的網頁表單服務包含主程式碼與資料表，而WcfServiceDemoTests是一個MSTEST執行器，可以裡面包含對GetDate 以及InsertData兩種函數的單元測試。

![image](https://github.com/nishikino25/WCFService-with-Unit-test/assets/42590869/a974f188-c67f-4f55-ab55-5bf03a13bbb0)

## Requirements + Versions
Visual Studio 2022
.NET V4.8

## How to open project WcfServiceDemo
1. 右鍵點擊專案 WcfServiceDemo > 重建方案
2. 使用偵錯模式啟動 (Any CPU)
3. 成功啟動後，在 http://localhost:52411/InsertData.aspx 看到InsertData頁面

![image](https://github.com/nishikino25/WCFService-with-Unit-test/assets/42590869/97abdaef-ece7-4272-ac6e-f4fcf48cc70f)

## Unit test Example
1. 右鍵點擊專案 WcfServiceDemoTests > 重建方案
2. 打開測試資源管理器 (上方導覽列 Test > Test Explorer).
3. 按一下「全部執行」以執行測試並在「測試資源管理器」視窗中查看測試結果。

![image](https://github.com/nishikino25/WCFService-with-Unit-test/assets/42590869/cc6286fe-cc7c-4c65-8b99-dfe6dcf926a0)

