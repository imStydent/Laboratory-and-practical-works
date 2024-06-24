﻿using Task1;

Context context = new Context(new OperationAdd());
Console.WriteLine($"10 + 5 = {context.ExecuteStrategy(10, 5)}");

context = new Context(new OperationSubstract());
Console.WriteLine($"10 - 5 = {context.ExecuteStrategy(10, 5)}");

context = new Context(new OperationMultiply());
Console.WriteLine($"10 * 5 = {context.ExecuteStrategy(10, 5)}");

context = new Context(new OperationIntegerDivide());
Console.WriteLine($"16 / 5 = {context.ExecuteStrategy(16, 5)}");