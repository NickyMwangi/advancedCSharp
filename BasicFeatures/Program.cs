using BasicFeatures;

/**
* Using read line
*/
//InputValue.ConsoleReadlines();

/**
* Testing number formatting
*/
//InputValue.NumberFormatting();

/**
 * List of exercises
 */
//ListExercises.TenTimesTable();
//ListExercises.FizzBuzzGame();
//ListExercises.ReverseString();
//ListExercises.PasswordChecker();
//ListExercises.OddEvenNumber();
Console.WriteLine("Enter Width");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Height");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The area of a Triangle is {ListExercises.CalculateArea(width, height)}");
/**
 * Data manipulation
 */
//DataManipulation.TestDictionary();
