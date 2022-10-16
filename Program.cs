/* 3) Решить задачу
Известно, что на доске 8×8 можно расставить 8 ферзей так, чтобы они не били друг друга.
Вам дана расстановка 8 ферзей на доске, определите, есть ли среди них пара бьющих друг друга.
Программа получает на вход восемь пар чисел, каждое число от 1 до 8 — координаты 8 ферзей.
Если ферзи не бьют друг друга, выведите слово NO, иначе выведите YES. */

int[] Q1 = {0,0};
int[] Q2 = {1,2};
int[] Q3 = {2,4};
int[] Q4 = {3,6};
int[] Q5 = {6,7};
int[] Q6 = {5,5};
int[] Q7 = {4,3};
int[] Q8 = {7,1};

Console.WriteLine();

if (Q1[0]==Q2[0] || Q1[1]==Q2[1] || Q1[0]-Q2[0] == Q1[1]-Q2[1])
Console.WriteLine("Бьют ли ферзи 1 и 2 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 1 и 2 друг друга? - No!");

if (Q1[0]==Q3[0] || Q1[1]==Q3[1] || Q1[0]-Q3[0] == Q1[1]-Q3[1])
Console.WriteLine("Бьют ли ферзи 1 и 3 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 1 и 3 друг друга? - No!");

if (Q1[0]==Q4[0] || Q1[1]==Q4[1] || Q1[0]-Q4[0] == Q1[1]-Q4[1])
Console.WriteLine("Бьют ли ферзи 1 и 4 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 1 и 4 друг друга? - No!");

if (Q1[0]==Q5[0] || Q1[1]==Q5[1] || Q1[0]-Q5[0] == Q1[1]-Q5[1])
Console.WriteLine("Бьют ли ферзи 1 и 5 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 1 и 5 друг друга? - No!");

if (Q1[0]==Q6[0] || Q1[1]==Q6[1] || Q1[0]-Q6[0] == Q1[1]-Q6[1])
Console.WriteLine("Бьют ли ферзи 1 и 6 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 1 и 6 друг друга? - No!");

if (Q1[0]==Q7[0] || Q1[1]==Q7[1] || Q1[0]-Q7[0] == Q1[1]-Q7[1])
Console.WriteLine("Бьют ли ферзи 1 и 7 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 1 и 7 друг друга? - No!");

if (Q1[0]==Q8[0] || Q1[1]==Q8[1] || Q1[0]-Q8[0] == Q1[1]-Q8[1])
Console.WriteLine("Бьют ли ферзи 1 и 8 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 1 и 8 друг друга? - No!");

Console.WriteLine();

if (Q2[0]==Q3[0] || Q2[1]==Q3[1] || Q2[0]-Q3[0] == Q2[1]-Q3[1])
Console.WriteLine("Бьют ли ферзи 2 и 3 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 2 и 3 друг друга? - No!");

if (Q2[0]==Q4[0] || Q2[1]==Q4[1] || Q2[0]-Q4[0] == Q2[1]-Q4[1])
Console.WriteLine("Бьют ли ферзи 2 и 4 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 2 и 4 друг друга? - No!");

if (Q2[0]==Q5[0] || Q2[1]==Q5[1] || Q2[0]-Q5[0] == Q2[1]-Q5[1])
Console.WriteLine("Бьют ли ферзи 2 и 5 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 2 и 5 друг друга? - No!");

if (Q2[0]==Q6[0] || Q2[1]==Q6[1] || Q2[0]-Q6[0] == Q2[1]-Q6[1])
Console.WriteLine("Бьют ли ферзи 2 и 6 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 2 и 6 друг друга? - No!");

if (Q2[0]==Q7[0] || Q2[1]==Q7[1] || Q2[0]-Q7[0] == Q2[1]-Q7[1])
Console.WriteLine("Бьют ли ферзи 2 и 7 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 2 и 7 друг друга? - No!");

if (Q2[0]==Q8[0] || Q2[1]==Q8[1] || Q2[0]-Q8[0] == Q2[1]-Q8[1])
Console.WriteLine("Бьют ли ферзи 2 и 8 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 2 и 8 друг друга? - No!");

Console.WriteLine();

if (Q3[0]==Q4[0] || Q3[1]==Q4[1] || Q3[0]-Q4[0] == Q3[1]-Q4[1])
Console.WriteLine("Бьют ли ферзи 3 и 4 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 3 и 4 друг друга? - No!");

if (Q3[0]==Q5[0] || Q3[1]==Q5[1] || Q3[0]-Q5[0] == Q3[1]-Q5[1])
Console.WriteLine("Бьют ли ферзи 2 и 5 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 2 и 5 друг друга? - No!");

if (Q3[0]==Q6[0] || Q3[1]==Q6[1] || Q3[0]-Q6[0] == Q3[1]-Q6[1])
Console.WriteLine("Бьют ли ферзи 3 и 6 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 3 и 6 друг друга? - No!");

if (Q3[0]==Q7[0] || Q3[1]==Q7[1] || Q3[0]-Q7[0] == Q3[1]-Q7[1])
Console.WriteLine("Бьют ли ферзи 3 и 7 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 3 и 7 друг друга? - No!");

if (Q3[0]==Q8[0] || Q3[1]==Q8[1] || Q3[0]-Q8[0] == Q3[1]-Q8[1])
Console.WriteLine("Бьют ли ферзи 3 и 8 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 3 и 8 друг друга? - No!");

Console.WriteLine();

if (Q4[0]==Q5[0] || Q4[1]==Q5[1] || Q4[0]-Q5[0] == Q4[1]-Q5[1])
Console.WriteLine("Бьют ли ферзи 4 и 5 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 4 и 5 друг друга? - No!");

if (Q4[0]==Q6[0] || Q4[1]==Q6[1] || Q4[0]-Q6[0] == Q4[1]-Q6[1])
Console.WriteLine("Бьют ли ферзи 4 и 6 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 4 и 6 друг друга? - No!");

if (Q4[0]==Q7[0] || Q4[1]==Q7[1] || Q4[0]-Q7[0] == Q4[1]-Q7[1])
Console.WriteLine("Бьют ли ферзи 3 и 7 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 3 и 7 друг друга? - No!");

if (Q4[0]==Q8[0] || Q4[1]==Q8[1] || Q4[0]-Q8[0] == Q4[1]-Q8[1])
Console.WriteLine("Бьют ли ферзи 4 и 8 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 4 и 8 друг друга? - No!");

Console.WriteLine();

if (Q5[0]==Q6[0] || Q5[1]==Q6[1] || Q5[0]-Q6[0] == Q5[1]-Q6[1])
Console.WriteLine("Бьют ли ферзи 5 и 6 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 5 и 6 друг друга? - No!");

if (Q5[0]==Q7[0] || Q5[1]==Q7[1] || Q5[0]-Q7[0] == Q5[1]-Q7[1])
Console.WriteLine("Бьют ли ферзи 5 и 7 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 5 и 7 друг друга? - No!");

if (Q5[0]==Q8[0] || Q5[1]==Q8[1] || Q5[0]-Q8[0] == Q5[1]-Q8[1])
Console.WriteLine("Бьют ли ферзи 5 и 8 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 5 и 8 друг друга? - No!");

Console.WriteLine();

if (Q6[0]==Q7[0] || Q6[1]==Q7[1] || Q6[0]-Q7[0] == Q6[1]-Q7[1])
Console.WriteLine("Бьют ли ферзи 6 и 7 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 6 и 7 друг друга? - No!");

if (Q6[0]==Q8[0] || Q6[1]==Q8[1] || Q6[0]-Q8[0] == Q6[1]-Q8[1])
Console.WriteLine("Бьют ли ферзи 6 и 8 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 6 и 8 друг друга? - No!");

Console.WriteLine();

if (Q7[0]==Q8[0] || Q7[1]==Q8[1] || Q7[0]-Q8[0] == Q7[1]-Q8[1])
Console.WriteLine("Бьют ли ферзи 7 и 8 друг друга? - YES!");
else Console.WriteLine("Бьют ли ферзи 7 и 8 друг друга? - No!");

Console.WriteLine();