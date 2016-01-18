using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //덧셈 계산 함수
        static void Add()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("1.덧셈을 선택하셨습니다.");
                Console.Write("하나의 수를 입력하세요 : ");
                string addition1 = Console.ReadLine();

                Console.Write("다른 하나의 수를 입력하세요 : ");
                string addition2 = Console.ReadLine();

                float addresult;
                float add1 = float.Parse(addition1);
                float add2 = float.Parse(addition2);
                addresult = add1 + add2;
                Console.WriteLine("덧셈결과 : {0}", addresult);
                Console.WriteLine("");
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("숫자만 입력해주세요");
                Console.WriteLine("");
            }
        }
        //뺄셈 계산 함수
        static void Minus()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("2.뺄셈을 선택하셨습니다.");
                Console.Write("수 하나를 입력하세요 : ");
                string subtraction1 = Console.ReadLine();

                Console.Write("나머지 수 하나를 입력하세요 : ");
                string subtraction2 = Console.ReadLine();

                float subresult;
                float sub1 = float.Parse(subtraction1);
                float sub2 = float.Parse(subtraction2);
                subresult = sub1 - sub2;
                Console.WriteLine("뺄셈결과 : {0}", subresult);
                Console.WriteLine("");
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("숫자만 입력해주세요");
                Console.WriteLine("");
            }
        }
        //곱셈 계산 함수
        static void Multiply()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("3.곱셈을 선택하셨습니다.");
                Console.Write("수 하나를 입력하세요 : ");
                string multiplication1 = Console.ReadLine();

                Console.Write("나머지 수 하나를 입력하세요 : ");
                string multiplication2 = Console.ReadLine();
                float mulresult;
                float mul1 = float.Parse(multiplication1);
                float mul2 = float.Parse(multiplication2);
                mulresult = mul1 * mul2;
                Console.WriteLine("곱셈결과 : {0}", mulresult);
                Console.WriteLine("");
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("숫자만 입력해주세요");
                Console.WriteLine("");
            }

        }
        //나눗셈 계산 함수
        static void Devide()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("4.나눗셈을 선택하셨습니다.");
                Console.Write("수 하나를 입력하세요 : ");
                string division1 = Console.ReadLine();

                Console.Write("나머지 수 하나를 입력하세요 : ");
                string division2 = Console.ReadLine();

                if (division2 == "0")
                {
                    Console.WriteLine();
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                    Console.WriteLine();
                    return;
                }
                float divresult;
                float div1 = float.Parse(division1);
                float div2 = float.Parse(division2);
                divresult = div1 / div2;
                Console.WriteLine("나눗셈결과 : {0}", divresult);
                Console.WriteLine("");
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("숫자만 입력해주세요");
                Console.WriteLine("");
            }
        }
        //루트 계산 함수
        static void Root()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("5. 루트를 선택하셨습니다.");
                Console.Write("수 하나를 입력하세요 : ");
                string NRoot = Console.ReadLine();
                float Nroot = float.Parse(NRoot);
                Console.WriteLine("루트결과 : {0}", Math.Sqrt(Nroot));
                Console.WriteLine("");
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("숫자만 입력해주세요");
                Console.WriteLine("");
            }
        }
       
        //목차 출력 함수
        static void PrintList()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("C#계산기 테스트입니다.");
            Console.WriteLine("1. 덧셈(UPDATE)");
            Console.WriteLine("2. 뺄셈(UPDATE)");
            Console.WriteLine("3. 곱셈(UPDATE)");
            Console.WriteLine("4. 나눗셈");
            Console.WriteLine("5. 루트(UPDATE)");
            Console.WriteLine("A. α업데이트 내역(NEW UPDATE)");
            Console.WriteLine("버전정보 : α1.1811061021959");
            Console.WriteLine("========================================");
            Console.Write("원하시는 메뉴번호를 적어주세요 : ");
        }

        //메인 함수
        static void Main(string[] args)
        {
            while (true)
            {
                PrintList();
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Minus();
                        break;
                    case "3":
                        Multiply();
                        break;
                    case "4":
                        Devide();
                        break;
                    case "5":
                        Root();
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "A":
                        UPDATE(args[0]);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("잘못 입력하셨습니다.");
                        Console.WriteLine();
                        break;
                }

                Console.WriteLine("처음으로 돌아가시려면 엔터를 눌러주세요.");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {

                }
                Console.Clear();
            }
        }

        //업데이트 내역 함수
        static void UPDATE(string arg)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("업데이트 내역입니다.");
            Console.WriteLine("1. α1.0711061022204 업데이트 내역");
            Console.WriteLine("2. α1.1811061021959 업데이트 내역(NEW)");
            Console.WriteLine("A. 목차로 돌아가기");
            Console.WriteLine("----------------------------------------");
            Console.Write("원하시는 업데이트 확인 번호를 적어주세요 : ");
            CHOOSEUPDATE(arg);

        }
        static void CHOOSEUPDATE(string arg)
        {
            while (true)
            {
                
                string CUPDATE = Console.ReadLine();
                switch (CUPDATE)
                {
                    case "1":
                        FirstαUPDATE();
                        break;
                    case "2":
                        SecondαUPDATE();
                        break;
                    case "A":
                        Console.Clear();
                        PrintList();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("잘못 입력하셨습니다.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        //α1.0711061022204 업데이트 내역 함수
        static void FirstαUPDATE()
        {
            Console.WriteLine("");
            Console.WriteLine("<<<α1.0711061022204 업데이트 내역>>>");
            Console.WriteLine("2016.01.17 α서비스 출시");
            Console.WriteLine("루트계산 추가");
            Console.WriteLine("업데이트 내역 추가");
            Console.WriteLine("");
        }
        //α1.1811061021959 업데이트 내역 함수
        static void SecondαUPDATE()
        {
            Console.WriteLine();
            Console.WriteLine("<<<α1.1811061021959 업데이트 내역>>>");
            Console.WriteLine("2016.01.18 α1.1811061021959 업데이트");
            Console.WriteLine("덧셈,뺄셈,곱셈,루트 계산에서 다른 키나, 알파벳 입력시 에러뜨는 현상 수정");
            Console.WriteLine("덧셈,뺄셈,곰셈,루트 계산에서 소수입력시 이상한 값 뜨는 현상 수정");
            Console.WriteLine("계산 창으로 갈 시에 화면리셋 현상 추가");
            Console.WriteLine("업데이트 내역 메뉴 목차처럼 수정");
        }
    }
}