public static class ComplexStack {
    public static bool DoSomethingComplicated(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}

/*takes a string as a parameter
creates and new stack of characters.
for each character determines if it is  a (,[, { it pushes it to the stack.
else returns false if stack.count is zero or last character is a parenthesis. etc.

(a == 3 or (b == 5 and c == 6))

stack (,(
(students]i].Grade > 80 and students[i].Grade < 90)
stack= (,*/

(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))