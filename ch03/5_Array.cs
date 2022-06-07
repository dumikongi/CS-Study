﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/07
 * 이름 : 허락녕 
 * 내용 : 배열 실습하기 교재 p157
 * 
 */

namespace ch03
{
    internal class _5_Array
    {
        static void Main(string[] args)
        {
            ////////////////////
            // 배열 기본
            ////////////////////

            // 배열(Array)
            int[] arr1 = new int[3];                     // 3개짜리 공간의 arr1이라는 배열을 만들었다
            
            arr1[0] = 1;                                 // 초기화
            arr1[1] = 2;
            arr1[2] = 3;

            // 배열 출력
            Console.WriteLine("arr1 1번째 데이터 :" + arr1[0]);
            Console.WriteLine("arr1 2번째 데이터 :" + arr1[1]);
            Console.WriteLine("arr1 3번째 데이터 :" + arr1[2]);

            //배열 출력

            for (int i = 0; i<3; i++)
            {
                Console.WriteLine("arr1 {0}번째 데이터 : {1}", i+1, arr1[i]);
            }

            // 배열 생성 초기화
            int[]    nums = { 1, 2, 3, 4, 5 };
            char[]   chars = {'A', 'B', 'C'};
            string[] cities = { "서울", "대전", "대구", " 부산", "광주" };

            // 배열 길이 (배열에 들어있는 자료의 개수)
            Console.WriteLine("nums 길이 : "+nums.Length);
            Console.WriteLine("chars 길이 : "+chars.Length);
            Console.WriteLine("cities 길이 : "+cities.Length);

            // 배열 반복문
            foreach (int num in nums)                                 // in 뒤에는 배열연산자, int 뒤에는 변수를, nums를 num에 대입하는 것

            {
                Console.Write(num+" ");
            }
            Console.WriteLine();

            foreach (char c in chars)                                 // in 뒤에는 배열연산자, int 뒤에는 변수를, nums를 num에 대입하는 것

            {
                Console.Write(c+ " ");
            }
            Console.WriteLine();

            foreach (string city in cities)                                 // in 뒤에는 배열연산자, int 뒤에는 변수를, nums를 num에 대입하는 것

            {
                Console.Write(city+ " ");
            }
            Console.WriteLine();

            ////////////////////
            // 다차원 배열
            ////////////////////

            // 1차원 배열 ( 한 줄 배열 )
            int[] arr1d = { 10, 20, 30, 40, 50, 60 };
            int total = 0;

            foreach(int num in arr1d)
            {
                total += num;
            }

            Console.WriteLine("arr1d 총합 : " +total);


            // 2차원 배열 ( 행렬 )
            int[,] arr2d = { {1, 2,  3,  4},
                             {5, 6,  7,  8}, 
                             {9, 10, 11, 12} };

            Console.WriteLine("arr2d[0,0] : "+ arr2d[0,0]);
            Console.WriteLine("arr2d[0,2] : "+ arr2d[0,2]);
            Console.WriteLine("arr2d[1,2] : "+ arr2d[1,2]);
            Console.WriteLine("arr2d[2,3] : "+ arr2d[2,3]);



            // 3차원 배열 ( 큐브 )                    

            int[,,] arr3d = {  
                { 
                  {1,  2,  3 }, 
                  {4,  5,  6 }, 
                  {7,  8,  9 } 
                },                     //1층 안에 행렬이 있다
                { 
                   {10, 11, 12 },
                   {13, 14, 15 }, 
                   {16, 17, 18 } 
                },                     //2층
                { 
                   {19, 20, 21 },
                   {22, 23, 24 }, 
                   {25, 26, 27 } }      //3층
            };

            Console.WriteLine("arr3d[0,0,2] : " + arr3d[0,0,2]);     //3
            Console.WriteLine("arr3d[1,1,1] : " + arr3d[1,1,1]);     //14
            Console.WriteLine("arr3d[1,2,1] : " + arr3d[1,2,1]);     //17



        }
    }
}
