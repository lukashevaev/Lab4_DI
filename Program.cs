using System;

namespace Lab4
{
    /// <summary>
    /// Конструктор класса Browser(зависимость встраивается через публичный метод класса-клиента)
    /// <param name="br_name">Название браузера</param>
    /// <param name="GetInformation">Метод для вывода названия компании</param>
    /// <param name="getMethods">Метод для начала поиска нужных методов</param>
    /// </summary>
    public class Browser
    {
        string br_name;
        public void GetInformation()
        {
            Console.WriteLine(br_name);
        }
        public void getMethods(string br_name)
        {
            Console.WriteLine("вызов нужных методов");
        }
    }
    /// <summary>
    /// Конструктор класса Google и его методы
    /// <param name="GoogleAutentificator">Метод для аутентификации</param>
    /// <param name="BlogSearch">Метод для поиска блогов</param>
    /// <param name="CodeSearch">Метод для поиска кодов</param>
    /// </summary>
    public class Google:Browser
    {
        public void GoogleAutentificator()
        {
            Console.WriteLine("Метод для аутентификации");
        }
        public void BlogSearch()
        {
            Console.WriteLine("Метод для поиска блогов");
        }
        public void CodeSearch()
        {
            Console.WriteLine("Метод для поиска кодов");
        }
        public void Finance()
        {
            Console.WriteLine("Метод для финансов");
        }

    }
    /// <summary>
    /// Конструктор класса Baidu и его методы
    /// <param name="BaiduIND">Метод для поиска акций</param>
    /// <param name="BaiduZhidao">Метод как мэйл ру</param>
    /// <param name="BaiduBaike">Метод энциклопедия</param>
    /// </summary>
    public class Baidu:Browser
    {

        public void BaiduIND()
        {
            Console.WriteLine("Метод для поиска акций");
        }
        //mail
        public void BaiduZhidao()
        {
            Console.WriteLine("Метод как мэйл ру");
        }
        //viki
        public void BaiduBaike()
        {
            Console.WriteLine("Метод энциклопедия");
        }
    }
    /// <summary>
    /// Конструктор класса Yandex и его методы
    /// <param name="Video">Метод для видео</param>
    /// <param name="Dzen">Метод для статей</param>
    /// <param name="Maps">Карты</param>
    /// </summary>
    public class Yandex:Browser
    {
        public void Video()
            {
            Console.WriteLine("видео");
        }
        public void Dzen()
        {
            Console.WriteLine("Дзен");
        }
        public void Maps()
        {
            Console.WriteLine("Карты");
        }
    }
    /// <summary>
    /// Точка входа для приложения
    /// <param name="version">Переменная содержащая версию</param>
    ///  <param name="br">Переменная для работы с методами браузера</param>
    /// </summary>
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Google, Yandex or Baidu?");
            string version = Console.ReadLine().ToLower();
            if (version != "google" && version != "baidu" && version != "yandex")
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Browser br = new Browser();
                br.getMethods(version);
                br.GetInformation();
                string s = Console.ReadLine();
                String[] methods = s.Split(' ');
            Google gl = new Google();
            Baidu b = new Baidu();
            Yandex ya = new Yandex();
                if (version == "google"){
                    foreach (string meth in methods)
                    {
                        if (meth == "GoogleAutentificator") gl.GoogleAutentificator();
                        else if (meth == "BlogSearch") gl.BlogSearch();
                        else if (meth == "CodeSearch") gl.CodeSearch();
                        else if (meth == "Finance") gl.Finance();
                        else { Console.WriteLine("Wrong method"); }
                    }
                }
               
                if (version == "baidu") {
                    foreach (string meth in methods)
                    {
                        if (meth == "BaiduIND") b.BaiduIND();
                        else if (meth == "BaiduZh") b.BaiduZhidao();
                        else if (meth == "BaiduBaike") b.BaiduBaike();
                        else { Console.WriteLine("Wrong method"); }
                    }
                }
                
                if (version == "yandex") {
                    foreach (string meth in methods)
                    {
                        if (meth == "Maps") ya.Maps();
                        else if (meth == "Video") ya.Video();
                        else if (meth == "Dzen") ya.Dzen();
                        else { Console.WriteLine("Wrong method"); }
                    }
                }
               

            }

            Console.ReadKey();
        }

    }

}