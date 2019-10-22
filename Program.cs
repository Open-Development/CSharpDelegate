using System;

namespace delegateDemo
{
    class Program
    {
        private delegate void DortIslem(double a, double b);
        private event DortIslem IslemGecersiz;

        static void Main(string[] args)
        {
            double a = 4.5, b = 2.5;
            DortIslem delege;

            MetodlariKaydet(out delege);
            Calistir(delege, ref a, ref b);
           
        }

        private static void Calistir(DortIslem delege, ref double a, ref double b){
            // Delegate[] functions = delege.GetInvocationList();

            // foreach (var item in functions)
            // {
            //     double result = (double)item.DynamicInvoke(a,b);
            //     Console.WriteLine($" {item.Method.Name} result: {result}");
            // }

            delege.Invoke(a,b);

            // delege(a,b);

            // IAsyncResult res = delege.BeginInvoke(a,b,null,null);
            // delege.EndInvoke(res);
        }

        private static void MetodlariKaydet(out DortIslem delege){
            delege = new DortIslem(Topla);            
            delege += Cikar;
            delege += Carp;
            delege += Bol;

        }

        private static void UyariYazdir(){
            Console.Write("Islem gecersiz");
        }

        private static void Topla(double a, double b){
            Console.WriteLine($" Topla result: {a+b}");
        }

        private static void Carp(double a, double b){
            Console.WriteLine($" Carp result: {a*b}");
        }

        private static void Bol(double a, double b){
            Console.WriteLine($" Bol result: {a/b}");
        }

        private static void Cikar(double a, double b){
             Console.WriteLine($" Cikar result: {a-b}");
        }
    }
}
