{\rtf1\ansi\ansicpg1252\cocoartf1561\cocoasubrtf200
{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww10800\viewh8400\viewkind0
\pard\tx566\tx1133\tx1700\tx2267\tx2834\tx3401\tx3968\tx4535\tx5102\tx5669\tx6236\tx6803\pardirnatural\partightenfactor0

\f0\fs24 \cf0 using System;\
\
namespace Beverage_Labels\
\{\
    class Program\
    \{\
        static void Main(string[] args)\
        \{\
            string name = Console.ReadLine();\
            int volume = int.Parse(Console.ReadLine());\
            int energy = int.Parse(Console.ReadLine());\
            int sugar = int.Parse(Console.ReadLine());\
\
            double energyResult= (volume * energy) / 100.00;\
            double sugarResult = (sugar * volume) / 100.00;\
\
            Console.WriteLine($"\{volume\}ml \{name\}:");\
            Console.WriteLine($"\{energyResult\}kcal, \{sugarResult\}g sugars");\
        \}\
    \}\
\}\
\
}