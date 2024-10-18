namespace Parsing_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pares 메소드 예
            string intStrinf = "123";
            int parsedInt = int.Parse(intStrinf);
            Console.WriteLine($"Parse 로 변환된 int 값: {parsedInt}");

            // TryParse 메소드 예
            string doubleString = "123.45";
            double parsedDouble;
            bool isDoubleParseSuccessful = double.TryParse(doubleString, out parsedDouble);
            Console.WriteLine(isDoubleParseSuccessful ? $"파싱된 double값 : {parsedDouble}" : "double로 파싱 실패");
        }
    }
}
