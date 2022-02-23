using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryApplication.Models
{
    public static class Helper
    {

        public static Decades ConvertToDecade(DateTime dateTime)
        {
            switch (dateTime.Year)
            {
                case int n when n >= 1960 && n < 1970:
                    Decades decade1 = Decades.Sixies;
                    return decade1;
                case int n when n >= 1970 && n < 1980:
                    Decades decade2 = Decades.Seventies;
                    return decade2;
                case int n when n >= 1980 && n < 1990:
                    Decades decade3 = Decades.Eighties;
                    return decade3;
                case int n when n >= 1990 && n < 2000:
                    Decades decade4 = Decades.Ninties;
                    return decade4;
                case int n when n >= 2000 && n < 2010:
                    Decades decade5 = Decades.Aughts;
                    return decade5;
                case int n when n >= 2010 && n < 2020:
                    Decades decade6 = Decades.Teens;
                    return decade6;
                case int n when n >= 2020 && n < 2030:
                    Decades decade7 = Decades.Twenties;
                    return decade7;
                default:
                    return Decades.Unknown;

            }
        }
    }
}
