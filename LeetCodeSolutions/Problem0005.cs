namespace LeetCodeSolutions;

public abstract class Solution {
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();

        if (input == null)
        {
            return;
        }

        var value = 0;

        for (var i = 0; i < input.Length; i++)
        {
            if (IsPrefixChar(input[i]) && i + 1 < input.Length)
            {
                var specialValue = CalculateSpecialCharacter(input[i], input[i + 1]);
                if (specialValue == 0)
                {
                    value += CalculateRegularCharacter(input[i]);
                }
                else
                {
                    value += specialValue;
                    i++;
                }
            }
            else
            {
                value += CalculateRegularCharacter(input[i]);
            }
        }

        Console.WriteLine(value);
    }

    private static bool IsPrefixChar(char character)
    {
        return character switch
        {
            'I' => true,
            'X' => true,
            'C' => true,
            _ => false
        };
    }

    private static int CalculateSpecialCharacter(char char1, char char2)
    {
        switch (char1)
        {
            case 'I':
                switch (char2)
                {
                    case 'V':
                        return 4;
                    case 'X':
                        return 9;
                }

                break;
            case 'X':
                switch (char2)
                {
                    case 'L':
                        return 40;
                    case 'C':
                        return 90;
                }

                break;
            
            case 'C':
                switch (char2)
                {
                    case 'D':
                        return 400;
                    case 'M':
                        return 900;
                }

                break;
        }

        return 0;
    }

    private static int CalculateRegularCharacter(char character)
    {
        return character switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
    }
}