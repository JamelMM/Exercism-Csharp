public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
            
        if(operation == null)
        {
            throw new ArgumentNullException(nameof(operation));
        }
        else if(operation == "")
        {
            throw new ArgumentException(nameof(operation));
        }
        else if(operation != "+" && operation != "*" && operation != "/")
        {
            throw new ArgumentOutOfRangeException(nameof(operation));
        }
        else
        {
            if (operation == "+")
            {
                return $"{operand1} + {operand2} = {operand1 + operand2}";
            } 
            else if (operation == "/")
            {
                if(operand2 == 0)
                {
                    return "Division by zero is not allowed.";
                }
                else
                {
                    return $"{operand1} / {operand2} = {operand1 / operand2}";
                }
            } 
            else 
            {
                return $"{operand1} * {operand2} = {operand1 * operand2}";
            } 
        }
            
    }
}
