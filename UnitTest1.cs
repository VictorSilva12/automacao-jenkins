using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
//https://chromedriver.chromium.org/ documentação do chromedriver
namespace NUnitTest
{
    public class Tests
    {
        public IWebDriver googleWebdriver;

        public String urlBase;
    
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
            options.AddArgument("no-sandbox");//desabilita o modo sandbox do chrome
            googleWebdriver = new ChromeDriver(options);//cria objeto utilzando a classe ChromeDriver
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
                googleWebdriver.Navigate().GoToUrl(urlBase+"COVID-19");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("COVID-19", stringTitulo);
                
            }
            
            catch(Exception e){
                Console.WriteLine(e.ToString());
            }
        }      
        public void Test2(){
            try{
                googleWebdriver.Navigate().GoToUrl(urlBase+"NASA");
                IWebElement titulo = googleWebdriver.FindElement(By.Id("firstHeading"));
                string stringTitulo = titulo.Text;
                Assert.AreEqual("Nasa", stringTitulo);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}