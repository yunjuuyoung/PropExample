using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOver(3);

            // 생성자
            //Product p = new Product();  // 기본 생성자(기정생성자)는 생성자가 없을 경우에만 자동으로 생성
            //Product p = new Product("아이스크림", 1500)
            
            // 팩토리 메서드 패턴 - private 생성자 사용
            Product p = Product.getInstance("국밥", 8000);


            // 정적 생성자 예시 1
            Console.WriteLine("첫 번째 위치");  // Sample.value 값 조회 전에 생성자 호출
            Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");
        }

        // 오버로딩
        public static int TestOver(int input) {  return 0; }
        public static int TestOver(double input) { return 0; }
        //public static bool TestOver(int input) { return true; }  // 매개변수가 같아서 error
    }
}
