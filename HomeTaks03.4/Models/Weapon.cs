using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaks03._4
{
    internal class Weapon
    {
        int _bulletCapacity;
        int _bulletCaunt;
        int _finishTime;
        private bool _single = true;

        public int BulletCapacity {  get { return _bulletCapacity; } set {  _bulletCapacity = value; } }
        public int BulletCaunt { get { return _bulletCaunt;} set { _bulletCaunt = value;} }
        public int FinishTime {  get { return _finishTime; } set {  _finishTime = value; } }
        public bool Single { get { return _single; } set { _single = value; } } 

        public Weapon(int bulletCapacity,int bulletcaunt,int finishtime,bool single) 
        {
            _bulletCapacity = bulletCapacity;
            _bulletCaunt = bulletcaunt;
            _finishTime = finishtime;
            _single = single;

        }
        public void Shot()
        {
            if (BulletCaunt > 0)
            {
                Console.WriteLine("PARRTTT");
                BulletCaunt--;
            }
            else { Console.WriteLine("Silahda gulle yoxdur zehmet olmasa reloud ele.Dusmenler gelir"); }
        } 
        public void Fire()
        {
            if (BulletCaunt > 0) 
            {
                Console.WriteLine("Butun gulleri bosaltdin");
                Console.WriteLine("Gulleler "+BulletCaunt*FinishTime+"saniyeyey bitdi");
                BulletCaunt = 0;
            }
            else
            {
                Console.WriteLine( "Silahda gulle yoxdur zehmet olmasa reloud ele. Dusmenler gelir");
            }
        }

        public void GetRemainBulletCount()
        {
            Console.WriteLine("Daragin tam dolmasi ucun lazim olan gulle sayi" + " "+ (BulletCapacity-BulletCaunt));
        }

        public void Reloud()
        {
            BulletCaunt=BulletCapacity;
            Console.WriteLine("Reloud olundu");
        }
        public void ChangeFireMode()
        {
            if (Single)
            {
                Single= false;
                Console.WriteLine("Silah otamatike cevrildi");
            }
            else if (!Single)
            {
                Single = true;
                Console.WriteLine("Silah tekliye cevrildi");
            }

        }



    }
}
