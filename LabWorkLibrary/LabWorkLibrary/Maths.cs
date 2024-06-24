namespace LabWorkLibrary
{
    /// <summary>
    /// Класс со статическими методами математических действий и бинарным коэффициентом
    /// </summary>
    public class Maths
    {
        /// <summary>
        /// Бинарный коэффициент
        /// </summary>
        public const int BINARY_FACTOR = 1024;

        /// <summary>
        /// Возвращает сумму двух чисел
        /// </summary>
        /// <param name="a">1 слагаемое</param>
        /// <param name="b">2 слагаемое</param>
        /// <returns>Представляет число типа double</returns>
        public static double Sum(double a, double b)
            => a + b;

        /// <summary>
        /// Возвращает разность двух чисел
        /// </summary>
        /// <param name="a">Уменьшаемое</param>
        /// <param name="b">Вычитаемое</param>
        /// <returns>Представляет число типа double</returns>
        public static double Subtract(double a, double b)
            => a - b;

        /// <summary>
        /// Возвращает произведение двух чисел
        /// </summary>
        /// <param name="a">1 множитель</param>
        /// <param name="b">2 множитель</param>
        /// <returns>Представляет число типа double</returns>
        public static double Multiply(double a, double b)
            => a * b;

        /// <summary>
        /// Возвращает частное двух чисел
        /// </summary>
        /// <param name="a">Делимое</param>
        /// <param name="b">Делитель</param> 
        /// <returns>Представляет число типа double</returns>
        /// <exception cref="ArgumentException">Деление на ноль невозможно</exception>
        public static double Divide(double a, double b)
            => b == 0 ? throw new ArgumentException("Ноль не может приниматься в параметрах в качестве делителя") : a / b;

        /// <summary>
        /// Возвращает площадь прямоугольника
        /// </summary>
        /// <param name="height">Высота прямоугольника</param>
        /// <param name="width">Ширина прямоугольника</param>
        /// <returns>Представляет число типа double</returns>
        /// <exception cref="ArgumentException">Значение сторон должно быть больше нуля</exception>
        public static double GetSquare(double height, double width)
            => height <= 0 || width <= 0 ? throw new ArgumentException("В параметрах не могут передаваться отрицательные или равные нулю значения ") : height * width;
    }
}
