using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
//https://chromedriver.chromium.org/ documentação do chromedriver
namespace NUnitTest
{
    [TestFixture]
    public class Tests
    {
        public IWebDriver googleWebdriver;

        public String urlBase;

        public ExtentReports reports;
        public ExtentTest test;

        [OneTimeSetUp]
        public void ExtentStart(){
            
            reports = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"\\...");
            reports.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose(){
            reports.Flush();
        }
        //[OneTimeSetUp]
        //metodo abaixo realizará a configuração inicial do teste
        //o termo OneTimeSetUp identifica o metodo que será chamado imediatamente uma unica vez
        //indempendente da quantidade de testes.
        [SetUp]//metodo abaixo realizará a configuração inicial do teste
        //o termo SetUp identifica o metodo que será chamado imediatamente ao
        //inicio de cada um dos testes.
        public void abrirChrome()
        {
            var options = new ChromeOptions();
            //options.AddArgument("no-sandbox");//desabilita o modo sandbox do chrome
            options.AddArguments(new List<string>() { "no-sandbox", "headless", "disable-gpu" });
            //googleWebdriver = new ChromeDriver(options);//cria objeto utilzando a classe ChromeDriver
            googleWebdriver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub/"), options);
            googleWebdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            googleWebdriver.Manage().Window.Maximize();//faz com que o navegador fique em tela cheia
            urlBase = "https://pt.wikipedia.org/wiki/";

        }
        //[OneTimeTearDown]
        //metodo abaixo lida com a finalização do teste
        //o termo OneTimeTearDown identifica o metodo que será
        //chamado imediatamente ao final de todos os testes.
        [TearDown]//metodo abaixo lida com a finalização do teste
        //o termo TearDown identifica o metodo que será chamado imediatamente
        //ao final de cada teste.
        public void fecharChrome(){
            try{
                Console.WriteLine("Terminando teste.....");
                googleWebdriver.Quit();
            }
            catch(Exception e){
                Console.WriteLine(e.ToString());
            }
        }
        [Test]
        public void Test1()
        {
            try{
                test = reports.CreateTest("Test1").Info("Teste Iniciou");
                test.Log(Status.Info, "Chromer Browser Iniciado");
                googleWebdriver.Navigate().GoToUrl(urlBase+"COVID-19");
                test.Log(Status.Info, "Navegando até url definida");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                test.Log(Status.Info, "Titulo da pagina capturado");
                Assert.AreEqual("COVID-19", stringTitulo);
                test.Log(Status.Pass, "Test1 validado, OK");
                
            }
            
            catch(Exception e){
                test.Log(Status.Fail, "Test1 validado, Erro");
                Console.WriteLine(e.ToString());
            }
        }
        [Test]
        public void Test2(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"NASA");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("NASA", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test3(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ritual");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ritual", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test4(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Religião");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Religião", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test5(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Educação");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Educação", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test6(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Conhecimento");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Conhecimento", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test7(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ensino");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ensino", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test8(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"NASA");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("NASA", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test9(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ritual");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ritual", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test10(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Religião");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Religião", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test11(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Educação");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Educação", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test12(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Conhecimento");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Conhecimento", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test13(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ensino");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ensino", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test14(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"NASA");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("NASA", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test15(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ritual");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ritual", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test16(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Religião");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Religião", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test17(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Educação");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Educação", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test18(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Conhecimento");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Conhecimento", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test19(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ensino");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ensino", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test20(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"NASA");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("NASA", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test21(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ritual");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ritual", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test22(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Religião");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Religião", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test23(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Educação");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Educação", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test24(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Conhecimento");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Conhecimento", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test25(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ensino");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ensino", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test26(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"NASA");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("NASA", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test27(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ritual");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ritual", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test28(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Religião");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Religião", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test29(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Educação");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Educação", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test30(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Conhecimento");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Conhecimento", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test31(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ensino");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ensino", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test32(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"NASA");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("NASA", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test33(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ritual");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ritual", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test34(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Religião");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Religião", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test35(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Educação");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Educação", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test36(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Conhecimento");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Conhecimento", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test37(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ensino");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ensino", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test38(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"NASA");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("NASA", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test39(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ritual");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ritual", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test40(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Religião");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Religião", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test41(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Educação");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Educação", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test42(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Conhecimento");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Conhecimento", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Test43(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"Ensino");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Ensino", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
