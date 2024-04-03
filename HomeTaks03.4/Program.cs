namespace HomeTaks03._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon=new Weapon(bulletCapacity:30,bulletcaunt:30,finishtime:2,true);
            while (true) 
            { 
            Console.WriteLine("0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Proqramdan dayandırmaq üçün\r\nqısayoldur.\n7 - Redaktə et :");
            string choose=Console.ReadLine();
                switch (choose)
                {
                    case "0":
                        Console.WriteLine($"Daragin tutumu:{weapon.BulletCapacity}\nGulle sayi:{weapon.BulletCaunt}\nGullerin bitme vaxti:{weapon.FinishTime}\nSilah teklidedir:{weapon.Single} \n");
                       
                       
                        break;
                        case "1":
                        weapon.Shot();
                        break;
                        case "2":
                        weapon.Fire();
                        break;
                        case "3":
                        weapon.GetRemainBulletCount();
                        break;
                        case "4":
                        weapon.Reloud();
                       break;
                        case "5":
                        weapon.ChangeFireMode();
                        break;
                        case "6":
                       
                    case "7":
                        Console.WriteLine("Y\nS\nD");
                        string minichoose =Console.ReadLine();
                        switch(minichoose)
                        {
                            case "y":
                                int value=int.Parse(Console.ReadLine());
                                Console.WriteLine("capasite sayi="+(value+weapon.BulletCapacity));
                                break;
                            //case "Y":
                            //    int num = int.Parse(Console.ReadLine());
                            //    Console.WriteLine("deyisdikden soraki sayi:"+(num + weapon.BulletCapacity));  //muellim bunlarida verdimki isdifadeci boyuk kicik yazanda yene islesin
                            //    break;
                            case "s":
                                int sum=int.Parse(Console.ReadLine());
                                Console.WriteLine( "gule sayi ="+(sum+weapon.BulletCapacity));
                                break;
                            //case "S":
                            //    int sum2=int.Parse(Console.ReadLine());
                            //    Console.WriteLine("gule sayi ="+(sum2 + weapon.BulletCapacity));
                            //    break;
                            case "d":
                                int time=int.Parse(Console.ReadLine());
                                Console.WriteLine("reload olma vatdi:"+(time+weapon.FinishTime));
                                break;
                            //case "D":
                            //    int time2=int.Parse(Console.ReadLine());
                            //    Console.WriteLine("sifirlanma saniyesi ="+(time2+weapon.FinishTime));
                            //    break;
                            default: Console.WriteLine("Menyuda olan ededi secin zehmet olmasa!!");
                                break;


                        }
                        break;
                        return;

                    default: Console.WriteLine("Menyuda olan ededi secin zehmet olmasa!!!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();







            }
        }
    }
}
