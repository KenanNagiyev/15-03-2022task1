using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20.Models
{
    class Weapon
    {
        public int bulletCap;
        public int bulletCount;
        public double time;
        public bool auto = true;
        public Weapon()
        {

        }

        public Weapon(int bulletCap, int bulletCount, double time, bool auto)
        {
            this.bulletCap = bulletCap;
            this.bulletCount = bulletCount;
            this.time = time;
            this.auto = auto;
            if (bulletCount > bulletCap)
            {
                Console.WriteLine("Xeberdarliq:gulle sayi tutumdan cox ola bilmez");
            }

        }
        public void GetInfo()
        {
            Console.WriteLine($"gulle tutumu:{ bulletCap}");
            Console.WriteLine($"gulle sayi:{ bulletCount}");
            Console.WriteLine($"vaxti:{ time}");
        }
        public void Shoot()
        {


            if (bulletCount <= 0)
            {
                Console.WriteLine("Gulle yoxdur");
            }
            else if (auto == true)
            {

                bulletCount--;

                if (bulletCount > 0)
                {
                    bulletCount--;
                    Console.WriteLine("part");

                }
                else
                {
                    Console.WriteLine("Gulle yoxdur");
                }

            }
        }

        public void Fire()
        {
            double shootbullets = 0;
            if (bulletCount == 0)
            {
                Console.WriteLine("gulle  yoxdur");
                return;
            }
            if (auto)
            {
                while (bulletCount > 0)
                {
                    bulletCount--;
                    shootbullets++;
                    Console.WriteLine(shootbullets);
                }
            }
            else
            {
                while (bulletCount > 0)
                {
                    bulletCount--;
                    shootbullets++;
                    Console.WriteLine(shootbullets);
                }
            }
            shootbullets *= (bulletCap / time);
            Console.WriteLine($"gulle bu qeder vaxta atildi:{shootbullets}");
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine(bulletCap - bulletCount);
        }
        public void Reload()
        {
            if (bulletCap - bulletCount == 0)
            {
                Console.WriteLine("doludur");
            }
            else
            {
                Console.WriteLine(bulletCap - bulletCount);
                bulletCount = bulletCap;
            }
        }
    }
}
