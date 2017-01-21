using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var photosTaken = long.Parse(Console.ReadLine());
            var secondsNeedToSee = long.Parse(Console.ReadLine());
            var percentUploadPhotos = long.Parse(Console.ReadLine());
            var secondsNeedToUpload = long.Parse(Console.ReadLine());

            double uploadPhotos = Math.Ceiling(photosTaken * percentUploadPhotos / 100.0);
            long totalSecondsNeeded = photosTaken * secondsNeedToSee + (long)uploadPhotos * secondsNeedToUpload;
            long tempSeconds = totalSecondsNeeded;

            long resultDay = tempSeconds / 86400;
            tempSeconds = tempSeconds - resultDay * 86400;

            var resultHour = tempSeconds / 3600;
            tempSeconds = tempSeconds - resultHour * 3600;

            var resultMin = tempSeconds / 60;
            tempSeconds = tempSeconds - resultMin * 60;

            var resultSeconds = tempSeconds;

            Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", resultDay, resultHour, resultMin, resultSeconds);
            //TimeSpan time = TimeSpan.FromSeconds(totalSecondsNeeded);
            //Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}",time.Days, time.Hours,time.Minutes,time.Seconds);
        }
    }
}
